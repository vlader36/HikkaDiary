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

        public void addAt (string value, string key)
        {
            this.peoples.Add(value, key);
        }

        public void readAtBase(Base same)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("hks.hk", FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (fs.Length == 0)
                {
                    return;
                }
                same = (Base)formatter.Deserialize(fs);
            }
        }

        public void writeToBase(Base same)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("hks.hk", FileMode.Append, FileAccess.Write))
            {
                formatter.Serialize(fs, same);
            }
        }
    }
}
