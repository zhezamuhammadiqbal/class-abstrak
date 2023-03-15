namespace v26
{

    abstract class Kalkulator
    {

        public int kali(int a, int b){
            return a*b;
        }
    }

    class Rumus:Kalkulator
    {

        public int persegi(int p, int l){
            return kali(p,l);
        }
    }
}
