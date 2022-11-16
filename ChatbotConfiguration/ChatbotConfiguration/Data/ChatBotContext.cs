using Microsoft.EntityFrameworkCore;

namespace ChatbotConfiguration.Data
{
    public class ChatBotContext : DbContext
    {
        public ChatBotContext()
        {
        }

        public ChatBotContext(DbContextOptions<ChatBotContext> options)
             : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }


        public DbSet<quetions> tbl_Quetions { get; set; }
        public DbSet<options> tbl_Options { get; set; }
        public DbSet<userReplies> tbl_UserReplies { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=JANVI-DESAI\\SQLEXPRESS;Database=Chatbot;Integrated Security=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
