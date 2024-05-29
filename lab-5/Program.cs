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

Console.WriteLine(body.OuterHTML() + "\n");
var append = body.Append(div2);
Console.WriteLine(body.OuterHTML() + "\n");
append.Undo();
Console.WriteLine(body.OuterHTML() + "\n");
body.Append("Not the best example of the Command pattern, but... Anyway");
Console.WriteLine(body.OuterHTML() + "\n");
body.Append(div1, div2);
Console.WriteLine(body.OuterHTML() + "\n");