namespace CSEnumeratorEnumerable
{
    public class Test
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Test)) return false;

            var emp = obj as Test;
            return this.Id == emp.Id
                  && this.Name == emp.Name
                  && this.Address == emp.Address;
        }

        public Test(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) +Id.GetHashCode();
            return hash;
        }
        public static bool operator ==(Test lhs , Test rhs) => lhs.Equals(rhs);
        public static bool operator !=(Test lhs, Test rhs) => !lhs.Equals(rhs);

    }
}