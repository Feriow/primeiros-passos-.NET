namespace Classes.Herança
{
   public class Ponto
   {
      public int x, y;

      private int distancia;

      public Ponto(int x, int y)
      {
         this.x = x;
         this.y = y;
      }

      protected void CalcularDistancia()
      {
         //Faz alguma coisa
      }

      private void CalcularDistancia2()
      {
         //Faz outra coisa
      }

      //Virtual permite que a classe filha faça override no método
      public virtual void CalcularDistancia3()
      {
         //Faz outra coisa
      }


   }
}