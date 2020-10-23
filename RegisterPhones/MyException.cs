using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegisterPhones
{
    /// <summary>
    /// отработка исключений
    /// </summary>
    internal class MyException
    {
        internal MyException(Exception e)
        {
            MessageBox.Show("Пожалуйста передайте эту информацию системному администратору!\n" +
                            "в приложении Development возникла ошибка: " +
                            e.Message + "\n\nСбойный модуль: " + e.StackTrace );
            Environment.Exit(0);
        
    }
}

        }