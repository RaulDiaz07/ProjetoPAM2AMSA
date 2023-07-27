// See https://aka.ms/ information
int n1;
int n2;
Console.WriteLine("Digite os numeros a serem comparados");
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());



if(n1<n2){
Console.WriteLine($"O maior numero dentre os dois é o {n2}");

}

else if(n1==n2){
    Console.WriteLine("Os Numeros são iguais, não a Diferenças");
}
else Console.WriteLine($"O maior numero dentre os dois é o {n1}");


