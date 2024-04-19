using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    //Inheritance for Base
    public class GameSession : BaseNotificationClass
    {
        private Location _currentLocation;
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                //Refractored
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToSouth));

                CompleteQuestsAtLocation();
                GivePlayerQuestsAtLocation();
                GetMonsterAtLocation(); 
            }
        }
        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }
        //Object initializers
        public GameSession() 
        { 
            CurrentPlayer = new Models.Player 
            {   Name = "Bot", 
                CharacterClass = "Warrior", 
                HitPoints = 10, 
                Gold = 1000000, 
                ExperiencePoints = 0, 
                Level = 1 
            };

            CurrentWorld = WorldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }

        //Added Guard clauses
        public void MoveNorth()
        {
            if(HasLocationToNorth)
            {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);

            }
        }
        public void MoveEast()
        {
            if(HasLocationToEast)
            {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);

            }

        }
        public void MoveSouth()
        {
            if(HasLocationToSouth)
            {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);

            }

        }
        public void MoveWest()
        {
            if(HasLocationToWest)
            {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);

            }

        }

        // command
        public void Attack()
        {
            // attack
        }

        public void Interact()
        {
            // interact
        }

        public void OpenInventory()
        {
            // inventory
        }

        public void Run()
        {
            // run
        }
        private void GivePlayerQuestsAtLocation()
        {
            foreach (Quest quest in CurrentLocation.AvailableQuest)
            { 
                if(!CurrentPlayer.Quest.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quest.Add(new QuestStatus(quest));
                }
            }
        }
        private void CompleteQuestsAtLocation()
        {
            foreach(Quest quest in CurrentLocation.AvailableQuest)
            {
                QuestStatus questToComplete = CurrentPlayer.Quest.FirstOrDefault(q => q.PlayerQuest.ID == quest.ID && !q.IsDone);
                if(questToComplete != null)
                {
                    if(CurrentPlayer.HasAllTheseItems(quest.ItemsToComplete))
                    {
                        foreach (ItemQuantity itemQuantity in quest.ItemsToComplete)
                        {
                            for (int i = 0; i < itemQuantity.Quantity; i++) 
                            {
                                CurrentPlayer.RemoveItemsFromInventory(CurrentPlayer.Inventory.First(item => item.ItemTypeId == itemQuantity.ItemID));

                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine($"You completed the'{quest.Name}'quest");

                        CurrentPlayer.ExperiencePoints += quest.RewardExpPoints;
                        Console.WriteLine($"You recieve{quest.RewardGold} gold");

                        foreach (ItemQuantity itemQuantity in quest.RewardItems)
                        {
                            GameItem rewardItem = ItemFactory.CreateGameItem(itemQuantity.ItemID);

                            CurrentPlayer.AddItemToInventory(rewardItem);
                            Console.WriteLine($" You recieve a {rewardItem.Name}");
                        }
                        questToComplete.IsDone = true; 

                    }
                }
            }
        }
    }
}

