using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.EventArgs;
using Engine.Models;
using Engine.ViewModels;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        private readonly GameSession _gameSession = new GameSession();
        public Form1()
        {
            InitializeComponent();
            monsterRichTextBox.Clear();
            foreach(var item in _gameSession.CurrentPlayer.Inventory)
            {
                inventoryRichTextBox.Text = item.Name;                
            }

            roomDescriptionBox.Text = _gameSession.CurrentLocation.Description;
            if (_gameSession.CurrentMonster != null)
            {
                monsterRichTextBox.Text = _gameSession.CurrentMonster.Name;
            }
            playerInfoRichTextBox.Text = $"Name - {_gameSession.CurrentPlayer.Name}" +
                $"\nClass - {_gameSession.CurrentPlayer.CharacterClass}" +
                $"\nHit Points - {_gameSession.CurrentPlayer.CurrentHitPoints}" +
                $"\nGold - {_gameSession.CurrentPlayer.Gold}" +
                $"\nXP - {_gameSession.CurrentPlayer.ExperiencePoints}" +
                $"\nLevel - {_gameSession.CurrentPlayer.Level}";

            equipedWeaponComboBox.DataSource = _gameSession.CurrentPlayer.Weapons;
            equipedWeaponComboBox.DisplayMember = "Name";
            equipedWeaponComboBox.SelectedIndex = 0;
            

        }

        private void moveNorthButton_Click(object sender, EventArgs e)
        {
            monsterRichTextBox.Clear();
            _gameSession.MoveNorth();
            roomDescriptionBox.Text = _gameSession.CurrentLocation.Description;
            if (_gameSession.CurrentMonster != null)
            {
                monsterRichTextBox.Text = $"{_gameSession.CurrentMonster.Name} {_gameSession.CurrentMonster.CurrentHitPoints}/{_gameSession.CurrentMonster.MaximumHitPoints}";
            }


        }

        private void moveSouthButton_Click(object sender, EventArgs e)
        {
            monsterRichTextBox.Clear();
            _gameSession.MoveSouth();
            roomDescriptionBox.Text = _gameSession.CurrentLocation.Description;
            if (_gameSession.CurrentMonster != null)
            {
                monsterRichTextBox.Text = $"{_gameSession.CurrentMonster.Name} {_gameSession.CurrentMonster.CurrentHitPoints}/{_gameSession.CurrentMonster.MaximumHitPoints}";
            }
        }

        private void moveEastButton_Click(object sender, EventArgs e)
        {
            monsterRichTextBox.Clear();
            _gameSession.MoveEast();
            roomDescriptionBox.Text = _gameSession.CurrentLocation.Description;
            if (_gameSession.CurrentMonster != null)
            {
                monsterRichTextBox.Text = $"{_gameSession.CurrentMonster.Name} {_gameSession.CurrentMonster.CurrentHitPoints}/{_gameSession.CurrentMonster.MaximumHitPoints}";
            }
        }

        private void moveWestButton_Click(object sender, EventArgs e)
        {
            monsterRichTextBox.Clear();
            _gameSession.MoveWest();
            roomDescriptionBox.Text = _gameSession.CurrentLocation.Description;
            if (_gameSession.CurrentMonster != null)
            {
                monsterRichTextBox.Text = $"{_gameSession.CurrentMonster.Name} {_gameSession.CurrentMonster.CurrentHitPoints}/{_gameSession.CurrentMonster.MaximumHitPoints}";
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            Weapon currentWeapon = (Weapon)equipedWeaponComboBox.SelectedItem;
            _gameSession.CurrentWeapon = currentWeapon;
            
            _gameSession.AttackCurrentMonster();            
            playerInfoRichTextBox.Text = $"Name - {_gameSession.CurrentPlayer.Name}" +
                $"\nClass - {_gameSession.CurrentPlayer.CharacterClass}" +
                $"\nHit Points - {_gameSession.CurrentPlayer.CurrentHitPoints}" +
                $"\nGold - {_gameSession.CurrentPlayer.Gold}" +
                $"\nXP - {_gameSession.CurrentPlayer.ExperiencePoints}" +
                $"\nLevel - {_gameSession.CurrentPlayer.Level}";
            if (_gameSession.CurrentMonster != null)
            {
                monsterRichTextBox.Text = $"{_gameSession.CurrentMonster.Name} {_gameSession.CurrentMonster.CurrentHitPoints}/{_gameSession.CurrentMonster.MaximumHitPoints}";
            }

        }       
    }
}
