using System;
using System.IO;

namespace scratchpad
{
    public class FileHelper
    {
        public string fileName;
        public FileHelper(string filename){
            this.fileName = filename;
        }

        public void readFile(){
           //Scenario 1
           //FileStream fileStream = new FileStream(fileName, FileMode.Open);
           
           //Scenario 2
           if(fileName != "accessToken"){
               throw new Exception("access token incorrect");
           }
           Console.WriteLine("read");
        }

        public void closeFile(){
            Console.WriteLine("close");
        }
    }
}
