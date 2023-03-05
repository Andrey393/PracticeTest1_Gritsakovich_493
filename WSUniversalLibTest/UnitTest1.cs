using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;
namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculation calculation = new Calculation();

        [TestMethod]
        public void GetQuantityForProduct_PositiveTesting()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            int expectedResult = 114146;
           
            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest,materialTypeTest,countTest,widthTest,lengthTest);

            //Assert
             Assert.AreEqual(expectedResult, actualResult);            
           
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            //Arrange
            int productTypeTest = -3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            int expectedResult = -1;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = -1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            int expectedResult = -1;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentCount()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = -15;
            float widthTest = 20;
            float lengthTest = 45;

            int expectedResult = -1;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidthTest()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = -20;
            float lengthTest = 45;

            int expectedResult = -1;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentLengthTest()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = -45;

            int expectedResult = -1;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_ProductType_1_coefficientProductType_1_1()
        {
            //Arrange
            int productTypeTest = 1;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 1.1;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.coefficientProductType);

        }

        [TestMethod]
        public void GetQuantityForProduct_ProductType_2_coefficientProductType_2_5()
        {
            //Arrange
            int productTypeTest = 2;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 2.5;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.coefficientProductType);

        }


        [TestMethod]
        public void GetQuantityForProduct_ProductType_3_coefficientProductType_8_43()
        {
            //Arrange
            int productTypeTest = 3; //2
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 8.43;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.coefficientProductType);

        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType_1_CoefficientMaterialType_0_3()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1; //7
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 0.3;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.coefficientMaterialType);

        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType_2_CoefficientMaterialType_0_12()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 2;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 0.12;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.coefficientMaterialType);

        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIs20_LengthIs45_PloshadEqual900()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 900;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.ploshad);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoLaunchClass()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 0;

            //Act
           // int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.coefficientMaterialType);

        }

        [TestMethod]//
        public void GetQuantityForProduct_QualityRaw()
        {
            //Arrange
            int productTypeTest = 3;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expectedResult = 113805;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, calculation.qualityRaw);

        }

        [TestMethod]//

        public void GetQuantityForProduct_ConvertProductTypeFloat_ToInt()
        {
            float productTypeFloat = 2.55f; //2.5f

            //Arrange
            int productTypeTest = 0;
            int materialTypeTest = 1;
            int countTest = 15;
            float widthTest = 0;
            float lengthTest = 45;

            productTypeTest = Convert.ToInt32(productTypeFloat);

            double expectedResult = 3;

            //Act
            int actualResult = calculation.GetQuantityForProduct(productTypeTest, materialTypeTest, countTest, widthTest, lengthTest);

            //Assert
            Assert.AreEqual(expectedResult, productTypeTest);

        }
    }

}
