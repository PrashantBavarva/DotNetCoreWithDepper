using Irock.PatientHealthApp.Repository.Interfaces;
using Irock.PatientHealthApp.Repository.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.Repository.Repository
{
    public class MessageRepository :BaseRepository , IMessageRepository
    {
        private readonly DapperContext _dapperContext;
        public MessageRepository(DapperContext dapperContext) : base(dapperContext)
        {
            this._dapperContext = dapperContext;
        }
    }
}
