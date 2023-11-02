using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] notas = {1,2,3};
        int[] notas2 = {10, 10, 10};
        Aluno aluno = new Aluno(1234, "Mario", notas);
        Aluno aluno2 = new Aluno(2345432, "Liedson Barros", notas2);

        imprimir(aluno);
        imprimir(aluno2);

        Console.ReadKey();
    }

    public static void imprimir(Aluno aluno)
    {
        StringBuilder AlunoAbout = new StringBuilder();
        AlunoAbout.Append("Matricula do aluno: " + aluno.GetMatricula() + "\n");
        AlunoAbout.Append("Nome do aluno: " + aluno.GetNome() + "\n");
        AlunoAbout.Append("Notas do aluno: " + aluno.GetNotas(0) + ", " + aluno.GetNotas(1) + ", " + aluno.GetNotas(2) + "\n");

        Console.WriteLine(AlunoAbout.ToString());
    }
    public class Aluno
    {
        private int matricula;
        private String nome;
        private int[] notas;

        public Aluno(int matricula, String nome, int[] notas)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.notas = notas;
        }

        public int GetMatricula(){
            return matricula;
        }
        public String GetNome(){
            return nome;
        }
        public int GetNotas(int nota){
            return notas[nota];
        }
    }
}