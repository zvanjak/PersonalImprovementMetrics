using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Domain
{
  public class WeeklyPerformanceMetricDailyMeasuredValueFormula : WeeklyPerformanceMetric
  {
    // ima definiranu value za 5
    // i onda parametar za nagib pravca
    public WeeklyPerformanceMetricDailyMeasuredValueFormula(string name, DailyMetric inBaseMetric) : base(name, inBaseMetric)
    {
    }
    public override double evaluateForWeek(DateTime date) { return 0.0f; }
    public override double evaluateForWeek(int weekOrdNum) { return 0.0f; }
    public override double evaluateForMonth(DateTime date) { return 0.0f; }
    public override double evaluateForYear(int year) { return 0.0f; }
  }

}
