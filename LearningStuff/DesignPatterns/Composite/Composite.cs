using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Composite : Component
    {
        private readonly List<Component> _components = new List<Component>();

        public void AddComponent(Component component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(Component component)
        {
            _components.Remove(component);
        }

        public IEnumerable<Component> GetComponents()
        {
            return _components.ToList();
        }

        public override void Operation()
        {
            _components.ForEach(x => x.Operation());
        }
    }
}
