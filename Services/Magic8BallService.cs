using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen_Endpoints.Services
{
    public class Magic8BallService
    {
    
        private readonly string[] _responses = new string[]
        {
            "No",
            "Yes",
            "Maybe",
            "Ask again later",
            "Definitely not",
            "It is certain",
            "I cannot predict now",
            "Very likely"
            
        };

        public string GetRandomResponse()
        {
            var random = new Random();
            int index = random.Next(_responses.Length);
            return _responses[index];
        }
    }
    }
