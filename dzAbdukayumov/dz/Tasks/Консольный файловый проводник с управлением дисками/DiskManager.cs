using System;
using System.IO;

class DiskManager
{
    static DriveInfo[] allDrives;
    static string currentPath = "";

    static void Main()
    {
        Console.WriteLine("Менеджер дисков");
        allDrives = DriveInfo.GetDrives();

        while (true)
        {
            if (string.IsNullOrEmpty(currentPath))
            {
                ShowDrivesMenu();
            }
            else
            {
                ShowDiskContentMenu();
            }

            ProcessCommand();
        }
    }

    static void ShowDrivesMenu()
    {
        Console.WriteLine("\n=== ДОСТУПНЫЕ ДИСКИ ===");
        for (int i = 0; i < allDrives.Length; i++)
        {
            var drive = allDrives[i];
            if (drive.IsReady)
            {
                Console.WriteLine($"{i + 1}. {drive.Name} ({drive.DriveType}, {drive.TotalFreeSpace / 1024 / 1024 / 1024} GB свободно из {drive.TotalSize / 1024 / 1024 / 1024} GB)");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {drive.Name} ({drive.DriveType}, не готов)");
            }
        }
        Console.WriteLine("0. Выход");
        Console.Write("Выберите диск: ");
    }

    static void ShowDiskContentMenu()
    {
        Console.WriteLine($"\n=== СОДЕРЖИМОЕ: {currentPath} ===");
        Console.WriteLine("1. Просмотреть информацию о диске");
        Console.WriteLine("2. Просмотреть содержимое");
        Console.WriteLine("3. Создать каталог");
        Console.WriteLine("4. Создать файл");
        Console.WriteLine("5. Удалить файл/каталог");
        Console.WriteLine("6. Вернуться к выбору диска");
        Console.WriteLine("0. Выход");
        Console.Write("Выберите действие: ");
    }

    static void ProcessCommand()
    {
        if (string.IsNullOrEmpty(currentPath))
        {
            ProcessDriveSelection();
        }
        else
        {
            ProcessDiskOperation();
        }
    }

    static void ProcessDriveSelection()
    {
        if (!int.TryParse(Console.ReadLine(), out int choice)) return;

        if (choice == 0) Environment.Exit(0);

        if (choice > 0 && choice <= allDrives.Length)
        {
            var selectedDrive = allDrives[choice - 1];
            if (selectedDrive.IsReady)
            {
                currentPath = selectedDrive.RootDirectory.FullName;
                Console.WriteLine($"\nВыбран диск: {selectedDrive.Name}");
                ShowDiskInfo(selectedDrive);
            }
            else
            {
                Console.WriteLine("Диск не готов к использованию!");
            }
        }
    }

    static void ProcessDiskOperation()
    {
        switch (Console.ReadLine())
        {
            case "1":
                ShowCurrentDiskInfo();
                break;
            case "2":
                ShowDirectoryContents();
                break;
            case "3":
                CreateDirectory();
                break;
            case "4":
                CreateFile();
                break;
            case "5":
                DeleteItem();
                break;
            case "6":
                currentPath = "";
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Неверная команда!");
                break;
        }
    }

    static void ShowCurrentDiskInfo()
    {
        var drive = new DriveInfo(Path.GetPathRoot(currentPath));
        ShowDiskInfo(drive);
    }

    static void ShowDiskInfo(DriveInfo drive)
    {
        Console.WriteLine("\nИнформация о диске:");
        Console.WriteLine($"Имя: {drive.Name}");
        Console.WriteLine($"Тип: {drive.DriveType}");

        if (drive.IsReady)
        {
            Console.WriteLine($"Файловая система: {drive.DriveFormat}");
            Console.WriteLine($"Общий размер: {drive.TotalSize / 1024 / 1024 / 1024} GB");
            Console.WriteLine($"Свободно: {drive.TotalFreeSpace / 1024 / 1024 / 1024} GB");
            Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
        }
    }

    static void ShowDirectoryContents()
    {
        Console.WriteLine($"\nСодержимое {currentPath}:\n");

        try
        {
            // Подкаталоги
            foreach (var dir in Directory.GetDirectories(currentPath))
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"[DIR]  {dirInfo.Name,-40} {dirInfo.CreationTime}");
            }

            // Файлы
            foreach (var file in Directory.GetFiles(currentPath))
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"[FILE] {fileInfo.Name,-40} {fileInfo.Length / 1024} KB");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Ошибка: {ex.Message}");
        }
    }

    static void CreateDirectory()
    {
        Console.Write("\nВведите имя нового каталога: ");
        string dirName = Console.ReadLine();
        string dirPath = Path.Combine(currentPath, dirName);

        try
        {
            Directory.CreateDirectory(dirPath);
            Console.WriteLine($"Каталог {dirName} создан");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void CreateFile()
    {
        Console.Write("\nВведите имя файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(currentPath, fileName);

        Console.WriteLine("Введите текст (для завершения введите пустую строку):");
        string content = "";
        string line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            content += line + Environment.NewLine;
        }

        try
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine($"Файл {fileName} создан");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Ошибка: {ex.Message}");
        }
    }

    static void DeleteItem()
    {
        Console.Write("\nВведите имя файла/каталога: ");
        string name = Console.ReadLine();
        string path = Path.Combine(currentPath, name);

        Console.Write($"Вы уверены, что хотите удалить {name}? (y/n): ");
        if (Console.ReadLine().ToLower() != "y") return;

        try
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine($"Каталог {name} удален");
            }
            else if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Файл {name} удален");
            }
            else
            {
                Console.WriteLine("Файл или каталог не найден!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}