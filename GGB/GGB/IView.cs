using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IView
    {
        void MessageError(string message);

        void OnSuccessRequest();

        //кнопки события, что пользователь нажал кнопку запроса
        event EventHandler GetRequestClick;
        event EventHandler ShowRequestClick;

        //получаем от пользователя текст запроса, через форму
        string requestText { get; }
    }
}
