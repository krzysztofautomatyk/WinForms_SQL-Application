﻿using ConnectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_SQL_Application
{
    public interface IPrizeRequester
    {
        void PrizeComlete(PrizeModel model);
    }
}
