using Framework;

namespace FrameworkTests 
{
    public class CloudGoogleTests : CommonConditions
    {
        [Test]
        public void TestComputeEngine()
        {
            //Arange
            Model operatingSystem = ModelCreator.ReturnOperatingSystemOs();
            Model machine = ModelCreator.ReturnMachine();
            Model gpu = ModelCreator.ReturnGpu();
            Model ssd = ModelCreator.ReturnSsd();
            Model region = ModelCreator.ReturnRegion();

            //Act
            CloudGooglePage cloudGooglePage = new CloudGooglePage(driver).OpenPage();
            cloudGooglePage.ClickAddToEstimate();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickComputeEngine();
            cloudGooglePage.ClickNumberOfInstances();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickOperatingSystem();
            cloudGooglePage.ClickOperatingSystemUbuntu();
            cloudGooglePage.ClickProvisioningModel();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickMachineType();
            cloudGooglePage.ClickMachineTypeN1();
            cloudGooglePage.ClickAddGPU();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickGPUModel();
            cloudGooglePage.ClickGPUModelV100();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickNumberOfGPU();
            cloudGooglePage.ClickNumberOfGPU8();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickLocalSSD();
            cloudGooglePage.ClickLocalSSD2();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickRegion();
            cloudGooglePage.ClickRegionTaiwan();
            cloudGooglePage.Pause();
            cloudGooglePage.ClickShare();
            cloudGooglePage.ClickEstimateSummary();
            cloudGooglePage.Pause();

            //Assert
            string Clean(string input) => input.Replace("\r", "").Replace("\n", "").Replace("\t", "").Trim();
            string actualResult = cloudGooglePage.ReturnResultMachineType();
            string cleanActualResult = Clean(actualResult);

            Assert.That(cleanActualResult, Does.Contain(operatingSystem.GetExpectedResult));
            Assert.That(cleanActualResult, Does.Contain(machine.GetExpectedResult));
            Assert.That(cleanActualResult, Does.Contain(gpu.GetExpectedResult));
            Assert.That(cleanActualResult, Does.Contain(ssd.GetExpectedResult));
            Assert.That(cleanActualResult, Does.Contain(region.GetExpectedResult));
        }
    }
}

