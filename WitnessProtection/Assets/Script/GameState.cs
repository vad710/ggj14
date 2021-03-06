﻿using System;
using UnityEngine;

namespace Assets.Script
{
    public class GameState
    {
        private GameState()
        {
            //enforces instantiation via the singleton
			this.previousSceneString = "";
            this.DetectiveNotebook = new Notebook();
			this.CalebUnlocked = false;
			this.EliUnlocked = false;
			this.DannyUnlocked = false;
        }

        private static GameState _instance;
        private bool _resolutionSet ;


        public static GameState Instance()
        {
            if (_instance == null)
            {
                _instance = new GameState();
            }

            return _instance;
        }

        public GameObject LastFolder { get; set; }

		public string previousSceneString { get; set; }
		public bool CalebUnlocked { get; set; }
		public bool EliUnlocked { get; set; }
		public bool DannyUnlocked { get; set; }

		[Obsolete]
        public Notebook DetectiveNotebook { get; private set; }

        public IWitness WitnessToInvestigate { get; set; }

        public void SetupResolution()
        {
            if (!_resolutionSet)
            {
                Debug.Log("Resolution Set!");

                Screen.SetResolution(1500, 1000, true);
                _resolutionSet = true;
            }
        }

    }
}
