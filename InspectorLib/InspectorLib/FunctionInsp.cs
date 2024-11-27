using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string _chiefInspector = "Васильев Василий Иванович";
        private string _carInspectionName = "Автоинспекция г. Чита";
        private List<string> _workers = new List<string>() { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
        private Random _random = new Random();


        public string GetInspector()
        {
            return _chiefInspector;
        }

        public string GetCarInspection()
        {
            return _carInspectionName;
        }

        public bool SetInspector(string fullName)
        {
            if (_workers.Contains(fullName))
            {
                _chiefInspector = fullName;
                return true;
            }
            return false;
        }

        public string GenerateNumber(char symbol, int code = 75)
        {
            int number = _random.Next(1000, 10000); // Generates a random 4-digit number
            return $"{symbol.ToString().ToUpper()}{number}_{code}";
        }

        public List<string> GetWorker()
        {
            return _workers;
        }

        public bool AddWorker(string fullName)
        {
            if (!_workers.Contains(fullName))
            {
                _workers.Add(fullName);
                return true;
            }
            return false;
        }
    }
}

