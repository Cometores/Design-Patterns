using EnemiesFactoryMethod;

Console.Title = "Enemies Factory Method";

var spawners = new List<ISpawner>()
{
    new WalkingEnemySpawner(),
    new FlyingEnemySpawner()
};

foreach (var spawner in spawners)
{
    IEnemy enemy = spawner.SpawnEnemy();
    enemy.ChasePlayer();
}