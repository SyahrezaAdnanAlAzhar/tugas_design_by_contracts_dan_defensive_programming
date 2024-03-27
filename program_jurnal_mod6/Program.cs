using program_jurnal_mod6;
using System;
using System.Diagnostics;
using System.Linq.Expressions;

public class main
{
    public static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Syahreza");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Finding Nemo oleh Syahreza");
        user.AddVideo(video1);
        video1.IncreasePlayCount(20);
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Finding Dori oleh Syahreza");
        user.AddVideo(video2);
        video2.IncreasePlayCount(50);
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Cars oleh Syahreza");
        user.AddVideo(video3);
        video3.IncreasePlayCount(60);
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Cars 2 oleh Syahreza");
        user.AddVideo(video4);
        video4.IncreasePlayCount(53);
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Cars 3 oleh Syahreza");
        user.AddVideo(video5);
        video5.IncreasePlayCount(543);
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Cars 4 oleh Syahreza");
        user.AddVideo(video6);
        video6.IncreasePlayCount(543);
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Toy Story oleh Syahreza");
        user.AddVideo(video7);
        video7.IncreasePlayCount(543);
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Toy Story 1 oleh Syahreza");
        user.AddVideo(video8);
        video8.IncreasePlayCount(543);
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Toy Story 2 oleh Syahreza");
        user.AddVideo(video9);
        video9.IncreasePlayCount(10);
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Toy Story 3 oleh Syahreza");
        user.AddVideo(video10);
        video10.IncreasePlayCount(13);
        SayaTubeVideo video11 = new SayaTubeVideo("Review Film Transformer oleh Syahreza");
        user.AddVideo(video11);
        video11.IncreasePlayCount(15);

        Console.WriteLine("Contoh film yang ada");
        video1.PrintVideoDetail();

        Console.WriteLine("---------");

        user.PrintAllVideoPlayCount();

        Console.WriteLine($"Total play count user {user.Username} adalah {user.GetTotalVideoPlayCount()}");



        // STV.IncreasePlayCount(1000000001);
        //int i = 100000;
        //while (i >= 0)
        //{
        //    STV.IncreasePlayCount(i);
        //}
        //STV.PrintVideoDetail();
    }
}