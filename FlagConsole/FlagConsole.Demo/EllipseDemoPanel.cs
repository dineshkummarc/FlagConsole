﻿using FlagConsole.Controls;
using FlagConsole.Drawing;
using FlagConsole.Measure;

namespace FlagConsole.Demo
{
    internal class EllipseDemoPanel : Panel
    {
        private Label ellipseLabel;
        private Label circleLabel;

        public EllipseDemoPanel()
        {
            this.ellipseLabel = new Label();
            this.ellipseLabel.Text = "This is an ellipse.";
            this.ellipseLabel.Size = new Size(this.ellipseLabel.Text.Length, 1);
            this.ellipseLabel.RelativeLocation = new Point(17, 0);
            this.Controls.Add(this.ellipseLabel);

            this.circleLabel = new Label();
            this.circleLabel.Text = "This is a circle.";
            this.circleLabel.Size = new Size(this.circleLabel.Text.Length, 1);
            this.circleLabel.RelativeLocation = new Point(19, 18);
            this.Controls.Add(this.circleLabel);
        }

        protected override void Draw()
        {
            base.Draw();

            Ellipse ellipse = new Ellipse(this.AbsoluteLocation + new Point(10, 7), 4, 7, '#');
            ellipse.Draw();

            Ellipse circle = new Ellipse(this.AbsoluteLocation + new Point(10, 25), 7, 7, '#');
            circle.Draw();
        }
    }
}