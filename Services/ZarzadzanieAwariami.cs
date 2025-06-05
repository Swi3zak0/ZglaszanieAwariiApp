using System.Collections.Generic;
using System.Linq;
using ZglaszanieAwariiApp.Models;
using ZglaszanieAwariiApp.Exceptions;

namespace ZglaszanieAwariiApp.Services
{
    public class ZarzadzanieAwariami : IZarzadzanieAwariami
    {
        private List<Awarie> listaAwarii = new();

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

        public void AktualizujStatus(int id, StatusAwarii nowyStatus)
        {
            var awaria = listaAwarii.FirstOrDefault(a => a.Id == id);
            if (awaria == null)
                throw new AwarieException($"Nie znaleziono awarii o ID = {id}");

            awaria.Status = nowyStatus;
        }

        public List<Awarie> PobierzWszystkie() => listaAwarii;

        public List<Awarie> FiltrujPoStatusie(StatusAwarii status) =>
            listaAwarii.Where(a => a.Status == status).ToList();
    }

    public interface IZarzadzanieAwariami
    {
        void DodajAwarie(Awarie awaria);
        void AktualizujStatus(int id, StatusAwarii nowyStatus);
        List<Awarie> PobierzWszystkie();
        List<Awarie> FiltrujPoStatusie(StatusAwarii status);
    }
}