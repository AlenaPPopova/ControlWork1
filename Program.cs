string[] Array(string[] array){
    int size = array.Length;
    int count = 0;
    string[] newarray = new string[size];    //Проверяем размер и сравниваем с условием
    for(int i=0; i<size; i++){
        if(array[i].Length<=3){
            newarray[count] = array[i];
            count++;
        }
    }
return newarray;
}

void NewArray1d(string[] array){                   //Вывод нового массива
    for(int i=0; i<array.Length; i++){
        Console.WriteLine(array[i] + " " );
    }
}

string[] array = { "Hello", "2", "Word", ":)" };
string[] PrintArray = Array(array);
NewArray1d(PrintArray);


