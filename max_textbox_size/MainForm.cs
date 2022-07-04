using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace max_textbox_size
{
    public partial class MainForm : Form
    {
        const int LIMIT = 250;
        public MainForm()
        {
            InitializeComponent();
            MessageField.ControlAdded += (sender, e) =>
            {
                e.Control.MaximumSize = new Size(LIMIT, int.MaxValue);
                var lastVisible =
                    MessageField.Controls
                    .Cast<Control>()
                    .LastOrDefault(control => control.Visible);                
                int spacer = 0;
                if(lastVisible != null)
                {
                    switch (e.Control.Name)
                    {
                        case "textBox": 
                            spacer = 2; 
                            break;
                        case "timeLabel":
                            if(lastVisible.Name == "textBox")
                            {
                                var minWidth = Math.Max(lastVisible.Width, e.Control.Width);
                                lastVisible.MinimumSize = e.Control.MinimumSize = new Size(minWidth, 0);
                                if(lastVisible.Tag.ToString() == "right")
                                {
                                    lastVisible.Location = new Point(
                                        MessageField.Width - lastVisible.Width,
                                        lastVisible.Location.Y);
                                }
                            }
                            spacer = 0;  break;
                        default: throw new NotImplementedException();    
                    }
                    switch (e.Control.Tag.ToString())
                    {
                        case "left": e.Control.Location =
                            e.Control.Location = new Point(
                                0,
                                lastVisible.Location.Y + lastVisible.Height + spacer);
                            break;
                        case "right":
                            e.Control.Location = new Point(
                                MessageField.Width - e.Control.Width,
                                lastVisible.Location.Y + lastVisible.Height + spacer);
                            break;
                    }
                }
                e.Control.Visible = true;
            };
            buttonMe.Click += (sender, e) =>
                TextBubble(textBoxCompose.Text, "left", $"{DateTime.Now}");

            buttonYou.Click += (sender, e) =>
                TextBubble(textBoxCompose.Text, "right", $"{DateTime.Now}");

            textBoxCompose.TextChanged += (sender, e) =>
               buttonMe.Enabled = buttonYou.Enabled = !string.IsNullOrWhiteSpace(textBoxCompose.Text);
        }
        void TextBubble(string message, string side, string time)
        {
            Label textBox = new Label()
            {
                Name = nameof(textBox),
                Visible = false,
                BackColor = Color.White,
                Font = new Font("SergioUI", 14),
                Padding = new Padding(2, 2, 2, 2),
                AutoSize = true,
                Text = message,
                BorderStyle = BorderStyle.FixedSingle, // To see what we're doing
                Tag = side,
            };
            MessageField.Controls.Add(textBox);

            Label timeLabel = new Label
            {
                Name = nameof(timeLabel),
                Visible = false,
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 5),
                Padding = new Padding(2, 2, 2, 2),
                AutoSize = true,
                Text = time,
                BorderStyle = BorderStyle.FixedSingle,  // To see what we're doing
                Width = textBox.Width,
                Location = new Point(textBox.Location.X, textBox.Location.Y + textBox.Height),
                Tag = side,
            };
            MessageField.Controls.Add(timeLabel);
            textBoxCompose.Clear();
        }
    }
}
