# EssentialDiagnostics.EntityFramework
Automatically creates tables and stored procedures for Essential Diagnostics (https://essentialdiagnostics.codeplex.com/) using Entity Framework.

Simply install the nuget package using the following command in the package manager console:

> Install-Package EssentialDiagnostics.EntityFramework

And then call the initialization method from the class library:

    protected override void Seed(DataContext context)
    {
       EssentialDiagnostics.EntityFramework.Db.InitializeDiagnosticTrace(context);
    }
   
Essential diagnostics will use a connection string from your config file called "DefaultConnection", there is also an override if you would like to use your own connection string.
