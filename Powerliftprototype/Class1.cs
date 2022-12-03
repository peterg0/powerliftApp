using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerliftprototype
{

	public class UserAccount
	{

		public string Username { get; set; }    //username
		public string Password { get; set; }    //pass
		public int UserID { get; set; }         //unique userID

		public List<Mesocycle> mesocycleList = new List<Mesocycle>(); //stores the user's past and current mesocycles

		public UserMaxes userMaxes; //userAccount has a userMaxes

		//constructor--- username, password

		public int getMesoID(Mesocycle mesocycle)
		{
			return mesocycle.mesoID;
		}
		public UserAccount(string username, string password)
		{
			this.Username = username;
			this.Password = password;

			userMaxes = new UserMaxes();
		}

		//convert mesocycle array to list, add a new mesocycle, convert back to array and return the array
		public void createMesocycle()
		{
			mesocycleList.Add(new Mesocycle());

			foreach (Mesocycle c in mesocycleList){
			c.mesoID = mesocycleList.IndexOf(c);
			}

		}
	}

	public class UserMaxes
	{
		//store user's One rep maxes
		public int OneRepMaxSquat { get; set; }
		public int OneRepMaxBench { get; set; }
		public int OneRepMaxDeadlift { get; set; }
		public int OneRepMaxOHP { get; set; }

		public int TMaxSquat { get; set; }
		public int TMaxBench { get; set; }
		public int TMaxDeadlift { get; set; }
		public int TMaxOHP { get; set; }

		private Mesocycle mesocycle; //UserMaxes has a mesocycle associated with it


		//constructor
		public UserMaxes()
		{
			
		}

		//functions to calculate the training max (90% of one rep max) of each lift
		public int SetTMax(int orm)
		{
			decimal d;
			d = (int)(orm * 0.9);
			d = Math.Round(d / 5) * 5;

			return (int)d;
		}

	}
	public class Mesocycle
	{

		public bool isCompleted { get; set; }       //variable to check if mesocycle has been completed

		public int mesoID { get; set; }

		public UserMaxes maxes;                     //Mesocycle has a usermax associated with it

	
		

		//private Microcycle[] microcycles = new Microcycle[] { week1, week2, week3, week4 }; //array to store each week

		//constructor
		public Mesocycle()
		{
			 Microcycle week1 = new Microcycle();
			 Microcycle week2 = new Microcycle();
			 Microcycle week3 = new Microcycle();
			 Microcycle week4 = new Microcycle();
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
	

	//	private TrainingDay[] trainingday = new TrainingDay[] { day1, day2, day3, day4 };//array to store the 4 training days

		//constructor
		public Microcycle()
		{
			TrainingDay day1 = new TrainingDay(1, "Squat");
			TrainingDay day2 = new TrainingDay(2, "Bench");
			TrainingDay day3 = new TrainingDay(3, "Deadlift");
			TrainingDay day4 = new TrainingDay(4, "OHP");
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


