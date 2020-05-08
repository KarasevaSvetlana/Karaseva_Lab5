using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            People seller = new Seller(mediator);
            People provider = new Provider(mediator);
            People buyer = new Buyer(mediator);
            mediator.Seller = seller;
            mediator.Provider = provider;
            mediator.Buyer = buyer;

            seller.Send("у нас нет товара");
            provider.Send("товар доставлен до магазина");
            buyer.Send("я хочу купить");

            Console.Read();
        }
    } 
}
