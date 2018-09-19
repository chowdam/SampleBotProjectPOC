using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;
using Microsoft.Bot.Builder.Ai.LUIS;

namespace Test1Bot
{
    public class EchoBot : IBot
    {
        /// <summary>
        /// Every Conversation turn for our EchoBot will call this method. In here
        /// the bot checks the Activty type to verify it's a message, bumps the 
        /// turn conversation 'Turn' count, and then echoes the users typing
        /// back to them. 
        /// </summary>
        /// <param name="context">Turn scoped context containing all the data needed
        /// for processing this conversation turn. </param>        
        public async Task OnTurn(ITurnContext context)
        {
            //key1: 507bfaf1a24f45f996f7b579dc892e90
            // app id in luis: 2be4e509-70b2-4b00-b415-c01c9de019e4


            // This bot is only handling Messages

            if (!context.Responded)
            {
                var result = context.Services.Get<RecognizerResult>(LuisRecognizerMiddleware.LuisRecognizerResultKey);
                var topIntent = result?.GetTopScoringIntent();
                topIntent = topIntent != null && topIntent.Value.score < 0.5 ? null : topIntent;
                string[] Specialties = new string[] { "Pizza", "Lasagna", "Carbonara" };
                switch (topIntent != null ? topIntent.Value.intent : null)
                {
                    case "TodaysSpecialty":                        
                        await context.SendActivity($"For today we have the following options: {string.Join(", ", Specialties)}");
                        break;
                    case "PSAL_Team":
                        await context.SendActivity($"Member of PSAL Team, OfCourse!");//get more info from API/services/database
                        break;
                    default:
                        await context.SendActivity("Sorry, I didn't understand that.");
                        break;
                }
            }


            //if (context.Activity.Type == ActivityTypes.Message)
            //{
            //    // Get the conversation state from the turn context
            //    var state = context.GetConversationState<EchoState>();

            //    // Bump the turn count. 
            //    state.TurnCount++;

            //    // Echo back to the user whatever they typed.
            //    await context.SendActivity($"Turn {state.TurnCount}: You sent '{context.Activity.Text}'");
            //}
            //else if (context.Activity.Type == ActivityTypes.ConversationUpdate && context.Activity.MembersAdded.FirstOrDefault()?.Id == context.Activity.Recipient.Id)
            //{
            //    await context.SendActivity("Hi! I'm a restaurant assistant bot. I can add help you with your reservation.");
            //}
        }
    }
}
