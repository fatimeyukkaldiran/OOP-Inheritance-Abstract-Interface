namespace OOPExercise
{
    class Customer
    {
        //public string name; field tanımlama
        //Müşterinin özellikleri tanımlanıyor
        public int Id { get; set; } //property / özellik tutmakta/ nesnelerin özelliği
        //public string FirstName { get; set; } // set etmek - değer vermek
        public string LastName { get; set; } // get etmek-
        public string City { get; set; }
        public string FirstName { get; set; }

       /* çok tercih edilmiyor şimdilerde
        * public string _name; 
         public string FirstName
        {
            get { return "Mrs." + _name; } //propertiye ekstra değer eklemek istersek böyle yapabiliriz
            set { _name = value; }
        } */
    }
}