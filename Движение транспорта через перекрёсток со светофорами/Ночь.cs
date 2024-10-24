using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

public class NightEffect
{
    private PictureBox nightOverlay;
    private Form form;
    private bool isNightVisible;

    public NightEffect(Form form)
    {
        this.form = form;
        this.isNightVisible = false;
    }

    // Метод для отображения или скрытия эффекта ночи
    public void ToggleNightEffect()
    {
        if (isNightVisible)
        {
            // Убираем эффект ночи
            form.Controls.Remove(nightOverlay);
            nightOverlay = null;
            isNightVisible = false;
        }
        else
        {
            // Создаем PictureBox для изображения ночи
            nightOverlay = new PictureBox();
            nightOverlay.Image = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\ночь.png"); // Укажи путь к изображению
            nightOverlay.SizeMode = PictureBoxSizeMode.StretchImage;
            nightOverlay.Dock = DockStyle.Fill; // Растягиваем изображение на весь экран
            nightOverlay.BackColor = Color.Transparent; // Прозрачный фон

            // Настраиваем прозрачность изображения
            nightOverlay.Image = SetImageOpacity(nightOverlay.Image, 0.7f); // Устанавливаем прозрачность на 70%

            // Добавляем изображение на форму и отображаем под всеми элементами
            form.Controls.Add(nightOverlay);
            nightOverlay.SendToBack(); // Перемещаем под все элементы

            isNightVisible = true;
        }
    }

    // Метод для установки прозрачности изображения
    private Image SetImageOpacity(Image image, float opacity)
    {
        Bitmap bmp = new Bitmap(image.Width, image.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = opacity; // Установка уровня прозрачности (0 - прозрачный, 1 - непрозрачный)
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
        }
        return bmp;
    }
}
