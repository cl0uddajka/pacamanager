using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
namespace PacaManager
{
    public sealed class Singleton
    {
        private Singleton() { }

        static readonly Singleton _instance = new Singleton();

        public static Singleton Instance => _instance;

        public MongoClient client;

        public string PACAConnectionString = "mongodb+srv://cl0uddajka:1596842424z@cluster0.yjlz2.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";

        public IMongoDatabase db;


        private int _count = 0;

        public void Increase() => _count++;

        public int Count => _count;
    }
    public class Common
    {
        public string checkMaID(int ma)
        {
            string tmp = "";
            if (ma <= 999999)
            {

                if (ma <= 99999)
                {
                    tmp = "0";

                    if (ma <= 9999)
                    {
                        tmp = "00";

                        if (ma <= 999)
                        {
                            tmp = "000";
                            if (ma <= 99)
                            {
                                tmp = "0000";
                                if (ma <= 9)
                                {
                                    tmp = "00000";
                                }
                            }
                        }
                    }
                }
            }
            return tmp + ma.ToString();
        }
    }

}
