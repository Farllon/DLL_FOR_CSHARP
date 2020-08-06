# Ferramentas para economia de tempo produzidas em C#

* ## CPF Validator

    Uma ferramenta de verificaçõ de CPF, retorna um valor booleano. True se o CPF é válido, false se é inválido.

    * **Funcionamento:** Link explicativo da validação do cpf: http://www.macoratti.net/alg_cpf.htm

    * **Entrada:** Uma string com o cpf completo sem pontos ou traços.

    * **Saída:** Um valor booleano
    
    * **Uso:** Referencie no seu projeto a dll com o nome Ferramentas.dll contida dentro do seguinte caminho Ferramentas/bin/Debug/. Para utilizar o validador, chame o método CPF.Validate("COLOQUE_AQUI_O_CPF") e guarde o retorno em uma variável do tipo bool.
