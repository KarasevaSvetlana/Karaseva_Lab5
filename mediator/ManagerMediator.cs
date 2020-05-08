using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    class ManagerMediator : Mediator
    {
        public People Provider { get; set; }
        public People Seller { get; set; }
        public People Buyer { get; set; }
        public override void Send(string msg, People colleague)
        {
            // если отправитель - покупатель, значит есть новый заказ
            // отправляем сообщение продавцу - выполнить заказ
            if (Buyer == colleague)
                Buyer.Notify(msg);
            // если отправитель - продавец, то можно приступать к тестированию
            // отправляем сообщение поставщику
            else if (Seller == colleague)
                Seller.Notify(msg);
            // если отправитель - поставщик, значит продукт готов
            // отправляем сообщение продавцу
            else if (Provider == colleague)
                Provider.Notify(msg);
        }
    }
}
