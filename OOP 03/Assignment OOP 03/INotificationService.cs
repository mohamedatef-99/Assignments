using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Assignment_OOP_03
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
