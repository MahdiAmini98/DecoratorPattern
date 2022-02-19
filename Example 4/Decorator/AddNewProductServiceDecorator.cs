using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Example_4.Domain;
using DecoratorPattern.Example_4.SimpleByInterface;

namespace DecoratorPattern.Example_4.Decorator
{
    public abstract class AddNewProductServiceDecorator: IAddNewProductService
    {
        private readonly IAddNewProductService _addNewProductService;

        public AddNewProductServiceDecorator(IAddNewProductService addNewProductService)
        {
            _addNewProductService = addNewProductService;
        }
        public void Execute(Product product)
        {
           _addNewProductService.Execute(product);
        }
    }

    //ConcreteClass For AddNewProductServiceDecorator
    public class LoggingDecorator: AddNewProductServiceDecorator
    {
        public LoggingDecorator(IAddNewProductService addNewProductService):base(addNewProductService)
        {
            
        }

        public void Execute(Product product)
        {
          base.Execute(product);
          Logging();
        }

        //Add New Feature
        public void Logging()
        {
            Console.WriteLine("Logging Is Success...");
        }

    }
}
