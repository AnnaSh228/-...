using games.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games
{
    public partial class Form1 : Form
    {
        MyRectangle myRect;
        List<BaseObject> objects= new List<BaseObject>();
        Player player;
        public Form1()
        {
            InitializeComponent();
            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);
            objects.Add(player);
            objects.Add(new MyRectangle(50, 50, 0));
            objects.Add(new MyRectangle(100, 100, 45));
            
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.White);

            foreach (var obj in objects)
            {
                g.Transform = obj.GetTransform();
                obj.Render(g);
            }

           // g.Transform = myRect.GetTransform();
           
          //  myRect.Render(g);
        }
    }
}
