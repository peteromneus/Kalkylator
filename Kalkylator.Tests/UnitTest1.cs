using Kalkylator;

public class RaknareTests
{
    [Fact]
    public void AdderaTvaPlusTreBlirFem()
    {
        var raknare = new Raknare();
        Assert.Equal(6, raknare.Addera(2, 3));
    }
}
