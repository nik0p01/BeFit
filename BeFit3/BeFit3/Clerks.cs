namespace BeFit3
{
    public class Clerks
    {
        private LinkedList<Clerk> clerks = new LinkedList<Clerk>();

        public void AddClerk(int id, ICollection<int> dependencies)
        {

            clerks.AddLast(new Clerk(id, dependencies));

        }

        public List<int> GetClerkOrder()
        {
          
            HashSet<int> ids = new HashSet<int>();
            HashSet<int> dependencyIds = new HashSet<int>();
            dependencyIds.ExceptWith(ids);
            foreach (var item in clerks)
            {
                ids.Add(item.Id);
                dependencyIds.UnionWith(item.Dependencies);
            }

            dependencyIds.ExceptWith(ids);
            var result = dependencyIds.ToList();

            var node = clerks.First;
            if (node == null)
            {
                return result;
            }
            while (true)
            {
                if (node.Value.Dependencies.All(x => result.Contains(x)))
                {
                    result.Add(node.Value.Id);
                    clerks.Remove(node);
                }
                node = node.Next ?? clerks.First;
                if (node == null)
                {
                    break;
                }
            }
            return result;
        }
    }
}
