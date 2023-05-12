Random rnd = new Random();
int[] Senha = new int[4];
int[] Jogada = new int[4];

#region GERAR A SENHA
for (int i = 0; i < Senha.Length; i++)
{
    Senha[i] = rnd.Next(1,6);
    //Console.WriteLine(Senha[i]);
}
#endregion
    #region ENTRADA DA JOGADA
    for (int i = 0; i < Jogada.Length; i++)
    {
        Console.Write("Entre com a jogada " + i + ":");
        Jogada[i] = Convert.ToInt32(Console.ReadLine());
    }
    #endregion

    #region COMPARAR A JOGADA
    for (int i = 0; i < Senha.Length; i++)
    {
        if (Senha[i] == Jogada[i])
        {
            Console.Write(" * ");
        }
        else
        {
            Console.Write(" ? ");
        }
    }
    #endregion
