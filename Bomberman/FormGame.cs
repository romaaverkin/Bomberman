using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class FormGame : Form
    {
        MainBoard board;

        public FormGame()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            board = new MainBoard(panelGame);
        }

        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра Bomberman!", "Описание игры");
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Аверкин Роман.", "Автор");
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    board.MovePlayer(Arrows.left);
                    break;
                case Keys.Right:
                    board.MovePlayer(Arrows.right);
                    break;
                case Keys.Up:
                    board.MovePlayer(Arrows.up);
                    break;
                case Keys.Down:
                    board.MovePlayer(Arrows.dawn);
                    break;
            }
        }
    }
}
