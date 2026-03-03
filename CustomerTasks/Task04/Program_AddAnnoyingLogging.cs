// Пример шумного лога для Task04.
// Скопируй тело метода PrintMenu из этого файла в свой Program.cs
// и сделай отдельный коммит, а затем откати его через reset.

static void PrintMenu()
{
    Console.WriteLine("=== Калькулятор мечты (v0, шумная версия) ===");
    Console.WriteLine("[DEBUG] Запуск меню. Если ты видишь это в релизе — что-то пошло не так.");
    Console.WriteLine("Доступные операции:");
    Console.WriteLine("  1 - сложение");
    Console.WriteLine("  2 - вычитание");
    Console.WriteLine("  3 - умножение");
    Console.WriteLine("  4 - деление");
    Console.WriteLine("  q - выход");
}

