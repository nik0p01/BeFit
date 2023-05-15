using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{

//    2. Напишите реализацию метода, возвращающего частичные суммы ряда
//IEnumerable<double> GetRowSums(IEnumerable<double> row);
//    Например, для ряда
//1, 2, 3, 4, ...
//он должен вернуть
//1, 3, 6, 10, ...
//Возможность переполнения типа double при суммировании можно не учитывать. (Рекомендация: используйте LINQ).

    public static class RowSumer
    {
        public static IEnumerable<double> GetRowSums(IEnumerable<double> row)
        {
            double sum = 0;
            return row.Select(value => sum += value);
        }
    }
}
