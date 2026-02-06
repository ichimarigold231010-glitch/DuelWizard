
//public class Wizard
//{
//    public string nama;
//    public int energi;
//    public int damage;

//    public Wizard(string nama, int damage)
//    {
//        nama = nama;
//        energi = 100;
//        damage = damage;
//    }

//    public void Attack(Wizard enemy)
//    {
//        enemy.energi -= damage;

//        if (enemy.energi < 0)
//            enemy.energi = 0;

//        Console.WriteLine($"{nama} menyerang {enemy.energi}!");
//        Console.WriteLine($"Energi {enemy.nama} tersisa: {enemy.energi}");
//    }
//    public void showStats()
//    {
//        Console.WriteLine($"Nama wizard: {nama}");
//        Console.WriteLine($"Eneri: {energi}");
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Wizard wizard1 = new Wizard("Mimi", 20);
//            Wizard wizard2 = new Wizard("Peri", 15);


//            wizard1.showStats();
//            wizard2.showStats();

//            wizard1.Attack(wizard2);
//            wizard2.Attack(wizard1);
//            wizard1.Attack(wizard2);

//            Console.WriteLine("=== Statistik Akhir ===");
//            wizard1.showStats();
//            wizard2.showStats();

//            Console.ReadLine();
//        }

//    }
//}


//BU BIAS CODE

Wizard wizardA = new Wizard("Mimi peri", 5);
Wizard wizardB = new Wizard("Dory", 10);

Console.WriteLine("Permainan dimulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan Selesai....");
Console.WriteLine("Statistik Akhir");
wizardA.ShowStats();
wizardB.ShowStats();


public class Wizard
{
    public string Name;
    public int Energy;
    public int Damage;

//constructor

    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }
    //deklarasi method
    public void ShowStats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Energy: {Energy}\n");
    }

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {enemyObj.Name}");
        Console.WriteLine($"Sisa energi {enemyObj.Name}: {enemyObj.Energy}");
    }

}


