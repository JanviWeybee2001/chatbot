using ChatbotConfiguration.Data;
using ChatbotConfiguration.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotConfiguration.Repository
{
    public class GetWorkflowRepository : IGetWorkflowRepository
    {
        private readonly ChatBotContext _context = null;

        public List<QuetionsBankModel> chatFlow = new List<QuetionsBankModel>()
        {
            new QuetionsBankModel() 
        };
        public GetWorkflowRepository(ChatBotContext context)
        {
            _context = context;
        }

        public async Task<List<QuetionsBankModel>> getFlow(int BotId)
        {
            var flow = new List<QuetionsBankModel>();
            var wholeflow = await _context.tbl_Quetions.Where(x => x.botId == BotId).ToListAsync();
            if (wholeflow?.Any() == true)
            {
                foreach (var party in wholeflow)
                {
                    flow.Add(new QuetionsBankModel()
                    {
                        Que_id = party.quetionsId,
                        Que_description = party.quetionsDescription,
                        Que_sequence = party.quetionsSequence,
                        Que_targetId = party.quetionsTargetId,
                        Que_type = party.quetionsType,
                        Bot_id = party.botId
                    });
                }
            }
            return flow;
        }

        public async Task<QuetionsBankModel> getQuetion(int quetionId)
        {
            var quetion = new QuetionsBankModel();
            var que = await _context.tbl_Quetions.Where(x => x.quetionsId == quetionId).FirstOrDefaultAsync();
            if(que != null)
            {
                quetion = new QuetionsBankModel()
                {
                    Que_id = que.quetionsId,
                    Que_description = que.quetionsDescription,
                    Que_sequence = que.quetionsSequence,
                    Que_targetId = que.quetionsTargetId,
                    Que_type = que.quetionsType
                };
            }

            return quetion;
        }

    }
}
