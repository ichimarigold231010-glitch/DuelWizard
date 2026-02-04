
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
    public void showStaats()
    {
        Console.WriteLine($"Nama wizard: {nama}");
        Console.WriteLine($"Eneri: {energi}");
    }
}

