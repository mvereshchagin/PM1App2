using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary;

public class Minipig : IComparable<Minipig>
{
    #region props
    public string Name { get; set; } = null!;

    public string? Breed { get; set; }

    public string? Description { get; set; }

    public DateTime? DateOfBirth { get; set; }
    #endregion

    #region IComparable<Minipig>
    //public int CompareTo(Minipig? other)
    //{
    //    if (other is null)
    //        return 1;

    //    if (Name is null && other.Name is null)
    //        return 0;

    //    if (Name is null)
    //        return -1;

    //    return Name.CompareTo(other.Name);
    //}

    public int CompareTo(Minipig? other)
    {
        if (other is null)
            return 1;

        if (DateOfBirth is null && other.DateOfBirth is null)
            return 0;

        if (DateOfBirth is null)
            return -1;

        return DateOfBirth.Value.CompareTo(other.DateOfBirth);
    }
    #endregion

    #region overriden
    public override string ToString()
    {
        return $"{Name} {Description} {DateOfBirth:yyyy.MM.dd}";
    }
    #endregion
}

public class MinipigNameComparer : IComparer<Minipig>
{
    public int Compare(Minipig? x, Minipig? y)
    {
        if (x is null && y is null) return 0;
        if (x is null) return -1;
        if (y is null) return 1;
        if (x.Name is null && y.Name is null) return 0;
        if (x.Name is null) return -1;

        return x.Name.CompareTo(y.Name);
    }
}

public class MinipigDateOfBirthComparer : IComparer<Minipig>
{
    public int Compare(Minipig? x, Minipig? y)
    {
        if (x is null && y is null) return 0;
        if (x is null) return -1;
        if (y is null) return 1;
        if (x.DateOfBirth is null && y.DateOfBirth is null) return 0;
        if (x.DateOfBirth is null) return -1;

        return x.DateOfBirth.Value.CompareTo(y.DateOfBirth);
    }
}
