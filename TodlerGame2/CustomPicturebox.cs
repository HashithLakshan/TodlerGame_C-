﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TodlerGame2
{
    public class CustomPicturebox : PictureBox
    {
        public CustomPicturebox(IContainer container)
        {
            container.Add(this);
        }

        Point point;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
                base.OnMouseDown(e);        
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                {
                 this.Left += e.X - point.X;
                 this.Top += e.Y - point.Y;
                }
            base.OnMouseMove(e);
        }
    }
}
