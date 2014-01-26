using System;
using Assets.Script.Witnesses;
using UnityEngine;

namespace Assets.Script
{
    public class OpenFolder : MonoBehaviour {

        /// <summary>
        /// Reference to the Opened Folder object
        /// </summary>
        public GameObject OpenedFolder;

        /// <summary>
        /// The name of the witness this folder represents
        /// </summary>
        public string WitnessName;

        public void OnMouseDown()
        {
            //hide the closed folder
            //this.gameObject.SetActive(false);

            var parent = this.gameObject.transform.parent.gameObject;

            parent.SetActive(false);

            GameState.Instance().LastFolder = parent;

            GameState.Instance().WitnessToInvestigate = this.GetSuspect(WitnessName);

            //show the opened folder
            OpenedFolder.SetActive(true);
            //TODO: Setup data of the folder here

        }

        private IWitness GetSuspect(string witnessName)
        {
            switch (witnessName)
            {
                case "Caleb":
                    return new DadWitness();

                case "Danny":
                    return new DannyWitness();

                case "Ethan":
                    return new BlindWitness();

                case "Eli":
                    return new HomelessWitness();

                case "Marta":
                    return new HouseKeeperWitness();

                case "Olivia":
                    return new MotherWitness();

                default:
                    throw new Exception("Unexpected Folder!");
            }
        }
    }
}
