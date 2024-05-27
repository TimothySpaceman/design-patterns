using lab_5.Nodes;

var body = new Body(new List<string>{"border-double"}, new List<LightNode>
{
    new Div(new List<string>{"bg-red", "bg-red"}, new List<LightNode>
    {
        new P(null, "Welcome to LightHTML!"),
        new P(new List<string>{"fg-darkred"}, "Have fun!")
    })
});

Console.WriteLine(body.OuterHTML());