using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num = 0;
        private int apple = 0;
        #region 1-2 фото
        private void Click1_Click(object sender, EventArgs e)
        {
            if (Click1.Visible == true)
            {
                Click1.Visible = false;
                Click2.Visible = true;
            }
            else
            {
                Click1.Visible = true;
                Click2.Visible = false;
            }
            this.num++;
            numbers.Text = "Монет: " + this.num.ToString();
            #region Подкольчик
            if (num == 333)
            {
                MessageBox.Show("Рот не устал?", "Подкольчик", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
        }

        private void Click2_Click(object sender, EventArgs e)
        {
            if (Click2.Visible == true)
            {
                Click2.Visible = false;
                Click1.Visible = true;
            }
            else
            {
                Click2.Visible = true;
                Click1.Visible = false;
            }
            this.num++;
            numbers.Text = "Монет: " + this.num.ToString();
        }
        #endregion

        #region Покупка Загубонов
        int s = 100;
        int r;
        private void Trade_Click(object sender, EventArgs e)
        {
            if (num >= 100)
            {
                r = this.num - this.s;
                this.num = r;
                apple++;
                apples.Text = "Загубонов: " + this.apple.ToString();
                MessageBox.Show("Вы купили загубон!", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("У вас недостаточно средств, нужно - 100 монет!", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Фото с Олегом
        private void Forochka_Click(object sender, EventArgs e)
        {
            if (apple >= 1)
            {
                Oleg.Visible = true;
                MessageBox.Show("Олег: *в соплях* ыыы айфон, го фото!", "Школьник Олег", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Олег: Айфон топ! А у тебя его нет!!! Ухади!", "Школьник Олег", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Конец игры
        private void Prank_Click(object sender, EventArgs e)
        {
            if (apple >= 10)
            {
                Gop.Visible = true;
                MessageBox.Show("Вас обокрали...", "Гопота", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ребята: ты не кто! Как будет 10 мобил, вернись!", "Гопота", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
