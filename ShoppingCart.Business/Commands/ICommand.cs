using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Commands
{

    //Komutları oluşturuyor ve soyutlamak için kullanırız
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
