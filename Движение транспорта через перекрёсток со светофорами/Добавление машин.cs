public class CarManager
{
    private List<PictureBox> cars;
    private List<Point> targetPoints; // Целевые точки для движения
    private List<int> speeds;
    private Random random;
    private System.Windows.Forms.Timer moveTimer; // Таймер для движения машин
    private Form form;

    // Пути к изображениям машин
    private readonly string[] carImages =
    {
        @"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\автомобиль жёлтый.jpg",
        @"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\автомобиль красный.jpg",
        @"D:\Работы\Лабы ТРПО\Программа по ТРПО\Изображения для программы\автомобиль белый.png"
    };

    // Координаты для появления машин
    private readonly Point[] carPositions =
    {
        new Point(725, 557),  // Нижняя левая позиция (для машины, движущейся вверх)
        new Point(550, 60)    // Нижняя правая позиция (для машины, движущейся вниз)
    };

    public CarManager(Form form)
    {
        this.form = form;
        cars = new List<PictureBox>();
        targetPoints = new List<Point>();
        speeds = new List<int>();
        random = new Random();

        // Инициализация таймера
        moveTimer = new System.Windows.Forms.Timer
        {
            Interval = 100 // Интервал в миллисекундах
        };
        moveTimer.Tick += MoveCars; // Подписка на событие Tick
    }

    public void AddRandomCar()
    {
        if (cars.Count >= carPositions.Length)
        {
            MessageBox.Show("Максимум 2 машины!");
            return;
        }

        // Создаем новую машину
        PictureBox car = new PictureBox
        {
            SizeMode = PictureBoxSizeMode.StretchImage,
            Size = new Size(50, 100),
            Image = Image.FromFile(carImages[random.Next(carImages.Length)]),
            Location = carPositions[cars.Count]
        };

        // Устанавливаем целевую точку для первой машины (движение вверх), для второй - вниз
        if (cars.Count == 0)
        {
            targetPoints.Add(new Point(car.Left, 0)); // Движение вверх
        }
        else
        {
            targetPoints.Add(new Point(car.Left, form.ClientSize.Height)); // Движение вниз
        }

        // Инициализируем скорость для новой машины
        speeds.Add(random.Next(3, 8)); // Случайная скорость от 3 до 7

        // Добавляем машину на форму и список
        form.Controls.Add(car);
        cars.Add(car);
        car.BringToFront();

        // Запускаем таймер, если он еще не запущен
        if (!moveTimer.Enabled)
        {
            moveTimer.Start();
        }
    }

    private void MoveToTarget(int carIndex, Point targetPoint)
    {
        var car = cars[carIndex]; // Получаем объект автомобиля по индексу

        // Обновление положения машины
        if (targetPoint.Y < car.Top) // Двигаем машину только вверх
        {
            car.Top -= speeds[carIndex];
        }
        else if (targetPoint.Y > car.Top) // Двигаем машину только вниз
        {
            car.Top += speeds[carIndex];
        }

        form.Invalidate();
    }

    private void MoveCars(object sender, EventArgs e)
    {
        for (int i = cars.Count - 1; i >= 0; i--)
        {
            var targetPoint = targetPoints[i];
            MoveToTarget(i, targetPoint);

            // Проверяем, вышел ли автомобиль за пределы формы
            if (IsCarOutOfBounds(cars[i]))
            {
                RemoveCar(i);
            }
        }
    }

    private bool IsCarOutOfBounds(PictureBox car)
    {
        // Проверяем, вышла ли машина за верхнюю или нижнюю границу формы
        bool outOfBounds = car.Top + car.Height < 0 || car.Top > form.ClientSize.Height;
        if (outOfBounds)
        {
            Console.WriteLine($"Машина {car.Name} вышла за пределы формы."); // Отладочная информация
        }
        return outOfBounds;
    }

    private void RemoveCar(int carIndex)
    {
        // Удаляем машину и связанные данные
        var car = cars[carIndex];
        Console.WriteLine($"Удаляем машину: {car.Name}"); // Отладочная информация

        form.Controls.Remove(car);
        cars.RemoveAt(carIndex);
        targetPoints.RemoveAt(carIndex);
        speeds.RemoveAt(carIndex);
    }

    public void StartMovingCars()
    {
        moveTimer.Start();
    }

    public void StopMovingCars()
    {
        moveTimer.Stop();
    }
}
