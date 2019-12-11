using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FootballTeam
{
    // enum - question 3
    public enum Position { Goalkeeper, Defender, Midfielder, Forward }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> allPlayers = new List<Player>();

        private static Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

        string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


        string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };

            int randomFirstSecond = 0;
            int randomYear = 0;
            int randomMonth = 0;
            int randomDay = 0;

            Player[] PlayerDetails = new Player[18];

            Player p1 = new Player(), p2 = new Player(), p3 = new Player(), p4 = new Player(), p5 = new Player(), p6 = new Player(), p7 = new Player(), p8 = new Player(), p9 = new Player(), p10 = new Player(), p11 = new Player(), p12 = new Player(), p13 = new Player(), p14 = new Player(), p15 = new Player(), p16 = new Player(), p17 = new Player(), p18 = new Player();
            for (int i = 0; i <PlayerDetails.Length; i++)
            {
                randomFirstSecond = rng.Next(1, firstNames.Length);
                randomYear = rng.Next(1988, 1998);
                randomMonth = rng.Next(1, 12);
                randomDay = rng.Next(1, 31);


                //Player p1 = new Player() { FirstName = firstNames[rng], Surname = lastNames[rng], Position = Position.Goalkeeper, DateOfBirth = 12/12/2019}
                //Player p1 = new Player("Sophie", "O'Neill", Position.Goalkeeper, 12/12/1998);
                PlayerDetails[i] = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Goalkeeper,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                /*p2 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Goalkeeper,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p3 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Defender,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p4 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Defender,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p5 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Defender,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p6 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Defender,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p7 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Defender,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p8 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Defender,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p9 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Midfielder,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p10 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Midfielder,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p11 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Midfielder,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p12 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Midfielder,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p13 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Midfielder,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p14 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Midfielder,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p15 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Forward,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p16 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Forward,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p17 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Forward,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };

                p18 = new Player()
                {
                    FirstName = firstNames[randomFirstSecond],
                    Surname = lastNames[randomFirstSecond],
                    Position = Position.Forward,
                    DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
                };*/
            }

                /*allPlayers.Add(p1);
                allPlayers.Add(p2);

                allPlayers.Add(p3);
                allPlayers.Add(p4);
                allPlayers.Add(p5);
                allPlayers.Add(p6);
                allPlayers.Add(p7);
                allPlayers.Add(p8);

                allPlayers.Add(p9);
                allPlayers.Add(p10);
                allPlayers.Add(p11);
                allPlayers.Add(p12);
                allPlayers.Add(p13);
                allPlayers.Add(p14);

                allPlayers.Add(p15);
                allPlayers.Add(p16);
                allPlayers.Add(p17);
                allPlayers.Add(p18);*/

            
            

            

                PlayerDetails[0].Position = Position.Goalkeeper;
                PlayerDetails[1].Position = Position.Goalkeeper;
                PlayerDetails[2].Position = Position.Defender;
                PlayerDetails[3].Position = Position.Midfielder;
                PlayerDetails[4].Position = Position.Defender;
                PlayerDetails[5].Position = Position.Midfielder;
                PlayerDetails[6].Position = Position.Forward;
                PlayerDetails[7].Position = Position.Defender;
                PlayerDetails[8].Position = Position.Midfielder;
                PlayerDetails[9].Position = Position.Forward;
                PlayerDetails[10].Position = Position.Defender;
                PlayerDetails[11].Position = Position.Midfielder;
                PlayerDetails[12].Position = Position.Forward;
                PlayerDetails[13].Position = Position.Defender;
                PlayerDetails[14].Position = Position.Midfielder;
                PlayerDetails[15].Position = Position.Forward;
                PlayerDetails[16].Position = Position.Defender;
                PlayerDetails[17].Position = Position.Midfielder;

            for (int i = 0; i < PlayerDetails.Length; i++)
            {
                allPlayers.Add(PlayerDetails[i]);
            }

            lbxAllPlayers.ItemsSource = allPlayers;
        }

        
}
}
