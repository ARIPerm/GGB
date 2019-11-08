﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IView
    {
        void MessageError(string message);

        void OnSuccessRequest(List<Student> students);
        
        void SaveFileDialog();

        //кнопки события, что пользователь нажал кнопку запроса
        event EventHandler GetRequestStudentUniversity;
        event EventHandler GetRequestAverageRating;

        event EventHandler SavePdfClick;
        event EventHandler SaveExcelClick;

        //получаем от пользователя текст запроса, через форму

        string selectedUniversity { get; }

        string averageRating { get; }
        
        string pathGet { get; }

        List<string> setUniversity { set; }

    }
}
