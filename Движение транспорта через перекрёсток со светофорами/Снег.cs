using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Snow
{
    private List<PictureBox> snowflakes;
    private Random random;
    private Form form;
    private System.Windows.Forms.Timer snowTimer;
    private bool snowing;

    public Snow(Form form)
    {
        this.form = form;
        snowflakes = new List<PictureBox>();
        random = new Random();

        snowTimer = new System.Windows.Forms.Timer();
        snowTimer.Interval = 50; // Интервал между снежинками
        snowTimer.Tick += SnowTimer_Tick;
    }

    public void StartSnow()
    {
        snowing = true; // Устанавливаем состояние снега
        snowTimer.Start();
    }

    public void StopSnow()
    {
        snowing = false; // Устанавливаем состояние снега
        snowTimer.Stop();
        ClearSnowflakes();
    }

    public bool IsSnowing()
    {
        return snowing; // Возвращаем текущее состояние снега
    }

    private void SnowTimer_Tick(object sender, EventArgs e)
    {
        CreateSnowflake();
        MoveSnowflakes();
    }

    private void CreateSnowflake()
    {
        PictureBox snowflake = new PictureBox();
        snowflake.Image = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\снежинка.png"); // Укажите путь к изображению снежинки
        snowflake.SizeMode = PictureBoxSizeMode.StretchImage;
        snowflake.Size = new Size(10, 10); // Размер снежинки (можно изменить)
        snowflake.Location = new Point(random.Next(form.Width), 0); // Начальная позиция
        form.Controls.Add(snowflake);
        snowflakes.Add(snowflake);
    }

    private void MoveSnowflakes()
    {
        for (int i = snowflakes.Count - 1; i >= 0; i--)
        {
            PictureBox snowflake = snowflakes[i];
            snowflake.Top += 15; // Устанавливаем скорость падения снежинки на 15 пикселей

            if (snowflake.Top > form.Height)
            {
                form.Controls.Remove(snowflake);
                snowflakes.RemoveAt(i);
            }
        }
    }

    private void ClearSnowflakes()
    {
        foreach (var snowflake in snowflakes)
        {
            form.Controls.Remove(snowflake);
        }
        snowflakes.Clear();
    }
}
