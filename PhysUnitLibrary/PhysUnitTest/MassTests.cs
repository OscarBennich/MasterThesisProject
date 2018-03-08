using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Mass_Units;
using System;

namespace PhysUnitTest
{
    [TestClass]
    public class MassTests
    {
        //[TestMethod]
        //public void ConversionFromAtomicMassToKilo()
        //{
        //    int value = 100;
        //    Kilogram kilogram = new Pound(value);

        //    Assert.AreEqual(expected: value * (1.660539040 * Math.Pow(10, -27)), actual: kilogram.Value);
        //}

        [TestMethod]
        public void MassAdditionExceptions()
        {
            Kilogram kilogram = new Kilogram(100); // No range set on this
            Kilogram kilogram2 = new Kilogram(200,10,340);

            Kilogram kilogram3 = kilogram + kilogram2;
                
            Assert.AreEqual(expected: 100 + 200, actual: kilogram3.Value);
        }

        //#region Conversion Tests

        //#region Atomic Mass Conversion Tests

        //[TestMethod]
        //public void ConversionFromAtomicMassToKilo()
        //{
        //    long value = 10000000000000000;
        //    Kilogram kilogram = new AtomicMass(value);

        //    Assert.AreEqual(expected: value * (1.660539040 * Math.Pow(10, -27)), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void ConversionFromAtomicMassToPlanckMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromAtomicMassToPound()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromAtomicMassToSlug()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromAtomicMassToSolarMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromAtomicMassToTonne()
        //{
        //    int value = 10000000;
        //    Tonne tonne = new AtomicMass(value);

        //    Assert.AreEqual(expected: value * (1.660539040 * Math.Pow(10, -27)) / 1000, actual: tonne.Value);
        //}
        //#endregion

        //#region Kilogram Conversion Tests
        //[TestMethod]
        //public void ConversionFromKiloToAtomicMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromKiloToPlanckMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromKiloToPound()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromKiloToSlug()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromKiloToSolarMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromKiloToTonne()
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion

        //#region PlanckMass Conversion Tests
        //[TestMethod]
        //public void ConversionFromPlanckMassToAtomicMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPlanckMassToKilo()
        //{
        //    long value = 100000000000000000;
        //    Kilogram kilogram = new PlanckMass(value);

        //    Assert.AreEqual(expected: value * (2.17647051 * Math.Pow(10, -8)), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void ConversionFromPlanckMassToPound()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPlanckMassToSlug()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPlanckMassToSolarMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPlanckMassToTonne()
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion

        //#region Pound Conversion Tests
        //[TestMethod]
        //public void ConversionFromPoundToAtomicMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPoundToPlanckMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPoundToKilo()
        //{
        //    int value = 1000;
        //    Kilogram kilogram = new Pound(value);

        //    Assert.AreEqual(expected: value * 0.45359237, actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void ConversionFromPoundToSlug()
        //{
        //    int value = 1000;
        //    Slug slug = new Pound(value);

        //    Assert.AreEqual(expected: value * 0.45359237 * 0.0685217659, actual: slug.Value);
        //}

        //[TestMethod]
        //public void ConversionFromPoundToSolarMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromPoundToTonne()
        //{
        //    throw new NotImplementedException();
        //}


        //#endregion

        //#region Slug Conversion Tests
        //[TestMethod]
        //public void ConversionFromSlugToAtomicMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSlugToKilo()
        //{
        //    int value = 100;
        //    Kilogram kilogram = new Slug(value);

        //    Assert.AreEqual(expected: value * 14.593903, actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void ConversionFromSlugToPlanckMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSlugToPound()
        //{
        //    int value = 1000;
        //    Pound pound = new Slug(value);

        //    Assert.AreEqual(expected: value * 14.593903 * 2.20462262, actual: pound.Value);
        //}

        //[TestMethod]
        //public void ConversionFromSlugToSolarMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSlugToTonne()
        //{
        //    throw new NotImplementedException();
        //}

        //#endregion

        //#region Solar Mass Conversion Tests
        //[TestMethod]
        //public void ConversionFromSolarMassToAtomicMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSolarMassToKilo()
        //{
        //    int value = 100;
        //    Kilogram kilogram = new SolarMass(value);

        //    Assert.AreEqual(expected: value * (1.98855 * Math.Pow(10, 30)), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void ConversionFromSolarMassToPlanckMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSolarMassToPound()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSolarMassToSlug()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromSolarMassToTonne()
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion

        //#region Tonne Conversion Tests
        //[TestMethod]
        //public void ConversionFromTonneToAtomicMass()
        //{
        //    int value = 10;
        //    AtomicMass atomicMass = new Tonne(value);

        //    Assert.AreEqual(expected: value * 1000 * (6.0221366516752 * Math.Pow(10, 26)), actual: atomicMass.Value);
        //}

        //[TestMethod]
        //public void ConversionFromTonneToKilo()
        //{
        //    int value = 100;
        //    Kilogram kilogram = new Tonne(value);

        //    Assert.AreEqual(expected: value * 1000, actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void ConversionFromTonneToPlanckMass()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromTonneToPound()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromTonneToSlug()
        //{
        //    throw new NotImplementedException();
        //}

        //[TestMethod]
        //public void ConversionFromTonneToSolarMass()
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion

        //#endregion

        //#region Operator Tests
        //[TestMethod]
        //public void AddingKiloToPound()
        //{
        //    Kilogram mass1 = new Kilogram(500);
        //    Pound mass2 = new Pound(1000);

        //    Kilogram kilogram = mass1 + mass2;

        //    Assert.AreEqual(expected: mass1.Value + mass2.Value * 0.45359237, actual: kilogram.Value);        
        //}

