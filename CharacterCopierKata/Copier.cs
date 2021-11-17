using System;

namespace CharacterCopierKata
{
    public class Copier
    {
        private readonly ISource source;
        private readonly IDestination destination;

        public Copier(ISource source, IDestination destination)
        {
            this.source = source;
            this.destination = destination;
        }

        public void Copy()
        {
            var characterToPrint = ' ';
            do
            {
                characterToPrint = source.ReadChar();
                destination.WriteChar(characterToPrint);
                

            } while (characterToPrint != '\n');
        }
    }
}