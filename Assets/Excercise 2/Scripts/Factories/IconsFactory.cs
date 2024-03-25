using Excercise_2.Scripts;
using Excercise_2.Scripts.Resources;
using UnityEngine;


public abstract class IconsFactory : ScriptableObject
{
    [field: SerializeField] protected ResourcesConfig Config { get; private set; }

    public abstract Resource GetCoin();
    public abstract Resource GetEnergy();
}
