using y = System.Console;



namespace ReviewTheBasics
{
    class Program
    {
        int[] num = new int[100];
        public int this[int index]
        {
            set
            {
                num[index] = value;
            }
            get
            {
                return num[index];
            }
        }
        static void Main(string[] args)
        {
            y.WriteLine("---------------------------------");
            y.WriteLine("\t 1D Indexer (Integer)");
            y.WriteLine("---------------------------------");
            Program obj = new Program();
            obj[0] = 14;
            obj[1] = 32;
            obj[2] = 54;
            obj[3] = 67;
            obj[4] = 72;
            for (int i = 0; i < obj.num.Length; i++)
            {
                if (obj[i] != 0)
                {
                    y.WriteLine(obj[i]);
                }
            }
        }
    }
}