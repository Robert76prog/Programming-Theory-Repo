using UnityEngine;

//INHERITANCE
public class Bus : Vehicle 
{
    protected override void Awake()
    {
        Speed = 4;
        Acceleration = 8;
        AngularSpeed = 120;
        base.Awake();
    }

    public override void GoTo(Stand target)
    {
        BusStand busStand = target as BusStand;
        if (busStand != null)
        {
            base.GoTo(target);
        }
    }
    public override void GoTo(Vector3 position)
    {
        //only goto Bus Station
        //base.GoTo(position);
    }
}
