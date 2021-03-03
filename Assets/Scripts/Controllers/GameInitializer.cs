namespace MaxG {
    
    public sealed class GameInitializer {
        
        public GameInitializer(GameController gameController) {
            gameController.Add(new TrapsController());
        }

    }
}