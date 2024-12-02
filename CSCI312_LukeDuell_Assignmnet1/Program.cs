/* Luke Duell
 * Instructor: Instructor Murray
 * CSCI 312: Object Oriented Programming w/C#
 * Assignment 1
 * Description: This program takes in a text file
 *              and reads it. The program then checks
 *              for every ASCII character and counts it.
 *              The output of this function is the character,
 *              then ASCII number followed by the number  of
 *              occurrences.
 */

using System;

class charcount
{
    public string CountChars(string source, char toFind, int charnumber)
    {
        string output = "";
        //searching the text file string for the given char
        int SourceCount = source.Count(t => t == toFind);
        //setting up the output for the console write line
        output = toFind + "(" + charnumber.ToString() + ")" + "     " + SourceCount.ToString();
        return output;
    }
}

class WritetoConsole
{
    static void Main()
    {
        charcount charcount = new charcount();
        string[] character = new string[128];

        //reading the text file
        string text = File.ReadAllText("C:\\Users\\luked\\source\\repos\\CSCI312_LukeDuell_Assignmnet1\\CSCI312_LukeDuell_Assignmnet1\\wap.txt");


        //special characters
        character[33] = charcount.CountChars(text, '!', 33);
        character[34] = charcount.CountChars(text, '"', 34);
        character[35] = charcount.CountChars(text, '#', 35);
        character[36] = charcount.CountChars(text, '$', 36);
        character[37] = charcount.CountChars(text, '%', 37);
        character[38] = charcount.CountChars(text, '&', 38);
        character[39] = charcount.CountChars(text, '\'', 39);
        character[40] = charcount.CountChars(text, '(', 40);
        character[41] = charcount.CountChars(text, ')', 41);
        character[42] = charcount.CountChars(text, '*', 42);
        character[43] = charcount.CountChars(text, '+', 43);
        character[44] = charcount.CountChars(text, ',', 44);
        character[45] = charcount.CountChars(text, '-', 45);
        character[46] = charcount.CountChars(text, '.', 46);
        character[47] = charcount.CountChars(text, '/', 47);

        //numbers
        character[48] = charcount.CountChars(text, '0', 48);
        character[49] = charcount.CountChars(text, '1', 49);
        character[50] = charcount.CountChars(text, '2', 50);
        character[51] = charcount.CountChars(text, '3', 51);
        character[52] = charcount.CountChars(text, '4', 52);
        character[53] = charcount.CountChars(text, '5', 53);
        character[54] = charcount.CountChars(text, '6', 54);
        character[55] = charcount.CountChars(text, '7', 55);
        character[56] = charcount.CountChars(text, '8', 56);
        character[57] = charcount.CountChars(text, '9', 57);

        //special characters
        character[58] = charcount.CountChars(text, ':', 58);
        character[59] = charcount.CountChars(text, ';', 59);
        character[60] = charcount.CountChars(text, '<', 60);
        character[61] = charcount.CountChars(text, '=', 61);
        character[62] = charcount.CountChars(text, '>', 62);
        character[63] = charcount.CountChars(text, '?', 63);
        character[64] = charcount.CountChars(text, '@', 64);

        //upper case
        character[65] = charcount.CountChars(text, 'A', 65);
        character[66] = charcount.CountChars(text, 'B', 66);
        character[67] = charcount.CountChars(text, 'C', 67);
        character[68] = charcount.CountChars(text, 'D', 68);
        character[69] = charcount.CountChars(text, 'E', 69);
        character[70] = charcount.CountChars(text, 'F', 70);
        character[71] = charcount.CountChars(text, 'G', 71);
        character[72] = charcount.CountChars(text, 'H', 72);
        character[73] = charcount.CountChars(text, 'I', 73);
        character[74] = charcount.CountChars(text, 'J', 74);
        character[75] = charcount.CountChars(text, 'K', 75);
        character[76] = charcount.CountChars(text, 'L', 76);
        character[77] = charcount.CountChars(text, 'M', 77);
        character[78] = charcount.CountChars(text, 'N', 78);
        character[79] = charcount.CountChars(text, 'O', 79);
        character[80] = charcount.CountChars(text, 'P', 80);
        character[81] = charcount.CountChars(text, 'Q', 81);
        character[82] = charcount.CountChars(text, 'R', 82);
        character[83] = charcount.CountChars(text, 'S', 83);
        character[84] = charcount.CountChars(text, 'T', 84);
        character[85] = charcount.CountChars(text, 'U', 85);
        character[86] = charcount.CountChars(text, 'V', 86);
        character[87] = charcount.CountChars(text, 'W', 87);
        character[88] = charcount.CountChars(text, 'X', 88);
        character[89] = charcount.CountChars(text, 'Y', 89);
        character[90] = charcount.CountChars(text, 'Z', 90);

        //special chars
        character[91] = charcount.CountChars(text, '[', 91);
        character[92] = charcount.CountChars(text, '\\', 92);
        character[93] = charcount.CountChars(text, ']', 93);
        character[94] = charcount.CountChars(text, '^', 94);
        character[95] = charcount.CountChars(text, '_', 95);
        character[96] = charcount.CountChars(text, '`', 96);

        //lower case
        character[97] = charcount.CountChars(text, 'a', 97);
        character[98] = charcount.CountChars(text, 'b', 98);
        character[99] = charcount.CountChars(text, 'c', 99);
        character[100] = charcount.CountChars(text, 'd', 100);
        character[101] = charcount.CountChars(text, 'e', 101);
        character[102] = charcount.CountChars(text, 'f', 102);
        character[103] = charcount.CountChars(text, 'g', 103);
        character[104] = charcount.CountChars(text, 'h', 104);
        character[105] = charcount.CountChars(text, 'i', 105);
        character[106] = charcount.CountChars(text, 'j', 106);
        character[107] = charcount.CountChars(text, 'k', 107);
        character[108] = charcount.CountChars(text, 'l', 108);
        character[109] = charcount.CountChars(text, 'm', 109);
        character[110] = charcount.CountChars(text, 'n', 110);
        character[111] = charcount.CountChars(text, 'o', 111);
        character[112] = charcount.CountChars(text, 'p', 112);
        character[113] = charcount.CountChars(text, 'q', 113);
        character[114] = charcount.CountChars(text, 'r', 114);
        character[115] = charcount.CountChars(text, 's', 115);
        character[116] = charcount.CountChars(text, 't', 116);
        character[117] = charcount.CountChars(text, 'u', 117);
        character[118] = charcount.CountChars(text, 'v', 118);
        character[119] = charcount.CountChars(text, 'w', 119);
        character[120] = charcount.CountChars(text, 'x', 120);
        character[121] = charcount.CountChars(text, 'y', 121);
        character[122] = charcount.CountChars(text, 'z', 122);

        //special characters
        character[123] = charcount.CountChars(text, '{', 123);
        character[124] = charcount.CountChars(text, '|', 124);
        character[125] = charcount.CountChars(text, '}', 125);
        character[126] = charcount.CountChars(text, '~', 126);


        for(int i = 33; i < 127; i++)
        {
            Console.WriteLine($"{character[i]}");
        }

    }
}

