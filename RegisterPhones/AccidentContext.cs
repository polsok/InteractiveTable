﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegisterPhones
{
    public class AccidentContext: DbContext
    {
        public AccidentContext(): base("DBConnection") //При инстанцировании объекты этого класса будут получать connectionString с названием DBConnection из файла конфигурации
        { }
        public DbSet<PhoneObj> Accidents { get; set; }
    }
}