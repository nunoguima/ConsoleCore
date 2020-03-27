using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome)
        {
            _Nome = nome; 
        }
        

        public string Chuta()
        {
            return $"{_Nome} está chutar! \n";
        }

         public string Corre()
        {
            return $"{_Nome} está correr! \n";
        }

         public string Passa()
        {
            return $"{_Nome} está passar! \n";
        }
    }
}