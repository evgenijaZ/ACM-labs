using System;

public class Interpolation
{
	public Interpolation()
	{
	}

    public void CalculateNodes(double[] x, double[] y, double a, double b)
    {
        for (int i = 0; i <= 10; i++) {
            x[i] = a + ((b - a) / 10) * i;
            y[i] = Math.Cos(x[i] + Math.Pow(Math.Cos(x[i]),3));
        }
    }
}
