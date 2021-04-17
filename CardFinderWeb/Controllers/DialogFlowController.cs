using Google.Cloud.Dialogflow.V2;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CardFinder.Controllers
{
   
    [Route("api")]
    [ApiController]
    public class DialogFlowController : Controller
    {
        private readonly ILogger<DialogFlowController> _logger;
        public DialogFlowController( ILogger<DialogFlowController> logger)
        {
            _logger = logger;
        }

        
        private static readonly JsonParser jsonParser =
        new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
        [HttpPost]
        public async Task<ContentResult> DialogAction()
        {
            // Read the request JSON asynchronously, as the Google.Protobuf library
            // doesn't (yet) support asynchronous parsing.
            string requestJson;
            using (TextReader reader = new StreamReader(Request.Body))
            {
                requestJson = await reader.ReadToEndAsync();
            }

            try
            {
                WebhookRequest request = jsonParser.Parse<WebhookRequest>(requestJson);
               OriginalDetectIntentRequest originalDetectIntent = request.OriginalDetectIntentRequest;
                originalDetectIntent.Payload
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.InnerException, e.Source);
                
            }
          

            
            WebhookResponse response = new WebhookResponse
            {
                // ...
            };

           
            string responseJson = response.ToString();
            return Content(responseJson, "application/json");
        }
       
        public IActionResult PostChipResponse(string data) 
        {
            // IntentsClient client = new IntentsClientBuilder { }.Build();

            // client.GetIntentAsync(name);
            _logger.LogInformation(data);
            return Ok();
        }
    }
}
