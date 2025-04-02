namespace lab3;

class Program
{
    static void Main()
    {
        BreakableWall bw = new BreakableWall();

        Enemy enemy = new Enemy();

        Bullet bullet = new Bullet(2);

        bullet.HitTarget(bw);

        bullet.HitTarget(enemy);
        bullet.HitTarget(enemy);
        bullet.HitTarget(enemy);
    }
}