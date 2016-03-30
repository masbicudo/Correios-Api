# Correios-Api (Portable)

Biblioteca .Net portável que permite usar o web-service oficial dos Correios:

https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl

Instalando [pacote NuGet](https://www.nuget.org/packages/Correios-Api):

    PM> Install-Package Correios-Api

Exemplos
--------

Obtendo o endereço a partir do CEP de forma assíncrona:

    var service = new CorreiosApi();
    var dados = (await service.consultaCEPAsync("24710480")).@return;

    // lendo o bairro do objeto
    var bairro = dados.bairro;

O método assíncrono possui a propriedade `@return` que por sua vez contém os dados.

Obtendo o endereço a partir do CEP de forma síncrona:

    var service = new CorreiosApi();
    var dados = service.consultaCEP("24710480");

    // lendo o bairro do objeto
    var bairro = dados.bairro;

Nota: essas classes são geradas pelo Visual Studio automaticamente a partir do WSDL.