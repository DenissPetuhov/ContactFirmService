using ContactFirmService.BLL;
using Xunit;

namespace ContactFirmSreviceTests
{
    public class FirmTests
    {
        [Fact]
        public void FirmCreateMainSubFirmDetectet()
        {

            // Arrange
            string mainSubFirmName = "Main SubFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            firmFactory.SetNamesflds("name1", "name3", "name4", "name5", "name6");
            firmFactory.Setflds("flds1", "flds3", "flds4", "flds5", "flds6");
            Firm firm = firmFactory.Create("Новя фирма");
            // Act
            string result = firm.subFirms[0].Name;
            // Assert
            Assert.Equal(mainSubFirmName, result);
        }
        [Fact]
        public void FirmAddContactDetected()
        {
            // Arrange
            ContType contType = new ContType();
            Contact contact = new Contact(contType);
            FirmFactory firmFactory = FirmFactory.GetInstance();
            firmFactory.SetNamesflds("name1", "name3", "name4", "name5", "name6");
            firmFactory.Setflds("flds1", "flds3", "flds4", "flds5", "flds6");
            Firm firm = firmFactory.Create("Новя фирма");
            firm.AddCont(contact);
            // Act
            Contact result = firm.subFirms[0].ExistContact()[0];
            // Assert
            Assert.Equal(contact, result);
        }
        [Fact]
        public void FirmAddNewSubFirm()
        {
            // Arrange
            string subFirmName = "Second SubFirm";
            SbFirmType sbFirmType = new SbFirmType();
            FirmFactory firmFactory = FirmFactory.GetInstance();
            firmFactory.SetNamesflds("name1", "name3", "name4", "name5", "name6");
            firmFactory.Setflds("flds1", "flds3", "flds4", "flds5", "flds6");
            Firm firm = firmFactory.Create("Новя фирма");
            firm.AddSbFirm(subFirmName, sbFirmType);
            // Act
            SubFirm result = firm.subFirms.Find(x => x.Name == subFirmName);
            // Assert
            Assert.Equal(subFirmName, result.Name);
        }

    }
}
