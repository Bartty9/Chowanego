using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chowanego
{
    public partial class Form1 : Form
    {
        int Moves;
        
        Location currentLocation; //aktualnie wyświetlane pomieszczenie

        RoomWithDoor livingRoom, kitchen;
        RoomWithHidingPlace diningRoom, masterBedroom, secondBedroom, bathroom, hallway;
        Room stairs;

        OutsideWithDoor backYard, frontYard;
        OutsideWithHidingPlace garden, driveway;

        Opponent opponent;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Gotowy czy nie - nadchodzę!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! Ukrywał się " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie ściennej", "dębowe drzwi z mosiężną klamką");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "w szafce", "rozsuwane drzwi");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "kryształowy żyrandol", "w wysokiej szafie");
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
            secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "małe łóżko", "pod łóżkiem");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem", "w szafie ściennej");
            stairs = new Room("Schody", "drewniana poręcz");

            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "ciężkie dębowe drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

            livingRoom.Exits = new Location[] { stairs, diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            bathroom.Exits = new Location[] { hallway };
            hallway.Exits = new Location[] { stairs, masterBedroom, secondBedroom, bathroom };
            stairs.Exits = new Location[] { hallway, livingRoom };

            backYard.Exits = new Location[] { garden, frontYard, driveway };
            frontYard.Exits = new Location[] { garden, backYard, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
    }
}
