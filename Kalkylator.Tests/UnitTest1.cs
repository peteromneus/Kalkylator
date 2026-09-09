using Kalkylator;

public class RaknareTests
{
    [Fact]
    public void AdderaTvaPlusTreBlirFem()
    {
        var raknare = new Raknare();
        Assert.Equal(5, raknare.Addera(2, 3));
    }
}
