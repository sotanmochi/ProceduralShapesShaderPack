using UnityEngine;
using UnityEngine.UI;

namespace ProceduralShapesShaderPack.Samples
{
    public class ShapeRotation : MonoBehaviour
    {
        [SerializeField] private Renderer _targetShape;
        [SerializeField] private Slider _slider;

        private Material _material;

        void Awake()
        {
            _material = _targetShape.material;

            _slider.onValueChanged.AddListener(value => 
            {
                _material.SetFloat("Rotation_Degrees", value);
            });
        }
    }
}
