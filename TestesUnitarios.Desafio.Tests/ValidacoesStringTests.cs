using TestesUnitarios.Desafio.Services;
namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        var texto = "abcdef";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

        Console.WriteLine($"Resultado-7 esperado ({resultadoEsperado}) = ({resultado}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void DeveConterAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
         var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado);

        Console.WriteLine($"Resultado-8 esperado (true) = ({resultado}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);

        Console.WriteLine($"Resultado-9 esperado (false) = ({resultado}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);

        Console.WriteLine($"Resultado-10 tem que ser True = ({resultado})");
        Console.WriteLine("-------------------------------------------------------------------");
    
    }
    [Fact]
    public void TextoNaoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "texto";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.False(resultado);

        Console.WriteLine($"Resultado-11 tem que ser False = ({resultado})");
        Console.WriteLine("-------------------------------------------------------------------");
    
    }
}
