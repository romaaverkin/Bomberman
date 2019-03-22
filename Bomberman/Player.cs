using System.Drawing;
using System.Windows.Forms;

namespace Bomberman
{
    enum Arrows
    {
        left,
        right,
        up,
        dawn
    }

    class Player
    {
        PictureBox player;
        int step;

        public Player(PictureBox _player)
        {
            player = _player;
            step = 3;
        }

        public void MovePlayer(Arrows arrow)
        {
            switch (arrow)
            {
                case Arrows.left:
                    Move(-step, 0);
                    break;
                case Arrows.right:
                    Move(step, 0);
                    break;
                case Arrows.up:
                    Move(0, -step);
                    break;
                case Arrows.dawn:
                    Move(0, step);
                    break;
                default:
                    break;
            }
        }

        private void Move(int sx, int sy)
        {
            player.Location = new Point(player.Location.X + sx, player.Location.Y + sy);
        }
    }
}
