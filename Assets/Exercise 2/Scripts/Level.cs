using UnityEngine;

namespace Exercise_2.Scripts
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private Player _player;

        public void Restart()
        {
            _player.Reset();
        }
    }
}