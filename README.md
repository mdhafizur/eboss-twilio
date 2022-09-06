Take a quick look at the contents of the EbossApp directory. Several files were created in the EbossApp directory, to give you a simple Blazor app that is ready to run.

Program.cs is the entry point for the app that starts the server and where you configure the app services and middleware.
App.razor is the root component for the app.
The Pages directory contains some example web pages for the app.
EbossApp.csproj defines the app project and its dependencies.
The launchSettings.json file inside the Properties directory defines different profile settings for the local development environment. A port number ranging between 5000-5300 is automatically assigned at project creation and saved on this file.

https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.0&tabs=visual-studio-code

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code

$ dotnet watch


$ twilio phone-numbers:buy:mobile --country-code BD
$ twilio phone-numbers:update +16187654158 --voice-url http://fad7-103-112-150-17.ngrok.io