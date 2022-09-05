using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnaylserUC2
{
    public class MoodAnasyle
    {
        private const string message = "I am in Sad Mood";
        private string testmessage = "";
        //public string Message
        //{ 
        //    get { return message; } 
        //    set { message = value; }
        //}
        public MoodAnasyle()
        {

        }
        public MoodAnasyle(string msg)
        {
            this.testmessage = msg;
        }

        public string AnalyseMood()
        {
            if (this.testmessage == message)
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
