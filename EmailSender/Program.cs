using AutoMapper;
using Data_AS.EntityModels.Korisnici;
using MusicApp.Infrastructure;
using MusicApplication.Core.Models;
using MusicApplication.Infrastructure.Repositories.Songs;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Threading;
using WebApplication.Data;

namespace EmailSender
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var administrator = "rijadmaljanovic98@gmail.com";
            while (true)
            {
                Console.WriteLine(SendEmail(administrator));
                Console.WriteLine("Email sent to: " + administrator);
                Thread.Sleep(5000);
            }

        }
        
        public static IRestResponse SendEmail(string email)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");

            client.Authenticator =
                new HttpBasicAuthenticator("api",
                    "f66691dee41f79c49943dac579120850-62916a6c-424ef069");

            RestRequest request = new RestRequest();

            request.AddParameter("domain", "sandboxca6ffada761e46ec80a3ec7865f4d68f.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Mailgun Sandbox <postmaster@sandboxca6ffada761e46ec80a3ec7865f4d68f.mailgun.org>");
            request.AddParameter("to", email);
            request.AddParameter("subject", "Report check");
            request.AddParameter("text", "Check the reports today please.");

            request.Method = Method.POST;

            return client.Execute(request);
        }
    }
}
