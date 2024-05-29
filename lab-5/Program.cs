using lab_5.Nodes;
using lab_5.Styles;

var body = new Body(new List<string> { "body" }, new List<LightNode>
{
    new Div(new List<string> { "div1", "bg-darkred" }, new List<LightNode>
    {
        new P(new List<string> { "p1" }, "1"),
        new P(new List<string> { "p2", "fg-red" }, "2")
    }),
    new Div(new List<string> { "div2", "bg-darkgreen" }, new List<LightNode>
    {
        new P(new List<string> { "p3", "fg-green" }, "3"),
        new Div(new List<string> { "div3", "bg-black" }, new List<LightNode>
        {
            new P(new List<string> { "p4" }, "4"),
            new P(new List<string> { "p5" }, "5")
        })
    })
});

var styleSheet = new StyleSheet();
styleSheet.AddClass("bg-darkred", new Style(
        backgroundColor: ConsoleColor.DarkRed
    ))
    .AddClass("bg-darkgreen", new Style(
        backgroundColor: ConsoleColor.DarkGreen
    ))
    .AddClass("bg-black", new Style(
        backgroundColor: ConsoleColor.Black
    ))
    .AddClass("fg-red", new Style(
        foregroundColor: ConsoleColor.Red
    ))
    .AddClass("fg-green", new Style(
        foregroundColor: ConsoleColor.Green
    ))
    .AddClass("body", new Style(
            top: 0,
            left: 0,
            width: Console.WindowWidth,
            height: Console.WindowHeight,
            backgroundColor: ConsoleColor.DarkBlue
        )
    ).AddClass("p1", new Style(
            top: 2,
            left: 3
        )
    ).AddClass("p2", new Style(
            top: 2,
            left: 4
        )
    )
    .AddClass("p3", new Style(
            top: 1,
            left: 1
        )
    )
    .AddClass("p4", new Style(
            top: 4,
            left: 1
        )
    )
    .AddClass("p5", new Style(
            top: 2,
            left: 3
        )
    ).AddClass("div1", new Style(
            top: 2,
            left: 4,
            width: 20,
            height: 7
        )
    ).AddClass("div2", new Style(
            top: 9,
            left: 5,
            width: 25,
            height: 10
        )
    ).AddClass("div3", new Style(
            top: 2,
            left: 2,
            width: 10,
            height: 5,
            foregroundColor: ConsoleColor.White
        )
    );

var document = new Document(body, styleSheet);
document.Render();

Console.ReadKey();