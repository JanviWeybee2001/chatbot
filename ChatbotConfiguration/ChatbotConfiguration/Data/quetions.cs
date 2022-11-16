using System.ComponentModel.DataAnnotations;

namespace ChatbotConfiguration.Data
{
    public class quetions
    {
        [Key]
        public int quetionsId { get; set; }
        public string quetionsDescription { get; set; }
        public string quetionsType { get; set; }
        public int quetionsTargetId { get; set; }
        public int quetionsSequence { get; set; }
        public int botId { get; set; }
    }
}
