using ChatbotConfiguration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotConfiguration.Model
{
    public class OptionsOfChoiceModel
    {
        public int Option_id { get; set; }
        public int Option_name { get; set; }
        public string Que_id { get; set; }
        public int Que_targetId { get; set; }
    }
}
