using Microsoft.VisualStudio.TestTools.UnitTesting;
using PIM.Domain;

namespace PIM.UnitTests
{
  [TestClass]
  public class MetricTests
  {
    [TestMethod]
    public void TestMethod1()
    {
      // kategorije - Smirenost, zdravlje, Um, Posao, Ivanka, Blog, Osobno, Ivankine metrike, Privat

      // metrike
      ActionTimeMetricFormula ustatiDo8 = new ActionTimeMetricFormula("Vrijeme ustajanja");
      ActionTimeMetricIntervals kadSamZapalioPrvog = new ActionTimeMetricIntervals("Kad sam zapalio prvoga");
      ActionTimeMetricFormula spavanjeDo1 = new ActionTimeMetricFormula("Vrijeme odlaska na spavanje");
      ActionTimeMetricFormula veceratioDo21 = new ActionTimeMetricFormula("Vrijeme večere");

      DailyEvaluationMetric kolikoSamVecerao = new DailyEvaluationMetric("Koliko sam večerao");
      DailyEvaluationMetric kolikoSamRazbijenDokPisam = new DailyEvaluationMetric("Koliko sam razbijen dok pišam");

      MeasuredValueMetricFormula tezina = new MeasuredValueMetricFormula("Težina");
      MeasuredValueMetricManual popijenihWhiskeya = new MeasuredValueMetricManual("Popijenih whiskeya");

      // kategorije
      // zadravlje, trava i alkohol, um, social (face, blog, izlasci i druženja, ivanka (posvećenost, djeci, kući, meni)
    }
  }
}
