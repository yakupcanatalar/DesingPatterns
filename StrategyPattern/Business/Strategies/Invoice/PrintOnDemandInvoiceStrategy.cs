
using Newtonsoft.Json;
using StrategyPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;

namespace StrategyPattern.Business.Strategies.Invoice
{
    public class PrintOnDemandInvoiceStrategy: InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(order);

                client.BaseAddress = new Uri("https://pluralsight.com");

                client.PostAsync("/print-on-demand", new StringContent(content));
            }
        }
    }
}
