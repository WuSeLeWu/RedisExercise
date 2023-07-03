using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisExercise
{
    public class Redis
    {
        private IDatabase Database;

        //Redis sınıfının nesnesini oluştururken bağlantı yolunun verilmesini mecbur kılıyoruz ve yapıcı blok içerisinde bağlantı kodlarını yazıyoruz.
        public Redis(string connectionPath)
        {
            var connectionOptions = new ConfigurationOptions
            {
                EndPoints = { connectionPath },
                AbortOnConnectFail = false
            };

            ConnectionMultiplexer a = ConnectionMultiplexer.Connect(connectionOptions);
            Database = a.GetDatabase();
        }

        //Veri eklemek için StringSet() metodunu kullanıyoruz bunu daha kolay yapabilmek ve sürekli kullanabilmek için metot halinde yaptık.
        public void AddData(string key, string value)
        {
            Database.StringSet(key, value);
        }

        //Veri getirmek için StringGet() metodunu kullanıyoruz bu metot anahtar üzerinden değeri getiriyor.

        public string GetData(string key)
        {
            return Database.StringGet(key);
        }

        //Veri silebilmek için KeyDelete() metodunu kullanıyoruz bu metot sayesinde anahtar üzerinde değeri silebiliyoruz.

        public void DeleteData(string key)
        {
            Database.KeyDelete(key);
        }
    }
}
