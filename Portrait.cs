using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GenerateurTrombinoscope
{
    public class Portrait
    {
        private Size _sizeMax = new Size(350, 450);
        private int _sizeCoef = 5;
        private double _factor = 1d;

        public Bitmap Original { get; private set; }
        public Bitmap Current { get; private set; }

        public Portrait(string aPathPhoto)
        {
            Bitmap bm = new Bitmap(aPathPhoto);
            if (bm.Width > bm.Height)
            {
                double ratio = (_sizeMax.Width * _sizeCoef) / (double)bm.Width;
                Original = new Bitmap(bm, new Size(_sizeMax.Width * _sizeCoef, (int)(bm.Height * ratio)));
                Original.RotateFlip(RotateFlipType.Rotate90FlipXY);
            }
            else
            {
                double ratio = (_sizeMax.Height * _sizeCoef) / (double)bm.Height;
                Original = new Bitmap(bm, new Size((int)(bm.Width * ratio), _sizeMax.Height * _sizeCoef));
            }
            Current = Original.Clone() as Bitmap;
        }

        public Bitmap zoom(double aFactor)
        {
            if ((aFactor < 0.1d) || (aFactor > 2)) // limite sup à 2 ?
            {
                throw new Exception("the reduction factor must be in the interval 0.1 to 2.0 ");
            }
            _factor = aFactor;
            int width = (int)(Original.Width * _factor);
            int height = (int)(Original.Height * _factor);
            Current = new Bitmap(Original, new Size(width, height));
            return Current;
        }

        public Bitmap rotate(RotateFlipType aRotateFlipType)
        {
            Original.RotateFlip(aRotateFlipType);
            zoom(_factor);
            return Current;
        }
    }
}
