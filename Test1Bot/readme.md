# EchoBot hosted in ASP.NET Core
This sample shows how to integrate a simple EchoBot bot with ASP.Net Core 2. 

# LUIS
Integrated LUIS with some sample intents for testing

https://www.luis.ai/



# project Info
This project is built on Visual Studio 2017

Installed Bot Builder V4 SDK Template for Visual Studio (https://marketplace.visualstudio.com/items?itemName=BotBuilder.botbuilderv4.)

Installed Bot Framework Emulator https://github.com/Microsoft/BotFramework-Emulator/releases

And followed step by step instrauctions here:  https://github.com/Microsoft/BuildAnIntelligentBot

NOTE: I already have Azure subscription, so used the same for LUIS account creation.




# Running this  applciation

1. Build the project once to restore all nuget packages. This project is already configured to use port 3978. So when you run the applciation, it should open http://localhost:3978/ in the browser.

2. Run the BOT emulator and select the "Test1Bot.bot" file from the project folder. 

You can find this file under: Test1Bot solution folder -> Test1Bot fodler -> Test1Bot.bot

3. For testing you can type below questions:

What's cooking?

Who is lakshmi?

What is psal?




# Additional Learning resources

I also followed some of the learning resources here:

https://aischool.microsoft.com/en-us/learning-paths