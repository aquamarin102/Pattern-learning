using UnityEngine;

namespace Zoork.Weapon
{
    public class BulletBuilder : MonoBehaviour
    {
        [SerializeField]
        private Sprite _view;


        [ContextMenu("Test Builder")]
        private void TestBuilder()
        {
            var gameObjectBuilder = new GameObjectBuilder();

            var buildResult = gameObjectBuilder
                .Visual
                .Name("Builder")
                .Sprite(_view)
                .Physics
                .Rigidbody2D(1f)
                .BoxCollider2D();

            Debug.Log("BuilderExample.TestBuilder: buildResult = " + buildResult);
        }

    }
}
