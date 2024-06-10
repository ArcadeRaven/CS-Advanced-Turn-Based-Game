using TBB;

Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
Random random = new Random();

while(!player.IsDead && and !enemy.IsDead)
{
    System.Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    System.Console.WriteLine("Player turn! What will you do?");
    string choice = System.Console.ReadLine();

    if (choice == "a")
        player.Attack(enemy);
    else
        player.Heal();

    if (player.IsDead || enemy.IsDead) break;

    System.Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);

    System.Console.WriteLine("Enemy turn!");

    int rand = random.Next(0, 2);

    if (rand == 0)
        enemy.Attack(player);

    else
        enemy.Heal();
}
