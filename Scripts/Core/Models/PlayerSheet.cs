using Godot;
using System;

namespace Models
{

    public partial class PlayerSheet
    {
        
        public int health { get; set; }
        public int mana { get; set; }
        public int damage { get; set; }
        public int attackSpeed { get; set; }
        public int defense { get; set; }

        public PlayerSheet(){}
    }
}
