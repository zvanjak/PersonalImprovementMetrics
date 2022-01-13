using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Domain
{
  public abstract class PerformanceMetric
  {
    private string _name;
    private Metric _baseMetric;

    public string Name { get => _name; set => _name = value; }
    public Metric BaseMetric { get => _baseMetric; set => _baseMetric = value; }

    public PerformanceMetric(string inName, Metric inBaseMetric)
    {
      Name = inName;
      BaseMetric = inBaseMetric;
    }

    public abstract double evaluateForMonth(DateTime date);
    public abstract double evaluateForYear(int year);
  }

  public abstract class WeeklyPerformanceMetric : PerformanceMetric
  {
    public WeeklyPerformanceMetric(string inName, WeeklyMetric inBaseMetric) : base(inName, inBaseMetric)
    { }

    public abstract double evaluateForWeek(DateTime date);
    public abstract double evaluateForWeek(int weekOrdNum);
  }

  public abstract class DailyPerformanceMetric : WeeklyPerformanceMetric
  {
    public DailyPerformanceMetric(string inName, DailyMetric inBaseMetric) : base(inName, inBaseMetric)
    { }

    public abstract double evaluateForDay(DateTime date);
  }

  //public class ActionTimeMetricManual : WeeklyMetric
  //{
  //	public ActionTimeMetricManual(string name) : base(name)
  //	{
  //	}

  //	public override double evaluateForWeek(DateTime date) { return 1.0; }
  //	public override double evaluateForMonth(DateTime date) { return 1.0; }

  //}

  //public class ActionTimeMetricIntervals : WeeklyMetric
  //{
  //	public ActionTimeMetricIntervals(string name) : base(name)
  //	{
  //	}

  //	public override double evaluateForWeek(DateTime date) { return 1.0; }
  //	public override double evaluateForMonth(DateTime date) { return 1.0; }

  //}


  //public class MeasuredValueMetricManual : WeeklyMetric
  //{
  //	public MeasuredValueMetricManual(string name) : base(name)
  //	{
  //	}

  //	public override double evaluateForWeek(DateTime date) { return 1.0; }
  //	public override double evaluateForMonth(DateTime date) { return 1.0; }

  //}

  //	public override double evaluateForWeek(DateTime date) { return 1.0; }
  //	public override double evaluateForMonth(DateTime date) { return 1.0; }

  //}
  //public class MeasuredValueMetricIntervals : WeeklyMetric
  //{
  //	public MeasuredValueMetricIntervals(string name) : base(name)
  //	{
  //	}

  //	public override double evaluateForWeek(DateTime date) { return 1.0; }
  //	public override double evaluateForMonth(DateTime date) { return 1.0; }

  //}
}
