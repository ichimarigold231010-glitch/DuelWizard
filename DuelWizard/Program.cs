
public class Wizard
{
    public string nama;
    public int energi;
    public int damage;

    public Wizard(string nama, int damage)
    {
        nama = nama;
        energi = 100;
        damage = damage;
    }

    public void Attack(Wizard enemy)
    {
        enemy.energi -= damage;

        if (enemy.energi < 0)
            enemy.energi = 0;

        Console.WriteLine($"{nama} menyerang {enemy.energi}!");
        Console.WriteLine($"Energi {enemy.nama} tersisa: {enemy.energi}");
    }
    public void showStats()
    {
        Console.WriteLine($"Nama wizard: {nama}");
        Console.WriteLine($"Eneri: {energi}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard1 = new Wizard("Mimi", 20);
            Wizard wizard2 = new Wizard("Peri", 15);


            wizard1.showStats();
            wizard2.showStats();

            wizard1.Attack(wizard2);
            wizard2.Attack(wizard1);
            wizard1.Attack(wizard2);

            Console.WriteLine("=== Statistik Akhir ===");
            wizard1.showStats();
            wizard2.showStats();

            Console.ReadLine();
        }

    }
}


