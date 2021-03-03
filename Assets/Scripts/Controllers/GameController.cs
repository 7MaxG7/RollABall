﻿using System.Collections.Generic;

namespace MaxG {
    
    public sealed class GameController : IController, IInitializer, IUpdater, ICleanUper {
        private List<IInitializer> _initializers;
        private List<IUpdater> _updaters;
        private List<ICleanUper> _cleanupers;

        public GameController() {
            _initializers = new List<IInitializer>();
            _updaters = new List<IUpdater>();
            _cleanupers = new List<ICleanUper>();
        }

        public void Add(IController controller) {
            if (controller is IInitializer initController) {
                _initializers.Add(initController);
            }
            if (controller is IUpdater updateController) {
                _updaters.Add(updateController);
            }
            if (controller is ICleanUper trashController) {
                _cleanupers.Add(trashController);
            }
        }

        public void Init() {
            foreach (var initController in _initializers) {
                initController.Init();
            }
        }

        public void DoUpdate() {
            foreach (var updateController in _updaters) {
                updateController.DoUpdate();
            }
        }

        public void CleanUp() {
            foreach (var trashController in _cleanupers) {
                trashController.CleanUp();
            }
        }
    }
    
}

