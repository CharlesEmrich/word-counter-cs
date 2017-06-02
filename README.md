# C# Word Repeat Counter
## Created by Charles Emrich

### Description
A barebones implementation of a system for search texts for repetitions of a word or words.

### Installation
1. Download or clone the repository from [here](https://github.com/CharlesEmrich/word-counter-cs.git)
2. Start the app by running dnx kestrel, or a similar local-server-starting command in your terminal of choice.
3. If debugging is necessary, the command "dnx test" is available.
4. Point your web browser to localhost:5004 to begin using the app.

### Specifications
| Behavior | Description | Input | Output |
|==========|=============|=======|========|
| User enters a string with a single occurrence of a word. | The simplest implementation is seeing whether you can detect a substring in a string and output confirmation of that to the user. | "the cat is fast"/"cat" | cat: 1 |
| User checks for two words, each of which occurs once. | The second simplest case is checking for multiple multiple substrings a seingle time each. |  | "the cat is fast"/"cat, fast" | cat: 1, fast: 1 |
| User enters a word which does not appear in the string | I generally allow myself to expect well-formed input from users, because accounting for all kinds of bad input is generally unfeasible in the time allotted for a Friday project. But this is one I want to be prepared for. (case-sensitivity is a stretch goal) | "the cat is fast"/"cat, dog" | cat: 1, dog: 0 |
| User enters a string with multiple recurrences of a word and asks about that word.| This is basically the MVP case, so testing it is essentially a no-brainer. | "the cat is a fast cat" / "cat" | "cat: 2" |
| User enters a string with multiple recurrences of multiple words and asks about those words. | I'm not perfectly sure that this needs to be its own spec, but I know enough about the way I expect to code the MVP that I know it might fail this case so I'm adding a spec, and test, to make sure I don't forget to account for it. | "the cat is the fastest cat" / "cat the" | "cat: 2, the: 2" |

### Known Bugs
Current implementation of the word search functionality is case-sensitive, and intolerant of user input like comma-separated lists.

#### License
This project is licensed under the MIT License.
Copyright (c) 2017 Charles Emrich
