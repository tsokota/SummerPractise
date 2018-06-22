using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_TP
{
    public enum LanguageEnum
    {
        Unit,
        Integration,
        System,
        Acceptance,
            }

    public enum PositionEnum
    {
        Analitic,
        Designer,
        Alfa,
        Beta,
        Tester
    }

    public class Tester
    {
        public Tester()
        {
            ID = 0;
            Birthday = new DateTime(2001, 09, 13);
        }

        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public DateTime Birthday { get; set; }
        public LanguageEnum Language { get; set; }
        public PositionEnum Position { get; set; }
        public int Expirience { get; set; }
        public int Salary { get; set; }
    }


    public class TesterArr
    {
        // Коллекция тестировщиков
        public ArrayList collTest;
        // Идентификатор последнего сгенерированного тестировщика
        private int _lastID;
        Random rand;


        public TesterArr()
        {
            collTest = new ArrayList();
            _lastID = 0;
            rand = new Random();
        }

        // генерация одного программиста
        public Tester Generate()
        {
            Tester tst = new Tester();


            string[] Surname =
            {
            "Пилипенко", "Кравец", "Лукьяненко", "Тютюн", "Судаков", "Пархоменко", "Боров", "Чишкала", "Иванов","Тихонов",
            "Котелевец",  "Чумейко", "Куприянов",  "Цокота", "Дугинов",  "Коломацкий",  "Соломка",  "Шухевич", "Порошенко","Джобс"
            };

            string[] Name =
            {
           "Тимур", "Антолий", "Дмитрий", "Ярослав", "Виктор", "Денис", "Максим", "Валерий", "Игорь",  "Евгений",
            "Кирилл", "Данил", "Стив", "Билл", "Михаил",  "Петр", "Роман",  "Евгений"
            };

            string[] MiddleName =
            {
             "Валериевич",  "Михайлович", "Богданович", "Тимурович",  "Григориевич", "Сергеевч", "Егорович", "Евгениевич",
            "Кондратиевич", "Стивович", "Романович", "Дмитриевич", "Максимович", "Петрович",  "Кириллович", "Антолиевич", "Денисович"
            };

            tst.ID = NewID();
            tst.Surname = Surname[rand.Next(0, Surname.Length - 1)];
            tst.Name = Name[rand.Next(0, Name.Length - 1)];
            tst.Middlename = MiddleName[rand.Next(0, MiddleName.Length - 1)];

            int year = rand.Next(1974, 2002);
            int month = rand.Next(1, 13);
            int day = rand.Next(1, 29);
            tst.Birthday = new DateTime(year, month, day);

            tst.Language = (LanguageEnum)rand.Next(0, 4);
            tst.Position = (PositionEnum)rand.Next(0, 5);
            tst.Expirience = rand.Next(0, 40);
            tst.Salary = rand.Next(3720, 99999);

            return tst;
        }

        // геннерация коллекции тестировщов
        public void GenerateArray(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Tester tst = this.Generate();
                collTest.Add(tst);
            }
        }

        // индексатор для доступа к эдементам массива по их индексу
        public Tester this[int index]
        {
            get { return (Tester)collTest[index]; }
            set { collTest[index] = value; }
        }

        // количество тестеров
        public int Count
        {
            get { return collTest.Count; }
        }

        // уникальный номер тестера
        public int NewID()
        {
            return ++_lastID;
        }

        public ArrayList ToArray()
        {
            return collTest;
        }

        // добавить одного тестера
        public void Add(Tester Tester)
        {
            collTest.Add(Tester);
        }

        // фильтрация массива
        public ArrayList Filtr(int Property, int Condition, object Value)
        {
            var result = from Tester tst in collTest
                         select tst;

            if (Condition == 0) //==
            {
                if (Property == 0) result = result.Where(tst => tst.ID == Convert.ToInt32(Value));
                else if (Property == 1) result = result.Where(tst => tst.Surname == (string)Value);
                else if (Property == 2) result = result.Where(tst => tst.Name == (string)Value);
                else if (Property == 3) result = result.Where(tst => tst.Middlename == (string)Value);
                else if (Property == 4) result = result.Where(tst => tst.Birthday == Convert.ToDateTime(Value));
                else if (Property == 5) result = result.Where(tst => tst.Language.ToString() == (string)Value);
                else if (Property == 6) result = result.Where(tst => tst.Position.ToString() == (string)Value);
                else if (Property == 7) result = result.Where(tst => tst.Expirience == Convert.ToInt32(Value));
                else if (Property == 8) result = result.Where(tst => tst.Salary == Convert.ToInt32(Value));
            }
            else if (Condition == 1) // !=
            {
                if (Property == 0) result = result.Where(tst => tst.ID != Convert.ToInt32(Value));
                else if (Property == 1) result = result.Where(tst => tst.Surname != (string)Value);
                else if (Property == 2) result = result.Where(tst => tst.Name != (string)Value);
                else if (Property == 3) result = result.Where(tst => tst.Middlename != (string)Value);
                else if (Property == 4) result = result.Where(tst => tst.Birthday != Convert.ToDateTime(Value));
                else if (Property == 5) result = result.Where(tst => tst.Language.ToString() != (string)Value);
                else if (Property == 6) result = result.Where(tst => tst.Position.ToString() != (string)Value);
                else if (Property == 7) result = result.Where(tst => tst.Expirience != Convert.ToInt32(Value));
                else if (Property == 8) result = result.Where(tst => tst.Salary != Convert.ToInt32(Value));
            }
            else if (Condition == 2) //indexof
            {
                if (Property == 0) result = result.Where(tst => tst.ID.ToString().IndexOf((string)Value) >= 0);
                else if (Property == 1) result = result.Where(tst => tst.Surname.IndexOf((string)Value) >= 0);
                else if (Property == 2) result = result.Where(tst => tst.Name.IndexOf((string)Value) >= 0);
                else if (Property == 3) result = result.Where(tst => tst.Middlename.IndexOf((string)Value) >= 0);
                else if (Property == 4) result = result.Where(tst => tst.Birthday.ToString().IndexOf((string)Value) >= 0);
                else if (Property == 5) result = result.Where(tst => tst.Language.ToString().IndexOf((string)Value) >= 0);
                else if (Property == 6) result = result.Where(tst => tst.Position.ToString().IndexOf((string)Value) >= 0);
                else if (Property == 7) result = result.Where(tst => tst.Expirience.ToString().IndexOf((string)Value) >= 0);
                else if (Property == 8) result = result.Where(tst => tst.Salary.ToString().IndexOf((string)Value) >= 0);
            }
            ArrayList arr = new ArrayList();
            foreach (Tester tst in result)
            {
                arr.Add(tst);
            }
            return arr;
        }

        // группировка массива
        public ArrayList Group(int Property)
        {
            ArrayList arr = new ArrayList();
            // группировка по фамилии
            if (Property == 0)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Surname;
                foreach (IGrouping<string, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по имени
            else if (Property == 1)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Name;
                foreach (IGrouping<string, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по отчеству
            else if (Property == 2)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Middlename;
                foreach (IGrouping<string, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по дате рождения
            else if (Property == 3)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Birthday;
                foreach (IGrouping<DateTime, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по технологии тестировании
            else if (Property == 4)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Language;
                foreach (IGrouping<LanguageEnum, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по должности
            else if (Property == 5)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Position;
                foreach (IGrouping<PositionEnum, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по опыту
            else if (Property == 6)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Expirience;
                foreach (IGrouping<int, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }
            // группировка по заплате
            else if (Property == 7)
            {
                var result = from Tester tst in collTest
                             group tst by tst.Salary;
                foreach (IGrouping<int, Tester> g in result)
                {
                    foreach (var t in g)
                    {
                        arr.Add(t);
                    }
                }
            }

            return arr;
        }

        // сортировка массива
        public ArrayList Sort(int Property, int Sort)
        {
            bool isAscending = false;
            if (Sort == 0) isAscending = true;
            else isAscending = false;

            var result = from Tester tst in collTest
                         select tst;
            // сортировка по возрвстанию
            if (isAscending)
            {
                if (Property == 0) result = result.OrderBy(a => a.ID);
                else if (Property == 1) result = result.OrderBy(a => a.Surname);
                else if (Property == 2) result = result.OrderBy(a => a.Name);
                else if (Property == 3) result = result.OrderBy(a => a.Middlename);
                else if (Property == 4) result = result.OrderBy(a => a.Birthday);
                else if (Property == 5) result = result.OrderBy(a => Enum.GetName(typeof(LanguageEnum), a.Language));
                else if (Property == 6) result = result.OrderBy(a => Enum.GetName(typeof(PositionEnum), a.Position));
                else if (Property == 7) result = result.OrderBy(a => a.Expirience);
                else if (Property == 8) result = result.OrderBy(a => a.Salary);
            }
            // сортировка по убыванию
            else
            {
                if (Property == 0) result = result.OrderByDescending(a => a.ID);
                else if (Property == 1) result = result.OrderByDescending(a => a.Surname);
                else if (Property == 2) result = result.OrderByDescending(a => a.Name);
                else if (Property == 3) result = result.OrderByDescending(a => a.Middlename);
                else if (Property == 4) result = result.OrderByDescending(a => a.Birthday);
                else if (Property == 5) result = result.OrderByDescending(a => Enum.GetName(typeof(LanguageEnum), a.Language));
                else if (Property == 6) result = result.OrderByDescending(a => Enum.GetName(typeof(PositionEnum), a.Position));
                else if (Property == 7) result = result.OrderByDescending(a => a.Expirience);
                else if (Property == 8) result = result.OrderByDescending(a => a.Salary);
            }
            ArrayList arr = new ArrayList();
            foreach (Tester tst in result)
            {
                arr.Add(tst);
            }
            return arr;
        }

        // очистка 
        public void Clear()
        {
            collTest.Clear();
            _lastID = 0;
        }

        // удаление элемента массива
        public void RemoveAt(int prgID)
        {
            collTest.RemoveAt(FindIndexFromID(prgID));
        }

        // нахождение индекса в массиве
        public int FindIndexFromID(int prgID)
        {
            int index = -1;

            var result = from Tester tst in collTest
                         select tst.ID;

            int[] arrayID = result.ToArray();

            index = Array.IndexOf(arrayID, prgID);

            return index;

        }


        // 1-я агрегатная функция
        private ArrayList Agregate0()
        {
            // Количество однофамильцев
            var result = from Tester tst in collTest
                         orderby tst.Surname
                         group tst by tst.Surname into g
                         select new { Фамилия = g.Key, Количество = g.Count() };

            ArrayList arr = new ArrayList();
            foreach (var prgSur in result)
            {
                arr.Add(prgSur);
            }

            return arr;
        }

        // 2-я агрегатая функция
        private ArrayList Agregate1()
        {
            // Минимальная дата рождения для техн
            var result = from Tester tst in collTest
                         orderby (LanguageEnum)tst.Language
                         group tst by tst.Language into g
                         select new { Язык = (LanguageEnum)g.Key, МинДеньРождения = g.Min(a => a.Birthday) };

            ArrayList arr = new ArrayList();
            foreach (var prgSur in result)
            {
                arr.Add(prgSur);
            }

            return arr;
        }

        // 3-я агрегатная функция
        private ArrayList Agregate2()
        {
            // Средняя зарплата по должностям
            var result = from Tester tst in collTest
                         orderby (LanguageEnum)tst.Position
                         group tst by tst.Position into g
                         select new { Должность = (PositionEnum)g.Key, СредняяЗП = g.Average(a => a.Salary) };

            ArrayList arr = new ArrayList();
            foreach (var prgSur in result)
            {
                arr.Add(prgSur);
            }

            return arr;
        }

        // выбор агрегатных функций
        public ArrayList Agregate(int Property)
        {
            ArrayList result;
            if (Property == 0) result = Agregate0();
            else if (Property == 1) result = Agregate1();
            else result = Agregate2();
            return result;
        }
    }

}
