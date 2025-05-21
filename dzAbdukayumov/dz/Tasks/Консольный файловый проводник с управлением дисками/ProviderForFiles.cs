using System;
using System.IO;

class PlusVersionExplorer
{
    static string currentDirectory = Directory.GetCurrentDirectory();

    static void Main()
    {
        Console.WriteLine("Улучшенный консольный проводник");
        Console.WriteLine($"Текущая директория: {currentDirectory}\n");

        while (true)
        {
            DisplayMainMenu();
            ProcessMainCommand();
        }
    }

    static void DisplayMainMenu()
    {
        Console.WriteLine("\n=== ГЛАВНОЕ МЕНЮ ===");
        Console.WriteLine("1. Просмотр содержимого");
        Console.WriteLine("2. Навигация по файловой системе");
        Console.WriteLine("3. Операции с файлами");
        Console.WriteLine("4. Операции с каталогами");
        Console.WriteLine("5. Информация о диске");
        Console.WriteLine("0. Выход");
        Console.Write("Выберите действие: ");
    }

    static void ProcessMainCommand()
    {
        switch (Console.ReadLine())
        {
            case "1":
                ShowDirectoryContents();
                break;
            case "2":
                NavigationMenu();
                break;
            case "3":
                FileOperationsMenu();
                break;
            case "4":
                DirectoryOperationsMenu();
                break;
            case "5":
                ShowDiskInfo();
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("⚠ Неверная команда!");
                break;
        }
    }

    static void ShowDirectoryContents()
    {
        Console.WriteLine($"\nСодержимое {currentDirectory}:\n");
        
        try
        {
            // Отображаем информацию о текущем диске
            var driveInfo = new DriveInfo(Path.GetPathRoot(currentDirectory));
            Console.WriteLine($"Диск {driveInfo.Name} | Свободно: {driveInfo.TotalFreeSpace/1024/1024} MB");

            // Подкаталоги
            foreach (var dir in Directory.GetDirectories(currentDirectory))
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"[DIR]  {dirInfo.Name,-30} {dirInfo.CreationTime}");
            }

            // Файлы
            foreach (var file in Directory.GetFiles(currentDirectory))
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"[FILE] {fileInfo.Name,-30} {fileInfo.Length/1024} KB");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void NavigationMenu()
    {
        Console.WriteLine("\n=== НАВИГАЦИЯ ===");
        Console.WriteLine("1. Перейти в каталог");
        Console.WriteLine("2. Перейти в родительский каталог");
        Console.WriteLine("3. Перейти к корню диска");
        Console.WriteLine("4. Выбрать другой диск");
        Console.WriteLine("0. Назад");
        Console.Write("Выберите действие: ");

        switch (Console.ReadLine())
        {
            case "1":
                EnterDirectory();
                break;
            case "2":
                GoToParentDirectory();
                break;
            case "3":
                GoToRoot();
                break;
            case "4":
                SelectDrive();
                break;
        }
    }

    static void FileOperationsMenu()
    {
        Console.WriteLine("\n=== ОПЕРАЦИИ С ФАЙЛАМИ ===");
        Console.WriteLine("1. Создать текстовый файл");
        Console.WriteLine("2. Просмотреть файл");
        Console.WriteLine("3. Удалить файл");
        Console.WriteLine("4. Копировать файл");
        Console.WriteLine("0. Назад");
        Console.Write("Выберите действие: ");

        switch (Console.ReadLine())
        {
            case "1":
                CreateTextFile();
                break;
            case "2":
                ViewFile();
                break;
            case "3":
                DeleteFile();
                break;
            case "4":
                CopyFile();
                break;
        }
    }

    static void DirectoryOperationsMenu()
    {
        Console.WriteLine("\n=== ОПЕРАЦИИ С КАТАЛОГАМИ ===");
        Console.WriteLine("1. Создать каталог");
        Console.WriteLine("2. Удалить каталог");
        Console.WriteLine("0. Назад");
        Console.Write("Выберите действие: ");

        switch (Console.ReadLine())
        {
            case "1":
                CreateDirectory();
                break;
            case "2":
                DeleteDirectory();
                break;
        }
    }

    static void CreateTextFile()
    {
        Console.Write("\nВведите имя файла (с расширением .txt): ");
        string fileName = Console.ReadLine();

        // Проверяем расширение файла
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        string filePath = Path.Combine(currentDirectory, fileName);

        if (File.Exists(filePath))
        {
            Console.WriteLine("Файл уже существует. Перезаписать? (y/n)");
            if (Console.ReadLine().ToLower() != "y") return;
        }

        Console.WriteLine("\nВведите содержимое файла (для завершения введите пустую строку):");
        Console.WriteLine("----------------------------------------");
        
        string content = "";
        string line;
        int lineNumber = 1;
        
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            content += $"{lineNumber++}. {line}{Environment.NewLine}";
        }

        try
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine($"\nФайл {fileName} успешно создан!");
            Console.WriteLine($"Размер: {content.Length} символов");
            Console.WriteLine($"Дата создания: {DateTime.Now}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
        }
    }

    static void ShowDiskInfo()
    {
        try
        {
            var drive = new DriveInfo(Path.GetPathRoot(currentDirectory));
            
            Console.WriteLine("\nПодробная информация о диске:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Имя: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            
            if (drive.IsReady)
            {
                Console.WriteLine($"Файловая система: {drive.DriveFormat}");
                Console.WriteLine($"Общий размер: {drive.TotalSize/1024/1024} MB");
                Console.WriteLine($"Доступно: {drive.TotalFreeSpace/1024/1024} MB");
                Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
                Console.WriteLine($"Занято: {100 - (drive.TotalFreeSpace * 100 / drive.TotalSize)}%");
            }
            else
            {
                Console.WriteLine("Диск не готов к использованию");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
