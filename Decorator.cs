
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Decorator:Component
    {

        private readonly Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        } 
    }

    public class ConcreteDecorator: Decorator
    {
        public ConcreteDecorator(Component component):base(component)
        {
            
        }
        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }

        //Add New Feature

        public void NewFeature()
        {
            Console.WriteLine("Add New Feature By Decorator Pattern....");
        }

    
    }
}
