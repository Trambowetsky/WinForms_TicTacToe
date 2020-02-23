using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTicTacToe
{
    public partial class Form1 : Form
    {
        private int scoreplayerX = 0, scoreplayerO = 0;
        private Button[,] buttons = new Button[3, 3];
        private Dictionary<bool, string> players = new Dictionary<bool, string>() { { false, "Игрок Х"}, { true, "Игрок 0" } };
        private bool player, endgame = false;
        public Form1()
        {
            InitializeComponent();
            player = players.Keys.First(); // false = x, true = o
            PlayerLabel.Text = players.Values.First();

            PlayerXlabel.Text = $"{players.Values.First()}: {scoreplayerX}";
            PlayerOlabel.Text = $"{players.Values.Last()}: {scoreplayerO}";

            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(142, 126);
                }
            }
            SetButtons();
        }
        private void SetButtons()
        {
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 148 * j, 12 + 132 * i);
                    buttons[i, j].Click += Button_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 68);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            endgame = false;
            LabelControl();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                    player = players.Keys.First();
                    PlayerLabel.Text = players.Values.First();
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case false:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    break;
                case true:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);

            WinCheck();

            player = !player;

            LabelControl();
        }
        private void WinCheck()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[1,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[1,2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[2,0].Text == buttons[2,1].Text && buttons[2,1].Text == buttons[2,2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[0,0].Text == buttons[1,0].Text && buttons[1,0].Text == buttons[2,0].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[0,1].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,1].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[0,2].Text == buttons[1,2].Text && buttons[1,2].Text == buttons[2,2].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[0,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
            if (buttons[0,2].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,0].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    MessageBox.Show($"{PlayerLabel.Text} победил");
                    BlockButtons(ref endgame);
                    return;
                }
            }
        }
        private void BlockButtons(ref bool endgame)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
            endgame = true;
        }

        private void ZeroScoreBtn_Click(object sender, EventArgs e)
        {
            PlayerXlabel.Text = $"{players.Values.First()}: {scoreplayerX = 0}";
            PlayerOlabel.Text = $"{players.Values.Last()}: {scoreplayerO = 0}";
        }

        private void LabelControl()
        {
            if (player) PlayerLabel.Text = players.Values.Last();
            else PlayerLabel.Text = players.Values.First();

            if (endgame)
            {
                AddScore();
                PlayerLabel.Visible = false;
                EndLabel.Visible = true;
            }
            else
            {
                PlayerLabel.Visible = true;
                EndLabel.Visible = false;
            }
        }
        private void AddScore()
        {
            if (!player) PlayerOlabel.Text = $"{players.Values.Last()}: {++scoreplayerO}";  

            else if (player) PlayerXlabel.Text = $"{players.Values.First()}: {++scoreplayerX}";
        }
    }
}
