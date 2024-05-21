using Irock.PatientHealthApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.Serivces.Interfaces
{
    public interface IMessageService
    {
        Task<ResponseModel<MessageDTO>> AddMessage(MessageDTO messageDTO);
    }
}
