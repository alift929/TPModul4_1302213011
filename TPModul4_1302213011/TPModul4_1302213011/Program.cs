// See https://aka.ms/new-console-template for more information

public class KodePos
{
    public enum Kelurahan
    {
        Batununggal, Kujangsari, Mengger, Wates, Cijaura, 
        Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
    }

    public static int getKodePos(Kelurahan kel)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodePos[(int)kel];
    }

}

public class DoorMachine
{
    enum State { Terkunci, Terbuka };
    public static void Main()
    {
        KodePos kodePos = new KodePos();
        int kode = KodePos.getKodePos(KodePos.Kelurahan.Mengger);
        Console.WriteLine("Kode Pos Mengger: " + kode + "\n");

        State state = State.Terkunci;
        string[] screen = { "Pintu Terkunci", "Pintu Tidak Terkunci" };

        while(state != null)
        {
            Console.WriteLine(screen[(int)state]);
            Console.Write("Command: ");
            string command = Console.ReadLine();
            switch (state)
            {
                case State.Terkunci:
                    if(command == "KunciPintu")
                    {
                        state = State.Terkunci;
                    }else if(command == "BukaPintu")
                    {
                        state = State.Terbuka;
                    }
                    break;

                case State.Terbuka:
                    if(command == "BukaPintu")
                    {
                        state = State.Terbuka;
                    }else if(command == "KunciPintu")
                    {
                        state = State.Terkunci;
                    }
                    break;
            }
        }

    }
}

