using TestesUnitarios.Desafio.Services;
namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

        // Imprime o resultado de forma legível
        Console.WriteLine($"Resultado-1 esperado ({string.Join(", ", resultadoEsperado)}) = ({string.Join(", ", resultado)}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);

        Console.WriteLine($"Resultado-2 tem que ser True = ({resultado})");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);

        Console.WriteLine($"Resultado-3 tem que ser False = ({resultado})");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Theory]
    [InlineData(new[] { 5, 7, 8, 9 })] 
    public void DeveMultiplicarOsElementosDaListaPor2(int[] array)
    {
        // Converte o array para uma lista
        var lista = new List<int>(array);

        // Arrange
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

        Console.WriteLine($"Resultado-4 esperado ({string.Join(", ", resultadoEsperado)}) = ({string.Join(", ", resultado)}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = 9;

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

        Console.WriteLine($"Resultado-5 esperado ({resultadoEsperado}) = ({resultado}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = -8;

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

        Console.WriteLine($"Resultado-6 esperado ({resultadoEsperado}) = ({resultado}) Resultado");
        Console.WriteLine("-------------------------------------------------------------------");
    
    }
}
