using UnityEngine;

namespace Exercise_3.Scripts.Balloons
{
    public class BalloonClicker : MonoBehaviour
    {
        [SerializeField] private float _maxDistance = 40;

        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                Physics.Raycast(ray, out RaycastHit hit, _maxDistance);

                Collider hitCollider = hit.collider;
                if (hitCollider != null)
                {
                    hitCollider.gameObject.TryGetComponent(out Balloon balloon);
                    Debug.Log(balloon);
                    balloon.Burst();
                }

                Debug.DrawRay(ray.origin, ray.direction * _maxDistance, Color.yellow);
            }
        }
    }
}
