using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ProceduralShapesShaderPack.Samples
{
    public class RoseDemo : MonoBehaviour
    {
        [SerializeField] private List<Renderer> _targetShapes;
        [SerializeField] private Slider _rotationSlider;
        [SerializeField] private Slider _nSlider;
        [SerializeField] private Slider _powerSlider;
        [SerializeField] private Text _nText;
        [SerializeField] private Text _powerText;

        private List<Material> _materials = new List<Material>();

        private int _rotationPropertyId;
        private int _nPropertyId;
        private int _powerPropertyId;

        void Awake()
        {
            _rotationPropertyId = Shader.PropertyToID("Rotation_Degrees");
            _nPropertyId = Shader.PropertyToID("N");
            _powerPropertyId = Shader.PropertyToID("Power");

            foreach (var renderer in _targetShapes)
            {
                _materials.Add(renderer.material);
            }

            _rotationSlider.onValueChanged.AddListener(value =>
            {
                foreach (var material in _materials)
                {
                    material.SetFloat(_rotationPropertyId, value);
                }
            });

            _nSlider.onValueChanged.AddListener(value => 
            {
                _nText.text = ((int)value).ToString();
                foreach (var material in _materials)
                {
                    material.SetFloat(_nPropertyId, value);
                }
            });

            _powerSlider.onValueChanged.AddListener(value => 
            {
                _powerText.text = value.ToString();
                foreach (var material in _materials)
                {
                    material.SetFloat(_powerPropertyId, value);
                }
            });
        }
    }
}