using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni
{
    public class Utils 
    {
        private readonly IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();


        /* Returns configuration builder */
        public IConfigurationRoot GetConfig()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            return config;
        }



        /* Returns project root path as string */
        public string GetProjectPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = System.IO.Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            return projectDirectory;
        }



        /* Returns browser value from appsettings.json file */
        public string GetBrowser()
        {
            var browser = config["browser"];
            return browser;
        }



        /* Returns URL value from appsettings.json file */
        public string GetBaseURL()
        {
            var baseURL = config["baseUrl"];
            return baseURL;
        }
    }
}
