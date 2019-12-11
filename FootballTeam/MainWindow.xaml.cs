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

            int randomFirstSecond = rng.Next(1, firstNames.Length);
            int randomYear = rng.Next(1988, 1998);
            int randomMonth = rng.Next(1, 12);
            int randomDay = rng.Next(1, 31);
            //Player p1 = new Player() { FirstName = firstNames[rng], Surname = lastNames[rng], Position = Position.Goalkeeper, DateOfBirth = 12/12/2019}
            //Player p1 = new Player("Sophie", "O'Neill", Position.Goalkeeper, 12/12/1998);
            Player p1 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Goalkeeper,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p2 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Goalkeeper,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p3 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Defender,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p4 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Defender,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p5 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Defender,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p6 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Defender,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p7 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Defender,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p8 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Defender,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p9 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Midfielder,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p10 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Midfielder,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p11 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Midfielder,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p12 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Midfielder,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p13 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Midfielder,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p14 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Midfielder,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p15 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Forward,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p16 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Forward,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p17 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Forward,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            Player p18 = new Player()
            {
                FirstName = firstNames[randomFirstSecond],
                Surname = lastNames[randomFirstSecond],
                Position = Position.Forward,
                DateOfBirth = new DateTime(randomYear, randomMonth, randomDay)
            };

            allPlayers.Add(p1);
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
            allPlayers.Add(p18);
        }
}
}
