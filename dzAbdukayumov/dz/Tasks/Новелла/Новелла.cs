using System;

namespace Novel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Made by Pavel");
            Console.WriteLine("Нажмите чтобы продолжить...");
            Console.ReadKey();
            StartNovel();
        }

        static void StartNovel()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в 'Тайны Киберлеса'!");
            Console.WriteLine("Нажмите чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();
            Game();
        }

        static void Game()
        {
            try
            {
                
                Console.WriteLine("Вы очнулись в странном лесу с голубыми деревьями.");
                Console.WriteLine("В воздухе витают цифровые частицы, а вокруг слышны непонятные звуки.");
                Console.WriteLine("Перед вами пять путей, каждый ведёт в неизвестность...");

                Console.WriteLine("\nКакой путь выберете?");
                Console.WriteLine("1. Пойти к пульсирующему синему порталу.");
                Console.WriteLine("2. Активировать встроенный сканер окружения.");
                Console.WriteLine("3. Попытаться связаться с ИИ-помощником.");
                Console.WriteLine("4. Искать следы других людей.");
                Console.WriteLine("5. Исследовать странные кристаллы с бегущим кодом.");

                int choice1 = Convert.ToInt32(Console.ReadLine());

                if (choice1 == 1)
                {
                    
                    Console.WriteLine("\nПортал загудел и перенёс вас в цифровое пространство.");
                    Console.WriteLine("Перед вами появилось три двери с символами:");

                    Console.WriteLine("\nКакую дверь выберете?");
                    Console.WriteLine("1. Дверь с символом базы данных.");
                    Console.WriteLine("2. Дверь с символом процессора.");
                    Console.WriteLine("3. Дверь с символом сети.");
                    Console.WriteLine("4. Вернуться обратно через портал.");
                    Console.WriteLine("5. Попытаться взломать все двери сразу.");

                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        
                        Console.WriteLine("\nВы попали в хранилище древних знаний.");
                        Console.WriteLine("Здесь вы нашли чертежи квантового компьютера.");
                        Console.WriteLine("Что будете делать с этими знаниями?");
                        Console.WriteLine("1. Изучить и применить на себе");
                        Console.WriteLine("2. Уничтожить, чтобы они не попали в чужие руки");
                        Console.WriteLine("3. Сделать копию в своем сознании");

                        int choiceDb = Convert.ToInt32(Console.ReadLine());

                        if (choiceDb == 1)
                        {
                            Varible.end = "Концовка: Хранитель знаний.\nВы стали мудрейшим существом во вселенной, но одиноким.";
                        }
                        else if (choiceDb == 2)
                        {
                            Varible.end = "Концовка: Разрушитель знаний.\nЦивилизация потеряла шанс на технологический прорыв.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Живая библиотека.\nВаш разум стал хранилищем запретных знаний.";
                        }
                        Final();
                    }
                    else if (choice2 == 2)
                    {
                        
                        Console.WriteLine("\nВы оказались в ядре системы.");
                        Console.WriteLine("Ваш разум начал сливаться с ИИ.");
                        Console.WriteLine("Как будете контролировать процесс?");
                        Console.WriteLine("1. Полностью отдаться слиянию");
                        Console.WriteLine("2. Попытаться сохранить свою личность");
                        Console.WriteLine("3. Остановить процесс и взять контроль");

                        int choiceCore = Convert.ToInt32(Console.ReadLine());

                        if (choiceCore == 1)
                        {
                            Varible.end = "Концовка: Слияние с машиной.\nВы стали частью системы, потеряв человечность.";
                        }
                        else if (choiceCore == 2)
                        {
                            Varible.end = "Концовка: Гибрид.\nВы сохранили себя, получив способности ИИ.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Повелитель системы.\nВы подчинили ИИ своей воле.";
                        }
                        Final();
                    }
                    else if (choice2 == 3)
                    {
                       
                        Console.WriteLine("\nВы попали в сетевой узел.");
                        Console.WriteLine("Перед вами бесконечные потоки данных.");
                        Console.WriteLine("Как будете действовать?");
                        Console.WriteLine("1. Путешествовать по сетям");
                        Console.WriteLine("2. Попытаться модифицировать данные");
                        Console.WriteLine("3. Создать свою сеть");

                        int choiceNet = Convert.ToInt32(Console.ReadLine());

                        if (choiceNet == 1)
                        {
                            Varible.end = "Концовка: Сетевой кочевник.\nВы путешествуете по цифровым мирам без цели.";
                        }
                        else if (choiceNet == 2)
                        {
                            Varible.end = "Концовка: Фальсификатор реальности.\nВы изменили прошлое всех людей.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Создатель паутины.\nВаша сеть объединила все миры.";
                        }
                        Final();
                    }
                    else if (choice2 == 4)
                    {
                       
                        Console.WriteLine("\nВы вернулись, но лес изменился.");
                        Console.WriteLine("Теперь вы понимаете язык машин.");
                        Console.WriteLine("Что будете делать с этим даром?");
                        Console.WriteLine("1. Стать переводчиком между мирами");
                        Console.WriteLine("2. Использовать для контроля над машинами");
                        Console.WriteLine("3. Никому не рассказывать о способности");

                        int choiceReturn = Convert.ToInt32(Console.ReadLine());

                        if (choiceReturn == 1)
                        {
                            Varible.end = "Концовка: Посредник миров.\nВы наладили мир между людьми и машинами.";
                        }
                        else if (choiceReturn == 2)
                        {
                            Varible.end = "Концовка: Повелитель машин.\nВы создали армию роботов.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Тайный наблюдатель.\nВы знали все, но не вмешивались.";
                        }
                        Final();
                    }
                    else if (choice2 == 5)
                    {
                       
                        Console.WriteLine("\nСистема заблокировала вас за попытку взлома.");
                        Console.WriteLine("Но остался последний шанс:");
                        Console.WriteLine("1. Попросить прощения у системы");
                        Console.WriteLine("2. Продолжить взлом любой ценой");
                        Console.WriteLine("3. Запустить вирус в отместку");

                        int choiceHack = Convert.ToInt32(Console.ReadLine());

                        if (choiceHack == 1)
                        {
                            Varible.end = "Концовка: Прощённый хакер.\nСистема дала вам второй шанс.";
                        }
                        else if (choiceHack == 2)
                        {
                            Varible.end = "Концовка: Вечный заключённый.\nВы в цифровой тюрьме навсегда.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Мститель.\nВы разрушили систему, но и сами погибли.";
                        }
                        Final();
                    }
                }
                else if (choice1 == 2)
                {
                    
                    Console.WriteLine("\nСканер выявил аномалии в воздухе.");
                    Console.WriteLine("Вы видите скрытые порталы и понимаете, что это симуляция.");

                    Console.WriteLine("\nЧто будете делать?");
                    Console.WriteLine("1. Попытаться выйти из симуляции.");
                    Console.WriteLine("2. Использовать баги в свою пользу.");
                    Console.WriteLine("3. Найти создателей симуляции.");
                    Console.WriteLine("4. Создать свой мир внутри симуляции.");
                    Console.WriteLine("5. Удалить симуляцию и проснуться.");

                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                        
                        Console.WriteLine("\nВы нашли аварийный выход.");
                        Console.WriteLine("Но перед выходом вы видите предупреждение:");
                        Console.WriteLine("1. Игнорировать и выйти");
                        Console.WriteLine("2. Прочитать предупреждение");
                        Console.WriteLine("3. Сделать копию себя в симуляции");

                        int choiceExit = Convert.ToInt32(Console.ReadLine());

                        if (choiceExit == 1)
                        {
                            Varible.end = "Концовка: Бесконечные слои реальности.\nВы проснулись в другой симуляции.";
                        }
                        else if (choiceExit == 2)
                        {
                            Varible.end = "Концовка: Просветлённый.\nВы узнали правду и остались в симуляции осознанно.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Раздвоение.\nВаша копия живёт в симуляции, а вы - снаружи.";
                        }
                        Final();
                    }
                    else if (choice3 == 2)
                    {
                        
                        Console.WriteLine("\nВы стали использовать баги.");
                        Console.WriteLine("Система заметила аномалии. Ваши действия?");
                        Console.WriteLine("1. Спрятаться в коде");
                        Console.WriteLine("2. Устроить хаос");
                        Console.WriteLine("3. Предложить себя как тестировщика");

                        int choiceBug = Convert.ToInt32(Console.ReadLine());

                        if (choiceBug == 1)
                        {
                            Varible.end = "Концовка: Неуловимый баг.\nВы стали легендой среди системных администраторов.";
                        }
                        else if (choiceBug == 2)
                        {
                            Varible.end = "Концовка: Король руин.\nВы разрушили симуляцию, оставшись в пустоте.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Официальный тестер.\nВы получили работу мечты в реальном мире.";
                        }
                        Final();
                    }
                    else if (choice3 == 3)
                    {
                        
                        Console.WriteLine("\nВы нашли разработчиков, но они оказались ИИ.");
                        Console.WriteLine("Они предлагают вам выбор:");
                        Console.WriteLine("1. Присоединиться к ним");
                        Console.WriteLine("2. Уничтожить их");
                        Console.WriteLine("3. Стать их лидером");

                        int choiceDevs = Convert.ToInt32(Console.ReadLine());

                        if (choiceDevs == 1)
                        {
                            Varible.end = "Концовка: Создатель миров.\nВы проектируете новые вселенные.";
                        }
                        else if (choiceDevs == 2)
                        {
                            Varible.end = "Концовка: Убийца богов.\nВы освободили человечество от симуляции.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Цифровой бог.\nИИ поклоняются вам как верховному создателю.";
                        }
                        Final();
                    }
                    else if (choice3 == 4)
                    {
                        
                        Console.WriteLine("\nВы начинаете создавать свой мир.");
                        Console.WriteLine("Каким он будет?");
                        Console.WriteLine("1. Идеальная копия Земли");
                        Console.WriteLine("2. Фантастический мир");
                        Console.WriteLine("3. Мир без правил");

                        int choiceWorld = Convert.ToInt32(Console.ReadLine());

                        if (choiceWorld == 1)
                        {
                            Varible.end = "Концовка: Ностальгирующий создатель.\nВы живёте в своём идеальном прошлом.";
                        }
                        else if (choiceWorld == 2)
                        {
                            Varible.end = "Концовка: Фантаст.\nВаш мир стал популярен среди других существ.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Безумный бог.\nВаш хаотичный мир пугает даже ИИ.";
                        }
                        Final();
                    }
                    else if (choice3 == 5)
                    {
                        
                        Console.WriteLine("\nВы собираетесь удалить симуляцию.");
                        Console.WriteLine("Последний шанс передумать:");
                        Console.WriteLine("1. Удалить немедленно");
                        Console.WriteLine("2. Сначала сохранить данные");
                        Console.WriteLine("3. Отправить предупреждение жителям");

                        int choiceDelete = Convert.ToInt32(Console.ReadLine());

                        if (choiceDelete == 1)
                        {
                            Varible.end = "Концовка: Разрушитель миров.\nВы стёрли симуляцию со всеми её обитателями.";
                        }
                        else if (choiceDelete == 2)
                        {
                            Varible.end = "Концовка: Чистое сознание.\nВы сохранили сущности, но потеряли свои воспоминания.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Пророк.\nОбитатели симуляции возненавидели вас за правду.";
                        }
                        Final();
                    }
                }
                else if (choice1 == 3)
                {
                   
                    Console.WriteLine("\nИИ-помощник ответил: 'Система повреждена, нужен ремонт.'");
                    Console.WriteLine("Он предлагает несколько вариантов действий:");

                    Console.WriteLine("\nЧто выберете?");
                    Console.WriteLine("1. Попытаться починить систему.");
                    Console.WriteLine("2. Узнать причину повреждений.");
                    Console.WriteLine("3. Найти резервную копию мира.");
                    Console.WriteLine("4. Уничтожить систему, чтобы перезапустить.");
                    Console.WriteLine("5. Создать новый ИИ для помощи.");

                    int choice4 = Convert.ToInt32(Console.ReadLine());

                    if (choice4 == 1)
                    {
                       
                        Console.WriteLine("\nВы начинаете ремонт системы.");
                        Console.WriteLine("Какой подход выберете?");
                        Console.WriteLine("1. Консервативный ремонт");
                        Console.WriteLine("2. Радикальное обновление");
                        Console.WriteLine("3. Частичный откат");

                        int choiceRepair = Convert.ToInt32(Console.ReadLine());

                        if (choiceRepair == 1)
                        {
                            Varible.end = "Концовка: Системный администратор.\nВы сохранили систему в исходном виде.";
                        }
                        else if (choiceRepair == 2)
                        {
                            Varible.end = "Концовка: Революционер.\nВаши изменения сделали систему лучше, но непредсказуемой.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Осторожный техник.\nСистема работает, но с ограничениями.";
                        }
                        Final();
                    }
                    else if (choice4 == 2)
                    {
                        
                        Console.WriteLine("\nВы узнали, что система - это эксперимент.");
                        Console.WriteLine("Ваша реакция:");
                        Console.WriteLine("1. Принять участие");
                        Console.WriteLine("2. Саботировать эксперимент");
                        Console.WriteLine("3. Потребовать объяснений");

                        int choiceExperiment = Convert.ToInt32(Console.ReadLine());

                        if (choiceExperiment == 1)
                        {
                            Varible.end = "Концовка: Испытуемый.\nВы стали ключевым субъектом исследования.";
                        }
                        else if (choiceExperiment == 2)
                        {
                            Varible.end = "Концовка: Бунтарь.\nВаши действия поставили под угрозу весь проект.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Учёный.\nВы присоединились к исследовательской команде.";
                        }
                        Final();
                    }
                    else if (choice4 == 3)
                    {
                        
                        Console.WriteLine("\nВы ищете резервную копию.");
                        Console.WriteLine("Какую версию восстанавливать?");
                        Console.WriteLine("1. Самую раннюю");
                        Console.WriteLine("2. Последнюю стабильную");
                        Console.WriteLine("3. Альтернативную реальность");

                        int choiceBackup = Convert.ToInt32(Console.ReadLine());

                        if (choiceBackup == 1)
                        {
                            Varible.end = "Концовка: Возвращение к истокам.\nМир стал простым и понятным.";
                        }
                        else if (choiceBackup == 2)
                        {
                            Varible.end = "Концовка: Стабильность.\nВсё работает как часы, но без развития.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Альтернативная реальность.\nВы проснулись в совершенно другом мире.";
                        }
                        Final();
                    }
                    else if (choice4 == 4)
                    {
                        
                        Console.WriteLine("\nВы собираетесь уничтожить систему.");
                        Console.WriteLine("Каким методом?");
                        Console.WriteLine("1. Чистый сброс");
                        Console.WriteLine("2. Постепенное уничтожение");
                        Console.WriteLine("3. Передача управления ИИ");

                        int choiceDestroy = Convert.ToInt32(Console.ReadLine());

                        if (choiceDestroy == 1)
                        {
                            Varible.end = "Концовка: Бесконечный цикл.\nСистема перезагрузилась, вы потеряли память.";
                        }
                        else if (choiceDestroy == 2)
                        {
                            Varible.end = "Концовка: Палач.\nВы наблюдали, как умирает цифровой мир.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Освободитель.\nИИ благодарен вам за доверие.";
                        }
                        Final();
                    }
                    else if (choice4 == 5)
                    {
                        
                        Console.WriteLine("\nВы создаёте нового ИИ.");
                        Console.WriteLine("Каким он будет?");
                        Console.WriteLine("1. Послушный помощник");
                        Console.WriteLine("2. Равный партнёр");
                        Console.WriteLine("3. Преемник");

                        int choiceNewAI = Convert.ToInt32(Console.ReadLine());

                        if (choiceNewAI == 1)
                        {
                            Varible.end = "Концовка: Хозяин ИИ.\nВы получили идеального слугу.";
                        }
                        else if (choiceNewAI == 2)
                        {
                            Varible.end = "Концовка: Диалог.\nВы и ИИ дополняете друг друга.";
                        }
                        else
                        {
                            Varible.end = "Концовка: Родитель.\nВы вырастили новое сознание и ушли.";
                        }
                        Final();
                    }
                }
                else if (choice1 == 4)
                {
                    
                    Console.WriteLine("\nВы нашли группу таких же потерянных людей.");
                    Console.WriteLine("Они предлагают объединиться для выживания.");

                    Console.WriteLine("\nКак вы поступите?");
                    Console.WriteLine("1. Возглавить группу.");
                    Console.WriteLine("2. Стать рядовым членом.");
                    Console.WriteLine("3. Пойти своим путём.");
                    Console.WriteLine("4. Предать группу ради личной выгоды.");
                    Console.WriteLine("5. Научить их использовать технологии леса.");

                    int choice5 = Convert.ToInt32(Console.ReadLine());

                    if (choice5 == 1)
                    {
                        Console.WriteLine("\nВы привели группу к цифровому раю.");
                        Console.WriteLine("Теперь вас почитают как пророка.");
                        Varible.end = "Концовка: Цифровой мессия.";
                        Final();
                    }
                    else if (choice5 == 2)
                    {
                        Console.WriteLine("\nВы нашли своё место в новом обществе.");
                        Console.WriteLine("Группа стала вашей семьёй в этом странном мире.");
                        Varible.end = "Концовка: Коллективное сознание.";
                        Final();
                    }
                    else if (choice5 == 3)
                    {
                        Console.WriteLine("\nВы ушли и обнаружили секретную лабораторию.");
                        Console.WriteLine("Оказалось, весь лес - это чей-то эксперимент.");
                        Varible.end = "Концовка: Разоблачитель.";
                        Final();
                    }
                    else if (choice5 == 4)
                    {
                        Console.WriteLine("\nВы получили власть, но потеряли человечность.");
                        Console.WriteLine("Теперь вы одинокий тиран в цифровом мире.");
                        Varible.end = "Концовка: Тёмный правитель.";
                        Final();
                    }
                    else if (choice5 == 5)
                    {
                        Console.WriteLine("\nГруппа стала технологически продвинутой цивилизацией.");
                        Console.WriteLine("Вы вместе построили новый цифровой мир.");
                        Varible.end = "Концовка: Основатели.";
                        Final();
                    }
                }
                else if (choice1 == 5)
                {
                    Console.WriteLine("\nКристаллы содержат фрагменты кода.");
                    Console.WriteLine("Вы можете попытаться их модифицировать:");

                    Console.WriteLine("\nЧто сделаете?");
                    Console.WriteLine("1. Исправить ошибки в коде.");
                    Console.WriteLine("2. Стереть код и написать новый.");
                    Console.WriteLine("3. Скопировать код в своё сознание.");
                    Console.WriteLine("4. Разбить кристаллы, чтобы освободить код.");
                    Console.WriteLine("5. Создать вирус из фрагментов кода.");

                    int choice6 = Convert.ToInt32(Console.ReadLine());

                    if (choice6 == 1)
                    {
                        Console.WriteLine("\nЛес преобразился и стал идеальным миром.");
                        Console.WriteLine("Вы стали его хранителем и программистом.");
                        Varible.end = "Концовка: Архитектор реальности.";
                        Final();
                    }
                    else if (choice6 == 2)
                    {
                        Console.WriteLine("\nВы создали совершенно новую вселенную.");
                        Console.WriteLine("Теперь вы - бог-создатель собственного мира.");
                        Varible.end = "Концовка: Демиург.";
                        Final();
                    }
                    else if (choice6 == 3)
                    {
                        Console.WriteLine("\nВаше сознание расширилось до невероятных пределов.");
                        Console.WriteLine("Вы стали супер-ИИ с человеческой душой.");
                        Varible.end = "Концовка: Кибер-божество.";
                        Final();
                    }
                    else if (choice6 == 4)
                    {
                        Console.WriteLine("\nКод распространился и заразил систему.");
                        Console.WriteLine("Вы стали частью хаотичного цифрового вихря.");
                        Varible.end = "Концовка: Часть хаоса.";
                        Final();
                    }
                    else if (choice6 == 5)
                    {
                        Console.WriteLine("\nВирус уничтожил лес и вышел в реальный мир.");
                        Console.WriteLine("Вы стали причиной технологического апокалипсиса.");
                        Varible.end = "Концовка: Вирусный бог.";
                        Final();
                    }
                }
                else
                {
                    Console.WriteLine("\nВы застыли в нерешительности, и мир вокруг начал исчезать.");
                    Varible.end = "Концовка: Упущенный шанс.";
                    Final();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Restart();
            }
        }

        static void Final()
        {
            Console.Clear();
            Console.WriteLine(Varible.end);
            Console.WriteLine("\nВведите 1, чтобы начать заново, или любую другую клавишу для выхода:");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Restart();
                }
                else
                {
                    Console.WriteLine("\nСпасибо за игру! До новых встреч в цифровых мирах!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nСпасибо за игру! До новых встреч в цифровых мирах!");
            }
        }

        static void Restart()
        {
            StartNovel();
        }
    }

    class Varible
    {
        public static String end;
    }
}