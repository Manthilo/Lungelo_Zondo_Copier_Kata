using NSubstitute;
using Xunit;

namespace CharacterCopierKata.Tests
{
    public class CopierShould
    {
        [Fact]
       public void WhenCopyingSingleCharacter()
        {
            var iSource = Substitute.For<ISource>();
            var iDestination = Substitute.For<IDestination>();
            //l/n+
            var str = "l\n";
            var index = 0;
            iSource.ReadChar().Returns<char>(x => {
                var val = str[index];
                index++;
                return val;
            });


            var Copier = new Copier(iSource, iDestination);


            Copier.Copy();

            iDestination.Received().WriteChar('l');

        }
        [Fact]
        public void WhenCopyingMultipleCharacters()
        {
            var iSource = Substitute.For<ISource>();
            var iDestination = Substitute.For<IDestination>();
            //l/n
            var str = "asdffd\n";
            var index = 0;
            iSource.ReadChar().Returns<char>(x =>{
                var val = str[index];
                index++;
                return val;
            });


            var Copier = new Copier(iSource, iDestination);


            Copier.Copy();

            iDestination.Received().WriteChar('a');
            iDestination.Received().WriteChar('s');
            iDestination.Received().WriteChar('d');
            iDestination.Received().WriteChar('f');
            iDestination.Received().WriteChar('f');
            iDestination.Received().WriteChar('d');

        }



    }
}
