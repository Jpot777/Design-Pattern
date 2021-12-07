abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth);
}

class Composite : Component
{
    private List<Component> m_children = new List<Component>();

    public Composite(string name) : base(name)
    {

    }

    public override void Add(Component component)
    {
        m_children.Add(component);
    }

    public override void Remove(Component component)
    {
        m_children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);

        foreach (Component component in collem_childrenction)
        {
            component.Display(depth + 2);
        }
    }
}