using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Domain
{
  public class MetricCategory
  {
    private string _name;
    public string Name { get => _name; set => _name = value; }

    // imamo i listu defaultnih kategorija

    public MetricCategory(string inName)
    {
      Name = inName;
    }
  }
}
