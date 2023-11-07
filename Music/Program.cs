using System;
namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            Band matue = new Band("matue");

            Music cogulandia = new Music(matue, "Cogulandia", 4.25f, true);
            Music vemChapar = new Music(matue, "Vem Chapar", 4.15f, true);
            Music gorilaRoxo = new Music(matue, "Gorila Roxo", 4.55f, true);
            Music antes = new Music(matue, "Antes", 4.55f, true);

            Album MaquinaDoTempo = new Album("Maquina do Tempo");
            MaquinaDoTempo.AddMusic(cogulandia);
            MaquinaDoTempo.AddMusic(vemChapar);
            MaquinaDoTempo.AddMusic(gorilaRoxo);
            MaquinaDoTempo.AddMusic(antes);

            matue.AddAlbum(MaquinaDoTempo);
            matue.ShowDiscografy();
            MaquinaDoTempo.ShowMusics();
            cogulandia.getDataSheet();

        }
    }
}
