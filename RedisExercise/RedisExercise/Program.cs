using RedisExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        var redis = new Redis("ADIGE\\SQLEXPRESS"); //Veri Tabanı yolumuzu Redis sınıfına veriyoruz.

        // Veri ekleme işlemleri
        redis.AddData("name", "Mustafa");
        redis.AddData("lastname", "YILMAN");
        redis.AddData("age", "21");
        redis.AddData("delete", "delete");


        // Veri getirme işlemleri
        string name = redis.GetData("name");
        string lastname = redis.GetData("lastname");
        string age = redis.GetData("age");
        string delete = redis.GetData("delete");

        Console.WriteLine(
            $" Adı: {name}\n" +
            $" Soyadı: {lastname}\n" +
            $" Yasi: {age}"
        );

        // Veri silme işlemleri
        redis.DeleteData("delete");


        /*      Console Görünümü
         * 
         * Adı : Mustafa
         * Soyadı : YILMAN
         * Yasi : 21
         * 
         * 
         */
    }
}