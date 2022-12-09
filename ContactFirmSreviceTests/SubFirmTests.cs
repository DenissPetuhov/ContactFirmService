using ContactFirmService.BLL;
using Xunit;

namespace ContactFirmSreviceTests
{
    public class SubFirmTests
    {
        [Fact]
        public void SubFirmIsMain()
        {
            // Arrange
            string mainSubFirmName = "Main SubFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            firmFactory.SetNamesflds("name1", "name3", "name4", "name5", "name6");
            firmFactory.Setflds("flds1", "flds3", "flds4", "flds5", "flds6");
            Firm firm = firmFactory.Create("new Firm");
            // Act
            SubFirm result = firm.subFirms.Find(x=>x.Name== mainSubFirmName);
            // Assert
            Assert.True(result.IsMain);
        }
        [Fact]
        public void SubFirmisMainType()
        {
            // Arrange
            string mainSubFirmName = "Main SubFirm";
            FirmFactory firmFactory = FirmFactory.GetInstance();
            firmFactory.SetNamesflds("name1", "name3", "name4", "name5", "name6");
            firmFactory.Setflds("flds1", "flds3", "flds4", "flds5", "flds6");
            Firm firm = firmFactory.Create("new Firm");
            // Act
            bool result = firm.subFirms.Find(x => x.Name == mainSubFirmName).SbFirmTpy.IsMain;
            // Assert
            Assert.True(result);
        }
    }
}
