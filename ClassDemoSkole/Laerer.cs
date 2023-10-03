namespace ClassDemoSkole
{
    public class Laerer
    {
        /*
         * InstansFelter
         */

        private string _navn;
        private string _uddannelse;
        private string _viden;
        private int _alder;

        /*
         * Properties
         */

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Uddannelse
        {
            get { return _uddannelse; }
            set { _uddannelse = value; }
        }
        public string Viden
        {
            get { return _viden; }
            set { _viden = value; }
        }

        //public String GetViden()
        //{
        //    return _viden;
        //}
        //public void SetViden(string viden)
        //{
        //    _viden = viden;
        //}

        public int Alder
        {
            get { return _alder; }
            set { _alder = value; }
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Uddannelse)}={Uddannelse}, {nameof(Viden)}={Viden}, {nameof(Alder)}={Alder.ToString()}}}";
        }
    }
}
