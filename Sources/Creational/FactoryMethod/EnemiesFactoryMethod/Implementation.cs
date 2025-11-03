namespace EnemiesFactoryMethod;

/// <summary>
/// Product
/// </summary>
public interface IEnemy
{
    public void ChasePlayer();
}

/// <summary>
/// Concrete product
/// </summary>
public class WalkingEnemy : IEnemy
{
    public void ChasePlayer()
    {
        Console.WriteLine("Enemy walks towards the player");
    }
}

/// <summary>
/// Concrete product
/// </summary>
public class FlyingEnemy : IEnemy
{
    public void ChasePlayer()
    {
        Console.WriteLine("Enemy flies towards the player");
    }
}

/// <summary>
/// Creator
/// </summary>
public interface ISpawner
{
    public IEnemy SpawnEnemy();
}

/// <summary>
/// Concrete creator
/// </summary>
public class WalkingEnemySpawner : ISpawner
{
    public IEnemy SpawnEnemy()
    {
        /* Logic for walking enemy spawn */
        return new WalkingEnemy();
    }
}

/// <summary>
/// Concrete creator
/// </summary>
public class FlyingEnemySpawner : ISpawner
{
    public IEnemy SpawnEnemy()
    {
        /* Logic for flying enemy spawn */
        return new FlyingEnemy();
    }
}