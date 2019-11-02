using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Publisher
    {
        //public delegate void ErrorEventHandler(object sender, EventArguments e);

        public event EventHandler errorSaveEvent;

        public void RaiseErrorEvent()
        {
            if (errorSaveEvent != null)
                errorSaveEvent(this, EventArgs.Empty);
        }

    }
}