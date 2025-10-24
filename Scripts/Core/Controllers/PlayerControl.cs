using Godot;
using Models;
using Views;
namespace Controllers
{
    public class PlayerControl
    {
        private PlayerSheet _playerSheet;
        private Player _player;
        public PlayerControl(PlayerSheet playerSheet, Player player)
        {
            _playerSheet = playerSheet;
            _player = player;
        }

        public void ProccessMovment(double delta)
        {
            
        }
    }
}