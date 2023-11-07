using System;
namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            Music cogulandia = new Music("Matue", "Cogulandia", 4.25f, true);
            Music vemChapar = new Music("Matue", "Vem Chapar", 4.15f, true);
            Music gorilaRoxo = new Music("Matue", "Gorila Roxo", 4.55f, true);

            Album MaquinaDoTempo = new Album();
            MaquinaDoTempo.Name = "Maquina do Tempo";
            MaquinaDoTempo.AddMusic(cogulandia);
            MaquinaDoTempo.AddMusic(vemChapar);
            MaquinaDoTempo.AddMusic(gorilaRoxo);

            MaquinaDoTempo.ShowMusics();

        }
    }
}
