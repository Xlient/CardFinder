using Google.Cloud.Dialogflow.V2;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CFWebHookApi.Controllers
{
	[Route("api")]
	public class WebHookController : Controller
	{
		private static readonly JsonParser jsonParser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

		[HttpPost]
		public async Task<HttpResponseMessage> Post()
        {
            // Read the request JSON asynchronously, as the Google.Protobuf library
            // doesn't (yet) support asynchronous parsing.
            string requestJson;
            using (TextReader reader = new StreamReader(Request.Body))
            {
                requestJson = await reader.ReadToEndAsync();
            }

            WebhookRequest request = jsonParser.Parse<WebhookRequest>(requestJson);

            WebhookResponse response = new WebhookResponse
            {
                // ...
            };
            HttpResponseMessage httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
            {
                // Ask Protobuf to format the JSON to return.
                // Again, we don't want to use Json.NET - it doesn't know how to handle Struct
                // values etc.
                Content = new StringContent(response.ToString())
                {
                    Headers = { ContentType = new MediaTypeHeaderValue("text/json") }
                }
            };

            return httpResponse;
        }
        [HttpPost]
        public void PostChipResponse( string response)
        {
            IntentsClient client = new IntentsClientBuilder { }.Build();
            string intent;
            //client.GetIntentAsync(intent);
        }

    }
	}

