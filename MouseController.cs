using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TestGame
{
    public class MouseController
    {
        public Vector2 mousePos = new Vector2();
        MouseState mouseState = Mouse.GetState();
        private MouseState oldState;

        public void MouseUpdate(){
            mousePos = new Vector2(mouseState.X, mouseState.Y);

            MouseState newState = Mouse.GetState(); 
            if(newState.LeftButton == ButtonState.Pressed && oldState.LeftButton == ButtonState.Released)
            {
                Game1.AddTurret(mousePos);
            }
            oldState = newState; 
            
        }

    }
}