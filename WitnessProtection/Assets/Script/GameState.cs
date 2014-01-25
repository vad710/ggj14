namespace Assets
{
    public class GameState
    {
        private GameState()
        {
            //enforces instantiation via the singleton
        }

        private static GameState _instance;

        public static GameState Instance()
        {
            if (_instance == null)
            {
                _instance = new GameState();
            }

            return _instance;
        }

        public IWitness WitnessToInvestigate { get; private set; }


        public void SwitchToHouseKeeper()
        {
            this.WitnessToInvestigate = new HouseKeeperWitness();
        }

    }
}
