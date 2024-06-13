using System.Numerics;
using Raylib_cs;

namespace flappy_berd_tester_tbh
{
    internal class Class1
    {
        private Vector2 position; // private field to store the position of the bird
        private Vector2 velocity; // private field to store the velocity of the bird
        private Vector2 gravity; // private field to store the gravity affecting the bird

        public Class1(Vector2 initialPosition, Vector2 initialGravity)
        {
            position = initialPosition; // initializes the bird's position with the provided initial position
            velocity = Vector2.Zero; // initializes the bird's velocity to zero
            gravity = initialGravity; // initializes the gravity affecting the bird with the provided initial gravity
        }

        public void SetPosition(Vector2 newPosition)
        {
            position = newPosition; // public method to set the bird's position
        }

        public Vector2 GetPosition()
        {
            return position; // public method to get the bird's position
        }

        public void SetVelocity(Vector2 newVelocity)
        {
            velocity = newVelocity; // public method to set the bird's velocity
        }

        public Vector2 GetVelocity()
        {
            return velocity; // public method to get the bird's velocity
        }

        public void SetGravity(Vector2 newGravity)
        {
            gravity = newGravity; // public method to set the gravity affecting the bird
        }

        public Vector2 GetGravity()
        {
            return gravity; // public method to get the gravity affecting the bird
        }

        public void ApplyFlap(Vector2 force)
        {
            velocity = force; // applies a flap force to the bird, affecting its velocity
        }

        public void SimulateGravity(float deltaTime)
        {
            Vector2 gravityForce = deltaTime * gravity; // calculates the gravitational force based on delta time and gravity
            velocity += gravityForce; // applies the gravitational force to the bird's velocity
            position += velocity; // updates the bird's position based on its velocity
        }

        public void CheckBounds(float upperBound, float lowerBound)
        {
            if (position.Y <= upperBound)
            {
                position = new Vector2(position.X, upperBound); // ensures the bird stays within the upper bound
                Raylib.CloseWindow(); // closes the window if the bird hits the upper bound
            }
            else if (position.Y >= lowerBound)
            {
                position = new Vector2(position.X, lowerBound); // ensures the bird stays within the lower bound
                Raylib.CloseWindow(); // closes the window if the bird hits the lower bound
            }
        }

        public void Draw()
        {
            Raylib.DrawCircleV(position, 25, Color.Maroon); // draws the bird as a circle at its current position
        }
    }
}
