using System;

using System.Collections.Generic;



public class BookStore<T>
{
    //  public T Book { get; set; }
    public T[] store;
    public BookStore()
    {
        store = new T[10];
    }
    public BookStore(int lenght)
    {
        store = new T[lenght];
    }
    public T this[int index]
    {

        get
        {
            if (index < 0 || index >= store.Length)
                throw new IndexOutOfRangeException("Index out of range");
            return store[index];
        }
        set
        {
            if (index < 0 || index >=store.Length)
                throw new IndexOutOfRangeException("Index out of range");
            store[index] = value;
        }
    }
    public int Length {

        get
        {
            return store.Length;
        }

    }



}
class Program
{
    static void Main(string[] args)
    {

        //BookStore<string> store = new BookStore<string>();
        //store.Book = "To jest fajna ksiazka";
        //Console.WriteLine(store.Book);
        //BookStore<int> istore = new BookStore<int>();
        //istore.Book = 1283;
        //Console.WriteLine(istore.Book);



        BookStore<int> istore = new BookStore<int>();
        istore[0] = 100;
        istore[1] = 25;
        istore[2] = 30;
        for (int i = 0; i < istore.Length; i++)
        {
            Console.WriteLine(istore[i]);
        }
        BookStore<string> names = new BookStore<string>();
        names[0] = "Tomek";
        names[1] = "Jacek";
        names[2] = "Krzysiek";
        names[3] = "Paweł";
        for (int i = 0; i<names.Length; i++)
        {

            Console.WriteLine(names[i]);

        }












    }












}











