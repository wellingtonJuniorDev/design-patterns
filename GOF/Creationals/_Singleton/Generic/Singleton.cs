namespace GOF.Creationals._Singleton.Generic
{
    public class Singleton
    {
        static Singleton instance;

        protected Singleton() { }

        public static Singleton Instance()
        {
            instance ??= new Singleton();

            return instance;
        }
    }
}
