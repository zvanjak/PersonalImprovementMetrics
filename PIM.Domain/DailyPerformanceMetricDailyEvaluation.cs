using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Domain
{
  public class DailyPerformanceMetricDailyEvaluation : DailyPerformanceMetric
  {
    public DailyPerformanceMetricDailyEvaluation(string name, DailyMetric inBaseMetric) : base(name, inBaseMetric)
    {
    }
    public override double evaluateForDay(DateTime date) { return 0.0f; }
    public override double evaluateForWeek(DateTime date) 
    {
      // naći početak i kraj za taj tjedan
      DateTime start = new DateTime(2022, 1, 3);
      DateTime end = new DateTime(2022, 1, 9, 23, 59, 59);

      var measurementsInRange = (from meas in (BaseMetric as DailyEvaluationMetric)._listMeasurements where meas.DateOfMeasurement >= start && meas.DateOfMeasurement < end select meas).ToList();
      double sum = measurementsInRange.Sum(x => x.Value);

      return sum/measurementsInRange.Count; 
    }
    public override double evaluateForWeek(int weekOrdNum) { return 0.0f; }
    public override double evaluateForMonth(DateTime date) { return 0.0f; }
    public override double evaluateForYear(int year) { return 0.0f; }
  }

}
