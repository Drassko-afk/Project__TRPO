using System.Drawing;

public class BackgroundManager
{
    private Form form;

    public BackgroundManager(Form form)
    {
        this.form = form;
    }

    public void ChangeBackground(string season)
    {
        Image backgroundImage = null;

        switch (season)
        {
            case "Лето":
                backgroundImage = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\лето.png");
                break;
            case "Осень":
                backgroundImage = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\осень.png");
                break;
            case "Зима":
                backgroundImage = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\зима.png");
                break;
            case "Весна":
                backgroundImage = Image.FromFile(@"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\весна.png");
                break;
        }

        // Устанавливаем фоновое изображение формы
        if (backgroundImage != null)
        {
            form.BackgroundImage = backgroundImage;
        }
    }
}
