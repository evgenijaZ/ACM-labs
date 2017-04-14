using System;

public class Interpolation
{
	public Interpolation()
	{
	}

    public void CalculateNodes(double[] x, double[] y, double a, double b, int n)
    {
        for (int i = 0; i <= n; i++) {
            x[i] = a + ((b - a) / n) * i;
            y[i] = Function(x[i]); ;
        }
    }

    public double Function(double x)
    {
        return Math.Cos(x + Math.Pow(Math.Cos(x), 3));
    }

    public double Polinom(double X, int n, double a, double b) {
        double sum = 0;
        double[] x = new double[n+1];
        double[] y = new double[n+1];
        CalculateNodes(x, y, a, b, n);
        for (int i = 0; i <= n; i++) {
            double product = 1;
            for (int j = 0; j <= n; j++) {
               if (i!=j)
                    product *= (X - x[j]) / (x[i] - x[j]);
            }
            sum += (y[i] * product);
        }
        return sum;
    }

}
