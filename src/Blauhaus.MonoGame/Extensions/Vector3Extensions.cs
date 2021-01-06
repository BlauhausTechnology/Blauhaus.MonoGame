using Microsoft.Xna.Framework;

namespace Blauhaus.MonoGame.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 ToMonoGame(this System.Numerics.Vector3 vector)
        {
            return new Vector3(vector.Y, vector.Z, vector.X);
        }
        
        public static System.Numerics.Vector3 FromMonoGame(this Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.Z, vector.X, vector.Y);
        }
    }
}