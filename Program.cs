// mensqgem de texto que irá ser mostrada ao usuario, o "enunciado" //
Console.WriteLine("Cifra de Cesar\n");
Console.Write("Digite uma palavra para ser criptografada: ");      
string nome = Console.ReadLine()!;
            
int chave = 3; // nessa linha é informada o número de posições para deslocar //
     
string cifraCesar = CriptografarCesar(nome, chave);
            
Console.WriteLine($"\nSua palavra cifrada é: {cifraCesar}"); // neste bloco é informada a palavra com a cifra de cesar já inclusa //
    
        static string CriptografarCesar(string texto, int chave) // padronização da cifra a ser feita, é fornecido o alfabeto pçara que possa ser criptografado a cifra de cesar //
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz"; 
            string textoCifrado = "";
            
            foreach (char letra in texto)
            {
                if (char.IsLetter(letra))
                {
                    char letraMin = char.ToLower(letra);
                    int indice = (alfabeto.IndexOf(letraMin) + chave) % 26;
                    char letraCifrada = alfabeto[indice];
                    if (char.IsUpper(letra))
                    {
                        letraCifrada = char.ToUpper(letraCifrada);
                    }
                    textoCifrado += letraCifrada;
                }
                else
                {
                    textoCifrado += letra;
                }
            }
            
            return textoCifrado;
        }