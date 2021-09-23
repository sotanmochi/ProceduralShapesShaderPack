using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ProceduralShapesShaderPack.Samples
{
    public class StarPolygonDemo : MonoBehaviour
    {
        [SerializeField] private List<Renderer> _targetShapes;
        [SerializeField] private Slider _rotationSlider;
        [SerializeField] private Slider _nSlider;
        [SerializeField] private Slider _stiffnessSlider;
        [SerializeField] private Text _nText;
        [SerializeField] private Text _stiffnessText;

        private List<Material> _materials = new List<Material>();

        private int _rotationPropertyId;
        private int _nPropertyId;
        private int _stiffnessPropertyId;

        void Awake()
        {
            _rotationPropertyId = Shader.PropertyToID("Rotation_Degrees");
            _nPropertyId = Shader.PropertyToID("N");
            _stiffnessPropertyId = Shader.PropertyToID("K");

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

            _stiffnessSlider.onValueChanged.AddListener(value => 
            {
                _stiffnessText.text = value.ToString();
                foreach (var material in _materials)
                {
                    material.SetFloat(_stiffnessPropertyId, value);
                }
            });
        }
    }
}