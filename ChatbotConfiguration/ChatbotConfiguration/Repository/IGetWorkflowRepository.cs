using ChatbotConfiguration.Model;

namespace ChatbotConfiguration.Repository
{
    public interface IGetWorkflowRepository
    {
        Task<List<QuetionsBankModel>> getFlow(int BotId);
        Task<QuetionsBankModel> getQuetion(int quetionId);
    }
}