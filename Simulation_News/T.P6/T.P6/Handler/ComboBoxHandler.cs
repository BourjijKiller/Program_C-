using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P6
{
    class ComboBoxHandler : ComboBox
    {
        public ComboBoxHandler() : base()
        {

        }
        
        public void ajouterData(Object sender, Args e)
        {
            this.Items.Add(e.getObj);
            if (this.Items.Count > 0)
                this.SelectedItem = e.getObj;
        }

        public void supprimerData(Object sender, Args e)
        {
            this.Items.Remove(e.getObj);
        }
    }
}
