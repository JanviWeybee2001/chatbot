using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotConfiguration.Model
{
    public class QuetionsBankModel
    {
        public int Que_id { get; set; }
        public string Que_description { get; set; }
        public string Que_type { get; set; }
        public int Que_targetId { get; set; }
        public int Que_sequence { get; set; }
        public int Bot_id { get; set; }
    }
}
