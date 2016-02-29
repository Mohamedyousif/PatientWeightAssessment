using System.Linq;
using System.Collections.Generic;
using Raven.Client;
using RavenDBHelper.Helpers;

namespace RavenDBHelper
{
    /// <summary>
    /// Abstract DAO for RavenDB
    /// </summary>
    /// <typeparam name="T">T is an generic RavenDB Entity</typeparam>
    public abstract class Dao<T>
    {
        string _database = "";
        bool _inMemory = false;

        public Dao(bool inMemory = false)
        {
            _database = ConfigHelper.GetConfigValue("Database");
            _inMemory = inMemory;
        }

        public IDocumentStore GetDocumentStore()
        {
            if (_inMemory)
                return DocumentStoreHolder.GetInMemoryStore();

            return DocumentStoreHolder.GetStore();
        }

        public virtual T Get(string id)
        {
            using (var documentStore = GetDocumentStore())
            {
                using (var session = documentStore.OpenSession(_database))
                {
                    return session.Load<T>(id);
                }
            }
        }

        public virtual List<T> GetAll()
        {
            using (var documentStore = GetDocumentStore())
            {
                using (var session = documentStore.OpenSession(_database))
                {
                    return session.Query<T>().ToList();
                }
            }
        }

        public List<T> GetPagedList(int startingPageIndex, int pageSize)
        {
            using (var documentStore = GetDocumentStore())
            {
                using (IDocumentSession session = documentStore.OpenSession(_database))
                {
                    return session.Query<T>()
                                  .Take(pageSize)
                                  .Skip(startingPageIndex * pageSize)
                                  .ToList();
                }
            }
        }

        public virtual void Save(T entity)
        {
            using (var documentStore = GetDocumentStore())
            {
                using (var session = documentStore.OpenSession(_database))
                {
                    session.Store(entity);
                    session.SaveChanges(); // Save all pending changes to server
                }
            }
        }

        public virtual void Delete(string id)
        {
            using (var documentStore = GetDocumentStore())
            {
                using (var session = documentStore.OpenSession(_database))
                {
                    T entity = session.Load<T>(id);
                    session.Delete(entity);
                    session.SaveChanges();
                }
            }
        }
    }
}
