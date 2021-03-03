namespace MaxG {
    
    public class StringsKiller {
        
        public class Tag {
            public string trapSpawnPoint = "TrapSpawnPoint";
        }

        public class Path {
            public string prefsFolder = "Prefs/";
            public string winScreenName = "WinScreen";
        }

        public StringsKiller() {
            tag = new Tag();
            path = new Path();
        }

        public Tag tag;
        public Path path;

    }
}