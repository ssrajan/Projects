using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
