using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InteractiveTable
{
    
    /// <summary>
    /// Данные приложения
    /// </summary>
    public class Accident
    {
        /// <summary>
        /// передача происшествия между формами
        /// </summary>
        public static Accident ObjAccident;
        /// <summary>
        /// список всех происшествий
        /// </summary>
        public static List<Accident> AccidentList = new List<Accident>();


        /// <summary>
        /// доступность файла происшествий для чтения
        /// </summary>
        public static bool AccessAccidentFileForRead = true;
        /// <summary>
        /// файл происшествий
        /// </summary>
        private static string PathAccident = "Accident.csv";

        /// <summary>
        /// файл удаленных происшествий
        /// </summary>
        private static string PathAccidentRemove = "AccidentRemove.csv";

        #region Загрузка файла с данными

        /// <summary>
        /// Загрузка файла с данными
        /// </summary>
        /// <returns>Список происшествий</returns>
        public static List<Accident> LoadFile()
        {
            if (!File.Exists(PathAccident))
            {
                AccessAccidentFileForRead = false;
                return null;
            }

            try
            {
                FileInfo log = new FileInfo(PathAccident);
                string text;
                using (var streamReader =
                    new StreamReader(log.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    text = streamReader.ReadToEnd();
                }

                text = text.Replace("\r", "");
                char[] chars = {'\n'};
                string[] R = text.Split(chars);
                for (int i = 0; i < R.Length; i++)
                {
                    var t = new List<string>();
                    var csvSplit = new Regex("((?<=\")[^\"]*(?=\"(,|$)+)|(?<=,|^)[^,\"]*(?=,|$))",
                        RegexOptions.Compiled);

                    foreach (Match match in csvSplit.Matches(R[i]))
                        t.Add(match.Value.TrimStart(','));
                    if (t.Count < 6)
                        continue;
                    //обрабатываем данные
                    Accident data = new Accident();
                    data.DataTime = t[0];
                    data.Adress = t[1];
                    data._Accident = t[2];
                    data.TimeAccident = t[3];
                    data.AddDispetcher = t[4];
                    data.District = t[5];
                    AccidentList.Add(data);
                }

                return AccidentList;
            }
            catch (Exception e)
            {
                File.AppendAllText("Error.txt",
                    DateTime.Now.ToString("F") + ", " + Environment.MachineName + ", " + e.Message);
                MessageBox.Show("Проблема с загрузкой файла происшествий");
                return null;
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
        public static void AddAccident(string district, string adress, string accident, string timeAccident)
        {
            try
            {
                Accident ObjAccident = new Accident(district, adress, accident, timeAccident);
                List<Accident> copyAccidents = AccidentList.GetRange(0, AccidentList.Count);
                copyAccidents.Add(ObjAccident);
                if (File.Exists(PathAccident))
                    File.Delete(PathAccident);
                foreach (var data in copyAccidents)
                {
                    string t = "\"" + data.DataTime + "\",";
                    t += "\"" + data.Adress + "\",";
                    t += "\"" + data._Accident + "\",";
                    t += "\"" + data.TimeAccident + "\",";
                    t += "\"" + data.AddDispetcher + "\",";
                    t += "\"" + data.District + "\"\n";
                    File.AppendAllText(PathAccident, t);
                }

                AccidentList.Add(ObjAccident);
            }
            catch (Exception e)
            {
                File.AppendAllText("Error.txt",
                    DateTime.Now.ToString("F") + ", " + Environment.MachineName + ", " + e.Message);
                MessageBox.Show("Не удалось записать данные в файл происшествий. Данные изменены не будут.");
            }
        }

        #endregion

        #region Удаление происшествия

        /// <summary>
        /// Удаление происшествия
        /// </summary>
        /// <param name="objAccident"></param>
        public static void DeleteAccident(Accident objAccident)
        {
            List<Accident> copyAccidents;
            //запись в файл происшествий
            try
            {
                copyAccidents = AccidentList.GetRange(0, AccidentList.Count);
                for (int i = 0; i < copyAccidents.Count; i++)
                {
                    if (objAccident == copyAccidents[i])
                    {
                        copyAccidents.RemoveAt(i);
                        break;
                    }
                }

                if (File.Exists(PathAccident))
                    File.Delete(PathAccident);
                foreach (var data in copyAccidents)
                {
                    string t = "\"" + data.DataTime + "\",";
                    t += "\"" + data.Adress + "\",";
                    t += "\"" + data._Accident + "\",";
                    t += "\"" + data.TimeAccident + "\",";
                    t += "\"" + data.AddDispetcher + "\",";
                    t += "\"" + data.District + "\"\n";
                    File.AppendAllText(PathAccident, t);
                }
            }
            catch (Exception e)
            {
                File.AppendAllText("Error.txt",
                    DateTime.Now.ToString("F") + ", " + Environment.MachineName + ", " + e.Message);
                MessageBox.Show("Не удалось записать данные в файл происшествий. Данные изменены не будут.");
                return;
            }

            //запись в файл удаленных происшествий
            try
            {
                string t = "\"" + objAccident.DataTime + "\",";
                t += "\"" + objAccident.Adress + "\",";
                t += "\"" + objAccident._Accident + "\",";
                t += "\"" + objAccident.TimeAccident + "\",";
                t += "\"" + objAccident.AddDispetcher + "\",";
                t += "\"" + objAccident.District + "\",";
                t += "\"" + objAccident.RemoveDispetcher + "\"\n";
                File.AppendAllText(PathAccidentRemove, t);

            }
            catch (Exception e)
            {
                File.AppendAllText("Error.txt",
                    DateTime.Now.ToString("F") + ", " + Environment.MachineName + ", " + e.Message);
                MessageBox.Show("Не удалось записать данные в файл удаленных происшествий. Данные изменены не будут.");
                return;
            }

            AccidentList = copyAccidents.GetRange(0, copyAccidents.Count);
        }

        #endregion

        #region Изменения происшествия

        public static void ChangeAccident(Accident oldAccident, Accident newAccident)
        {
            List<Accident> copyAccidents;
            try
            {
                copyAccidents = AccidentList.GetRange(0, AccidentList.Count);
                for (int i = 0; i < copyAccidents.Count; i++)
                {
                    if (oldAccident == copyAccidents[i])
                    {
                        copyAccidents.RemoveAt(i);
                        break;
                    }
                }

                copyAccidents.Add(newAccident);
                if (File.Exists(PathAccident))
                    File.Delete(PathAccident);
                foreach (var data in copyAccidents)
                {
                    string t = "\"" + data.DataTime + "\",";
                    t += "\"" + data.Adress + "\",";
                    t += "\"" + data._Accident + "\",";
                    t += "\"" + data.TimeAccident + "\",";
                    t += "\"" + data.AddDispetcher + "\",";
                    t += "\"" + data.District + "\"\n";
                    File.AppendAllText(PathAccident, t);
                }
            }
            catch (Exception e)
            {
                File.AppendAllText("Error.txt",
                    DateTime.Now.ToString("F") + ", " + Environment.MachineName + ", " + e.Message);
                MessageBox.Show("Не удалось записать данные в файл происшествий. Данные изменены не будут.");
                return;
            }

            //запись в файл удаленных происшествий
            try
            {
                string t = "\"" + oldAccident.DataTime + "\",";
                t += "\"" + oldAccident.Adress + "\",";
                t += "\"" + oldAccident._Accident + "\",";
                t += "\"" + oldAccident.TimeAccident + "\",";
                t += "\"" + oldAccident.AddDispetcher + "\",";
                t += "\"" + oldAccident.District + "\",";
                t += "\"Change\"\n";
                File.AppendAllText(PathAccidentRemove, t);

            }
            catch (Exception e)
            {
                File.AppendAllText("Error.txt",
                    DateTime.Now.ToString("F") + ", " + Environment.MachineName + ", " + e.Message);
                MessageBox.Show("Не удалось записать данные в файл удаленных происшествий. Данные изменены не будут.");
                return;
            }

            AccidentList = copyAccidents.GetRange(0, copyAccidents.Count);
        }

        #endregion

        Accident()
        {
        }

        public Accident(string district, string adress, string accident, string timeAccident)
        {
            DataTime = DateTime.Now.ToString("O");
            District = district;
            _Accident = accident;
            Adress = adress;
            TimeAccident = timeAccident;
            AddDispetcher = Environment.UserName;
        }

        /// <summary>
        /// время и дата создания заявки
        /// </summary>
        public string DataTime { get; set; }

        /// <summary>
        /// Происшествие
        /// </summary>
        public string _Accident { get; set; }

        /// <summary>
        /// адрес происшествия
        /// </summary>
        public string Adress { get; set; }

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
        /// Район
        /// </summary>
        public string District { get; set; }
    }
}

