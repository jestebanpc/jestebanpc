using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security.Tokens;
using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Xml;

namespace ConsoleApplication1
{

    class Program
    {
       

        static void Main(string[] args)
        {
            ServiceReference1.getPDF64SoapClient proxy;
            proxy = new ServiceReference1.getPDF64SoapClient("getPDF64Soap");

            var behavior = new PasswordDigestBehavior("PROD0229_WSS", "esuite");
            proxy.Endpoint.EndpointBehaviors.Add(behavior);
            proxy.Open();


            proxy.get_pdf("76481576-9", "3632629", "33", "26417", "2020-03-07", "76481576-9", false);

            proxy.Close();
        }

    }
}
