using Godot;
using System;
using Models;
using Controllers;
namespace Views
{
    public partial class Player : CharacterBody2D
    {
        private PlayerSheet _playerSheet;
        private PlayerControl _playerControl;
        public override void _Ready()
        {
            _playerSheet = new PlayerSheet();
            _playerControl = new PlayerControl(_playerSheet, this);
            GD.Print("Player is ready.");
        }

        public override void _PhysicsProcess(double delta)
        {
            base._PhysicsProcess(delta);
            _playerControl.ProccessMovment(delta);
        }
    }
}