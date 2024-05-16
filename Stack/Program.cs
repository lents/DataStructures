// Create a stack to store actions for undo
Stack<Action> undoStack = new Stack<Action>();

// Initial text
string text = "Initial text.";

// Perform actions (e.g., editing text)
Console.WriteLine("Original text: " + text);

// Action 1: Append text
AppendText(ref text, " Appended text.");
Console.WriteLine("After appending: " + text);
undoStack.Push(() => RemoveText(ref text, " Appended text.")); // Add reverse action to undo stack

// Action 2: Replace text
ReplaceText(ref text, "Initial", "Replaced");
Console.WriteLine("After replacing: " + text);
undoStack.Push(() => ReplaceText(ref text, "Replaced", "Initial")); // Add reverse action to undo stack

// Action 3: Undo
if (undoStack.Count > 0)
{
    Console.WriteLine("Undoing last action...");
    undoStack.Pop().Invoke(); // Perform reverse action from undo stack
    Console.WriteLine("After undo: " + text);
}
else
{
    Console.WriteLine("No actions to undo.");
}
    

    static void AppendText(ref string text, string newText)
{
    text += newText;
}

static void ReplaceText(ref string text, string oldText, string newText)
{
    text = text.Replace(oldText, newText);
}

static void RemoveText(ref string text, string textToRemove)
{
    text = text.Replace(textToRemove, "");
}