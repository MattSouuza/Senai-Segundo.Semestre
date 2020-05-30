/*
Declare uma variável `pessoa`, que receba suas informações pessoais.
As propriedades e tipos de valores para cada propriedade desse objeto devem ser:
- `nome` - String
- `sobrenome` - String
- `genero` - String
- `idade` - Number
- `altura` - Number
- `peso` - Number
- `andando` - Boolean - recebe "falso" por padrão
- `caminhouQuantosMetros` - Number - recebe "zero" por padrão
*/

var person = {
    Name: 'Matheus',
    LastName: 'Souza Silva',
    Gender: 'Masculine',
    Age: 17,
    Hight: 1.74,
    Weight: 55,
    Walking: false,
    WalkedHowManyMeters: 0
}

/*
Adicione um método ao objeto `pessoa` chamado `fazerAniversario`. O método deve
alterar o valor da propriedade `idade` dessa pessoa, somando `1` a cada vez que
for chamado.
*/

person.HaveBirthday = function () {
    person.Age = person.Age + 1;
}

/*
Adicione um método ao objeto `pessoa` chamado `andar`, que terá as seguintes
características:
- Esse método deve receber por parâmetro um valor que representará a quantidade
de metros caminhados;
- Ele deve alterar o valor da propriedade `caminhouQuantosMetros`, somando ao
valor dessa propriedade a quantidade passada por parâmetro;
- Ele deverá modificar o valor da propriedade `andando` para o valor
booleano que representa "verdadeiro";
*/

person.Walk = function (quantitiesMetersWalked) {
    person.WalkedHowManyMeters = person.WalkedHowManyMeters + quantitiesMetersWalked;
    person.Walking = true;
}

/*
Adicione um método ao objeto `pessoa` chamado `parar`, que irá modificar o valor
da propriedade `andando` para o valor booleano que representa "falso".
*/

person.Stop = function () {
    person.Walking = false;
}

/*
Crie um método chamado `nomeCompleto`, que retorne a frase:
- "Olá! Meu nome é [NOME] [SOBRENOME]!"
*/

person.FullName = function () {
    console.log('Hello! My name is ' + person.Name + ' ' + person.LastName + '!')
}

/*
Crie um método chamado `mostrarIdade`, que retorne a frase:
- "Olá, eu tenho [IDADE] anos!"
*/

person.ShowAge = function () {
    console.log('Hello, I am ' + person.Age + ' years old!')
}

/*
Crie um método chamado `mostrarPeso`, que retorne a frase:
- "Eu peso [PESO]Kg."
*/

person.ShowWeight = function () {
    console.log(`I weight ${person.Weight}Kg.`)
}

/*
Crie um método chamado `mostrarAltura` que retorne a frase:
- "Minha altura é [ALTURA]m."
*/

person.ShowHight = function () {
    console.log(`My hight is ${person.Hight}m.`)
}

/*
Agora vamos trabalhar um pouco com o objeto criado:
Qual o nome completo da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(person.FullName());
//Hello! My name is Matheus Souza Silva!

/*
Qual a idade da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(person.ShowAge());
//Hello, I am 17 years old!

/*
Qual o peso da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(person.ShowWeight());
//I weight 55Kg.

/*
Qual a altura da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(person.ShowHight());
//

/*
Faça a `pessoa` fazer 3 aniversários.
*/

person.HaveBirthday()
person.HaveBirthday()
person.HaveBirthday()


/*
Quantos anos a `pessoa` tem agora? (Use a instrução para responder e
comentários inline ao lado da instrução para mostrar qual foi a resposta
retornada)
*/

console.log(person.ShowAge());
person.Age = 17;
//Hello, I am 20 years old!

/*
Agora, faça a `pessoa` caminhar alguns metros, invocando o método `andar` 3x,
com as distâncias diferentes passadas por parâmetro.
*/
person.Walk(981);
person.Walk(548);
person.Walk(364);

/*
A pessoa ainda está andando? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

person.IsPersonWalking = function () {
    if (person.Walking === true) {
        console.log(`${person.Name} is still walking.`)
    } else {
        console.log(`${person.Name} is no longer walking.`)
    }
}

person.IsPersonWalking();
//The person is still walking.

/*
Se a pessoa ainda está andando, faça-a parar.
*/

person.Stop();

/*
E agora: a pessoa ainda está andando? (Use uma instrução para responder e
comentários inline ao lado da instrução para mostrar a resposta retornada)
*/

person.IsPersonWalking();
//The person is no longer walking.

/*
Quantos metros a pessoa andou? (Use uma instrução para responder e comentários
inline ao lado da instrução para mostrar a resposta retornada)
*/

person.HowFarWalked = function () {
    console.log(`${person.Name} walked ${this.WalkedHowManyMeters}m.`)
}

person.HowFarWalked();
//Matheus walked 1893m.

/*
Agora, vamos deixar a brincadeira um pouco mais divertida! :D
Crie um método para o objeto `pessoa` chamado `apresentacao`. Esse método deve
retornar a string:
- "Olá, eu sou o [NOME COMPLETO], tenho [IDADE] anos, [ALTURA], meu peso é [PESO] e, só hoje, eu já caminhei [CAMINHOU QUANTOS METROS] metros!"

Só que, antes de retornar a string, você vai fazer algumas validações:
- Se o `genero` de `pessoa` for "Feminino", a frase acima, no início da
apresentação, onde diz "eu sou o", deve mostrar "a" no lugar do "o";
- Se a idade for `1`, a frase acima, na parte que fala da idade, vai mostrar a
palavra "ano" ao invés de "anos", pois é singular;
- Se a quantidade de metros caminhados for igual a `1`, então a palavra que
deve conter no retorno da frase acima é "metro" no lugar de "metros".
- Para cada validação, você irá declarar uma variável localmente (dentro do
método), que será concatenada com a frase de retorno, mostrando a resposta
correta, de acordo com os dados inseridos no objeto.
*/

person.Presentation = function () {
    var article
    var singularYear
    var singularMeter

    if (person.Gender === 'Feminine') {
        article = 'a'
    } else {
        article = 'o'
    }

    if (person.Age === 1) {
        singularYear = 'ano'
    } else {
        singularYear = 'anos'
    }

    if (person.WalkedHowManyMeters === 1) {
        singularMeter = 'metro'
    } else {
        singularMeter = 'metros'
    }

    console.log(`Olá! Eu sou ${article} ${person.Name} ${person.LastName},
tenho ${person.Age} ${singularYear}, ${person.Hight} de altura,
meu peso é ${person.Weight}Kg e, só hoje,
eu já caminhei ${person.WalkedHowManyMeters} ${singularMeter}!`)
} 

/* Agora, apresente-se. */

console.log('')
person.Presentation();