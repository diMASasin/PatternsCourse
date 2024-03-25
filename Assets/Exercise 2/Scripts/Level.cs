using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class Level
    {
        public event Action Defeat;

        public void Start()
        {
            //������ ������ 
            Debug.Log("StartLevel");
        }

        public void Restart()
        {
            //������ ������� ������
            Start();
        }

        public void OnDefeat()
        {
            //������ ��������� ����
            Defeat?.Invoke();
        }
    }
}
