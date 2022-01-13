using System;

namespace PIM.Domain
{
	// weekly based metrike
	// daily based metrike

	public abstract class Metric
	{
		private string _name;

		public string Name { get => _name; set => _name = value; }

		// kategorija metrike

		// privatnost

		// time validity - imamo i "privremene" metrike 
		public Metric(string name)
		{
			Name = name;
		}

		public abstract double  evaluateForWeek(DateTime date);
		public abstract double  evaluateForMonth(DateTime date);
	}

	public class DailyEvaluationMetric : Metric
	{
		// grade from 1-5, given daily
		// daily? ako je samo jedna ocjena u danu, to je za dan ... ali, može ih biti i više
		public DailyEvaluationMetric(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}

	public class ActionTimeMetric : Metric
	{
		//- "kad nešto treba napraviti", ciljano vrijeme za akciju, zapiše se vrijeme, i na osnovu toga izračuna ocjena za taj dan, uzimajući u obzir definirane intervale
		   // - spavanje, lijeganje
		   // - večera
		   // - kad sam zapalio
		   // - svaki ima neki vremenski trenutak, u odnosu na koji se formira ocjena
		public ActionTimeMetric(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class ActionTimeMetricManual : Metric
	{
		public ActionTimeMetricManual(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class ActionTimeMetricFormula : Metric
	{
		// ima definiranu value za 5
		// i onda parametar za nagib pravca
		public ActionTimeMetricFormula(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class ActionTimeMetricIntervals : Metric
	{
		public ActionTimeMetricIntervals(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}

	// da može imati i external source! povlači se iz Health
	public class MeasuredValueMetric : Metric
	{

		public MeasuredValueMetric(string name) : base(name)
		{
		}
		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }


	}
	public class MeasuredValueMetricManual : Metric
	{
		public MeasuredValueMetricManual(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class MeasuredValueMetricFormula : Metric
	{
		// ima definiranu value za 5
		// i onda parametar za nagib pravca
		public MeasuredValueMetricFormula(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
	public class MeasuredValueMetricIntervals : Metric
	{
		public MeasuredValueMetricIntervals(string name) : base(name)
		{
		}

		public override double evaluateForWeek(DateTime date) { return 1.0; }
		public override double evaluateForMonth(DateTime date) { return 1.0; }

	}
}
