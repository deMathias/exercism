using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        /*
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
        */
        //Spy: the group can be spied upon if at least one of them is awake. Otherwise, spying is a waste of time. so || instead of && as in the previous solution because we approach the problem different.
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        /*
        if(!archerIsAwake && prisonerIsAwake){
            return true;
        }
        else{
            return false;
        }
        */
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && !archerIsAwake)
        {
            return true;
        }
        else if (!petDogIsPresent && !archerIsAwake && !knightIsAwake && prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
