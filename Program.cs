namespace Пианино
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение октавы F2-F8");
            string[,] klava =
            {
                {"-----", "[W] C#", "-----", "[E] Eb", "-----", "-----", "[T] F#", "-----", "[Y] G#", "-----", "[U] Bb", "-----" },
                {"[A] C", "------", "[S] D", "------", "[D] E", "[F] F", "------", "[G] G", "------", "[H] A", "------", "[J] B" }
            };
            for (int i = 0; i < klava.GetLength(0); i++)
            {
                for (int j = 0; j < klava.GetLength(1); j++)
                {
                    Console.Write(klava[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[] octava = Smena(ConsoleKey.F2, null);
            while (true)
            {
                ConsoleKeyInfo klavisha = Console.ReadKey(true);
                octava = Smena(klavisha.Key, octava);
                Noti(octava, klavisha);
                if (klavisha.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        static int[] Smena(ConsoleKey klavisha, int[]? octava)
        {
            int[] octava2 = new int[] { 65, 69, 73, 78, 82, 88, 93, 98, 104, 110, 117, 124 };
            int[] octava3 = new int[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
            int[] octava4 = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] octava5 = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            int[] octava6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
            int[] octava7 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] octava8 = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            switch(klavisha)
            {
                case ConsoleKey.F2: {  return octava2; }
                case ConsoleKey.F3: {  return octava3; }
                case ConsoleKey.F4: {  return octava4; }
                case ConsoleKey.F5: {  return octava5; }
                case ConsoleKey.F6: {  return octava6; }
                case ConsoleKey.F7: {  return octava7; }
                case ConsoleKey.F8: {  return octava8; }
                default: { return octava; }
            }
        }

        static void Noti(int[]? octava, ConsoleKeyInfo klavisha)
        {
            switch(klavisha.Key)
            {
                case ConsoleKey.A: { Console.Beep(octava[0], 600); break; }
                case ConsoleKey.W: { Console.Beep(octava[1], 600); break; }
                case ConsoleKey.S: { Console.Beep(octava[2], 600); break; }
                case ConsoleKey.E: { Console.Beep(octava[3], 600); break; }
                case ConsoleKey.D: { Console.Beep(octava[4], 600); break; }
                case ConsoleKey.F: { Console.Beep(octava[5], 600); break; }
                case ConsoleKey.T: { Console.Beep(octava[6], 600); break; }
                case ConsoleKey.G: { Console.Beep(octava[7], 600); break; }
                case ConsoleKey.Y: { Console.Beep(octava[8], 600); break; }
                case ConsoleKey.H: { Console.Beep(octava[9], 600); break; }
                case ConsoleKey.U: { Console.Beep(octava[10], 600); break; }
                case ConsoleKey.J: { Console.Beep(octava[11], 600); break; }
            }
        }
    }
}