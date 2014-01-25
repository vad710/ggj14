using Assets.Script.Witnesses;

namespace Assets.Script
{
    public class GameState
    {
        private GameState()
        {
            //enforces instantiation via the singleton
			this.previousSceneString = "";
            this.DetectiveNotebook = new Notebook();
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

		public string previousSceneString { get; set; }

        public Notebook DetectiveNotebook { get; private set; }

        public IWitness WitnessToInvestigate { get; private set; }


        public void SwitchToHouseKeeper()
        {
            this.WitnessToInvestigate = new HouseKeeperWitness();
        }

		public void SwitchToBlind()
		{
			this.WitnessToInvestigate = new BlindWitness();
		}

		public void SwitchToHomeless()
		{
			this.WitnessToInvestigate = new HomelessWitness();
		}

		public void SwitchToMother()
		{
			this.WitnessToInvestigate = new MotherWitness();
		}


        public string SampleData { get; set; } //TODO: remove this!

    }
}
