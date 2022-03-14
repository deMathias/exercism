using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] intArrayLastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return intArrayLastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int numberOfBirds = 0;
        for(int i = 0; i < numberOfDays; i++)
        {
            numberOfBirds += birdsPerDay[i];
        }
        return numberOfBirds;
    }

    public int BusyDays()
    {
        int amountOfBusyDays = 0;
        foreach(int amountOfBirds in birdsPerDay)
        {
            if(amountOfBirds >= 5)
            {
                amountOfBusyDays += 1;
            }
        }
        return amountOfBusyDays;
    }
}
