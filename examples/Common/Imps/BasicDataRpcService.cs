using Common.Interfaces;
using Common.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Imps
{
    public class BasicDataRpcService : IBasicDataRpcService
    {
        public List<StageMessage> GetAllStages()
        {
            return new List<StageMessage>() {
                new StageMessage{ StageId = 1,StageName = "幼儿园"},
                new StageMessage{ StageId = 2,StageName = "小学"},
                new StageMessage{ StageId = 4,StageName = "初中"},
                new StageMessage{ StageId = 8,StageName = "高中"}
            };
        }

        public async Task<List<StageMessage>> GetAllStagesAsync()
        {
            return await Task.FromResult(new List<StageMessage>() {
                new StageMessage{ StageId = 1,StageName = "幼儿园"},
                new StageMessage{ StageId = 2,StageName = "小学"},
                new StageMessage{ StageId = 4,StageName = "初中"},
                new StageMessage{ StageId = 8,StageName = "高中"}
            });
        }
    }
}
