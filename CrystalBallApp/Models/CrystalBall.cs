using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //get random number
        //create an array of strings
        public string getResponse()
        {
            string[] responses = { "Don't be a jerk.", "Life is short. Play hard.", "Go Cleveland. Whatever team." };
            //get random object
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length);
            return responses[num];

        }
    }
}