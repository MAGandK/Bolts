using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Project.Game
{
    public class ColorStackController : MonoBehaviour
    {
        [SerializeField] private int _capacity;
        
        private int _colorObjectIndex;
        private bool _isComplete = false;
        
        private Stack<ColorObject> _colorObjects;
        
        public bool IsComplete => _isComplete;

        private void Awake()
        {
            _colorObjects = new Stack<ColorObject>(_capacity);
        }

        public List<ColorObject> GetSameColorObjects()
        {
            if (_colorObjects.Count <= 0)
            {
                return null;
            }

            var result = new List<ColorObject>();

            ColorObject currentObject;
            
            do
            {
                currentObject = _colorObjects.Pop();
                result.Add(currentObject);
            } while (currentObject.ColorType == _colorObjects.Peek().ColorType);

            return result;
        }

        public void AddSameColorObject(List<ColorObject> newObjects)
        {
            var colorObject = newObjects[0];

            if (newObjects.Any(x => x.ColorType != colorObject.ColorType))
            {
                return;
            }

            foreach (var newObject in newObjects)
            {
                _colorObjects.Push(newObject);
            }
        }

        private void CheckState()
        {
            if (_colorObjects.Count != _capacity)
            {
                return;
            }

            var colorObject = _colorObjects.Peek();
            
            _isComplete = _colorObjects.All(x => x.ColorType == colorObject.ColorType);
        }
    }
}