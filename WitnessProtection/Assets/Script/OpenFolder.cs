using System;
using Assets.Script.Witnesses;
using UnityEngine;

namespace Assets.Script
{
    public struct WitnessNames
    {
        public const string EliName = "Eli";
        public const string CalebName = "Caleb";
        public const string DannyName = "Danny";
        public const string EthanName = "Ethan";
        public const string MartaName = "Marta";
        public const string OliviaName = "Olivia";
    }

    public class OpenFolder : MonoBehaviour 
    {


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

            var witnessToInvestigate = this.GetSuspect(WitnessName);

            GameState.Instance().WitnessToInvestigate = witnessToInvestigate;

            //show the opened folder
            OpenedFolder.SetActive(true);
            //TODO: Setup data of the folder here


            //TextLeft
            //GameObject.Find
            //GameObject.Find("TextLeft").GetComponents<GUIText>().text = witnessToInvestigate.LeftFolderText;
            //TODO: Update the text here
        }

        private IWitness GetSuspect(string witnessName)
        {
            switch (witnessName)
            {
                case WitnessNames.CalebName:
                    return new DadWitness();

                case WitnessNames.DannyName:
                    return new DannyWitness();

                case WitnessNames.EthanName:
                    return new BlindWitness();

                case WitnessNames.EliName:
                    return new HomelessWitness();

                case WitnessNames.MartaName:
                    return new HouseKeeperWitness();

                case WitnessNames.OliviaName:
                    return new MotherWitness();

                default:
                    throw new Exception("Unexpected Folder!");
            }
        }
    }
}
