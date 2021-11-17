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
        public void WhenCopyingSingleCharacter1()
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

        /*  calculator
      .Add(Arg.Any<int>(), Arg.Any<int>())
      .Returns(x => (int) x[0] + (int) x[1]);


          /*[Fact]
          public void WhenCopyingMultipleCharacters()
          {
              ;
              var iDestination = Substitute.For<IDestination>();


              var iSource = Substitute.For<ISource>();
              char[] myChar = {',' };
              string myText = "w,w,u,/n";
              string[] charsToPrint = myText.Split(myChar);

              for (int i = 0; i < myText.Length(); i++)
              {
                    char 
                      iSource.When(x => x.ReadChar(Arg.Any<char>())
                        .Returns('w', 'w', 'u'));

                      var Copier = new Copier(iSource, iDestination);

                      Copier.Copy();



              }

                  iDestination.Received(1).WriteChar('w');
                  iDestination.Received(2).WriteChar('w');
                  iDestination.Received(3).WriteChar('u');

              }



          }*/


    }
}