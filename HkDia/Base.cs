using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HkDia
{
    [Serializable]
    class Base
    {
        public Dictionary<string, string> peoples;

        public Base()
        {
            peoples = new Dictionary<string, string>();
        }

        public void addAt (string name, string pass)
        {
            this.peoples.Add(name, pass);
        }

        static public void readAtBase(ref Dictionary<string, string> same)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("hks.hk", FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (fs.Length == 0)
                {
                    return;
                }
                same = (Dictionary<string, string>)formatter.Deserialize(fs);
            }
        }

        static public void writeToBase(Base same)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("hks.hk", FileMode.Truncate, FileAccess.Write);
            formatter.Serialize(fs, same.peoples);
            fs.Close();
        }
    }
}
