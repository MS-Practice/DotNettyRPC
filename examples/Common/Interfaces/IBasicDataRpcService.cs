using Common.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IBasicDataRpcService
    {
        Task<List<StageMessage>> GetAllStagesAsync();
        List<StageMessage> GetAllStages();
    }
}
