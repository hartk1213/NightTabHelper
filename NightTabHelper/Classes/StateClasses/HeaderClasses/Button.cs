using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.HeaderClasses
{
    public class Button : Header
    {
        #region Private
        private string style;
        private EditAdd editAdd;
        private Accent accent;
        #endregion
        #region Properties
        public string Style { get { return style; } set { style = value; } }
        public EditAdd EditAdd { get { return editAdd; } set{ editAdd = value; } }
        public Accent Accent { get { return accent; } set{ accent = value; } }

        #endregion
        public Button() {
            style = "";
        }
    }

    #region SubClasses
    public class EditAdd : Button
    {
        public EditAdd() { }
    }

    public class Accent : Button
    {
        public Accent() { }
    }
    #endregion
}
