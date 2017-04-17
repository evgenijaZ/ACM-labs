using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Solver
    {
        public void TransformMatrix(double[,] arr, int n, int m) {
            for (int i = 0; i < n; i++) {
                double k = arr[i, i];
                for (int j = 0; j < m; j++) {
                    arr[i, j] = arr[i, j] / k;
                }
                for (int p = i+1; p < n; p++)
                {
                    k = arr[p, i] / arr[i, i];
                    for (int j = 0; j < m; j++)
                    {
                        arr[p, j] = arr[p, j] - k * arr[i, j];
                    }
                }
            }
        }
    }
}
