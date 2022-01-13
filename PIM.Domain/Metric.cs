using System;

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
