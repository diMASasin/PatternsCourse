using System;
using System.Drawing.Printing;
using UnityEngine;

namespace Excercise_5.Scripts
{
    [Serializable]
    public class CharacterStats
    {
        [field: SerializeField] public int Strength { get; private set; }
        [field: SerializeField] public int Intelligence { get; private set; }
        [field: SerializeField] public int Agility { get; private set; }

        public CharacterStats(int strength, int intelligence, int agility)
        {
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
        }

        public static CharacterStats operator +(CharacterStats stat, CharacterStats additional)
        {
            return new CharacterStats(
                stat.Strength + additional.Strength,
                stat.Intelligence + additional.Intelligence, 
                stat.Agility + additional.Agility
                );
        }

        public static CharacterStats operator *(CharacterStats stat, CharacterStats additional)
        {
            return new CharacterStats(
                stat.Strength * additional.Strength,
                stat.Intelligence * additional.Intelligence,
                stat.Agility * additional.Agility
                );
        }

        public void Print()
        {
            Debug.Log($"Strength: {Strength} Intelligence: {Intelligence} Agility: {Agility}");
        }
    }
}