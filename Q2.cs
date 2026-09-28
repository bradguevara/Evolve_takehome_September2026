/*Question 2
Write an object oriented class system to accommodate the following
requirements. You can supplement some logic with comments in order to
complete this question within the time constraints (as needed).
Suppose there are 3 types of vehicles: cars, motorcycles, and buses. Each
type of vehicle has the following public properties:
Make and model
Number of wheels
Length
Weight
Max number of passengers
Additionally, there are 2 places a vehicle can park: parking lot and a parking
garage. Both lots and garages have a set number of spaces for each
location, but each type differs in the following ways:
Lots can accommodate any type of vehicle; however, garages can only
accommodate cars and motorcycles.
Garages (only) have "compact only" spaces in addition to normal
spaces where only vehicles weighing less than 1,500 can park. When
possible, compact spaces should be utilized before a normal space.*/


//vehicles
using System.Security.Cryptography.X509Certificates;

public class vehicles
{
    public string Make {set; get;}
    public string Model {set;get;}
    public int Num_Wheels {set; get;}
    public double Length {set; get;}
    public double Weight {set; get;}
    public int Max_Passengers {set; get;}


}

public class Car: vehicles {}
public class Bus: vehicles {}
public class Motorcicle: vehicles {}

//parking

public class parkingLot
{
    public int spaces {set; get;}
    public int spaces_used = 0;

    public park(vehicles v)
    {
        //if spaces used < spaces
        //spaces_used++;
        //return true;
        //else{
        //return false;}
    }

}
public class Garage{
    public int Normal_Spaces {set; get;}
    public int Compact_Spaces {set; get;}
    public int Nspaces_used = 0;
    public int Cspaces_used = 0;

    public park(vehicles v)
    {
        //if vehicle ==  Bus return false;

        if (vehicle weight < 1500 and Cspaces_used < compact_Sapces)
        {
            Cspaces_used++;
            return true;
        }
        elif (Nspaces_used < Normal_Spaces)
        {
            Nspaces_used++;
            return true;
        } else
        {
            return false;
        }
    }


}