using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris1Block
{
    public partial class Form1 : Form
    {
        private Color[] _blockEmptyColor;

        private Timer _timer;

        private int _tetrisPiecePostion;
        private bool[] _blocksFilled;

        public Form1()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 400;
            _timer.Enabled = true;
            _timer.Tick += new System.EventHandler(TimerTickEvent);

            _blockEmptyColor = new Color[2];

            _blocksFilled = new bool[40];

            _tetrisPiecePostion = -3;

            _blockEmptyColor[0] = Color.LimeGreen;

            _blockEmptyColor[1] = Color.DarkSlateBlue;

            foreach (Label label in BlockLabels)
            {
                label.BackColor = _blockEmptyColor[0];
            }

            _timer.Start();
        }

        public void TimerTickEvent(object sender, EventArgs e)
        {
            _tetrisPiecePostion += 5;

            if (_tetrisPiecePostion > 40)
            {
                _tetrisPiecePostion = 2;
            }

            if (_tetrisPiecePostion < 40)
            {
                if (BlockLabels[_tetrisPiecePostion].BackColor == _blockEmptyColor[0])
                {
                    BlockLabels[_tetrisPiecePostion].BackColor = _blockEmptyColor[1];
                    if (_tetrisPiecePostion > 5)
                    {
                        BlockLabels[_tetrisPiecePostion - 5].BackColor = _blockEmptyColor[0];
                    }
                }
            }

            if (BlockLabels[35].BackColor == _blockEmptyColor[1] && BlockLabels[36].BackColor == _blockEmptyColor[1] &&
            BlockLabels[37].BackColor == _blockEmptyColor[1] && BlockLabels[38].BackColor == _blockEmptyColor[1] && BlockLabels[39].BackColor == _blockEmptyColor[1])
            {
                BlockLabels[35].BackColor = _blockEmptyColor[0];
                BlockLabels[36].BackColor = _blockEmptyColor[0];
                BlockLabels[37].BackColor = _blockEmptyColor[0];
                BlockLabels[38].BackColor = _blockEmptyColor[0];
                BlockLabels[39].BackColor = _blockEmptyColor[0];

                int amoutBlocks = 0;
                _blocksFilled = new bool[40];

                foreach (Label block in BlockLabels)
                {
                    if (block.BackColor == _blockEmptyColor[1])
                    {
                        _blocksFilled[amoutBlocks + 5] = true;
                    }
                    amoutBlocks++;
                }

                foreach(Label block in BlockLabels)
                {
                    block.BackColor = _blockEmptyColor[0];
                }

                int amoutBlue = 0;
                foreach(bool blockFilled in _blocksFilled)
                {
                    if (blockFilled == true)
                    {
                        BlockLabels[amoutBlue].BackColor = _blockEmptyColor[1];
                    }
                    amoutBlue++;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Left)
            {
                if (_tetrisPiecePostion < 39 && _blocksFilled[_tetrisPiecePostion] == false)
                {
                    if(_tetrisPiecePostion != 0 && _tetrisPiecePostion != 5 && _tetrisPiecePostion != 10 &&
                        _tetrisPiecePostion != 15 && _tetrisPiecePostion != 20 && _tetrisPiecePostion != 25 &&
                        _tetrisPiecePostion !=30 && _tetrisPiecePostion != 35 && BlockLabels[_tetrisPiecePostion - 1].BackColor != _blockEmptyColor[1])
                    {
                        _tetrisPiecePostion--;
                        BlockLabels[_tetrisPiecePostion].BackColor =  _blockEmptyColor[1];
                        BlockLabels[_tetrisPiecePostion + 1].BackColor =  _blockEmptyColor[0];
                        return true;
                    }
                }

            }if(keyData == Keys.Right)
            {
                if(_tetrisPiecePostion != 0 && _tetrisPiecePostion != 4 && _tetrisPiecePostion != 9 &&
                        _tetrisPiecePostion != 14 && _tetrisPiecePostion != 19 && _tetrisPiecePostion != 24 &&
                        _tetrisPiecePostion != 29 && _tetrisPiecePostion != 34 && BlockLabels[_tetrisPiecePostion + 1].BackColor != _blockEmptyColor[1])
                    {
                    _tetrisPiecePostion++;
                    BlockLabels[_tetrisPiecePostion].BackColor = _blockEmptyColor[1];
                    BlockLabels[_tetrisPiecePostion - 1].BackColor = _blockEmptyColor[0];
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
