﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DrinkCategoryBUS
    {
        DrinkCategoryDAL drinkCategoryDAL = new DrinkCategoryDAL();
        public DataTable getDrinkCategoryNames()
        {
            return drinkCategoryDAL.getDrinkCategories();
        }
    }
}
