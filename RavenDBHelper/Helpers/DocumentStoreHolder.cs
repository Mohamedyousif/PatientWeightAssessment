using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;

namespace RavenDBHelper.Helpers
{
    public class DocumentStoreHolder
    {
        public static IDocumentStore GetInMemoryStore()
        {
            var store = new EmbeddableDocumentStore
            {
                RunInMemory = true,
                DataDirectory = "Data"
            };

            store.Configuration.Storage.Voron.AllowOn32Bits = true;
            store.Initialize();
            store.DatabaseCommands.GlobalAdmin.EnsureDatabaseExists(ConfigHelper.GetConfigValue("Database"));
            return store;
        }

        public static IDocumentStore GetStore()
        {
            IDocumentStore store = new DocumentStore()
            {
                Url = ConfigHelper.GetConfigValue("Url"),
                DefaultDatabase = ConfigHelper.GetConfigValue("Database")
            }.Initialize();

            return store;
        }
    }
}
