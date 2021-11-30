using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace games.Objects
{
    class Marker : BaseObject
    {
        public Marker(float x, float y,float angle):base(x,y,angle)
        {

        }
        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.DeepPink), -3,-3, 6, 6);
            g.DrawEllipse(new Pen(Color.DeepPink, 2), -6, -6, 12, 12);
            g.DrawLine(new Pen(Color.DeepPink, 2), -10, -10, 20, 20);
        }
    }
}
