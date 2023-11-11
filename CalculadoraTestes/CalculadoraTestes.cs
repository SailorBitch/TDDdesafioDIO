using CalculadoraPrincipal;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    public Calculadora construirClasse()
    {
        string data = "01/01/2023";
        Calculadora calcu = new Calculadora(data);
        return calcu;
    }

    [Theory]
    [InlineData(1 , 2 , 3)]
    [InlineData(4 , 5 , 9)]
    public void Somar_Valor1EValor2_RetornarResultado(int val1, int val2, int resultado)
    {
        Calculadora calcu = construirClasse();
        
        int resultadoCalculo = calcu.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData(3 , 2 , 1)]
    [InlineData(5 , 4 , 1)]
    public void Subtrair_Valor1EValor2_RetornarResultado(int val1, int val2, int resultado)
    {
        Calculadora calcu = construirClasse();
        
        int resultadoCalculo = calcu.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData(2 , 2 , 4)]
    [InlineData(4 , 4 , 16)]
    public void Multiplicar_Valor1EValor2_RetornarResultado(int val1, int val2, int resultado)
    {
        Calculadora calcu = construirClasse();
        
        int resultadoCalculo = calcu.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData(2 , 2 , 1)]
    [InlineData(20 , 5 , 4)]
    public void Dividir_Valor1EValor2_RetornarResultado(int val1, int val2, int resultado)
    {
        Calculadora calcu = construirClasse();
        
        int resultadoCalculo = calcu.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Fact]
    public void Dividir_PorZero_RetornarException()
    {
        // Given
        Calculadora calcu = construirClasse();
        // When
        int val1 = 3;
        // Then
        Assert.Throws<DivideByZeroException>( 
                () => calcu.Dividir(val1 , 0));
    }

    [Fact]
    public void Historico_RetornarOsTresUltimosCalculos()
    {
        // Given
        Calculadora calcu = construirClasse();
        // When
        calcu.Somar(1,2);
        calcu.Somar(2,2);
        calcu.Somar(3,2);
        calcu.Somar(4,2);

        var lista = calcu.Historico();

        // Then
        Assert.NotEmpty(lista);
        Assert.Equal(3 , lista.Count);
    }

}