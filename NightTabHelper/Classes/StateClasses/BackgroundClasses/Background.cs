using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.BackgroundClasses
{
    public class Background : State
    {
        #region private
        private Image image;
        #endregion
        #region properties
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        #endregion
        public Background()
        {
        }
    }
    #region subclasses
    public class Image : Background
    {
        private bool show;
        private string url;
        private decimal blur;
        private decimal scale;
        private decimal opacity;
        private decimal grayscale;
        private decimal accent;

        public bool Show {
            get { return show; }
            set { show = value; }
        }
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public decimal Blur
        {
            get { return blur; }
            set { blur = value; }
        }
        public decimal Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        public decimal Opacity
        {
            get { return opacity; }
            set { opacity = value; }
        }
        public decimal Grayscale
        {
            get { return grayscale; }
            set { grayscale = value; }
        }
        public decimal Accent
        {
            get { return accent; }
            set { accent = value; }
        }

        public Image() {
            show = false;
            url = "";
            blur = 0;
            scale = 0;
            opacity = 0;
            accent = 0;
        }
    }
    #endregion
}
