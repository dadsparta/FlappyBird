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

        public void SetSkinUnformal()
        {
            _playerSpriteRenderer.sprite = _skins[1];
        }

        public void SetSkinBlueBird()
        {
            _playerSpriteRenderer.sprite = _skins[2];
        }

        public void SetSkinGreenBird()
        {
            _playerSpriteRenderer.sprite = _skins[3];
        }

        public void SetSkinPinkBird()
        {
            _playerSpriteRenderer.sprite = _skins[4];
        }

        public void SetIdleSkin()
        {
            _playerSpriteRenderer.sprite = _skins[5];
        }
    }
}
