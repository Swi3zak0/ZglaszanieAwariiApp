using System.Collections.Generic;
using System.Linq;
using ZglaszanieAwariiApp.Models;
using ZglaszanieAwariiApp.Exceptions;

namespace ZglaszanieAwariiApp.Services
{
    // Klasa z wykorzystaniem interfejsu
    public class ZarzadzanieAwariami : IZarzadzanieAwariami
    {
        private List<Awarie> listaAwarii = new();

        // Funkcja dodaje nową awarię do listy po sprawdzeniu poprawności danych
        public void DodajAwarie(Awarie awaria)
        {
            if (string.IsNullOrWhiteSpace(awaria.Opis))
                throw new AwarieException("Opis awarii nie może być pusty.");

            if (awaria.Zglaszajacy == null)
                throw new AwarieException("Brak zgłaszającego awarię.");

            awaria.Id = listaAwarii.Count + 1;
            awaria.DataZgloszenia = System.DateTime.Now;
            listaAwarii.Add(awaria);
        }
        // Funkcja aktualizuje status awarii na podstawie jej ID
        public void AktualizujStatus(int id, StatusAwarii nowyStatus)
        {
            var awaria = listaAwarii.FirstOrDefault(a => a.Id == id);
            if (awaria == null)
                throw new AwarieException($"Nie znaleziono awarii o ID = {id}");

            awaria.Status = nowyStatus;
        }
        // Funkcja zwraca wszystkie zgłoszone awarie
        public List<Awarie> PobierzWszystkie() => listaAwarii;

        // Funkcja zwaraca awarie przefiltorwane po ich statusie
        public List<Awarie> FiltrujPoStatusie(StatusAwarii status) =>
            listaAwarii.Where(a => a.Status == status).ToList();
    }
    // Interfejs
    public interface IZarzadzanieAwariami
    {
        void DodajAwarie(Awarie awaria);
        void AktualizujStatus(int id, StatusAwarii nowyStatus);
        List<Awarie> PobierzWszystkie();
        List<Awarie> FiltrujPoStatusie(StatusAwarii status);
    }
}