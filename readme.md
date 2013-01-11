# MMDB Razor Email #

## Format an object into HTML with Razor and send it via email in one line of code, from any .NET app.##

NuGet: http://nuget.org/packages/MMDB.RazorEmail

Need to send an email. Have a bunch of data, and want to actually look nice?  How about using some of that fancy Razor stuff that the ASP.NET guys have cooked up?

**Basic Usage**
```C#
    new RazorEmailEngine()
          .SendEmail("This is the subject",                       //Give a subject
                new {FirstName="Mike", LastName="Mooney" },       //and a model object
                "Hello <b>@Model.FirstName @Model.LastName</b>!", //and a Razor view
                new List<string> {"to@example.com"},              //and a list of people to send it do
                "from@example.com"                               //and who you are
          );
```

**Include Some Attachments**
```C#
    new RazorEmailEngine()
          .SendEmail("This is the subject",                       //Give a subject
                new {FirstName="Mike", LastName="Mooney" },       //and a model object
                "Hello <b>@Model.FirstName @Model.LastName</b>!", //and a Razor view
                new List<string> {"to@example.com"},              //and a list of people to send it do
                "from@example.com",                               //and who you are
                new EmailAttachmentData { FileName="Attachement1.txt", AttachmentData="This is the file data"},
                new EmailAttachmentData { FileName="Attachement2.txt", AttachmentData="This is more data"}
          );
```

**Specify SMTP Settings**

The previous examples use the default SMTP settings from the app.config or web.config.  However, if you wanted to specify different settings at runtime:
```C#
    var settings = new EmailServerSettings
    {
          Host="mail.example.com",
          Port=25,
          UserName="testuser",
          Password="ThisIsASuperDuperPassword"
    };
    new RazorEmailEngine(settings)
          .SendEmail("This is the subject",                       //Give a subject
                new {FirstName="Mike", LastName="Mooney" },       //and a model object
                "Hello <b>@Model.FirstName @Model.LastName</b>!", //and a Razor view
                new List<string> {"to@example.com"},              //and a list of people to send it do
                "from@example.com"                               //and who you are
          );
```

**Mock The Email Engine**

Want your unit tests to verify that the right emails are being sent, without actually sending the email?  You can inject a mock EmailSender class
```C#
    Mock<EmailSender> mockEmailSender = new Mock<EmailSender>();
    new RazorEmailEngine(mockEmailSender.Object)
          .SendEmail("This is the subject",                       //Give a subject
                new { FirstName = "Mike", LastName = "Mooney" },       //and a model object
                "Hello <b>@Model.FirstName @Model.LastName</b>!", //and a Razor view
                new List<string> { "to@example.com" },              //and a list of people to send it do
                "from@example.com"                               //and who you are
          );
    mockEmailSender.Verify(i => i.SendEmail("This is the subject", "Hello <b>Mike Mooney</b>!", It.IsAny<IEnumerable<MailAddress>>(), It.IsAny<MailAddress>()), Times.Once());
```

**Sample App**

We've included a working sample app you can play with:
<img src="https://raw.github.com/mmooney/MMDB.RazorEmail/master/SampleAppScreenShot.png"></img>

**FAQ**
* Can I used this outside a MVC application?
    * Absolutely. We wrote this specifically so we could use it in a Windows service.
* What dependencies are involved? 
    * If you use the NuGet package (http://nuget.org/packages/MMDB.RazorEmail), it will also download MMDB.Shared (a simple library of common functions), and Antaris Razor Engine (https://github.com/Antaris/RazorEngine)

**Thanks**

MMDB.RazorEmail makes use of the following open source projects:
* Antaris RazorEngine: https://github.com/Antaris/RazorEngine
* Json.NET: http://james.newtonking.com/projects/json-net.aspx

We also used the following in our testing:
* moq: http://code.google.com/p/moq/
* NUnit: http://www.nunit.org/

[![githalytics.com alpha](https://cruel-carlota.pagodabox.com/35e594150e77d8d015064dadab40dff4 "githalytics.com")](http://githalytics.com/mmooney/MMDB.RazorEmail)
