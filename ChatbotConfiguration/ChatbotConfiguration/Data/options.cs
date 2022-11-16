using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatbotConfiguration.Data
{
    public class options
    {
        [Key]
        public int optionsId { get; set; }  
        public string optionsName { get; set; }
        public int quetionsId { get; set; }
        public int quetionsTargetId { get; set; }

        public quetions quetions { get; set; }

    }
}
