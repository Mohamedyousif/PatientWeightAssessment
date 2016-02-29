# PatientWeightAssessment
Patient Weight Assessment, Powered by RavenDB backend.

# Introduction

I was researching on NoSQL databases and possible application(s) that can be developed. Here I am sharing a real world example where one can make use of NoSQL databases for managing data in an efficient way. There are times one has to think and use the right tools and technologies that will help in solving our day-to-day problems. The “Patient Weight Assessment” is a tool for understanding patient’s weight periodically over a time frame. We will try to gather all the required information that can help in determining the results through which the patient’s health conditions can be improved. 

The assessment application uses Raven DB for managing all the assessment data. However, you can use any NoSQL as a persisting mechanism. There is a strong reason for choosing a non-relational NoSQL backend as opposed to any relational database. 

Depending upon the nature of your requirement and project that you are working on, there are certain situations in which you have to think twice in deciding whether or not to go with the NoSQL. This project, “Patient Weight Assessment,” is about gathering certain weight and other related informationand could be done either with relational or non-relational. I tend to go with these projects as non-relational as we can store all the relevant patient’s weight information as a single document in NoSQL database. That will also help in data retrieval as one can do a single fetch to get all the relevant information. 

#Note 

The application is designed by following the free form template published in http://www.freeprintablemedicalforms.com/preview/Weight_Assessment

# Prerequisite 

This project is coded using VS 2015. Please make sure to have it installed. Also download and install "RavenDB" if you don’t have one. 
You can install the same from - https://ravendb.net/downloads

