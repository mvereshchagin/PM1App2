﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Interfaces;

public interface IItem<T>
{
    T Id { get; set; }
}
