# CardFinder 💰 Winner of FinHacks 2021 💰
[![Alt text for your video](https://user-images.githubusercontent.com/35268101/132959739-84e57b4a-2ab8-4e0e-b412-9d1e2d1d447a.png)](https://youtu.be/X-wxkX-o4IU)
## Inspiration
the idea for this project came from when I was in an internship and one of our assignments was to conduct a website analysis on a company's website. I chose a bank and I noticed that from a user perspective searching and applying for credit cards was tedious.  I wanted to make a tool where it can give me suggestions on what cards I should pick or look into and answer general questions

## What it does
The main idea of  Card finder is to help make choosing the right credit card easy for consumers. Instead of using traditional filters and comparison tables to help narrow down a users search,
Card Finder leverages lifelike conversational AI to make suggestions on potential credit card matches through a virtual agent. It also educates on credit cards and gives users resources to use credit cards wisely.  Currently only support  CapitalOne cards (travel rewards etc..)

## How we built it
I mainly used Asp.NetCore 3.1 MVC for the front & back-end of the application which is deployed to Google cloud using App engine Flex. Other google cloud services used Cloud functions mainly for webhooks, Dialogflow CX for our chatbot that is integrated into our website & its API & AutoML API 

## Challenges we ran into
- Understanding webhooks, handle fulfillment in the Dialogflow cx API and deploying those webhooks and remains a work in progress because of the spotty-ness of dialog cx available libraries for fulfillment for the user
- designing conversations flow  was definitely a challenge to think of possible scenarios and counter for them
- rich-text responses  
only because Dialogflow cx doesn't have a fulfillment library for node.js as of yet and with Dialogflow messenger being experimental some of the events were throwing unexpected errors. so I had strategize how I wanted to send rich text responses
-  being stuck with javascript because there was no up to date .NET client library for Dialogflow cx

## Accomplishments that we're proud of

I'm really proud that I got the bot working and displaying rich content for users, this also was my first time deploying an application to Google cloud so i had to learn a bit of docker!

## What we learned
I learned how easy it was to set up and deploy a web app in google cloud.  I also learned how to set up a webhook in node js and deploy it and integrate it into my bot. I learn how to design the flow of conversation in a chat bot

## What's next for Card Finder
Lots of things here are a few:
- Adding more cards from different issuers
- Adding more content to the resources section of the project to educate on credit cards or maybe turn that into a blog (help)
- Polish the conversation flow according to best practices 
