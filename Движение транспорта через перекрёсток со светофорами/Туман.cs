using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

public class FogEffect
{
    private PictureBox fogOverlay;
    private Form form;
    private bool isFogVisible;

    public FogEffect(Form form)
    {
        this.form = form;
        this.isFogVisible = false;
    }

    // Метод для отображения или скрытия эффекта тумана
    public void ToggleFogEffect()
    {
        if (isFogVisible)
        {
            // Убираем эффект тумана
            form.Controls.Remove(fogOverlay);
            fogOverlay = null;
            isFogVisible = false;
        }
        else
        {
            // Создаем PictureBox для изображения тумана
            fogOverlay = new PictureBox();
            fogOverlay.Image = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\туман.png"); // Укажи путь к изображению
            fogOverlay.SizeMode = PictureBoxSizeMode.StretchImage;
            fogOverlay.Dock = DockStyle.Fill; // Растягиваем изображение на весь экран
            fogOverlay.BackColor = Color.Transparent; // Прозрачный фон

            // Настраиваем прозрачность изображения
            fogOverlay.Image = SetImageOpacity(fogOverlay.Image, 0.7f); // Устанавливаем прозрачность на 70%

            // Добавляем изображение на форму и отображаем под всеми элементами
            form.Controls.Add(fogOverlay);
            fogOverlay.SendToBack(); // Перемещаем под все элементы

            isFogVisible = true;
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
