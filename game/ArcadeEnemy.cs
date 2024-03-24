﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking
{
    internal class ArcadeEnemy : ArcadeGameObject
    {
        private int windowHeight;
        private int windowWidth;

        //Constants for enemy shift and shoot delay
        private const int ShiftDelay = 3;
        private const int shootDelay = 3;

        //Constant for enemy shift distance
        private const int ShiftDistance = 3;

        //Needed booleans
        private bool isAlive;
        private bool shiftedRight;
        
        //Timer related variables
        private double shootTimer;
        private double shiftTimer;
        
        //Rng
        private Random rng;

        //List of all enemies
        public List<ArcadeEnemy> enemyList = new List<ArcadeEnemy>();

        /// <summary>
        /// public parameterized constructor for arcade enemies
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        /// <param name="windowHeight"></param>
        /// <param name="windowWidth"></param>
        public ArcadeEnemy (Texture2D texture, Rectangle position, int windowHeight, int windowWidth)
            : base(texture, position)
        {
            this.windowHeight = windowHeight;
            this.windowWidth = windowWidth;
            
            shiftedRight = false;
            shiftTimer = ShiftDelay;
            shootTimer = shootDelay;
            
            //Adds the new enemy to the enemy list
            enemyList.Add(this);
            
        }

        /// <summary>
        /// Property to tell if an enemy is alive or dead
        /// </summary>
        public bool IsAlive { get { return isAlive; } set { IsAlive = value;  } }

        /// <summary>
        /// Property to get the list of enemies
        /// </summary>
        public List<ArcadeEnemy> EnemyList
        {
            get { return enemyList; }
        }


        /// <summary>
        /// Update method
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {

            //Tracks time to know when to shift
            shiftTimer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (shiftTimer < 0)
            {
                //If the enemy shifted right last shift
                if(shiftedRight)
                {
                    //Shift Left
                    position.X -= 5;
                }
                //Otherwise
                else
                {
                    //Shift right
                    position.X += 5;
                }
            }

            //The enemy constantly moves downward
            position.Y -= 1;

            /*
            every 3 seconds % chance to shoot a projectile
            
            If "shootDelay" seconds passed
            {
               if rng.Next() > (whatever the percentage is decided to be
               {
                  create new projectile object
               }
            }
            */


        }



    }
}
