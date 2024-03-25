using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private int _objectsNumber = 10;
    [SerializeField] private Bullet _template;
    [SerializeField] private Transform _container;

    private List<Bullet> _objects = new();

    public void Start()
    {
        for (int i = 0; i < _objects.Count; i++)
            CreateObject();
    }

    private Bullet CreateObject()
    {
        var newObject = Instantiate(_template, _container);
        _objects.Add(newObject);
        newObject.gameObject.SetActive(false);

        return newObject;
    }

    public Bullet GetFreeObject()
    {
        var freeObject = _objects.FirstOrDefault(obj => !obj.gameObject.activeInHierarchy);
        freeObject ??= CreateObject();
        StartCoroutine(RemoveWithDelay(freeObject));

        return freeObject;
    }

    private IEnumerator RemoveWithDelay(Bullet bullet)
    {
        yield return new WaitForSeconds(10);
        bullet.gameObject.SetActive(false);
        bullet.transform.rotation = Quaternion.identity;
    }
}