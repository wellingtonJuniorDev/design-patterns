﻿namespace GOF.Strutcturals._Facade.Generic
{
    public class Facade
    {
        readonly SubSystemOne one;
        readonly SubSystemTwo two;
        readonly SubSystemThree three;
        readonly SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() --- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() --- ");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
