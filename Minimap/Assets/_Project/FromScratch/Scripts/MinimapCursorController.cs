using UnityEngine;

namespace Scripts
{
    public class MinimapCursorController : MonoBehaviour
    {
        [SerializeField] private RectTransform _cursor;
        [SerializeField] private Transform _player;

        private void Update()
        {
            UpdateCompas();
        }

        void UpdateCompas()
        {
            Vector3 rotation = GetPlayerRotation(_player);
            ApplyRotationToCursor(rotation);
        }

        private void ApplyRotationToCursor(Vector3 rotation)
        {
            // need to find a way to propelry translate from Y Axis on 3D --> Z Axis on 2D space
            var rot = Quaternion.Euler(0f, 0f, -rotation.y);
           _cursor.localRotation = rot;
           
        }

        private Vector3 GetPlayerRotation(Transform t)
        {
            return t.eulerAngles;
        }
    }
}