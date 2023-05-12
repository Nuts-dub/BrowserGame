using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace platformerMVC
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private LevelObjectView _playerView;
        private PlayerController _playerController;

        private void Awake()
        {
            _playerController = new PlayerController(_playerView);
        }

        void Update()
        {
            _playerController.Update();
        }
    }
}