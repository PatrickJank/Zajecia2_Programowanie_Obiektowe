using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    internal class ZapisOdczyt
    {

        static public bool Save(List<string> list, string filename)
        {

            FileStream fsWrite = new FileStream(filename, FileMode.Create);
            
            if(fsWrite.CanWrite == false)
            {
                return false;
            }            

            StreamWriter sw = new StreamWriter(fsWrite);
            sw.AutoFlush = true;
            foreach(string item in list)
            {
                sw.WriteLine(item);
            }
            fsWrite.Close();
            return true;

        }

        static public bool Load(string filename, out List<string> result)
        {
            result = new List<string>();

            FileStream fsRead = new FileStream(filename, FileMode.Open);
            if (fsRead.CanRead == false)
                return false;
            StreamReader sr = new StreamReader(fsRead);

            while(!sr.EndOfStream)
                result.Add(sr.ReadLine());
            fsRead.Close();

            return true;
        }

    }
}
