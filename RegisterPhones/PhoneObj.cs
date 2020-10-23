using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegisterPhones
{

    /// <summary>
    /// Данные приложения
    /// </summary>
    public class PhoneObj
    {
        private static MyException myException;

        /// <summary>
        /// перенос данных между формами
        /// </summary>
        public static bool Transfer;

        /// <summary>
        /// перенос объекта происшествия между формами
        /// </summary>
        public static PhoneObj ObjAccident = new PhoneObj();

        /// <summary>
        /// список всех происшествий
        /// </summary>
        public static List<PhoneObj> AccidentList = new List<PhoneObj>();

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
                    PhoneObj accident = new PhoneObj("", "", "", "");
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
                            string[] Loads = VARIABLE.Split(new char[] {';'});
                            PhoneObj accident = new PhoneObj();
                            accident.DataTime = Loads[1];
                            accident.Street = Loads[2];
                            accident.Accident = Loads[3];
                            accident.DateCall = Loads[4];
                            accident.AddDispetcher = Loads[5];
                            accident.RemoveDispetcher = Loads[6];
                            accident.Computer = Loads[7];
                            accident.District = Loads[8];
                            accident.Kind = Loads[9];
                            db.Accidents.Add(accident);
                        }
                        catch
                        {
                        }
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
        public static void AddAccident(PhoneObj accident)
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
        public static void DeleteAccident(PhoneObj accident)
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

        public static void ChangeAccident(PhoneObj oldAccident, PhoneObj newAccident)
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

        internal static bool GetHash(List<PhoneObj> AccidentList1, List<PhoneObj> AccidentList2)
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

        public PhoneObj()
        {
        }

        public PhoneObj(string district, string adress, string accident, string timeAccident)
        {
            DataTime = DateTime.Now.ToString("O");
            District = district;
            Accident = accident;
            Street = adress;
            DateCall = timeAccident;
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
        /// дата звонка
        /// </summary>
        public string DateCall { get; set; }

        /// <summary>
        /// вх./исх звонок
        /// </summary>
        public string InOut { get; set; }

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string Worker { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        public int Building { get; set; }

        /// <summary>
        /// Кор
        /// </summary>
        public string Corps { get; set; }

        /// <summary>
        /// Кв
        /// </summary>
        public int Flat { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public long Phone { get; set; }

        /// <summary>
        /// Статус звонка
        /// </summary>
        public string StatusPhone { get; set; }

        /// <summary>
        /// ЛС
        /// </summary>
        public int LS { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Компания
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Содержимое разговора
        /// </summary>
        public string Conversation { get; set; }

        /// <summary>
        /// Тон разговора
        /// </summary>
        public string TonConversation { get; set; }

        /// <summary>
        /// Решение об оплате
        /// </summary>
        public string Solution { get; set; }

        /// <summary>
        /// Расшифровка решения "Не оплатит по другой причине"
        /// </summary>
        public string DecodingSolution { get; set; }

        /// <summary>
        /// Сомневается что оплатит потому, что…
        /// </summary>
        public string Doubt { get; set; }

        /// <summary>
        /// Происшествие
        /// </summary>
        public string Accident { get; set; }

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
        /// тип резервации
        /// </summary>
        public string Kind { get; set; }
    }
}

