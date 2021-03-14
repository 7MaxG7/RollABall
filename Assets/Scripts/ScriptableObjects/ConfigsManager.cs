using System;
using UnityEngine;

namespace MaxG {
    [CreateAssetMenu(fileName = "ConfigsManger", menuName = "Configs/ConfigsManager", order = 151)]
    public class ConfigsManager : ScriptableObject {
        
        public SpawnsConfig SpawnsConfig {
            get {
                if (!_spawnsConfig)
                    _spawnsConfig = Resources.Load<SpawnsConfig>(_spawnsConfigPath);
                if (!_spawnsConfig)
                    throw new Exception($"{this}: spawns config hasn't been loaded");
                
                return _spawnsConfig;
            }
        }
        public MapConfig MapConfig {
            get {
                if (!_mapConfig)
                    _mapConfig = Resources.Load<MapConfig>(_mapConfigPath);
                if (!_mapConfig)
                    throw new Exception($"{this}: map config hasn't been loaded");

                return _mapConfig;
            }
        }

        public LogicConfig LogicConfig {
            get {
                if (!_logicConfig)
                    _logicConfig = Resources.Load<LogicConfig>(_logicConfigPath);
                if (!_logicConfig)
                    throw new Exception($"{this}: logic config hasn't been loaded");

                return _logicConfig;
            }
        }

        public UIConfig UIConfig {
            get {
                if (!_uiConfig)
                    _uiConfig = Resources.Load<UIConfig>(_uiConfigPath);
                if (!_uiConfig)
                    throw new Exception($"{this}: UI config hasn't been loaded");

                return _uiConfig;
            }
        }
        
        [SerializeField] private string _spawnsConfigPath;
        [SerializeField] private string _mapConfigPath;
        [SerializeField] private string _logicConfigPath;
        [SerializeField] private string _uiConfigPath;

        private SpawnsConfig _spawnsConfig;
        private MapConfig _mapConfig;
        private LogicConfig _logicConfig;
        private UIConfig _uiConfig;
    }
}