using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteractiveTable
{
    /// <summary>
    /// Данные приложения
    /// </summary>
    class Accident
    {
        public Accident()
        {

        }
        public Accident(string district, string adress, string accident, string timeAccident)
        {
            ID = Program.ID;
            DataTime = DateTime.Now.ToString("F");
            District = district;
            _Accident = accident;
            Adress = adress;
            TimeAccident = timeAccident;
            AddDispetcher = Environment.UserName;
        }
        public int ID { get; set; }
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
