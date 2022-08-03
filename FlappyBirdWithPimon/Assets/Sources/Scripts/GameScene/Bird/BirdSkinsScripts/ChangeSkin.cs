using UnityEngine;
using UnityEngine.UI;

namespace Sources.Scripts.GameScene.Bird.BirdSkinsScripts
{
    public class ChangeSkin : MonoBehaviour
    {
        [SerializeField] private Sprite[] _skins;
        [SerializeField] private SpriteRenderer _playerSpriteRenderer;

        public void SetSkinPirate()
        {
            _playerSpriteRenderer.sprite = _skins[0];
        }
    }
}
