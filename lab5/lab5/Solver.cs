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
        public void CalculateRoots(double[,] arr, ref double x1, ref double x2, ref double x3) {
            x3 = arr[2, 3];
            x2 = arr[1, 3] - x3 * arr[1, 2];
            x1 = arr[0, 3] - (x2 * arr[0, 1] + x3 * arr[0, 2]);
        }
    }
}
