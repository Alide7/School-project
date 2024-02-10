using UnityEngine;

public class OOP : MonoBehaviour
{
	private void Start()
	{
		Animal dog1 = new Dog("Бобик");
		Animal dog2 = new Dog("Лайка");

		dog2.MakeSound
	}
}
public abstract class Animal
{
	protected string name;
	public Animal(string name)
	{
		this.name=name;
	}
	public virtual void MakeSound()
	{
		Debug.Log($"{name} makes a sound.")
	}
} 

public class Dog : Animal
{
	public static int dogCount = 0
	public Dog(string name): base(name)
	{
		dogCount++;
	}
	public override void MakeSound()
	{
		Debug.Log($"{name} barks.");
	}
	public static void PrintHowManyDogs()
	{
		Debug.Log($"There are{dogCount} dogs.")
	}
}

public interface ISwiming
{
	void Swim();
}

public class Duck : Animal, ISwiming
{
	public Duck(string name) : base(name) {}
	public override void MakeSound()
	{
		Debug.Log($"(name) guacks.");
	}
	public void Swim()
	{
		Debug.Log($"(name) swims.");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Dog dog = new Dog("Rex");
		dog.MakeSound();
		dog.PrintHowManyDogs();

		Duck duck = new Duck("Donald");
		duck.MakeSound();
		duck.PrintHowManyDogs();
	}
}