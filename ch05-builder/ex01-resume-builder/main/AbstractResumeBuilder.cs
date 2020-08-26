using Company.Example.Interface;

namespace Company.Example
{
    public abstract class AbstractResumeBuilder : IResumeBuilder
    {
        public Resume resume = new Resume();
        public Resume build()
        {
            Resume resumeToReturn = resume;
            resume = new Resume();
            return resumeToReturn;
        }
        public abstract void createEducationDetails();
        public abstract void createProjectDetails();
        public abstract void createSocialDetails();
        public abstract void createTestimonialDetails();
        public abstract void createPersonalDetails();
        public abstract void createCertificationDetails();
        public abstract void createNameAndTitle();

    }
}
