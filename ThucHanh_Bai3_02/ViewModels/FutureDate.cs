﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ThucHanh_Bai3_02.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}