using System.ComponentModel.DataAnnotations;

namespace ChatbotConfiguration.Data
{
    public class userReplies
    {
        [Key]
        public int userRepliesId { get; set; }
        public int quetionsId { get; set; }
        public string userReply { get; set; }
        public int userIdentity { get; set; }


        public quetions quetions { get; set; }
    }
}
