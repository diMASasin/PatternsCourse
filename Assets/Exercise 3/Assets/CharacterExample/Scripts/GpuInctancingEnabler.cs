using UnityEngine;

namespace Exercise_3.Assets.CharacterExample.Scripts
{
    [RequireComponent(typeof(MeshRenderer))]
    public class GpuInctancingEnabler : MonoBehaviour
    {
        private void Awake()
        {
            MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.SetPropertyBlock(materialPropertyBlock);
        }
    }
}
