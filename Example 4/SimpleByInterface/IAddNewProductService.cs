using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Example_4.Domain;

namespace DecoratorPattern.Example_4.SimpleByInterface
{
    public interface IAddNewProductService
    {
        public void Execute(Product product);

    }


    public class AddNewProductService : IAddNewProductService
    {

        public void Execute(Product product)
        {
           //Add Product Database Code
        }
    }
}
