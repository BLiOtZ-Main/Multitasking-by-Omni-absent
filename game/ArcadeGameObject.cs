﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking
{
    internal abstract class ArcadeGameObject
    {
        //Field Declaration
        protected Texture2D texture;
        public Rectangle position;

        /// <summary>
        /// Protected parameterized constructor
        /// </summary>
        /// <param name="texture">Asset passed in from a child class</param>
        /// <param name="position">Position passed in from a child class</param>
        protected ArcadeGameObject (Texture2D texture, Rectangle position)
        {
            this.texture = texture;
            this.position = position;
        }

        /// <summary>
        /// Virtual method for drawing a SpriteBatch,
        /// can be overridden by child classes
        /// </summary>
        /// <param name="sb">Required SpriteBatch object for drawing</param>
        /// <param name="color">Color to be used in the draw method</param>
        public virtual void Draw(SpriteBatch sb, Color color)
        {
            sb.Draw(texture, position, color);
        }

        /// <summary>
        /// Implemented by child classes to update themselves
        /// for the current frame
        /// </summary>
        /// <param name="gameTime">Required GameTime object for update methods</param>
        public abstract void Update(GameTime gameTime);
    }
}
