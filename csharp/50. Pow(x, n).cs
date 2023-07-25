public class Solution {
    public double MyPow(double x, int n) {
        //Check if n < 0
        //If it is then x = 1 / x
        if(n < 0)
        {
            x = 1 / x;
        }
        //Return the result of the function Pow with the
        //parameters x and n
        return Pow(x,n);
    }

    //Define a new function called Pow
    private double Pow(double x, int n)
    {
        //Check the rules for the calculation
        //if n == 0 the result will be one and etc...
        if(n == 0) return 1;
        //if n == 1 or -1 than return the x value.
        if(n == 1 || n == -1) return x;

        //Result will be the res of the Pow function with the parameters
        //x and n/2
        double res = Pow(x, n/2);

        //Do the calculation for the next step.
        return res*res*(n % 2 == 0 ? 1:x);

    }

}