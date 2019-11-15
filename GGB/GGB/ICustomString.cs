using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface ICustomString
    {
        void DefaultLanguage();
        void SetLanguage(Language language);

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
