Roman Numeral
	A Roman numeral represents an integer using letters. Examples are XVII to represent 17, MCMLIII for 1953,
	and MMMCCCIII for 3303. By contrast, ordinary numbers such as 17 or 1953 are called Arabic numerals. 
	The following table shows the Arabic equivalent of all the single-letter Roman numerals:

      M    1000            X   10
      D     500            V    5
      C     100            I    1
      L      50
   When letters are strung together, the values of the letters are just added up, with the following 
   exception. When a letter of smaller value is followed by a letter of larger value, the smaller value is 
   subtracted from the larger value. For example, IV represents 5 - 1, or 4. And MCMXCV is interpreted 
   as M + CM + XC + V, or 1000 + (1000 - 100) + (100 - 10) + 5, which is 1995. In standard Roman numerals, 
   no more than thee consecutive copies of the same letter are used. Following these rules, every number 
   between 1 and 3999 can be represented as a Roman numeral made up of the following one- and two-letter 
   combinations:

      M    1000            X   10
      CM    900            IX   9
      D     500            V    5
      CD    400            IV   4
      C     100            I    1
      XC     90
      L      50
      XL     40
Write a class to represent Roman numerals. The class should have two constructors. One constructs a Roman 
numeral from a string such as "XVII" or "MCMXCV". It should throw a NumberFormatException if the string is 
not a legal Roman numeral. The other constructor constructs a Roman numeral from an int. It should throw a 
NumberFormatException if the int is outside the range 1 to 3999.

In addition, the class should have two instance methods. The method toString() returns the string that 
represents the Roman numeral. The method toInt() returns the value of the Roman numeral as an int.