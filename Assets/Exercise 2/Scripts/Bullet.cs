using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private float _speed = 1;

    private bool _launched = false;

    private void Update()
    {
        if(_launched == true)
            transform.Translate(_speed * Time.deltaTime * Vector3.left);
    }

    public void Launch(Vector3 spawnPosition, Quaternion spawnRotation)
    {
        transform.position = spawnPosition;
        transform.rotation = spawnRotation;
        _launched = true;
    }
}
