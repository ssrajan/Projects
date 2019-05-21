using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string getDescription();
    }
}
