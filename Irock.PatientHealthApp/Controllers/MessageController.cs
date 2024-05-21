using Irock.PatientHealthApp.DTO;
using Irock.PatientHealthApp.Serivces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Irock.PatientHealthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService messageService;
        public MessageController(IMessageService messageService)
        {
              this.messageService = messageService; 
        }

        [HttpPost]
        public async Task<ResponseModel<MessageDTO>> AddMessage(MessageDTO messageDTO)
        {
            return await messageService.AddMessage(messageDTO);
        }
    }
}
