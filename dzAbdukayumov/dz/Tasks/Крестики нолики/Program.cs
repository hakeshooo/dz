using System;

class TicTacToe
{

    private static readonly int BoardSize = 3;


    private static char[,] board = new char[BoardSize, BoardSize];

  
    private static char player1Symbol = 'X';
    private static char player2Symbol = 'O';


    private static char currentPlayer = 'X';

    static void Main(string[] args)
    {
        InitializeBoard();
        PrintBoard();

        while (true)
        {
            Console.WriteLine($"Ход игрока {currentPlayer}!");

          
            Console.Write("Введите строку (1-3): ");
            int row = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Введите столбец (1-3): ");
            int col = int.Parse(Console.ReadLine()) - 1;

           
            if (row < 0 || row >= BoardSize || col < 0 || col >= BoardSize)
            {
                Console.WriteLine("Неверные координаты! Попробуйте снова.");
                continue;
            }

            if (board[row, col] != '\0')
            {
                Console.WriteLine("Эта клетка уже занята! Попробуйте снова.");
                continue;
            }

         
            board[row, col] = currentPlayer;
            PrintBoard();

           
            if (CheckForWinner())
            {
                Console.WriteLine($"Игрок {currentPlayer} победил!");
                break;
            }

            
            if (IsBoardFull())
            {
                Console.WriteLine("Ничья! Игра окончена.");
                break;
            }

         
            currentPlayer = currentPlayer == player1Symbol ? player2Symbol : player1Symbol;
        }

        Console.WriteLine("Спасибо за игру! Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }


    private static void InitializeBoard()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                board[i, j] = '\0';
            }
        }
    }

    
    private static void PrintBoard()
    {
        Console.WriteLine("\n   1   2   3");
        for (int i = 0; i < BoardSize; i++)
        {
            Console.Write($"{i + 1} ");
            for (int j = 0; j < BoardSize; j++)
            {
                Console.Write(board[i, j] == '\0' ? "[ ]" : $"[{board[i, j]}]");
                if (j < BoardSize - 1) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < BoardSize - 1) Console.WriteLine("  ---+---+---");
        } 
        Console.WriteLine();
    }


    private static bool CheckForWinner()
    {
        
        for (int i = 0; i < BoardSize; i++)
        {
            if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
            {
                return true;
            }
        }

    
        if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
            (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
        {
            return true;
        }

        return false;
    }


    private static bool IsBoardFull()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                if (board[i, j] == '\0') return false; 
            }
        }
        return true;
    }
}