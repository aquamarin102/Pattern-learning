using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoork
{
    public class GameObjectBuilder : MonoBehaviour
    {
        protected GameObject _gameObject;

        public GameObjectBuilder()
        {
            _gameObject = new GameObject();
        }

        protected GameObjectBuilder(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        
        public GameObjectVisualBuilder Visual => new GameObjectVisualBuilder(_gameObject);
        public GameObjectPhysicsBuilder Physics => new GameObjectPhysicsBuilder(_gameObject);

        // "Builder могу присвоить GameObject'у"
        public static implicit operator GameObject(GameObjectBuilder builder)
        {
            return builder._gameObject;
        }

        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }

            return result;
        }
        
    }

    public class GameObjectVisualBuilder : GameObjectBuilder
    {
        public GameObjectVisualBuilder(GameObject gameObject) : base(gameObject)
        {
        }

        public GameObjectVisualBuilder Name(string name)
        {
            _gameObject.name = name;
            return this;
        }

        public GameObjectVisualBuilder Sprite(Sprite sprite)
        {
            var component = GetOrAddComponent<SpriteRenderer>();
            component.sprite = sprite;
            return this;
        }

        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }

            return result;
        }
    }
    
    public class GameObjectPhysicsBuilder : GameObjectBuilder
    {
        public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject)
        {
        }

       
        
        public GameObjectPhysicsBuilder BoxCollider2D()
        {
            GetOrAddComponent<BoxCollider2D>();
            return this;
        }
        public GameObjectPhysicsBuilder Rigidbody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return this;
        }
        
        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }

            return result;
        }
    }
    
    
}
