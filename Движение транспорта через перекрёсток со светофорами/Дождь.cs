using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Rain
{
    private List<PictureBox> raindrops;
    private Random random;
    private Form form;
    private System.Windows.Forms.Timer rainTimer;
    private bool raining;

    public Rain(Form form)
    {
        this.form = form;
        raindrops = new List<PictureBox>();
        random = new Random();

        rainTimer = new System.Windows.Forms.Timer();
        rainTimer.Interval = 50; // Интервал между каплями
        rainTimer.Tick += RainTimer_Tick;
    }

    public void StartRain()
    {
        raining = true; // Устанавливаем состояние дождя
        rainTimer.Start();
    }

    public void StopRain()
    {
        raining = false; // Устанавливаем состояние дождя
        rainTimer.Stop();
        ClearRaindrops();
    }

    public bool IsRaining()
    {
        return raining; // Возвращаем текущее состояние дождя
    }

    private void RainTimer_Tick(object sender, EventArgs e)
    {
        CreateRaindrop();
        MoveRaindrops();
    }

    private void CreateRaindrop()
    {
        PictureBox raindrop = new PictureBox();
        raindrop.Image = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\дождь.png");
        raindrop.SizeMode = PictureBoxSizeMode.StretchImage;
        raindrop.Size = new Size(5, 20); // Размер капли
        raindrop.Location = new Point(random.Next(form.Width), 0); // Начальная позиция
        form.Controls.Add(raindrop);
        raindrops.Add(raindrop);
    }

    private void MoveRaindrops()
    {
        for (int i = raindrops.Count - 1; i >= 0; i--)
        {
            PictureBox raindrop = raindrops[i];
            raindrop.Top += 15; // Увеличиваем скорость падения капли до 15 пикселей

            if (raindrop.Top > form.Height)
            {
                form.Controls.Remove(raindrop);
                raindrops.RemoveAt(i);
            }
        }
    }


    private void ClearRaindrops()
    {
        foreach (var raindrop in raindrops)
        {
            form.Controls.Remove(raindrop);
        }
        raindrops.Clear();
    }
}