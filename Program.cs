using System;

namespace scratchpad
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileHelper fh = new FileHelper("test");
            Console.WriteLine("Hello World!");
            try{
                try {
                fh.readFile();
                }finally{
                    fh.closeFile();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
