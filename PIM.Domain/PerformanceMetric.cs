using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Domain
{
  internal class PerformanceMetric
  {
  }

	public class ActionTimeMetricManual : WeeklyMetric
	{
		public ActionTimeMetricManual(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class ActionTimeMetricFormula : WeeklyMetric
	{
		// ima definiranu value za 5
		// i onda parametar za nagib pravca
		public ActionTimeMetricFormula(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class ActionTimeMetricIntervals : WeeklyMetric
	{
		public ActionTimeMetricIntervals(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}


	public class MeasuredValueMetricManual : WeeklyMetric
	{
		public MeasuredValueMetricManual(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class MeasuredValueMetricFormula : WeeklyMetric
	{
		// ima definiranu value za 5
		// i onda parametar za nagib pravca
		public MeasuredValueMetricFormula(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class MeasuredValueMetricIntervals : WeeklyMetric
	{
		public MeasuredValueMetricIntervals(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
}
