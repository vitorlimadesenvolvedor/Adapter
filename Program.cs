// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var servicoLegado = new ServicoLegado(); 
ICliente clienteUsandoLegado = new Adapter(servicoLegado);
Console.WriteLine(clienteUsandoLegado.ObterServico());

ICliente cliente = new Cliente();
Console.WriteLine(cliente.ObterServico());


public class Adapter : ICliente
{
    private readonly IServicoLegado _servicoLegado;
    public Adapter(IServicoLegado servicoLegado)
    {
        _servicoLegado = servicoLegado;
    }

    public int ObterServico()
    {
         return int.Parse(_servicoLegado.ObterServicoAntigo().ToString());
    }
}

public class Cliente : ICliente
{

    public int ObterServico()
    {
        return 321;
    }
}


public interface ICliente
{
    int ObterServico();

}

public class ServicoLegado : IServicoLegado
{

    public long ObterServicoAntigo()
    {
        return 123;
    }

}

public interface IServicoLegado
{
    long ObterServicoAntigo();
}

