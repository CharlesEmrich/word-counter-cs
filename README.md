| Behavior | Description | Input | Output |
|==========|=============|=======|========|
| User enters a string with a single occurrence of a word. | The simplest implementation is seeing whether you can detect a substring in a string and output confirmation of that to the user. | "the cat is fast"/"cat" | cat: 1 |
| User checks for two words, each of which occurs once. | The second simplest case is checking for multiple multiple substrings a seingle time each. |  | "the cat is fast"/"cat, fast" | cat: 1, fast: 1 |
| User enters a word which does not appear in the string | I generally allow myself to expect well-formed input from users, because accounting for all kinds of bad input is generally unfeasible in the time allotted for a Friday project. But this is one I want to be prepared for. (case-sensitivity is a stretch goal) | "the cat is fast"/"cat, dog" | cat: 1, dog: 0 |
| User enters a string with multiple recurrences of a word and asks about that word. | "the cat is a fast cat" / "cat" | "cat: 2" |
