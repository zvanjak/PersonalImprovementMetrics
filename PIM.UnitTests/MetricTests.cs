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
      MetricCategory obitelj = new MetricCategory("Obitelj");
      MetricCategory zdravlje = new MetricCategory("Zdravlje");
      MetricCategory znanje = new MetricCategory("Znanje i blog");

      DailyEvaluationMetric obilnostVecere = new DailyEvaluationMetric("Koliko sam večerao", zdravlje;

      DailyActionTimeMetric  ustatiDo8 = new DailyActionTimeMetric("Vrijeme ustajanja", zdravlje);

      DailyMeasuredValueMetric tezina = new DailyMeasuredValueMetric("Težina", zdravlje);

      DailyMeasuredValueMetric procitanihStranicaKnjige = new DailyMeasuredValueMetric("Pročitanih stranica", znanje);

      // metrike
      //ActionTimeMetricIntervals kadSamZapalioPrvog = new ActionTimeMetricIntervals("Kad sam zapalio prvoga");
      //ActionTimeMetricFormula spavanjeDo1 = new ActionTimeMetricFormula("Vrijeme odlaska na spavanje");
      //ActionTimeMetricFormula veceratioDo21 = new ActionTimeMetricFormula("Vrijeme večere");

      //DailyEvaluationMetric kolikoSamRazbijenDokPisam = new DailyEvaluationMetric("Koliko sam razbijen dok pišam");
      //MeasuredValueMetricManual popijenihWhiskeya = new MeasuredValueMetricManual("Popijenih whiskeya");


      // kategorije
      // zadravlje, trava i alkohol, um, social (face, blog, izlasci i druženja, ivanka (posvećenost, djeci, kući, meni)
    }
  }
}
