# ZglaszanieAwariiApp - Projekt zaliczeniowy

Aplikacja desktopowa w C# WinForms do zgłaszania i zarządzania awariami w firmie. Aplikacja powstała w celu zaliczenia przedmiotu **ZPO** (Zaawansowane Programowanie Obiektowe) na Uniwersytecie Warmińsko-Mazurskim.

---

## 📝 Opis projektu

**ZglaszanieAwariiApp** umożliwia użytkownikom zgłaszanie różnych awarii, filtrowanie ich według statusu oraz aktualizację statusu zgłoszeń. Dane są zapisywane w pliku JSON, co pozwala na prostą i trwałą obsługę zgłoszeń.

---

## 🚀 Funkcjonalności

- ➕ Dodawanie nowego zgłoszenia awarii z informacjami o opisie, kategorii, zgłaszającym oraz lokalizacji (numer budynku, piętro).
- 🔍 Przeglądanie listy wszystkich zgłoszonych awarii.
- ✏️ Filtrowanie awarii według statusu (np. Nowe, W trakcie, Zakończone).
- ⚙️ Aktualizacja statusów awarii w widoku listy.
- 🔍 Wyszukiwanie awarii po numerze ID i podgląd szczegółów zgłoszenia.
- 💾 Zapisywanie i wczytywanie danych z pliku JSON (`awarie.json`).

---

## Technologie

- C# (.NET 7.0)  
- Windows Forms (WinForms)  
- JSON Serialization

---

## 📁 Struktura projektu

- **Forms/** – formularze WinForms do interakcji użytkownika  
- **Models/** – definicje klas danych (np. `Awarie`, `Uzytkownik`, `StatusAwarii`)  
- **Services/** – logika biznesowa i zarządzanie danymi  
- **Config/** – konfiguracja singleton z ustawieniami aplikacji  
- **Exceptions/** – własne prosta klasa wyjątków dla obsługi błędów (`AwarieException`)

---

## ▶️ Jak uruchomić?

1. Sklonuj repozytorium:  git clone https://github.com/Swi3zak0/ZglaszanieAwariiApp.git
2. Otwórz projekt w Visual Studio.  
3. Ustaw projekt jako startowy i uruchom aplikację (`F5`).

---

## 💡 Przykładowe użycie

- Otwórz formularz zgłoszenia awarii i wypełnij pola.  
- Kliknij **Dodaj**, aby zapisać zgłoszenie.  
- Przejdź do listy awarii, aby filtrować i edytować statusy.  
- Sprawdź status awarii podając jej ID.

---

## 🔮 Przyszłe Rozszerzenia

- Dodanie autoryzacji i logowania użytkowników.  
- Użycie bazy danych zamiast pliku JSON dla większej skalowalności.  
- Powiadomienia email lub system alertów.

---

## 👤 Autor

- [@Patrycjusz Siwek 164463](https://github.com/Swi3zak0)

---
