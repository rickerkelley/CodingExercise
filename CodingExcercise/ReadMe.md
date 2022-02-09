# ReadMe

CodingExcercise is written with ASP.NET Core 5.0 and Entity Framework Core 5.0.  For simplicity and portability, a SQL Server DB is mocked up in memory using Model Classes (with Data Annotations) so that sample can be easily run on different systems.  A DBInitializer class mocks up several datasets on application start.  Application also uses several NuGet packages which will need to be restored before application can run.

# Projects 
This solution contains two Projects, *CodingExcercise* and *CodingExcerciseTest*.  
# CodingExcercise
Contains Folders for Controllers, Data, Models, wwwroot.
**Controllers:**
*UserInvestmentDetailsController* -  returns detailed investment data for a specific UserID via a GET Request
*UserTransactionsController* - returns a list of Investments with ID for UserID via a GET Request

**Data**
*DbInitializer* - populates mock data into datasets for each table 
*FinanceContext* - defines Context and datasets for each table (User, Transaction, Investment)

**Models**
*Investment* - Class representing Investment table 
*Transaction* - Class representing Transcation table 
*User* - Class representing User table 
*UserInvestmentDetails* - Class representing data for UserInvestmentDetailsController.  Has some logic in constructor for populating values.
*UserTransactions* - Class representing data for UserTranscationsController.  

**wwwroot**
Contains index.html, site.js, and site.css.  Simple front end for retrieving data and displaying data.

# CodingExcerciseTest
Contains a simple set of unit tests contained in a single class.  Validates calculations that are used in the UserInvestmentDetails.
