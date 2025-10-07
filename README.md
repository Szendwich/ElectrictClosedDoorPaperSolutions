# ElectrictClosedDoorPaperSolutions
Old "written examination" exercises and their solution in .NET &amp; C#

## VZH1

### Relatively Prime
>Write a program that reads two positive integers separated by a comma and prints the word "yes" or "no" to the screen depending on whether the numbers are relatively prime.
(Two or more numbers are called relatively prime if their greatest common divisor is 1.)

| Input  | Output |
| ------ | ------ |
| 12,121 |    yes |
| 16,72  |     no |
| 26,49  |    yes |

### Number of combinations of n based on k without repetition
>Write a program that reads two positive integers (n, k) and prints the number of combinations of n based on k without repetition (where n is k). 
Assume that n and k are between 0 and 10.

| Input  | Output |
| ------ | ------ |
| 6,4    |     15 |
| 9,3    |     84 |

### Number to text (Hungarian!!!)
>Write a program that reads an integer between 0 and 100 and prints its text form on the screen without accents. Hungarian language!!!

| Input  | Output       |
| ------ | ------------ |
| 1      |          egy |
| 42     | negyvenketto |

### Nearest square number
>Write a program that reads a positive integer and prints its distance from the nearest square number! 
(The distance between two numbers is the absolute value of their difference.)

| Input  | Output |
| ------ | ------ |
| 45     |      4 |

### Longest Interval
>Write a program that reads five pairs of numbers (ten integers separated by commas).
The pairs of numbers represent the start and end points of intervals.The program prints the length of the longest interval!
(It can be assumed that the first member of the pairs of numbers is less than the second.)

| Input                           | Output |
| ------------------------------- | ------ |
| -12,-2,34,56,4,100,65,83,-45,23 |     96 |

### Greatest Common Subinterval
>Write a program that reads three pairs of integers (six integers separated by commas).
The program prints the length of the greatest common subinterval of the intervals!
(It can be assumed that the first member of the pairs of numbers is less than the second.)

| Input          | Output |
| -------------- | ------ |
| 1,5,3,10,0,2   |      0 |
| -5,2,-3,1,-7,0 |      3 |

### Cube root
>Write a program that reads an integer (n) and prints the number of cubes between 0 and n! (A cube is a number whose cube root is an integer.)

| Input  | Output |
| ------ | ------ |
| 0      |      1 |
| 9      |      3 |
| -10    |      3 |
| 1024   |     11 |

## VZH2

### How many word in the line
>Write a program that reads a line and prints out how many words are in the line! We consider a single space as the only delimiter.
It can be assumed that the line consists of at most 64 characters.

| Input                            | Output |
| -------------------------------- | ------ |
| alma korte                       |      2 |
| szilva,barack                    |      1 |
| Hany szo van ebben a mondatban?  |      6 |

### Palindrome
>Write a program that reads a line and determines whether it is a palindrome. Palindromes are phrases or sentences that have the same meaning when read backwards.
The program ignores non-letter characters(spaces, commas, etc.)! It is assumed that the input consists of only lowercase letters.
The program returns the word "yes" or "no" as the answer! It is assumed that the line consists of a maximum of 64 characters.

| Input                               | Output |
| ----------------------------------- | ------ |
| indul a görög aludni.               |    yes |
| géza, kék az ég!                    |    yes |
| nehéz ez a feladat                  |     no |
| rám német nem lel, elmentem én már. |    yes |

### Reverse the row
>Write a program that reads a line and prints its reverse! It is assumed that the line consists of at most 64 characters.

| Input                | Output             |
| -------------------- | ------------------ |
| indul a görög aludni |indula görög aludni |
| fordítva             |avtídrof            |

### Border word
>Write a program that reads a line containing two words separated by a single space and determines whether the second word is a border of the first.
A word is a border of another if it is both the beginning and end of it.It is assumed that the line consists of at most 64 characters.

| Input         | Output |
| ------------- | ------ |
| abababa ababa |    yes |
| pompom pom    |    yes |
| alma alma     |    yes |
| alma a        |    yes |
| kerek ke      |     no |


