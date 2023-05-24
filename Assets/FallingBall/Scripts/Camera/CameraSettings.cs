using UnityEngine;

namespace HelixJump.Camera
{
    [CreateAssetMenu(menuName = "HelixJumpClone/Camera/CameraSettings")]
    public class CameraSettings : ScriptableObject
    {
        public float CameraPosition { get { return _cameraPosition; } set { _cameraPosition = value; } }
        public float CameraMoveSmooth { get { return _cameraMoveSmooth; } set { _cameraMoveSmooth = value; } }
        
        [SerializeField] private float _cameraPosition;
        [SerializeField] private float _cameraMoveSmooth;
    }
}