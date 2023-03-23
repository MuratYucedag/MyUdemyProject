using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface ISendMessageService : IGenericService<SendMessage>
    {
        public int TGetSendMessageCount();
    }
}
