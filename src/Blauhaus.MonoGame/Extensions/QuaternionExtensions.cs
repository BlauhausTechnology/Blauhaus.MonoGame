using Microsoft.Xna.Framework;

namespace Blauhaus.MonoGame.Extensions
{
    public static class QuaternionExtensions
    {
        public static System.Numerics.Quaternion FromMonoGame(this Quaternion quaternion)
        {
            return new System.Numerics.Quaternion(quaternion.Y, quaternion.Z, quaternion.X, quaternion.W);
        }


        public static Quaternion ToMonoGame(this System.Numerics.Quaternion quaternion)
        {
            return new Quaternion(quaternion.Y, quaternion.Z, quaternion.X, quaternion.W);
        }
    }
}