using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Domain
{
  // ovo su u biti PRAVE METRIKE - ono što se mjeri - koliko si večerao, kad si išao spavati, koliko si težak, jesi li odradio trening u teretani
  // a onda se nad tim podacima mogu definirati Performance metrike
  public class MetricMeasurement
  {
    string _noteText;
    private DateTime _dateOfMeasurement;

    public DateTime DateOfMeasurement { get => _dateOfMeasurement; set => _dateOfMeasurement = value; }
    public string NoteText { get => _noteText; set => _noteText = value; }
  }

  public class DailyEvaluationMetricMeasurement
  {
    private double _value;

    public double Value { get => _value; set => _value = value; }
  }
}
