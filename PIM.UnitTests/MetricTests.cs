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

      // metrike
      DailyEvaluationMetric     metricSmirenost = new DailyEvaluationMetric("Koliko sam smiren", zdravlje);
      DailyActionTimeMetric     metricVrijemeUstajanja = new DailyActionTimeMetric("Vrijeme ustajanja", zdravlje);
      DailyMeasuredValueMetric  metricTezina = new DailyMeasuredValueMetric("Težina", zdravlje);
      DailyMeasuredValueMetric  metricProcitanihStranicaKnjige = new DailyMeasuredValueMetric("Pročitanih stranica", znanje);

      // dodati par mjerenja
      // smirenots
      DailyEvaluationMetricMeasurement smir1 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 3), 3);
      DailyEvaluationMetricMeasurement smir2 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 4), 3);
      DailyEvaluationMetricMeasurement smir3 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 5), 3);
      DailyEvaluationMetricMeasurement smir4 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 6), 3);
      DailyEvaluationMetricMeasurement smir5 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 7), 3);
      DailyEvaluationMetricMeasurement smir6 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 8), 3);
      DailyEvaluationMetricMeasurement smir7 = new DailyEvaluationMetricMeasurement(new System.DateTime(2022, 1, 9), 3);

      metricSmirenost.AddMeasurement(smir1);
      metricSmirenost.AddMeasurement(smir2);
      metricSmirenost.AddMeasurement(smir3);
      metricSmirenost.AddMeasurement(smir4);
      metricSmirenost.AddMeasurement(smir5);
      metricSmirenost.AddMeasurement(smir6);
      metricSmirenost.AddMeasurement(smir7);

      // težina
      DailyMeasureValueMetricMeasurement tez1 = new DailyMeasureValueMetricMeasurement(new System.DateTime(2022, 1, 3), 94.5f);
      // ustajanje
      DailyActionTimeMetricMeasurement ust1 = new DailyActionTimeMetricMeasurement(new System.DateTime(2022, 1, 2), 8, 45);
      // pročitano stranica knjige
      DailyMeasureValueMetricMeasurement knjiga1 = new DailyMeasureValueMetricMeasurement(new System.DateTime(2022, 1, 3), 0);
      DailyMeasureValueMetricMeasurement knjiga2 = new DailyMeasureValueMetricMeasurement(new System.DateTime(2022, 1, 3), 0);

      // definirati performance metrike
      DailyPerformanceMetricDailyEvaluation smirenost = new DailyPerformanceMetricDailyEvaluation("Smirenost bar 4.5", metricSmirenost);

      DailyPerformanceMetricMeasuredValueFormula tezina92kg = new DailyPerformanceMetricMeasuredValueFormula("Težina 92 kg", metricTezina);
      DailyPerformanceMetricActionTimeFormula ustajanjeDo8 = new DailyPerformanceMetricActionTimeFormula("Ustati do 8", metricVrijemeUstajanja);
      WeeklyPerformanceMetricDailyMeasuredValueFormula procitati200Stranica = new WeeklyPerformanceMetricDailyMeasuredValueFormula("Pročitati 200 stranica tjedno", metricProcitanihStranicaKnjige);

      // evaluirati performanse metrike
      Assert.AreEqual(3.0f, smirenost.evaluateForWeek(new System.DateTime(2022, 1, 5)));


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
