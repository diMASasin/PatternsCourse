using UnityEngine;

namespace Excercise_3.Scripts
{
    public class SpawnArea
    {
        private readonly int _triesToFindPosition;
        private readonly Transform _parent;
        private readonly float _radius;
        private readonly Color _gizmosColor;

        public SpawnArea(int triesToFindPosition, Transform parent, float radius, Color gizmosColor)
        {
            _triesToFindPosition = triesToFindPosition;
            _parent = parent;
            _radius = radius;
            _gizmosColor = gizmosColor;
        }

        public Vector3 GetAvailablePoint(float radius)
        {
            Vector3 spawnPoint;
            int triesToFindPosition = _triesToFindPosition;
            bool isSphereIntersect;

            do
            {
                spawnPoint = Random.insideUnitSphere * _radius;
                spawnPoint.y = 0;
                spawnPoint += _parent.position;

                isSphereIntersect = Physics.CheckSphere(spawnPoint, radius);
                triesToFindPosition--;
            } while (isSphereIntersect == true && triesToFindPosition > 0);

            if (triesToFindPosition == 0)
                Debug.LogWarning(
                    $"Coins intersect. Spawn radius ({nameof(_radius)}) or {nameof(_triesToFindPosition)} too small");

            return spawnPoint;
        }

        public void DrawGizmoDisk(Transform transform, float radius)
        {
            Matrix4x4 oldMatrix = Gizmos.matrix;
            Gizmos.color = _gizmosColor;
            var gizmosScaling = new Vector3(1, 0.01f, 1);
            Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, gizmosScaling);
            Gizmos.DrawSphere(Vector3.zero, radius);
            Gizmos.matrix = oldMatrix;
        }
    }
}