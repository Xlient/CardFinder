using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFWebHookApi
{
    public class CardFulliment
    {

        public class Rootobject
        {
            public Fulfillmentmessage[] fulfillmentMessages { get; set; }
        }

        public class Fulfillmentmessage
        {
            public Card card { get; set; }
        }

        public class Card
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string imageUri { get; set; }
            public Button[] buttons { get; set; }
        }

        public class Button
        {
            public string text { get; set; }
            public string postback { get; set; }
        }

    }
}
