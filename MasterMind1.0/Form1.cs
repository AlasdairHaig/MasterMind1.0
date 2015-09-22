using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MasterMind1._0
{
    public partial class Form1 : Form
    {
        private PictureBox[,] m_pctBxs;
        private int[] _iMarmorNummer;
        private int _iBxCount;
        private int _iDifficulty;
        private int[] _iKey = new int[4];
        private bool _bWon = false;
        private bool _bRowchecked = false;
        private int _iSelectedBackdrop = 1;

        Bitmap _backdrop;
        Bitmap _b;
        SpriteCutter _sc;
        Point _selectionPoint;
        Random _rdm = new Random();

        public Form1()
        {
            InitializeComponent();
            //Marble Bitmap
            _b = new Bitmap("C:/Users/b.wood/Documents/GitHub/MasterMind1.0/Resources/SpriteSheetMarblesT.png");
            _b.MakeTransparent(Color.Transparent);
            MarbleSelectionPB.Image = _b;

            //Backdrop Bitmap
            setBackdrop(1);

            // Initialize Variables
            _selectionPoint = new Point();
            _iBxCount = 0;
            _iDifficulty = 7;
            _iMarmorNummer = new int[(4 * _iDifficulty)];
            m_pctBxs = new PictureBox[4, _iDifficulty];

            _sc = new SpriteCutter(_b, 32, 0, 0);

            displayPictureBoxes(_iDifficulty);

            createKey();
        }

        private void displayPictureBoxes(int diff)
        {
            this.SuspendLayout();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < diff; j++)
                {
                    m_pctBxs[i, j] = new PictureBox();

                    m_pctBxs[i, j].Location = new System.Drawing.Point(110 + (i * 34), 120 + (j * 36));
                    m_pctBxs[i, j].Name = "Box_" + i.ToString() + j.ToString();
                    m_pctBxs[i, j].Size = new System.Drawing.Size(32, 32);
                    m_pctBxs[i, j].BackColor = Color.Transparent;
                    m_pctBxs[i, j].BorderStyle = BorderStyle.Fixed3D;

                    Controls.Add(m_pctBxs[i, j]);
                }
            }
            this.ResumeLayout();
        }

        private void setBackdrop(int bild)
        {
            switch (bild)
            {
                case 1:
                    _backdrop = new Bitmap("C:/Users/b.wood/Documents/GitHub/MasterMind1.0/Resources/wood_background_texture_1.jpg");
                    this.BackgroundImage = _backdrop;
                    break;
                case 2:
                    _backdrop = new Bitmap("C:/Users/b.wood/Documents/GitHub/MasterMind1.0/Resources/wood_background_texture_2.jpg");
                    this.BackgroundImage = _backdrop;
                    break;
                case 3:
                    _backdrop = new Bitmap("C:/Users/b.wood/Documents/GitHub/MasterMind1.0/Resources/wood_background_texture_3.jpg");
                    this.BackgroundImage = _backdrop;
                    break;
                default:
                    _backdrop = new Bitmap("C:/Users/b.wood/Documents/GitHub/MasterMind1.0/Resources/wood_background_texture_1.jpg");
                    this.BackgroundImage = _backdrop;
                    break;
            }
        }

        private void createKey()
        {
            for (int i = 0; i < 4; i++)
            {
                _iKey[i] = _rdm.Next(0, 6);
                //MessageBox.Show(_iKey[i].ToString());

            }
        }

        /* Need to display key if key matches row
         */


        private void selectedMarmor()
        {
            _selectionPoint.X = MarbleSelectionPB.PointToClient(Cursor.Position).X;
            _selectionPoint.Y = MarbleSelectionPB.PointToClient(Cursor.Position).Y;

            //MessageBox.Show(selectionPoint.ToString());

            int marmorSelected = (_selectionPoint.X / 32);

            //MessageBox.Show(marmorSelected.ToString());

            _iMarmorNummer[_iBxCount] = marmorSelected;
            displayMarmor(marmorSelected, getPictureBox());
            
        }

        private PictureBox getPictureBox()
        {
            if (_iBxCount < (_iDifficulty * 4))
            {
                int x = _iBxCount % 4;
                int y = _iBxCount / 4;


                return m_pctBxs[x, y];
            }
            else
                return null;
        }

        private void displayMarmor(int marmorSelected, PictureBox pcbox)
        {
            if (pcbox != null)
            {
                _sc.cutFrame(_b, marmorSelected);
                pcbox.Image = _sc.getFrame;
                _iBxCount++;
            }
        }

        private void MarbleSelectionPB_Click(object sender, EventArgs e)
        {
            if ((!((_iBxCount % 4) == 0)) || _iBxCount == 0)
            {
                selectedMarmor();
            }
            else if (rowChecked())
            {
                selectedMarmor();
                _bRowchecked = false;
            }
            
        }

        private bool rowChecked()
        {
            if (_bRowchecked == true)
            {
                return true;
            }
            return false;
        }

        #region Form Events
        private void button1_Click(object sender, EventArgs e)
        {
            _bRowchecked = true;

            if ((_iBxCount % 4) == 0)
            {
                check();

                // If not, you lost :(
                if (_iBxCount == (_iDifficulty * 4) && _bWon == false)
                {
                    MessageBox.Show("You Lost! Surpised? \nWell go cry on your huge pillow :P!!");
                }   
            }
            else
            {
                MessageBox.Show("The Row is not complete.");
            }
        }

        private void neueSpeilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neueSpiel();
        }

        private void cedarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBackdrop(1);
            _iSelectedBackdrop = 1;
        }

        private void spruceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBackdrop(2);
            _iSelectedBackdrop = 2;
        }

        private void pineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBackdrop(3);
            _iSelectedBackdrop = 3;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neueSpiel();
            removePictureBoxes();
            _iDifficulty = 9;
            _iMarmorNummer = new int[(_iDifficulty * 4)];
            m_pctBxs = new PictureBox[4, _iDifficulty];
            displayPictureBoxes(_iDifficulty);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neueSpiel();
            removePictureBoxes();
            _iDifficulty = 7;
            _iMarmorNummer = new int[(_iDifficulty * 4)];
            m_pctBxs = new PictureBox[4, _iDifficulty];
            displayPictureBoxes(_iDifficulty);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neueSpiel();
            removePictureBoxes();
            _iDifficulty = 5;
            _iMarmorNummer = new int[(_iDifficulty * 4)];
            m_pctBxs = new PictureBox[4, _iDifficulty];
            displayPictureBoxes(_iDifficulty);
        }
        #endregion

        private void check()
        {
            List<int> userKey = new List<int>(4);
            //Copy Master Key
            List<int> masterKey = _iKey.ToList();

            //Copy user's row to list
            for (int j = (_iBxCount - 4); j < _iBxCount; j++)
            {
                userKey.Add(_iMarmorNummer[j]);
            }

            int colorSlot = 3;
            int count = 3;
            //check placement and remove all matches from both lists
            while (count >= 0)
            {
                //MessageBox.Show("Is Masterkey equal to userkey on this slot? " + masterKey[count].ToString() + " == " + userKey[count].ToString());
                if (masterKey[count] == userKey[count])
                {
                    //MessageBox.Show("Yes. Removing Match. Black");
                    //Remover 'Pair'
                    masterKey.RemoveAt(count);
                    userKey.RemoveAt(count);
                    paintCircle(2, colorSlot);
                    colorSlot--;
                }
                //MessageBox.Show(masterKey.Count.ToString());
                count--;
            }

            count = masterKey.Count - 1;
            //MessageBox.Show(count.ToString());

            //check for remaining matching colors and remove those from both lists
            //Make sure list is not empty
            if (masterKey.Count != 0)
            {
                while (count >= 0)
                {
                    //MessageBox.Show("Does Masterkey contain a userkey color?");
                    if (userKey.Contains(masterKey[count]))
                    {
                        //MessageBox.Show("Yes. Removing Match. White");
                        userKey.Remove(masterKey[count]);
                        masterKey.Remove(masterKey[count]);
                        paintCircle(1, colorSlot);
                        colorSlot--;
                    }
                    count--;
                }
            }
            else
            {
                _bWon = true;
                MessageBox.Show("You Won!!");
            }

            //MessageBox.Show(masterKey.Count.ToString() + " colors do not belong.");

        }

        private void paintCircle(int color, int count) //count starts at 3 and goes to 0
        {
            // 2 means black, 1 means white, 0 means nothing

            //use the CreateGraphics method to create a Graphics object
            Graphics formGraphics = this.CreateGraphics();

            //Create a red brush
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen pen = new Pen(blackBrush);

            Point newPoint = Point.Add(m_pctBxs[3,((_iBxCount - 1)/ 4)].Location, new Size(40, 3));

            if (count < 2) // put lower down
            {
                newPoint.Y = newPoint.Y + 15;
            }
            if ((count % 2) == 0) // put further right
            {
                newPoint.X = newPoint.X + 15;
            }

            //Paint Black Circles
            if (color == 2)
            {
                formGraphics.FillEllipse(blackBrush, newPoint.X, newPoint.Y, 10, 10);
            }

            //Paint White Circles
            if (color == 1)
            {
                formGraphics.FillEllipse(whiteBrush, newPoint.X, newPoint.Y, 10, 10);
            }

            //Paint Empty Circles
            if (color == 0)
            {
                //formGraphics.DrawEllipse(pen, newPoint.X, newPoint.Y, 10, 10);
            }

            // dispose of graphics object
            formGraphics.Dispose();
        }

        private void neueSpiel()
        {
            while (!(_iBxCount < 0))
            {
                int x = _iBxCount % 4;
                int y = (_iBxCount - 1) / 4;

                m_pctBxs[x, y].Image = null;
                _iMarmorNummer[_iBxCount] = 0;
                _iBxCount--;
            }
            setBackdrop(_iSelectedBackdrop);
            _iBxCount = 0;
            createKey();
            _bWon = false;
        }

        public void removePictureBoxes()
        {
            this.SuspendLayout();
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is PictureBox && this.Controls[ix] != MarbleSelectionPB)
                {
                    this.Controls[ix].Dispose();
                }
            }
            this.ResumeLayout();
        }

    }
}
