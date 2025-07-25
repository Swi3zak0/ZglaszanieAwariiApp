﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ZglaszanieAwariiApp.Models;

namespace ZglaszanieAwariiApp.Services
{
    public class ZarzadzanieDanymi
    {
        private readonly string _filePath;
        // Konstruktor
        public ZarzadzanieDanymi(string filePath)
        {
            _filePath = filePath;
        }
        // Wczytuje dane awarii z pliku JSON
        public List<Awarie> Wczytaj()
        {
            if (!File.Exists(_filePath))
                return new List<Awarie>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Awarie>>(json) ?? new List<Awarie>();
        }
        // Zapisuje dane awarii do pliku JSON
        public void Zapisz(List<Awarie> awarie)
        {
            var json = JsonSerializer.Serialize(awarie, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

    }
}