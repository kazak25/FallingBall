using UnityEngine;

namespace HelixJump.Bar
{
    [CreateAssetMenu(menuName = "HelixJumpClone/Bar/BarSettings")]
    public class BarSettings : ScriptableObject
    { 
        public Material BarDeadZoneMaterial => _barDeadZoneMaterial;
        
        [SerializeField] private Material _barDeadZoneMaterial;
    }
}