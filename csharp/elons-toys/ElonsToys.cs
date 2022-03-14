using System;

class RemoteControlCar
{
    public int intMetersDriven = 0;
    public int intBatteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        var someCar = new RemoteControlCar();
        return someCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {intMetersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (intBatteryPercentage != 0)
        {
            return $"Battery at {intBatteryPercentage}%";
        }
        else
        {
            return $"Battery empty";
        }
    }

    public void Drive()
    {
        if(intBatteryPercentage == 0)
        {
            return;
        }
        else 
        {
            intMetersDriven += 20;
            intBatteryPercentage -= 1;
        }        
    }
}
