using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth;

public class Oscillator : GroupBox
{
    private int sizeX = 50;
    private int sizeY = 30;

    public Oscillator()
    {
        Controls.Add(new Button()
        {
            Name = "Sine",
            Location = new Point(10, 15),
            Text = "Sine",
            Size = new Size(sizeX, sizeY)
        });

        Controls.Add(new Button()
        {
            Name = "Square",
            Location = new Point(65, 15),
            Text = "Square",
        });

        Controls.Add(new Button()
        {
            Name = "Saw",
            Location = new Point(120, 15),
            Text = "Saw",
        });

        Controls.Add(new Button()
        {
            Name = "Triangle",
            Location = new Point(10, 50),
            Text = "Triangle",
        });

        Controls.Add(new Button()
        {
            Name = "Noise",
            Location = new Point(65, 50),
            Text = "Noise",
        });

        foreach (Control btn in Controls)
        {
            btn.Size = new Size(sizeX, sizeY);
            btn.Font = new Font("Microsoft Sans Serif", 6.75f);
        }
    }
}