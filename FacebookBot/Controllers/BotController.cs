using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FacebookBot.API;
using System.Net.Http;
using System.Net;
using System.IO;

namespace FacebookBot.Controllers
{
    [Route("bot")]
    public class BotController : Controller
    {
        // GET bot
        [HttpGet]
        public string Verify()
        {
            var mode = Request.Query["hub.mode"].FirstOrDefault();
            var challenge = Request.Query["hub.challenge"].FirstOrDefault();
            var token = Request.Query["hub.verify_token"].FirstOrDefault();
            return challenge ?? string.Empty;
        }
        // POST bot
        [HttpPost]
        public void Post([FromBody] Letter letter)
        {
            var content = letter.entry[0].messaging[0];

            const string token = @"Yourtoken";
            var uri = new Uri("https://graph.facebook.com/v2.6/me/messages?access_token=" + token);
             
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var requestWriter = new StreamWriter(request.GetRequestStream()))
            {
                requestWriter.Write($@" {{recipient: {{  id: {content.sender.id}}},message: {{text: ""{content.message.text}"" }}}}");
            }
            var response = (HttpWebResponse)request.GetResponse();
        }
    }
}
