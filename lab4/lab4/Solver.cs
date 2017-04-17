using System;

public class Solver
{
	public Solver()
	{
	}
    public double Function(double x)
    {
        return Math.Pow(Math.Sin(x + Math.PI / 2),2) - (Math.Pow(x, 2) / 4);
    }

    public double Function_(double x)
    {
        return ((-2*Math.Sin(x)*Math.Cos(x)) - (x / 2));
    }

    public bool FindNode(double a, double b, double e, ref double x, ref int k)
    {
        double x0;
        k = 0;
        if (a > b) 
        {
            x0 = a;
            a = b;
            b = x0;
        }
        if (Function(a) * Function(b) < 0)
        {
            
            if (Math.Abs(a - b) <= e) {
                x = ((a + b) / 2);
                return true;
            }
            if (Function(a) * Function_(a) > 0) {
                x0 = a;
            }
            else x0 = b;
            x = x0 - Function(x0) / Function_(x0);
            k++;
            while (Math.Abs(x - x0) > e)
            {
                x0 = x;
                x = x0 - Function(x0) / Function_(x0);
                k++;
                
            }
           
            return true;
         } else return false;
    }
}
