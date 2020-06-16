using System;

namespace Oof
{
    public static class Rechner
    {
        // Main Methode
        private static void Main(string[] args)
        {
            // Ausführung des Rechners
            MeinTaschenrechner();
        }

        // Taschenrechner Methode
        private static void MeinTaschenrechner()
        {
            try
            {
                // Console Clear, Ausgabe des ersten Textes und lesen- und speicherung der ersten Zahl
                Console.Clear();
                WriteInfo("Willkommen beim besten Taschenrechner der Welt!\nBitte geben Sie Ihre erste Zahl an:");
                string string1 = Console.ReadLine();

                // Ausgabe des zweiten Textes und lesen- und speicherung der zweiten Zahl
                WriteInfo("Bitte geben Sie nun Ihre zweite Zahl an:");
                string string2 = Console.ReadLine();
                
                // Umwandlung der eingegebenen Zahlen
                float num1 = float.Parse(string1);
                float num2 = float.Parse(string2);

                // Ausgabe des dritten Textes und lesen- und speicherung des eingegebenem Zeichen
                WriteInfo("Bitte geben Sie nun eines dieser Zeichen an,\n mit welches Sie die Zahlen berechnen wollen: +, -, *, /, %");
                string mathOperator = Console.ReadLine();
                // Umwandlung des Zeichens in Char
                char mathOperatorToChar = char.Parse(mathOperator);

                // Abfrage ob kein passendes Zeichen angegeben wurde
                if (mathOperatorToChar != '+' && mathOperatorToChar != '-' && mathOperatorToChar != '*' && mathOperatorToChar != '/' && mathOperatorToChar != '%')
                {
                    // Fehlermeldung wenns stimmt
                    WriteError("Sie haben ein falsches Zeichen angegeben!");
                    Console.ReadKey();
                    MeinTaschenrechner();
                }
                else
                {
                    // Abfragen welches Zeichen eingegeben wurde
                    if (mathOperatorToChar == '+')
                    {
                        // Berechnung und ausgabe der Zahlen und des Ergebnisses mit +
                        float result = num1 + num2;
                        WriteSuccess("Berechnung fertig! Dein Ergebnis:\n" + num1 + " + " + num2 + " = " + result);
                        Console.ReadKey();
                        MeinTaschenrechner();
                    }
                    else if (mathOperatorToChar == '-')
                    {
                        // Berechnung und ausgabe der Zahlen und des Ergebnisses mit -
                        float result = num1 - num2;
                        WriteSuccess("Berechnung fertig! Dein Ergebnis:\n" + num1 + " - " + num2 + " = " + result);
                        Console.ReadKey();
                        MeinTaschenrechner();
                    }
                    else if (mathOperatorToChar == '*')
                    {
                        // Berechnung und ausgabe der Zahlen und des Ergebnisses mit /
                        float result = num1 * num2;
                        WriteSuccess("Berechnung fertig! Dein Ergebnis:\n" + num1 + " / " + num2 + " = " + result);
                        Console.ReadKey();
                        MeinTaschenrechner();
                    }
                    else if (mathOperatorToChar == '/')
                    {
                        // Berechnung und ausgabe der Zahlen und des Ergebnisses mit *
                        float result = num1 / num2;
                        WriteSuccess("Berechnung fertig! Dein Ergebnis:\n" + num1 + " * " + num2 + " = " + result);
                        Console.ReadKey();
                        MeinTaschenrechner();
                    }
                    else if (mathOperatorToChar == '%')
                    {
                        // Berechnung und ausgabe der Zahlen und des Ergebnisses mit %
                        float result = num1 % num2;
                        WriteSuccess("Berechnung fertig! Dein Ergebnis:\n" + num1 + " % " + num2 + " = " + result);
                        Console.ReadKey();
                        MeinTaschenrechner();
                    }
                }
            }
            // Error Abfang bei leer eingabe einer Zahlenabfrage
            catch (ArgumentNullException)
            {
                // Textausgabe und neustart des Rechners
                WriteError("Bitte lasse das Zahlenfeld nicht leer!");
                Console.ReadKey();
                MeinTaschenrechner();
            }
            // Error Abfang bei falsch eingabe einer Zahlenabfrage
            catch (FormatException)
            {
                // Textausgabe und neustart des Rechners
                WriteError("Bitte gebe im Zahlenfeld nur Zahlen an: 1 2 3 4 5 6 7 8 9 0");
                Console.ReadKey();
                MeinTaschenrechner();
            }
        }

        // Eigene WriteLine Methode
        private static void WriteLine(ConsoleColor _c, string _prefix, string _text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(DateTime.Now.ToLongTimeString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] [");
            Console.ForegroundColor = _c;
            Console.Write(_prefix);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] :: ");
            Console.WriteLine(_text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        // Informationen
        private static void WriteInfo(string _text)
        {
            WriteLine(ConsoleColor.Yellow, "INFO", _text);
        }

        // Fehlermeldung
        private static void WriteError(string _text)
        {
            WriteLine(ConsoleColor.Red, "FEHLER", _text);
        }
        
        // Erfolgreich
        private static void WriteSuccess(string _text)
        {
            WriteLine(ConsoleColor.Green, "ERFOLGREICH", _text);
        }
    }
}
