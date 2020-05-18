using MegaManGame.Enemies;
using Microsoft.Xna.Framework;
using System.Xml;

namespace MegaManGame
{
    class LevelLoader : ILevelLoader
    {
        private string LevelName;

        public LevelLoader(string levelName)
        {
            this.LevelName = levelName;
        }

        private void CreateBlock(XmlNode node, ILevel level)
        {
            string xLocation = node["XLocation"].InnerText;
            string yLocation = node["YLocation"].InnerText;
            Vector2 location = new Vector2(int.Parse(xLocation), int.Parse(yLocation));

            switch (node["Name"].InnerText)
            {
                case "GutsManYellowBlock":
                    level.AddBlock(new GutsManYellowBlock(location));
                    break;
                case "HorizSteelBlock":
                    level.AddBlock(new HorizSteelBlock(location));
                    break;
                case "VertSteelBlock":
                    level.AddBlock(new VertSteelBlock(location));
                    break;
                case "LeftVertSteelBlock":
                    level.AddBlock(new LeftVertSteelBlock(location));
                    break;
                case "RightVertSteelBlock":
                    level.AddBlock(new RightVertSteelBlock(location));
                    break;
                case "SpikeSteelBlock":
                    level.AddBlock(new SpikeSteelBlock(location));
                    break;
                case "SupportBeamSteelBlock":
                    level.AddBlock(new SupportBeamSteelBlock(location));
                    break;
                case "YellowBlock":
                    level.AddBlock(new YellowBlock(location));
                    break;
                default:
                    break;
            }
        }

        private void CreateEnemy(XmlNode node, ILevel level)
        {
            string xLocation = node["XLocation"].InnerText;
            string yLocation = node["YLocation"].InnerText;
            Vector2 location = new Vector2(int.Parse(xLocation), int.Parse(yLocation));

            switch (node["Name"].InnerText)
            {
                case "GreenFlyingEnemy":
                    level.AddEnemy(new GreenFlyingEnemy(location));
                    break;
                case "BluePogoEnemy":
                    level.AddEnemy(new BluePogoEnemy(location));
                    break;
                case "YellowHelmetEnemy":
                    level.AddEnemy(new YellowHelmetEnemy(location));
                    break;
                case "YellowMinerEnemy":
                    level.AddEnemy(new YellowMinerEnemy(location));
                    break;
                case "GutsMan":
                    level.AddEnemy(new GutsMan(location));
                    break;
                default:
                    break;
            }
        }

        private void CreateItem(XmlNode node, ILevel level)
        {
            string xLocation = node["XLocation"].InnerText;
            string yLocation = node["YLocation"].InnerText;
            Vector2 location = new Vector2(int.Parse(xLocation), int.Parse(yLocation));

            switch (node["Name"].InnerText)
            {
                case "EndOrangeRailing":
                    level.AddItem(new EndOrangeRailing(location));
                    break;
                case "GreenPlatform":
                    level.AddItem(new GreenPlatform(location));
                    break;
                case "SkinnyOrangeRailing":
                    level.AddItem(new SkinnyOrangeRailing(location));
                    break;
                case "ThickOrangeRailing":
                    level.AddItem(new ThickOrangeRailing(location));
                    break;
                default:
                    break;
            }
        }

        private void CreateBackground(XmlNode node, ILevel level)
        {
            string xLocation = node["XLocation"].InnerText;
            string yLocation = node["YLocation"].InnerText;
            Vector2 location = new Vector2(int.Parse(xLocation), int.Parse(yLocation));

            switch (node["Name"].InnerText)
            {
                case "BigMountain1":
                    level.AddBackground(new BigMountain1(location));
                    break;
                case "BigMountain2":
                    level.AddBackground(new BigMountain2(location));
                    break;
                case "Cloud1":
                    level.AddBackground(new Cloud1(location));
                    break;
                default:
                    break;
            }
        }

        public void LoadLevel(ILevel level)
        {
            XmlDocument levelFile = new XmlDocument();
            levelFile.Load("Level\\" + LevelName + ".xml");
            XmlNodeList levelObjects = levelFile.GetElementsByTagName("Object");

            foreach (XmlNode node in levelObjects)
            {
                switch (node["Type"].InnerText)
                {
                    case "Enemy":
                        CreateEnemy(node, level);
                        break;
                    case "Item":
                        CreateItem(node, level);
                        break;
                    case "Block":
                        CreateBlock(node, level);
                        break;
                    case "Background":
                        CreateBackground(node, level);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
