using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Abstractions
{
    public interface ITriangle: IShape
    {
        double A { get; }
        double B { get; }
        double C { get; }

        bool IsRightTriangle { get; }
    }
}
