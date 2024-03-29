﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IUserString
    {
        void DefaultLanguage();
        void SetLanguage(string language);
        void SettingLaunguage(string lang);

        string selectedLanguage { get; set; }
        string nameRequestUniversity { get; set; }
        string nameRequestRating { get; set; }
        string university { get; set; }
        string ratingAverage { get; set; }
        string buttonNameRequest { get; set; }
        string buttonSavePdf { get; set; }
        string buttonSaveExcel { get; set; }
    }
}
