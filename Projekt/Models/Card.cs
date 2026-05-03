namespace Projekt.Models
{
    public class Card
    {
        public int Id { get; set; } // Główne ID dla bazy danych

        public string CardNumber { get; set; } // np. "001", "020"
        public string Name { get; set; } // np. "BLUBERINI OCTOPUSINI"
        
        // Zamiast relacji do klasy CardPack, po prostu trzymamy nazwę folderu
        public string PackName { get; set; } // np. "brainrot"

        // Właściwość pomocnicza do wyświetlania obrazka w Blazorze
        public string ImageUrl => $"packs/{PackName}/{CardNumber}.png";
    }
}