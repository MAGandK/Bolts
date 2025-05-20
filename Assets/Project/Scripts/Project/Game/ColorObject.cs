using UnityEngine;

namespace Project.Game
{
    public class ColorObject : MonoBehaviour
    {
        [SerializeField] private ColorType _colorType;

        public ColorType ColorType => _colorType;
    }
}