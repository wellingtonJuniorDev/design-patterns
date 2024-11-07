namespace GOF.Creationals._FactoryMethod.RealWorld
{
    public abstract class Page 
    {
        public override string ToString() => GetType().Name;
    }

    public class SkillsPage : Page { }
    public class EducationPage : Page { }
    public class ExperiencePage : Page { }
    public class IntroductionPage : Page { }
    public class ResultsPage : Page { }
    public class ConclusionPage : Page { }
    public class SummaryPage : Page { }
    public class BibliographyPage : Page { }
}
