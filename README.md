<h1> <img style="vertical-align:bottom;" src="https://raw.githubusercontent.com/masbicudo/Correios-Api/master/icon-256.png" width="48" height="48" /> Correios-Api (Portable)</h1>


Biblioteca portável desenvolvida utilizando-se o **web-service oficial dos Correios**:

 - https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl

Conta com interfaces síncronas e assíncronas (async/await).

O código é **gerado automaticamente** pelo Visual Studio a partir do WSDL dos Correios,
ao invés de fazer parse de HTML. **Dessa forma não há possibilidade de erros**.

Instalando [pacote NuGet](https://www.nuget.org/packages/Correios-Api):

    PM> Install-Package Correios-Api

Exemplos
--------

**Obtendo o endereço a partir do CEP de forma assíncrona:**

    var service = new CorreiosApi();
    var dados = (await service.consultaCEPAsync("24710480")).@return;

    // lendo o bairro do objeto
    var bairro = dados.bairro;

O método assíncrono possui a propriedade `@return` que por sua vez contém os dados.

**Obtendo o endereço a partir do CEP de forma síncrona:**

    var service = new CorreiosApi();
    var dados = service.consultaCEP("24710480");

    // lendo o bairro do objeto
    var bairro = dados.bairro;

Nota: essas classes são geradas pelo Visual Studio automaticamente a partir do WSDL.

Licença
-------

Essa licença refere-se ao código fonte:

[Apache 2.0](https://raw.githubusercontent.com/masbicudo/Correios-Api/master/LICENSE)

Note que o uso dos serviços dos Correios requer a aceitação de uma licença de uso do serviço.
Essa licença esta descrita no manual linkado abaixo. Seguem os trechos mais relevantes:

 - Os Correios disponibilizam **gratuitamente**, para clientes **com contrato**, um conjunto
de operações acessíveis via Web Service que possibilitam a integração do Gerenciador
de Postagem dos Correios – SIGEP WEB com sistemas proprietários de cliente

 - **Pré-Requisitos**

    Para ter acesso a este serviço, o cliente necessitará:

    - Possuir contrato com os Correios;
    - Solicitar ao representante comercial da ECT permissão de acesso para utilização do Web Service através de login e senha;
    - Implementar em seu sistema proprietário as funcionalidades necessárias para integração com os métodos descritos neste documento a exemplo da seqüência lógica aqui descrita.

Documentação oficial do Web-Service
-----------------------------------

[Manual de Implementação do Web Service SIGEPWEB Logistica Reversa](http://www.corporativo.correios.com.br/encomendas/sigepweb/doc/Manual_de_Implementacao_do_Web_Service_SIGEP_WEB.pdf)
