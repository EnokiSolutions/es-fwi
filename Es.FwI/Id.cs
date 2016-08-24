namespace Es.FwI
{
    public struct Id
    {
        public readonly ulong[] Ulongs;

        public Id(ulong h = 0, ulong l = 0)
        {
            Ulongs = new ulong[2];
            Ulongs[0] = l;
            Ulongs[1] = h;
        }

        public override bool Equals(object other)
        {
            if (!(other is Id))
                return false;

            return this == (Id)other;
        }

        public override int GetHashCode()
        {
            return Ulongs[0].GetHashCode()| Ulongs[1].GetHashCode();
        }

        public static bool operator ==(Id x, Id y)
        {
            return x.Ulongs[0] == y.Ulongs[0] && x.Ulongs[1] == y.Ulongs[1];
        }

        public static bool operator !=(Id x, Id y)
        {
            return x.Ulongs[0] != y.Ulongs[0] || x.Ulongs[1] != y.Ulongs[1];
        }

        public static bool operator >(Id x, Id y)
        {
            return x.Ulongs[0] > y.Ulongs[0] || x.Ulongs[0] == y.Ulongs[0] && x.Ulongs[1] > y.Ulongs[1];
        }
        public static bool operator <(Id x, Id y)
        {
            return x.Ulongs[0] < y.Ulongs[0] || x.Ulongs[0] == y.Ulongs[0] && x.Ulongs[1] < y.Ulongs[1];
        }
    }
}