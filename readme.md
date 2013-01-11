# MMDB Razor Email #

## Format your object with Razor and send it via email in two lines of code, from any .NET app, any time.##

Need to send an email. Have a bunch of data, and want to actually look nice?  How about using some of that fancy Razor stuff that the ASP.NET guys have cooked up?

```C#
    new RazorEmailEngine()
          .SendEmail("This is the subject",                       //Give a subject
                new {FirstName="Mike", LastName="Mooney" },       //and a model object
                "Hello <b>@Model.FirstName @Model.LastName</b>!", //and a Razor view
                new List<string> {"to@example.com"},              //and a list of people to send it do
                "from@example.com"                               //and who you are
          );
```
