namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("\nInformar Nome:");
            string var_nome=Console.ReadLine();
            Console.WriteLine("Informar Endereço:");
            string var_endereço=Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (F) ou Juridica (J):");
            string var_tipo=Console.ReadLine();
            if(var_tipo=="f" || var_tipo=="F")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                
                Console.WriteLine("\nInformar CPF:");
                pf.cpf=Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg=Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag=float.Parse(Console.ReadLine());

                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("\n***** Pessoa Física *****");
                Console.WriteLine("Nome...............: " + var_nome);
                Console.WriteLine("Endereço...........: " + var_endereço);
                Console.WriteLine("CPF................: " + pf.cpf);
                Console.WriteLine("RG.................: " + pf.rg);
                Console.WriteLine("Valor da compra....: " + pf.valor.ToString("C"));
                Console.WriteLine("Valor do imposto...: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Valor total........: " + pf.total.ToString("C") + "\n");
            }
             if(var_tipo=="j" || var_tipo=="J")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                
                Console.WriteLine("\nInformar CNPJ:");
                pj.cnpj=Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie=Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag=float.Parse(Console.ReadLine());

                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("\n***** Pessoa Física *****");
                Console.WriteLine("Nome...............: " + var_nome);
                Console.WriteLine("Endereço...........: " + var_endereço);
                Console.WriteLine("CPF................: " + pj.cnpj);
                Console.WriteLine("RG.................: " + pj.ie);
                Console.WriteLine("Valor da compra....: " + pj.valor.ToString("C"));
                Console.WriteLine("Valor do imposto...: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Valor total........: " + pj.total.ToString("C") + "\n");
            }
            
            Console.WriteLine("Aperte qualquer coisa para sair!\n");
            string saida=Console.ReadLine();
        }
    }
}