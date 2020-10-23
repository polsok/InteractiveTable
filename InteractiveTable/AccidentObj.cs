using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InteractiveTable
{
    
    /// <summary>
    /// Данные приложения
    /// </summary>
    public class AccidentObj
    {
        private static MyException myException;
        /// <summary>
        /// перенос данных между формами
        /// </summary>
        public static bool Transfer;
        /// <summary>
        /// перенос объекта происшествия между формами
        /// </summary>
        public static AccidentObj ObjAccident = new AccidentObj();
        /// <summary>
        /// список всех происшествий
        /// </summary>
        public static List<AccidentObj> AccidentList = new List<AccidentObj>();

        #region создание таблицы
        /// <summary>
        /// создание таблицы
        /// </summary>
        public static void CreateTable()
        {
            try
            {
                using (AccidentContext db = new AccidentContext())
                {
                    AccidentObj accident = new AccidentObj("", "", "", "");
                    db.Accidents.Add(accident);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                 myException = new MyException(e);
            }
        }
        #endregion

        #region Загрузка данных из файла

        public static void UploadTable(string path)
        {
            try
            {
                string[] Load = File.ReadAllLines(path);
                using (AccidentContext db = new AccidentContext())
                {
                    foreach (var VARIABLE in Load)
                    {
                        try
                        {
                            string[] Loads = VARIABLE.Split(new char[] { ';' });
                            AccidentObj accident = new AccidentObj();
                            accident.DataTime = Loads[1];
                            accident.Adress = Loads[2];
                            accident.Accident = Loads[3];
                            accident.TimeAccident = Loads[4];
                            accident.AddDispetcher = Loads[5];
                            accident.RemoveDispetcher = Loads[6];
                            accident.Computer = Loads[7];
                            accident.District = Loads[8];
                            accident.Kind = Loads[9];
                            db.Accidents.Add(accident);
                        }
                        catch{}
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                myException = new MyException(e);
            }
        }
        #endregion

        #region Добавление происшествия

        /// <summary>
        /// Добавление происшествия
        /// </summary>
        /// <param name="district">Район</param>
        /// <param name="adress">Адрес</param>
        /// <param name="accident">Происшествие</param>
        /// <param name="timeAccident">Время происшествия</param>
        public static void AddAccident(AccidentObj accident)
        {
            try
            {
                using (AccidentContext db = new AccidentContext())
                {
                    db.Accidents.Add(accident);
                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {
                myException = new MyException(e);
            }
        }

        #endregion

        #region Удаление происшествия

        /// <summary>
        /// Удаление происшествия
        /// </summary>
        /// <param name="objAccident"></param>
        public static void DeleteAccident(AccidentObj accident)
        {
            try
            {
                using (AccidentContext db = new AccidentContext())
                {
                    var accidents = db.Accidents.Where(p => p.DataTime == accident.DataTime);
                    accidents.FirstOrDefault().Kind = "Удален";
                    accidents.FirstOrDefault().RemoveDispetcher = Environment.UserName;
                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {
                myException = new MyException(e);
            }
            Transfer = true;
        }

        #endregion

        #region Изменения происшествия

        public static void ChangeAccident(AccidentObj oldAccident, AccidentObj newAccident)
        {
            try
            {
                using (AccidentContext db = new AccidentContext())
                {
                    var accidents = db.Accidents.Where(p => p.DataTime == oldAccident.DataTime);
                    accidents.FirstOrDefault().Kind = "Изменен";
                    accidents.FirstOrDefault().RemoveDispetcher = Environment.UserName;
                    db.Accidents.Add(newAccident);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                myException = new MyException(e);
            }
            Transfer = true;
            //AccidentList = copyAccidents.GetRange(0, copyAccidents.Count);
        }

        #endregion

        #region Сравнение двух списков

        internal static bool GetHash(List<AccidentObj> AccidentList1, List<AccidentObj> AccidentList2)
        {
            try
            {
                List<int> AccidentHash1 = new List<int>();
                List<int> AccidentHash2 = new List<int>();
                foreach (var VARIABLE in AccidentList1)
                    AccidentHash1.Add((VARIABLE.DataTime + VARIABLE.Kind).GetHashCode());
                foreach (var VARIABLE in AccidentList2)
                    AccidentHash2.Add((VARIABLE.DataTime + VARIABLE.Kind).GetHashCode());
                return AccidentHash1.SequenceEqual(AccidentHash2);
            }
            catch (Exception e)
            {
                myException = new MyException(e);
                return false;
            }
        }

        #endregion

        public AccidentObj()
        {
        }

        public AccidentObj(string district, string adress, string accident, string timeAccident)
        {
            DataTime = DateTime.Now.ToString("O");
            District = district;
            Accident = accident;
            Adress = adress;
            TimeAccident = timeAccident;
            AddDispetcher = Environment.UserName;
            Computer = Environment.MachineName;
            Kind = "Создан";
        }
        public int Id { get; set; }
        /// <summary>
        /// время и дата создания заявки
        /// </summary>
        public string DataTime { get; set; }       

        /// <summary>
        /// адрес происшествия
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Происшествие
        /// </summary>
        public string Accident { get; set; }

        /// <summary>
        /// время происшествия
        /// </summary>
        public string TimeAccident { get; set; }

        /// <summary>
        /// диспетчер который добавил
        /// </summary>
        public string AddDispetcher { get; set; }

        /// <summary>
        /// Диспетчер который удалил
        /// </summary>
        public string RemoveDispetcher { get; set; }

        /// <summary>
        /// компьютер с которого сделано изменение
        /// </summary>
        public string Computer { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// тип резервации
        /// </summary>
        public string Kind { get; set; }
    }
}

