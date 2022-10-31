using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Interfaces;

public interface IItemWithName<T> : IItem<T>
{
    string Name { get; set; }
}
