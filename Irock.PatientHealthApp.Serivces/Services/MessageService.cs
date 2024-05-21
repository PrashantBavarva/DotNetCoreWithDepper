using Irock.PatientHealthApp.DTO;
using Irock.PatientHealthApp.Repository.Interfaces;
using Irock.PatientHealthApp.Serivces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.Serivces.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        public MessageService(IMessageRepository messageRepository)
        {
            this._messageRepository = messageRepository;
        }
        public async Task<ResponseModel<MessageDTO>> AddMessage(MessageDTO messageDTO)
        {
            var response = new ResponseModel<MessageDTO>();

            messageDTO.MessageId = Guid.NewGuid();
            var result = await _messageRepository.Add("Proc_AddMessage", messageDTO);
            if(result == true ) 
            {
                response.Success = true;
                response.Message = "Message saved";
            }
            return response;
        }
    }
}
