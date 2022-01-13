using System;

using System.Collections;
using System.Collections.Generic;

/*
Obitelj - praćene metrike
1. koliko sam dobar
2. koliko sam smiren
3. koliko sam posvećen ženi
4. koliko sam posvećen obitelji i njenom boljitku
5. koliko sam posvećen, i od pomoći (škola) djeci
6. posvećenost kućanskim poslovima

Zdravlje
1. spavanje - ustati do 8, leći do 1, barem 7 sati sna
2. droga i alkohol - kad sam zapalio prvoga i koliko sam ih popušio, koliko sam whiskeya popio
3. prehrana - kvaliteta/obilnost ručka/večer, večerati najkasnije do 9
4. težina
5. barem 3 treninga u teretani tjedno
6. ocjena kvalitete fizičke aktivnosti u danu

Znanje i blog
1. pročitati 200 stranica knjiga
2. svaki dan objaviti bar nešto na blogu (može i iz history)
3. tjedno imati barem jedan kvalitetan post
4. svaki tjedan napisati nedjeljni feel-good post
5. imati u prosjeku 100 dnevnih posjetitelja na blogu
6. mjesečno riješiti jedan zanimljiv problem iz fizike i popratiti postom
7. tjedno riješiti 10 jednostavnijih zadataka 
8. u prosjeku imati barem 5 commitova dnevno na Githubu

Osobno
1. koliko se potentno/motivirano osjećam
2. koliko sam zadovoljan
Društvo
1. minimalno jednom tjedno izaći iz kuće i naći se s nekim barem na kavi UŽIVO
2. biti pristojan na Fejsu i na blogu

Posao
1. ocjena opterećenja poslom
2. koliko dobro odrađujem posao

Mjesečno
- pročitati barem dvije knjige
- jednom poći do Sukošana
- dva puta izvesti obitelj na večeru/ručak
- poći negdje na vikend-izlet s obitelji
- minimalno jednom mjesečno s frendovima poći "navečer van" (znači, doma biti u ponoć 😂) - koncert, druženje uz neki event 
- imati mjesečno 5.000 posjetitelja na blogu 
*/
namespace PIM.Domain
{
	// weekly based metrike
	// daily based metrike


	public abstract class Metric
	{
		private string _name;
		private MetricCategory _category;

		public string Name { get => _name; set => _name = value; }
		internal MetricCategory Category { get => _category; set => _category = value; }

		// privatnost

		public Metric(string name, MetricCategory inCategory)
		{
			Name = name;
			Category = inCategory;
		}
	}

	public abstract class WeeklyMetric : Metric
	{
		public WeeklyMetric(string name, MetricCategory inCategory) : base(name, inCategory)		{	}
	}

	public abstract class DailyMetric : WeeklyMetric
	{
		public DailyMetric(string name, MetricCategory inCategory) : base(name, inCategory) { }
	}

	/// //////////////////////////////////////////////////////////////////
	public class DailyEvaluationMetric : DailyMetric
	{
		public List<DailyEvaluationMetricMeasurement> _listMeasurements = new List<DailyEvaluationMetricMeasurement>();

		// grade from 1-5, given daily
		// daily? ako je samo jedna ocjena u danu, to je za dan ... ali, može ih biti i više
		public DailyEvaluationMetric(string name, MetricCategory inCategory) : base(name, inCategory)
		{
		}

		public void AddMeasurement(DailyEvaluationMetricMeasurement inMeas)
    {
			_listMeasurements.Add(inMeas);
    }
	}

	public class DailyActionTimeMetric : DailyMetric
	{
		//- "kad nešto treba napraviti", ciljano vrijeme za akciju, zapiše se vrijeme, i na osnovu toga izračuna ocjena za taj dan, uzimajući u obzir definirane intervale
			 // - spavanje, lijeganje
			 // - večera
			 // - kad sam zapalio
			 // - svaki ima neki vremenski trenutak, u odnosu na koji se formira ocjena
		public DailyActionTimeMetric(string name, MetricCategory inCategory) : base(name, inCategory)
		{
		}
	}

	// da može imati i external source! povlači se iz Health
	public class DailyMeasuredValueMetric : DailyMetric
	{

		public DailyMeasuredValueMetric(string name, MetricCategory inCategory) : base(name, inCategory)
		{
		}
	}
}
