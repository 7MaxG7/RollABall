using System;
using UnityEngine;

namespace MaxG {
    
    [CreateAssetMenu(fileName = "SpawnsConfig", menuName = "Configs/SpawnsConfig", order = 154)]
    public class SpawnsConfig : ScriptableObject {

#region Ball Properties
        public string BallSpawnPointTag => _ballSpawnPointTag;
        public GameObject BallPref {
            get {
                if (!_ballPref)
                    _ballPref = Resources.Load<GameObject>(_ballPrefPath);
                if (!_ballPref)
                    throw new Exception($"{this}: trap prefab hasn't been loaded");

                return _ballPref;
            }
        }
#endregion
        
#region Traps Properties
        public string TrapSpawnPointTag => _trapSpawnPointTag;
        public GameObject TrapPref {
            get {
                if (!_trapPref)
                    _trapPref = Resources.Load<GameObject>(_trapPrefPath);
                if (!_trapPref)
                    throw new Exception($"{this}: trap prefab hasn't been loaded");

                return _trapPref;
            }
        }
        public Vector3 TrapInstatiationRotation => _trapInstatiationRotation;
#endregion
        
#region Bonuses Properties
        public string BonusSpawnPointTag => _bonusSpawnPointTag;
        public GameObject BonusPref {
            get {
                if (!_bonusPref)
                    _bonusPref = Resources.Load<GameObject>(_bonusPrefPath);
                if (!_bonusPref)
                    throw new Exception($"{this}: bonus prefab hasn't been loaded");

                return _bonusPref;
            }
        }
        public Vector3 BonusInstatiationRotation => _bonusInstatiationRotation;
#endregion
        
        
        [Header("Ball spawn config")]
        [SerializeField] private string _ballSpawnPointTag;
        [SerializeField] private string _ballPrefPath;

        [Header("Traps spawn config")]
        [SerializeField] private string _trapSpawnPointTag;
        [SerializeField] private string _trapPrefPath;
        [SerializeField] private Vector3 _trapInstatiationRotation;

        [Header("Bonuses spawn config")]
        [SerializeField] private string _bonusSpawnPointTag;
        [SerializeField] private string _bonusPrefPath;
        [SerializeField] private Vector3 _bonusInstatiationRotation;

        private GameObject _trapPref;
        private GameObject _bonusPref;
        private GameObject _ballPref;
    }
}