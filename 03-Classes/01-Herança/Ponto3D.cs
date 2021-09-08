namespace Classes.Herança
{
   public class Ponto3D : Ponto
   {
      public int z;

      //base faz referência à classe pai. Aqui serve para completar o construtor com o construtor da classe pai
      public Ponto3D(int x, int y, int z) : base(x, y)
      {
         this.z = z;
         CalcularDistancia();
      }

      public static void Calcular()
      {
         //Faz alguma coisa...
      }

      //O override modifica um método virtual vindo da classe pai
      public override void CalcularDistancia3()
      {
         //Faz outra coisa ...
         base.CalcularDistancia3();
      }
   }
}