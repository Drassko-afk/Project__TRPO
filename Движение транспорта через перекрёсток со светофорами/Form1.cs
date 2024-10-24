using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Движение_транспорта_через_перекрёсток_со_светофорами
{
    public partial class Form1 : Form
    {
        private Image backgroundImage;
        private BackgroundManager backgroundManager;
        private Rain rain; // Объявляем дождь как поле класса
        private Button startRainButton;
        private Snow snow; // Объявляем объект класса Snow
        private NightEffect nightEffect;
        private FogEffect fogEffect;
        private CarManager carManager;


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            backgroundManager = new BackgroundManager(this);
            rain = new Rain(this); // Инициализация дождя
            snow = new Snow(this); // Инициализация снега
            startRainButton = new Button();
            fogEffect = new FogEffect(this); // Инициализация эффекта тумана
            carManager = new CarManager(this); // Инициализация CarManager

            startRainButton.Text = "Начать дождь";
            startRainButton.Click += дождьToolStripMenuItem_Click;
            this.Controls.Add(startRainButton);
            nightEffect = new NightEffect(this); // Инициализация эффекта ночи

        }

        private void летоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundManager.ChangeBackground("Лето");
        }

        private void осеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundManager.ChangeBackground("Осень");
        }

        private void зимаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundManager.ChangeBackground("Зима");
        }

        private void веснаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundManager.ChangeBackground("Весна");
        }

        private void дождьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rain.IsRaining()) // Проверяем, идет ли дождь
            {
                rain.StopRain(); // Останавливаем дождь
                дождьToolStripMenuItem.Text = "Начать дождь"; // Меняем текст кнопки
            }
            else
            {
                rain.StartRain(); // Запускаем дождь
                дождьToolStripMenuItem.Text = "Остановить дождь"; // Меняем текст кнопки
            }
        }

        private void снегToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snow.IsSnowing()) // Проверяем, идёт ли снег
            {
                snow.StopSnow(); // Останавливаем снег
                снегToolStripMenuItem.Text = "Начать снег"; // Меняем текст кнопки
            }
            else
            {
                snow.StartSnow(); // Запускаем снег
                снегToolStripMenuItem.Text = "Остановить снег"; // Меняем текст кнопки
            }
        }

        private void ночьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nightEffect.ToggleNightEffect(); // Включение или выключение эффекта ночи
        }

        private void туманToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fogEffect.ToggleFogEffect(); // Включение или выключение эффекта тумана
        }

        private void добавитьМашинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carManager.AddRandomCar(); // Добавление машины при нажатии на кнопку
        }

        private void запуститьМоделированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carManager.StartMovingCars(); // Запускаем движение машин
        }

        private void остановитьМоделированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carManager.StopMovingCars(); // Останавливаем движение машин
        }
        
    }
}