using System;
using System.Collections.Generic;
using System.Net.Mail;
using MMDB.Shared;
using Moq;
using NUnit.Framework;

namespace MMDB.RazorEmail.Tests
{
    public class RazorEmailEngineTests
    {
		public class SampleModel
		{
			public string StringValue { get; set; }
			public Guid GuidValue { get; set; }
			public int IntValue { get; set; }
			public decimal DecimalValue { get; set; }
		}

		public class TestData
		{
			public Mock<EmailSender> EmailSender { get; set; }
			public string Subject { get; set; }
			public List<MailAddress> ToAddressList { get; set; }
			public MailAddress FromAddress { get; set; }
			public SampleModel Model { get; set; }
			public IRazorEmailEngine EmailEngine { get; set; }

			public static TestData Setup(int toAddressCount = 1)
			{
				var returnValue = new TestData()
				{
					EmailSender = new Mock<EmailSender>(new EmailServerSettings()),
					Subject = Guid.NewGuid().ToString(),
					ToAddressList = new List<MailAddress>(),
					FromAddress = new MailAddress(Guid.NewGuid().ToString() + "@example.com"),
					Model = new SampleModel()
					{
						StringValue = Guid.NewGuid().ToString(),
						GuidValue = Guid.NewGuid(),
						IntValue = TestDataHelper.RandomInt(),
						DecimalValue = TestDataHelper.RandomDecimal()
					}
				};
				for (int i = 0; i < toAddressCount; i++)
				{
					var address = new MailAddress(Guid.NewGuid().ToString() + "@example.com");
					returnValue.ToAddressList.Add(address);
				}
				returnValue.EmailEngine = new RazorEmailEngine(returnValue.EmailSender.Object);
				return returnValue;
			}
		}

		[Test]
		public void CallsEmailSender()
		{
			var testData = TestData.Setup();
			testData.EmailEngine.SendEmail(testData.Subject, testData.Model, "test", testData.ToAddressList, testData.FromAddress);

			testData.EmailSender.Verify(i => i.SendEmail(null, testData.Subject, "test", testData.ToAddressList, testData.FromAddress), Times.Once());
		}

		[Test]
		public void EvaluatesRazorViewWithoutModel()
		{
			var testData = TestData.Setup();
			testData.EmailEngine.SendEmail(testData.Subject, testData.Model, "<html>@(123+1)</html>", testData.ToAddressList, testData.FromAddress);

			testData.EmailSender.Verify(i => i.SendEmail(null, testData.Subject, "<html>124</html>", testData.ToAddressList, testData.FromAddress), Times.Once());
		}

		[Test]
		public void EvaluatesRazorViewWithModel()
		{
			var testData = TestData.Setup();
			string razorView = "<html><div>String Value: @Model.StringValue</div></html>";
			string expectedBody = razorView.Replace("@Model.StringValue", testData.Model.StringValue);
			testData.EmailEngine.SendEmail(testData.Subject, testData.Model, razorView, testData.ToAddressList, testData.FromAddress);

			testData.EmailSender.Verify(i => i.SendEmail(null, testData.Subject, expectedBody, testData.ToAddressList, testData.FromAddress), Times.Once());
		}
	}
}
