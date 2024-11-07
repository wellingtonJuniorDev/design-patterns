namespace GOF.Creationals._FactoryMethod.RealWorld
{
    public abstract class Document
    {
        public List<Page> Pages { get; protected set; } = null;

        /// <summary>Factory method</summary>
        public abstract void CreatePages();

        public override string ToString() => GetType().Name;
    }

    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages =
            [
                new SkillsPage(),
                new EducationPage(),
                new ExperiencePage()
            ];
        }
    }

    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages =
            [
                new IntroductionPage(),
                new ResultsPage(),
                new ConclusionPage(),
                new SummaryPage(),
                new BibliographyPage()
            ];
        }
    }
}
