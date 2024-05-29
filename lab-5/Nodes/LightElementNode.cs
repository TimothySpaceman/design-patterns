﻿using lab_5.Events;

namespace lab_5.Nodes;

public class LightElementNode : LightNode
{
    public string Tag { get; }
    public bool IsInline { get; }
    public bool IsPaired { get; }
    public List<string> CssClasses { get; }
    public List<LightNode> Children { get; }

    public LightElementNode Parent { get; set; }
    
    public int ChildrenCount => Children.Count;

    public EventManager EventManager = new EventManager();
    
    public override string InnerHTML(int childLevel = 0)
    {
        return !IsPaired ? "" : Children.Aggregate("", (current, child) => current + child.OuterHTML(childLevel + 1) + (IsInline ? "" : "\n"));
    }

    public override string OuterHTML(int childLevel = 0)
    {
        var padding = new string(' ', childLevel * 4);
        
        var result = padding + OpeningTag();
        result += (IsInline ? "" : "\n") + InnerHTML(childLevel);
        result += padding + ClosingTag();
        return result;
    }

    public string OpeningTag()
    {
        var result = $"<{Tag}";
        result += CssClasses.Count != 0 ? " class=\"" + string.Join(" ", CssClasses.ToArray()) + "\"" : "";
        result += IsPaired ? ">" : "/>";
        return result;
    }

    public string ClosingTag()
    {
        return IsPaired ? $"</{Tag}>" : "";
    }

    public LightElementNode(string tag, bool isInline = true, bool isPaired = false, List<string>? cssClasses = null, List<LightNode>? children = null)
    {
        Tag = tag;
        IsInline = isInline;
        IsPaired = isPaired;
        CssClasses = cssClasses ?? new List<string>();
        Children = children ?? new List<LightNode>();
        foreach (var child in Children.OfType<LightElementNode>())
        {
            (child).Parent = this;
        }
    }
    
    public void AddListener(string eventName, Action<Event> listener)
    {
        EventManager.AddListener(eventName, listener);
    }
    
    public void RemoveListener(string eventName, Action<Event> listener)
    {
        EventManager.RemoveListener(eventName, listener);
    }

    public void OnClick((int, int) position, int button)
    {
        var eventInstance = new ClickEvent(position, button, this);
        OnClick(eventInstance);
    }

    public void OnClick(Event eventInstance)
    {
        EventManager.NotifyListeners("click", eventInstance);
        Parent?.OnClick(eventInstance);
    }
    
    public void OnMouseOver((int, int) position)
    {
        var eventInstance = new MouseOverEvent(position, this);
        OnMouseOver(eventInstance);
    }

    public void OnMouseOver(Event eventInstance)
    {
        EventManager.NotifyListeners("mouseover", eventInstance);
        Parent?.OnMouseOver(eventInstance);
    }
}