using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerliftprototype
{

	public static class ballsstatic
	{
		public static string ballsstring = "balls";
	}
	public class UserAccount
	{
		
		public string Username { get; set; }    //username
		public string Password { get; set; }    //pass
		public int UserID { get; set; }         //unique userID



		public Mesocycle[] mesocyclesArray; //stores the user's past and current mesocycles

		public UserMaxes userMaxes; //userAccount has a userMaxes

		//constructor--- username, password


		public UserAccount(string username, string password)
		{
			Username = username;
			Password = password;
		}

		//convert mesocycle array to list, add a new mesocycle, convert back to array and return the array
		private Mesocycle[] createMesocycle(UserMaxes maxes)
		{
			return mesocyclesArray;
		}
	}

	public class UserMaxes
	{
		//store user's One rep maxes
		public int OneRepMaxSquat { get; set; }
		public int OneRepMaxBench { get; set; }
		public int OneRepMaxDeadlift { get; set; }
		public int OneRepMaxOHP { get; set; }

		private Mesocycle mesocycle; //UserMaxes has a mesocycle associated with it


		//constructor
		public UserMaxes(int oneRepMaxSquat, int oneRepMaxBench, int oneRepMaxDeadlift, int oneRepMaxOHP)
		{
			OneRepMaxSquat = oneRepMaxSquat;
			OneRepMaxBench = oneRepMaxBench;
			OneRepMaxDeadlift = oneRepMaxDeadlift;
			OneRepMaxOHP = oneRepMaxOHP;
		}

		//functions to calculate the training max (90% of one rep max) of each lift
		public int calculateTMax_Squat(int orm)
		{
			orm = OneRepMaxSquat;
			orm = (int)(orm * 0.9);
			return orm;
		}
		public int calculateTMax_Bench(int orm)
		{
			orm = OneRepMaxBench;
			orm = (int)(orm * 0.9);
			return orm;
		}
		public int calculateTMax_Deadlift(int orm)
		{
			orm = OneRepMaxDeadlift;
			orm = (int)(orm * 0.9);
			return orm;
		}
		public int calculateTMax_OHP(int orm)
		{
			orm = OneRepMaxOHP;
			orm = (int)(orm * 0.9);
			return orm;
		}
	}
	public class Mesocycle
	{

		public bool isCompleted { get; set; }       //variable to check if mesocycle has been completed

		public UserMaxes maxes;                     //Mesocycle has a usermax associated with it

		//composition, create 4 microcycle objects
		static Microcycle week1 = new Microcycle(1);
		static Microcycle week2 = new Microcycle(2);
		static Microcycle week3 = new Microcycle(3);
		static Microcycle week4 = new Microcycle(4);

		private Microcycle[] microcycles = new Microcycle[] { week1, week2, week3, week4 }; //array to store each week

		//constructor
		public Mesocycle(UserMaxes maxes)
		{
			this.maxes = maxes;
		}

		//check if all 4 microcycles are completed
		public void MicrocyclesCompleted()
		{

		}
	}

	public class Microcycle
	{

		public int WeekNumber { get; set; } //week number to differentiate each week (week1,week2,week3,week4)



		//each microcycle(each week) has 4 trainingDays
		static TrainingDay day1 = new TrainingDay(1, "Squat");
		static TrainingDay day2 = new TrainingDay(2, "Bench");
		static TrainingDay day3 = new TrainingDay(3, "Deadlift");
		static TrainingDay day4 = new TrainingDay(4, "OHP");

		private TrainingDay[] trainingday = new TrainingDay[] { day1, day2, day3, day4 };//array to store the 4 training days

		//constructor
		public Microcycle(int weekNumber)
		{
			WeekNumber = weekNumber;
		}
	}

	public class TrainingDay
	{
		public int dayNumber { get; set; } //daynumber to differntiate the training days (day1,day2,day3,day4)
		public int MainliftWeight { get; set; } //stores the prescribed weight of the main lift
		public bool isCompleted { get; set; } //check if day (or workout) is completed

		public string MainLiftName { get; set; } //stores the mainlift name (squat, bench, deadlift, Overhead press)

		public MainLift mainlift; //trainingday has a mainlift

		public AccessoryLift[] accessoryLift;//create array to store user's accessory lifts

		//constructor
		public TrainingDay(int dayNumber, string mainLiftName)
		{
			this.dayNumber = dayNumber;
			this.isCompleted = isCompleted;
			MainLiftName = mainLiftName;
		}

		private void createAccessoryLift(AccessoryLift accessoryLift)
		{

		}



	}

	public class AccessoryLift
	{

		public string exerciseName { get; set; }

		private Set[] set { get; set; } //accessorylift has a set

		private AccessoryLift(string exerciseName, Set[] set)
		{
			this.exerciseName = exerciseName;
			this.set = set;
		}
	}

	public class MainLift
	{

		public string MainLiftName { get; set; }

		private Set[] set { get; set; }

		private MainLift(string MainLiftName, Set[] set)
		{
			this.MainLiftName = MainLiftName;
			this.set = set;
		}
	}

	public class Set
	{

		public int reps { get; set; }
		public int weight { get; set; }
		public double percentOfMax { get; set; }

		public Set(int reps, int weight)
		{
			this.reps = reps;
			this.weight = weight;
		}

		public Set(int reps, int weight, double percentOfMax)
		{
			this.reps = reps;
			this.weight = weight;
			this.percentOfMax = percentOfMax;
		}

		public double calculateWeight(int orm, double percent)
		{
			int weight;
			weight = (int)(orm * percent);
			return weight;
		}
	}
}


