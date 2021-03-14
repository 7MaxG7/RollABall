namespace MaxG {
    
    public class StringsKiller {
        
        public class Tag {
            public string trapSpawnPoint = "TrapSpawnPoint";
            public string bonusSpawnPoint = "BonusSpawnPoint";
            public string ballSpawnPoint = "BallSpawnPoint";
        }

        public class Path {
            public string winScreenPref = "Prefs/WinScreen";
            public string trapPref = "Prefs/Trap";
            public string labirinthPref = "Prefs/Labirinth";
        }

        public StringsKiller() {
            tag = new Tag();
            path = new Path();
        }

        public Tag tag;
        public Path path;

    }
}