### Lower to Upper or Upper to Lower
>Write a program that reads a line and converts it to the screen in a format that changes all lowercase letters to uppercase and all uppercase letters to lowercase.
It is assumed that the lines contain only letters of the English alphabet, punctuation marks, and spaces.It is assumed that the line consists of at most 64 characters.

| Input               | Output              |
| ------------------- | ------------------- |
| Ez egy pelDaMONdat. | eZ EGY PELdAmonDAT. |

### Substring
>Write a program that reads a line containing two words separated by a single space and searches the first word for the starting position of the first occurrence of the second word.
The program should print -1 if the searched word is not found, otherwise the starting position.
It is assumed that the line consists of at most 64 characters.

| Input          | Output |
| -------------- | ------ |
| almafa alma    |      0 |
| JuhászPici ász |      3 |
| szakest pia    |     -1 |
| nap nappal     |     -1 |


## VZH3

### Sum below the average
>Write a program that reads real numbers from standard input until EOF. Each line contains exactly one number.
The input can contain any number, but it must contain at least one.
The program writes to standard output the sum of the values ​​that are equal to or less than the average of all numbers read!
Use a linked list to solve this problem!

| Input                    | Output  |
| ------------------------ | ------- |
| 3.6 1.2 5 1.48           |    2.68 |
| -5.4 3.2 -524.36 -0 -200 | -724.36 |

### Reverse
>Write a program that reads characters from standard input up to the * character. The characters can be uppercase and lowercase letters of the English alphabet and the * character.
Each line contains exactly one character.The input can contain any number of characters, but it must contain at least one.
The program writes the characters read in reverse order to the standard output, in a single line, replacing lowercase letters with uppercase letters.
The output also contains the* character! Use a linked list to solve this problem!

| Input | Output |
| ------| ------ |
| *     |      * |
| g*    |     *G |
| alMa* |  *AMLA |

### Except
>Write a program that reads nonnegative integers from standard input. Each line contains exactly one number.
The list represents two sequences of numbers, each of which has at least one element, terminated by the number 0. The input can contain any number.
The program writes to standard output the numbers that are in the second sequence but not in the first!
The program writes the resulting sequence of numbers to the output in the same format.The order of the numbers should be the same as the original order.
Use a linked list to solve this problem!

| Input                                           | Output                                                                   |
| ----------------------------------------------- | ------------------------------------------------------------------------ |
| data work product<br />area program system work | data<br />work<br />area<br />work<br />system<br />product<br />program |
| kis kacsa furdik fekete toban                   | kis<br />kacsa<br />toban<br />furdik<br />fekete                        |


### Order by
>Write a program that reads words separated by spaces until the end of the line EOF. The words are separated by whitespace characters (space, tab, and newline).
The length of each word is up to 32 characters.The number of lines and words in a line is arbitrary.
The program prints the words one below the other, sorted by their length in ascending order.In case of the same length, the order of arrival counts.
Use a linked list to solve the problem!

| Input                        | Output   |
| ---------------------------- | -------- |
| 5 2 0<br />7 5 0             | 7 0      |
| 17 2 6 9 0<br />2 4 6 8 10 0 | 4 8 10 0 |

### Concat
>Write a program that reads lines from the standard input. The lines contain a grade and a Neptun code separated by a comma.
The number of lines is arbitrary. The program reads until EOF.
Based on the input, a multilist must be created, in which one chain contains the data according to Neptun code, and the other according to arrival in ascending order.
The program lists the data according to Neptun code, then according to grade.
The two lists are separated by a line containing the characters "---". Separate the grades from the Neptun codes with a space character!
Each grade code should be placed on a new line in pairs.

| Input                                                            | Output                                                                                                                                           |
| ---------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| 5,FRTY5F<br />3,AWSD3E<br />2,BDER3W<br />4,GRTY6R<br />5,QWER3R | 3 AWSD3E<br />2 BDER3W<br />5 FRTY5F<br />4 GRTY6R<br />5 QWER3R<br />---<br />2 BDER3W<br />3 AWSD3E<br />4 GRTY6R<br />5 FRTY5F<br /> 5 QWER3R |
