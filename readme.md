see OldPhonePad.cs for the sourcecode.

log of AI usage : 2 instances of accepting code refinements from GitHub CoPilot

line 27 - changed output.Substring(0, output.length-1) to output[..^1]

line 28 - changed phonePadMap.ContainsKey() to phonePadMap.TryGetValue()

