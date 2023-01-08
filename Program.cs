int n;
Console.WriteLine("Введите количество элементов массива: ");
n = int.Parse(Console.ReadLine());
string[] array;
array = new string[n];
array = CreateMas(n);
string[] Maas;
Maas=ChangeMas(array,n);
ShowMas(Maas);

string[] CreateMas(int n){
    array = new string[n];
    for(int i=0;i<n;i++){
        Console.WriteLine("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] ChangeMas(string[] array, int n){
    int summ = 0;
    for(int i=0;i<n;i++){
        if(array[i].Length<=3){
            summ+=1;
        }
    }
    Maas = new string[summ];
    int j=0;
    for(int i=0;i<n;i++){
        if(array[i].Length<=3){
            Maas[j] = array[i];
            j++;
        }
    }
    return Maas;
}
void ShowMas(string[] Maas){
    int m = Maas.Length;
    for(int i=0;i<m;i++){
        Console.Write($"{Maas[i]}  ");
    }
}