        //[TestMethod]
        //public void AddingPoundToPound()
        //{
        //    Pound mass1 = new Pound(500);
        //    Pound mass2 = new Pound(1000);

        //    Kilogram kilogram = mass1 + mass2;

        //    Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237, actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void AddingMoreThanTwoMasses()
        //{
        //    Pound mass1 = new Pound(500);
        //    Pound mass2 = new Pound(1000);
        //    Kilogram mass3 = new Kilogram(1500);

        //    Kilogram kilogram = mass1 + mass2 + mass3;

        //    Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237 + mass3.Value, actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void AddingThreeDifferentMasses()
        //{
        //    Pound mass1 = new Pound(500);
        //    Pound mass2 = new Pound(1000);
        //    Tonne mass3 = new Tonne(4); 

        //    Kilogram kilogram = mass1 + mass2 + mass3;

        //    Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237 + mass3.Value * 1000, actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void SubtractingTwoMassses()
        //{
        //    Kilogram mass1 = new Kilogram(500);
        //    Pound mass2 = new Pound(1000);

        //    Kilogram kilogram = mass1 - mass2;

        //    Assert.AreEqual(expected: mass1.Value - (mass2.Value * 0.45359237), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void MultiplyingTwoMasses()
        //{
        //    Kilogram mass1 = new Kilogram(500);
        //    Pound mass2 = new Pound(1000);

        //    Kilogram kilogram = mass1 * mass2;

        //    Assert.AreEqual(expected: mass1.Value * (mass2.Value * 0.45359237), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void DividingTwoMasses()
        //{
        //    Kilogram mass1 = new Kilogram(500);
        //    Pound mass2 = new Pound(1000);

        //    Kilogram kilogram = mass1 / mass2;

        //    Assert.AreEqual(expected: mass1.Value / (mass2.Value * 0.45359237), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void AddingPoundToSolarmass()
        //{
        //    Pound mass1 = new Pound(500);
        //    SolarMass mass2 = new SolarMass(1);
        //    Tonne mass3 = new Tonne(400);
        //    SolarMass mass4 = new SolarMass(1.5);

        //    Kilogram kilogram = mass1 + mass2 + mass3 + mass4;

        //    Assert.AreEqual(expected: mass1.Value * 0.45359237 + (mass2.Value * 1.98855 * Math.Pow(10, 30)) + mass3.Value * 1000 + (mass4.Value * 1.98855 * Math.Pow(10, 30)), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void AddingAtomicMasses()
        //{
        //    AtomicMass mass1 = new AtomicMass(100000);
        //    AtomicMass mass2 = new AtomicMass(1000);

        //    Kilogram kilogram = mass1 + mass2;

        //    Assert.AreEqual(expected: (mass1.Value * 1.660539040 * Math.Pow(10, -27)) + (mass2.Value * 1.660539040 * Math.Pow(10, -27)), actual: kilogram.Value);
        //}

        //[TestMethod]
        //public void AddingAllMasses()   
        //{
        //    AtomicMass mass1 = new AtomicMass(100000000000000000);
        //    Kilogram mass2 = new Kilogram(400);
        //    PlanckMass mass3 = new PlanckMass(100000000000000000);
        //    Pound mass4 = new Pound(100);
        //    Slug mass5 = new Slug(50);
        //    SolarMass mass6 = new SolarMass(0.00000000000000000000000000001);
        //    Tonne mass7 = new Tonne(4);

        //    Kilogram kilogram = mass1 + mass2 + mass3 + mass4 + mass5 + mass6 + mass7;

        //    Assert.AreEqual(expected: (mass1.Value * 1.660539040 * Math.Pow(10, -27)) + (mass2.Value) + (mass3.Value * 2.17647051 * Math.Pow(10, -8)) + (mass4.Value * 0.45359237) + (mass5.Value * 14.593903) + (mass6.Value * 1.98855 * Math.Pow(10, 30) + (mass7.Value * 1000)), actual: kilogram.Value);
        //}
        //#endregion

        //#region Abbreviation Tests
        //[TestMethod]
        //public void AtomicMassAbbreviation()
        //{
        //    AtomicMass atomicMass = new AtomicMass(1);
        //    Assert.AreEqual(expected: "1u", actual: atomicMass.ToString());
        //}

        //[TestMethod]
        //public void KilogramAbbreviation()
        //{
        //    Kilogram kilogram = new Kilogram(1);
        //    Assert.AreEqual(expected: "1kg", actual: kilogram.ToString());
        //}

        //[TestMethod]
        //public void PlanckMassAbbreviation()
        //{
        //    PlanckMass planckMass = new PlanckMass(1);
        //    Assert.AreEqual(expected: "1mP", actual: planckMass.ToString());
        //}

        //[TestMethod]
        //public void PoundAbbreviation()
        //{
        //    Pound pound = new Pound(1);
        //    Assert.AreEqual(expected: "1lb", actual: pound.ToString());
        //}

        //[TestMethod]
        //public void SlugAbbreviation()
        //{
        //    Slug slug = new Slug(1);
        //    Assert.AreEqual(expected: "1sl", actual: slug.ToString());
        //}

        //[TestMethod]
        //public void SolarMassAbbreviation()
        //{
        //    SolarMass solarMass = new SolarMass(1);
        //    Assert.AreEqual(expected: "1Mo", actual: solarMass.ToString());
        //}

        //[TestMethod]
        //public void TonneAbbreviation()
        //{
        //    Tonne tonne = new Tonne(1);
        //    Assert.AreEqual(expected: "1t", actual: tonne.ToString());
        //}
        //#endregion
    }
}
