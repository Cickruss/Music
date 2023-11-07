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
            //matue.ShowDiscografy();
            //MaquinaDoTempo.ShowMusics();
            //cogulandia.getDataSheet();

            Podcast PodPah = new Podcast("PodPah", "Igão");
            Episode episode1 = new Episode(1,"Tuezin", 45.23f, PodPah);
            episode1.AddGuest("Matue");
            Episode episode2 = new Episode(2,"Ultimo romântico", 40.03f, PodPah);
            episode2.AddGuest("Wiu");
            Episode episode3 = new Episode(3,"Cheiro verde", 43.34f, PodPah);
            episode3.AddGuest("Teto");

            //episode1.ShowDetails();
            PodPah.AddEpisode(episode1);
            PodPah.AddEpisode(episode2);
            PodPah.AddEpisode(episode3);

            PodPah.ShowDetailsAllEpisodes();

        }
    }
}
