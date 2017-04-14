using System;

public class Solver
{
	public Solver()
	{
	}
    public double Function(double x)
    {
        return Math.Sin(x + Math.PI / 2) - (x ^ 2 / 4);
    }

    public double Function_(double x)
    {
        return Math.Sin(2 * x + Math.PI) ^ 2 - (x / 2);
    }

    public bool FindNode(double a, double b, double e, double x, int k = 0)
    {
        if (Function(a) * Function(b) > 0)
        {
            
            if (Math.Abs(a - b) <= e) {
                x = (a + b) / 2;
                return true;
            }
            if (Function(b)*Function_(b) < 0) {
                double t = a;
                a = b;
                b = t;
            }
            do {
                x = b - Function(b) / Function_(b);
                k++;
                b = x;
            }
            while (Math.Abs(x - b) > e);
            return true;
         }
         return false;
    }
}
