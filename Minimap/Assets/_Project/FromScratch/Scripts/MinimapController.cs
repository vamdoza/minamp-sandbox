using UnityEngine;

namespace Scripts
{
    public class MinimapController : MonoBehaviour
    {
        [SerializeField] private RectTransform _map;
        [SerializeField] private Transform _player;

        [SerializeField] private Rect _worldMap = new Rect(new Vector2(0, 0), new Vector2(50, 50));

        void Update()
        {
            UpdateMapPos();
        }

        private void UpdateMapPos()
        {
            var rect = _map.rect;
            _map.localPosition = GetMapPosBasedOnPlayerPos(rect, _player.position);
        }

        private Vector3 GetMapPosBasedOnPlayerPos(Rect map, Vector3 player)
        {
            var xmap = CalcMapCoord(-player.x, _worldMap.width, map.width);
            var ymap = CalcMapCoord(-player.z, _worldMap.height, map.height);

            return new Vector3(xmap, ymap);
        }

        private float CalcMapCoord(float x, float worldWidth, float mapWidth)
        {
            return ((x / worldWidth) * mapWidth) * 0.5f;
        }
    }
}