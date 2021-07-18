using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Describe_Sorting_Algorithm
{
    class Bar
    {
        public static int MARGIN_LEFT { get; private set; } = 1;
        float width;
        float height;
        float x;
        float y;
        int value;
        public float Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
                this.Height = value;
            }
        }

        public Color Color { get; set; }

        public Bar()
        {
            Width = Height = X = Y = 0;
        }

        public Bar(float width, float x, float y, int value)
        {
            this.Width = width;
            this.X = x;
            this.Y = y;
            this.Value = value;
            Color = ConstColor.DEFAULT_BAR;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), x, y - value, width, height);
        }

        public void Clear(Graphics g)
        {
            g.FillRectangle(new SolidBrush(ConstColor.BACKGROUP_CANVAS), x, y - value, width, height);
        }


    }
}
