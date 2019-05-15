## Approach for the string reversal algorythm

My first pass at this was to turn the string into a character array, iterate over the array in reverse and then add each character to a new array.

The approach I went with was to maintain two integers i, and j. i is set to the beginning of the string and J to the length of the string.
The algorythm swaps characters at those respective positions until they meet in the middle meaning we only have to iterate over half of the string.

I also added a maxLength default parameter to ensure that the when this method is used it cannot be passed a string that might cause the thread to block (max string length is 1GB in length in .NET) unless it was the programmers intention to parse an overly large string.
We don't have to worry about UTF-16 and surrogate pairs in the reversal operation as the decoding has already been done into a char[] by the .NET framework and we're not reading bytes.