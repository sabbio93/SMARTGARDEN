namespace WindowsFormsApplication1
{
    class GestoreInformazioni
    {
        Providers _providers;
        //TODO gestore giardino

        public Providers Providers
            {
                get
                {
                    return _providers;
                }

                set
                {
                _providers = value;
                }
            }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            GestoreInformazioni gest = (GestoreInformazioni)obj;
            return _providers.Equals(gest.Providers);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double GetModifierRequirement(Pianta pianta)
        {
            return _providers.GetModifierRequirement(pianta);
        }
    }
}
