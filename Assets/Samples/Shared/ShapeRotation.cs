using UnityEngine;
using UnityEngine.UI;

namespace ProceduralShapesShaderPack.Samples
{
    public class ShapeRotation : MonoBehaviour
    {
        [SerializeField] private Renderer _targetShape;
        [SerializeField] private Slider _slider;

        private Material _material;
        private int _rotationPropertyId;

        void Awake()
        {
            _rotationPropertyId = Shader.PropertyToID("Rotation_Degrees");
            _material = _targetShape.material;

            _slider.onValueChanged.AddListener(value => 
            {
                _material.SetFloat(_rotationPropertyId, value);
            });
        }
    }
}
