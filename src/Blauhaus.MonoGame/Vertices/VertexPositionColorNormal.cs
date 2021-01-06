using System.Runtime.InteropServices;
using Blauhaus.MonoGame.Extensions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blauhaus.MonoGame.Vertices
{
    //to be included in monogame: https://github.com/MonoGame/MonoGame/pull/7421
    
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VertexPositionColorNormal : IVertexType
    {
        public Vector3 Position;
        public Color Color;
        public Vector3 Normal;
        public static readonly VertexDeclaration VertexDeclaration;

        //Takes in System types in a Cartesian coordinate system and creates MonoGame types in a screen coordinate system
        public VertexPositionColorNormal(System.Numerics.Vector3 position, System.Drawing.Color color, System.Numerics.Vector3 normal)
        {
            Position = position.ToMonoGame();
            Color = new Color(color.R, color.G, color.B, color.A);
            Normal = new Vector3(normal.Y, normal.Z, normal.X);
        }
        
        public VertexPositionColorNormal(Vector3 position, Color color, Vector3 normal)
        {
            Position = position;
            Color = color;
            Normal = normal;
        }

        VertexDeclaration IVertexType.VertexDeclaration => VertexDeclaration;

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Position.GetHashCode();
                hashCode = (hashCode * 397) ^ Color.GetHashCode();
                hashCode = (hashCode * 397) ^ Normal.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return "{{Position:" + this.Position + " Color:" + this.Color + " Normal:" + this.Normal + "}}";
        }

        public static bool operator ==(VertexPositionColorNormal left, VertexPositionColorNormal right)
        {
            return (((left.Position == right.Position) && (left.Color == right.Color)) && (left.Normal == right.Normal));
        }

        public static bool operator !=(VertexPositionColorNormal left, VertexPositionColorNormal right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != base.GetType())
                return false;

            return (this == ((VertexPositionColorNormal)obj));
        }

        static VertexPositionColorNormal()
        {
            var elements = new VertexElement[]
            {
                new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0),
                new VertexElement(12, VertexElementFormat.Color, VertexElementUsage.Color, 0),
                new VertexElement(16, VertexElementFormat.Vector3, VertexElementUsage.Normal, 0)
            };
            VertexDeclaration = new VertexDeclaration(elements);
        }
    }
}