
class Aluno
//classes e objetos 
//todo atributo é uma caracteristica da minha class
// metodos são as açoes do nosso objeto
{
    public String Nome;

    public int Idade;


    public String Curso;

}

class program
{

    static void Main()
    {
        Aluno aluno1 = new Aluno();

        aluno1.Nome = "Carlos";
        aluno1.Idade = 18;
        aluno1.Curso = "Programador Full Stack";

        Console.WriteLine(aluno1.Nome);
        Console.WriteLine(aluno1.Idade);
        Console.WriteLine(aluno1.Curso);
    }
}


 
 