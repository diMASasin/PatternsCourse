using Exercise_3.Scripts.GameModes;

namespace Exercise_3.Scripts.Loader
{
    public class LevelLoadingData 
    {
        public GameMode GameMode { get; private set; }

        public LevelLoadingData(GameMode gameMode) 
            => GameMode = gameMode;
    }
}
