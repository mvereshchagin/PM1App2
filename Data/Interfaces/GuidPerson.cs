using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Interfaces;

internal class GuidPerson : IItem<Guid>
{
    public Guid Id { get; set; }  
}
