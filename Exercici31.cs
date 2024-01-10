/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 10/01/2024
 * Exercici 31.En l’estudi on estàs fent les pràctiques, volen llençar un nou videojoc. Les tasques que t’han assignat són crear les rutines següents que s’afegiran al programa que està implementant tot l’equip:
 *     - Demanar a l’usuari el nom del personatge amb el que vol jugar. La rutina ha de validar que el nom no superi els 10 caràcters.
 *     - Demanar a l’usuari que introdueixi un nombre dins del rang [1,500].
 *     - Generar un valor aleatori (posició del mapa) entre el 1 i el 100.
 *
 */


namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string AskName = "Introdueix un nombre:";
            const string MsgValidName = "El nombre es valid.";
            const string MsgInvalidName = "El nombre es invalid.";
            const string AskNum = "Introdueix un numero dins del rang {0} - {1}:";
            const string MsgSelectedNumber = "El numero introduit es: {0}";
            const string MsgMapPosition = "La posicio aleatoria es: {0}";
            const int MinRange = 1, MaxRange = 500, MinMap = 1, MaxMap = 100;

            Console.WriteLine(AskName);
            string name = Console.ReadLine()!;
            Console.WriteLine(CharacterNameValidator(name)? MsgValidName : MsgInvalidName);

            Console.WriteLine(AskNum, MinRange, MaxRange);
            int num = NumberInRange(MinRange, MaxRange);
            Console.WriteLine(MsgSelectedNumber, num);

            int rand = RandomValue(MinMap, MaxMap);
            Console.WriteLine(MsgMapPosition, rand);

        }
        public static bool CharacterNameValidator(string name)
        {
            return name.Length <= 10;
        }

        public static int NumberInRange(int min, int max)
        {
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());

            } while (num < min || num > max);

            return num;
        }

        public static int RandomValue(int min, int max)
        {
            Random randValue = new Random();
            return randValue.Next(min, max);
        }
    }
}
