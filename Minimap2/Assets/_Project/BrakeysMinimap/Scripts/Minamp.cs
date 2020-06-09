using UnityEngine;

namespace Scripts
{
    /// <summary>
    /// Put this script in the Minimap Camera
    /// </summary>
    public class Minamp : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private bool fixedNorth;


        private void LateUpdate()
        {
            FollowPlayer(_player);
            RotateMinimap(_player);
        }

        private void RotateMinimap(Transform player)
        {
            transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
        }

        private void FollowPlayer(Transform player)
        {
            Vector3 newPosition = player.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
    }
}