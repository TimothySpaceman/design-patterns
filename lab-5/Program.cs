using lab_5.Iterators;
using lab_5.Nodes;

var body = new Body(new List<string>{"border-double"}, new List<LightNode>
{
    new Div(new List<string>{"bg-red", "bg-red"}, new List<LightNode>
    {
        new P(null, "1"),
        new P(new List<string>{"fg-darkred"}, "2")
    }),
    new Div(new List<string>{"bg-red", "bg-red"}, new List<LightNode>
    {
        new Div(new List<string>{"bg-red", "bg-red"}, new List<LightNode>
        {
            new P(null, "3"),
            new P(new List<string>{"fg-darkred"}, "4")
        }),
        new P(new List<string>{"fg-darkred"}, "5")
    })
});

var iterator = new DepthIterator(body);

Console.WriteLine($"Root: {iterator.Next()?.OuterHTML()}");
Console.WriteLine($"Next: {iterator.Next()?.OuterHTML()}");
Console.WriteLine($"Next: {iterator.Next()?.OuterHTML()}");
Console.WriteLine($"Next: {iterator.Next()?.OuterHTML()}");