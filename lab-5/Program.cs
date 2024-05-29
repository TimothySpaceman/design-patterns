using lab_5.Iterators;
using lab_5.Nodes;

var body = new Body(new List<string>{"border-double"}, new List<LightNode>{});

var div1 = new Div(new List<string> { "bg-red", "bg-red" }, new List<LightNode>
{
    new P(null, "1"),
    new P(new List<string> { "fg-darkred" }, "2")
});

var div2 = new Div(new List<string> { "bg-red", "bg-red" }, new List<LightNode>
{
    new Div(new List<string> { "bg-red", "bg-red" }, new List<LightNode>
    {
        new P(null, "3"),
        new P(new List<string> { "fg-darkred" }, "4")
    }),
    new P(new List<string> { "fg-darkred" }, "5")
});

body.Append(div1, div2);
body.SetDisplayState(new CollapsedState());

Console.WriteLine(body.OuterHTML() + "\n");
body.AddClass("new-class");
Console.WriteLine(body.OuterHTML() + "\n");
body.ToggleClass("new-class");
Console.WriteLine(body.OuterHTML() + "\n");
body.ToggleClass("new-class");
Console.WriteLine(body.OuterHTML() + "\n");