namespace Движение_транспорта_через_перекрёсток_со_светофорами
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            моделированиеToolStripMenuItem = new ToolStripMenuItem();
            запуститьМоделированиеToolStripMenuItem = new ToolStripMenuItem();
            остановитьМоделированиеToolStripMenuItem = new ToolStripMenuItem();
            машиныToolStripMenuItem = new ToolStripMenuItem();
            добавитьМашинуToolStripMenuItem = new ToolStripMenuItem();
            удалитьМашинуToolStripMenuItem = new ToolStripMenuItem();
            времяСутокToolStripMenuItem = new ToolStripMenuItem();
            ночьToolStripMenuItem = new ToolStripMenuItem();
            времяГодаToolStripMenuItem = new ToolStripMenuItem();
            летоToolStripMenuItem = new ToolStripMenuItem();
            осеньToolStripMenuItem = new ToolStripMenuItem();
            зимаToolStripMenuItem = new ToolStripMenuItem();
            веснаToolStripMenuItem = new ToolStripMenuItem();
            погодныеУсловияToolStripMenuItem = new ToolStripMenuItem();
            дождьToolStripMenuItem = new ToolStripMenuItem();
            снегToolStripMenuItem = new ToolStripMenuItem();
            туманToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { моделированиеToolStripMenuItem, машиныToolStripMenuItem, времяСутокToolStripMenuItem, времяГодаToolStripMenuItem, погодныеУсловияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1306, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // моделированиеToolStripMenuItem
            // 
            моделированиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { запуститьМоделированиеToolStripMenuItem, остановитьМоделированиеToolStripMenuItem });
            моделированиеToolStripMenuItem.Name = "моделированиеToolStripMenuItem";
            моделированиеToolStripMenuItem.Size = new Size(138, 24);
            моделированиеToolStripMenuItem.Text = "Моделирование";
            // 
            // запуститьМоделированиеToolStripMenuItem
            // 
            запуститьМоделированиеToolStripMenuItem.Name = "запуститьМоделированиеToolStripMenuItem";
            запуститьМоделированиеToolStripMenuItem.Size = new Size(290, 26);
            запуститьМоделированиеToolStripMenuItem.Text = "Запустить моделирование";
            запуститьМоделированиеToolStripMenuItem.Click += запуститьМоделированиеToolStripMenuItem_Click;
            // 
            // остановитьМоделированиеToolStripMenuItem
            // 
            остановитьМоделированиеToolStripMenuItem.Name = "остановитьМоделированиеToolStripMenuItem";
            остановитьМоделированиеToolStripMenuItem.Size = new Size(290, 26);
            остановитьМоделированиеToolStripMenuItem.Text = "Остановить моделирование";
            остановитьМоделированиеToolStripMenuItem.Click += остановитьМоделированиеToolStripMenuItem_Click;
            // 
            // машиныToolStripMenuItem
            // 
            машиныToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьМашинуToolStripMenuItem, удалитьМашинуToolStripMenuItem });
            машиныToolStripMenuItem.Name = "машиныToolStripMenuItem";
            машиныToolStripMenuItem.Size = new Size(85, 24);
            машиныToolStripMenuItem.Text = "Машины";
            // 
            // добавитьМашинуToolStripMenuItem
            // 
            добавитьМашинуToolStripMenuItem.Name = "добавитьМашинуToolStripMenuItem";
            добавитьМашинуToolStripMenuItem.Size = new Size(219, 26);
            добавитьМашинуToolStripMenuItem.Text = "Добавить машину";
            добавитьМашинуToolStripMenuItem.Click += добавитьМашинуToolStripMenuItem_Click;
            // 
            // удалитьМашинуToolStripMenuItem
            // 
            удалитьМашинуToolStripMenuItem.Name = "удалитьМашинуToolStripMenuItem";
            удалитьМашинуToolStripMenuItem.Size = new Size(219, 26);
            удалитьМашинуToolStripMenuItem.Text = "Удалить машину";
            // 
            // времяСутокToolStripMenuItem
            // 
            времяСутокToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ночьToolStripMenuItem });
            времяСутокToolStripMenuItem.Name = "времяСутокToolStripMenuItem";
            времяСутокToolStripMenuItem.Size = new Size(108, 24);
            времяСутокToolStripMenuItem.Text = "Время суток";
            // 
            // ночьToolStripMenuItem
            // 
            ночьToolStripMenuItem.Name = "ночьToolStripMenuItem";
            ночьToolStripMenuItem.Size = new Size(128, 26);
            ночьToolStripMenuItem.Text = "Ночь";
            ночьToolStripMenuItem.Click += ночьToolStripMenuItem_Click;
            // 
            // времяГодаToolStripMenuItem
            // 
            времяГодаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { летоToolStripMenuItem, осеньToolStripMenuItem, зимаToolStripMenuItem, веснаToolStripMenuItem });
            времяГодаToolStripMenuItem.Name = "времяГодаToolStripMenuItem";
            времяГодаToolStripMenuItem.Size = new Size(103, 24);
            времяГодаToolStripMenuItem.Text = "Время года";
            // 
            // летоToolStripMenuItem
            // 
            летоToolStripMenuItem.Name = "летоToolStripMenuItem";
            летоToolStripMenuItem.Size = new Size(135, 26);
            летоToolStripMenuItem.Text = "Лето";
            летоToolStripMenuItem.Click += летоToolStripMenuItem_Click;
            // 
            // осеньToolStripMenuItem
            // 
            осеньToolStripMenuItem.Name = "осеньToolStripMenuItem";
            осеньToolStripMenuItem.Size = new Size(135, 26);
            осеньToolStripMenuItem.Text = "Осень";
            осеньToolStripMenuItem.Click += осеньToolStripMenuItem_Click;
            // 
            // зимаToolStripMenuItem
            // 
            зимаToolStripMenuItem.Name = "зимаToolStripMenuItem";
            зимаToolStripMenuItem.Size = new Size(135, 26);
            зимаToolStripMenuItem.Text = "Зима";
            зимаToolStripMenuItem.Click += зимаToolStripMenuItem_Click;
            // 
            // веснаToolStripMenuItem
            // 
            веснаToolStripMenuItem.Name = "веснаToolStripMenuItem";
            веснаToolStripMenuItem.Size = new Size(135, 26);
            веснаToolStripMenuItem.Text = "Весна";
            веснаToolStripMenuItem.Click += веснаToolStripMenuItem_Click;
            // 
            // погодныеУсловияToolStripMenuItem
            // 
            погодныеУсловияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { дождьToolStripMenuItem, снегToolStripMenuItem, туманToolStripMenuItem });
            погодныеУсловияToolStripMenuItem.Name = "погодныеУсловияToolStripMenuItem";
            погодныеУсловияToolStripMenuItem.Size = new Size(154, 24);
            погодныеУсловияToolStripMenuItem.Text = "Погодные условия";
            // 
            // дождьToolStripMenuItem
            // 
            дождьToolStripMenuItem.Name = "дождьToolStripMenuItem";
            дождьToolStripMenuItem.Size = new Size(138, 26);
            дождьToolStripMenuItem.Text = "Дождь";
            дождьToolStripMenuItem.Click += дождьToolStripMenuItem_Click;
            // 
            // снегToolStripMenuItem
            // 
            снегToolStripMenuItem.Name = "снегToolStripMenuItem";
            снегToolStripMenuItem.Size = new Size(138, 26);
            снегToolStripMenuItem.Text = "Снег";
            снегToolStripMenuItem.Click += снегToolStripMenuItem_Click;
            // 
            // туманToolStripMenuItem
            // 
            туманToolStripMenuItem.Name = "туманToolStripMenuItem";
            туманToolStripMenuItem.Size = new Size(138, 26);
            туманToolStripMenuItem.Text = "Туман";
            туманToolStripMenuItem.Click += туманToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.лето;
            ClientSize = new Size(1306, 696);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem моделированиеToolStripMenuItem;
        private ToolStripMenuItem запуститьМоделированиеToolStripMenuItem;
        private ToolStripMenuItem остановитьМоделированиеToolStripMenuItem;
        private ToolStripMenuItem машиныToolStripMenuItem;
        private ToolStripMenuItem добавитьМашинуToolStripMenuItem;
        private ToolStripMenuItem удалитьМашинуToolStripMenuItem;
        private ToolStripMenuItem времяСутокToolStripMenuItem;
        private ToolStripMenuItem ночьToolStripMenuItem;
        private ToolStripMenuItem времяГодаToolStripMenuItem;
        private ToolStripMenuItem летоToolStripMenuItem;
        private ToolStripMenuItem осеньToolStripMenuItem;
        private ToolStripMenuItem зимаToolStripMenuItem;
        private ToolStripMenuItem веснаToolStripMenuItem;
        private ToolStripMenuItem погодныеУсловияToolStripMenuItem;
        private ToolStripMenuItem дождьToolStripMenuItem;
        private ToolStripMenuItem снегToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem туманToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}