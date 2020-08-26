using Company.Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Company.Example.Test
{
    public class ResumeMakerTest
    {
        [Fact]
        public void ensure_professional_cv()
        {
            IResumeBuilder builder = new ProfessionalResumeBuilder();
            ResumeMaker maker = new ResumeMaker(builder);
            maker.makeCV();
            Resume resume = builder.build();

            String cvText = "Professional NameAndTitle"
                            + "Professional Projects"
                            + "Professional Testimonials"
                            + "Professional Certifications"
                            + "Professional Education"
                            + "Professional Social"
                            + "Professional Personal";

            Assert.Equal(cvText, resume.toString());

        }

        [Fact]
        public void ensure_professional_resume()
        {
            IResumeBuilder builder = new ProfessionalResumeBuilder();
            ResumeMaker maker = new ResumeMaker(builder);
            maker.makeResume();
            Resume resume = builder.build();

            String cvText = "Professional NameAndTitle"
                            + "Professional Projects"
                            + "Professional Certifications"
                            + "Professional Education"
                            + "Professional Personal";

            Assert.Equal(cvText, resume.toString());
        }

        [Fact]
        public void ensure_professional_one_pager()
        {
            IResumeBuilder builder = new ProfessionalResumeBuilder();
            ResumeMaker maker = new ResumeMaker(builder);
            maker.makeOnePagerResume();
            Resume resume = builder.build();

            String cvText = "Professional NameAndTitle"
                            + "Professional Projects"
                            + "Professional Personal";

            Assert.Equal(cvText, resume.toString());

        }

        [Fact]
        public void ensure_social_cv()
        {
            IResumeBuilder builder = new SocialResumeBuilder();
            ResumeMaker maker = new ResumeMaker(builder);
            maker.makeCV();
            Resume resume = builder.build();

            String cvText = "Social NameAndTitle"
                            + "Social Projects"
                            + "Social Testimonials"
                            + "Social Certifications"
                            + "Social Education"
                            + "Social Social"
                            + "Social Personal";

            Assert.Equal(cvText, resume.toString());
        }

        [Fact]
        public void ensure_social_resume()
        {
            IResumeBuilder builder = new SocialResumeBuilder();
            ResumeMaker maker = new ResumeMaker(builder);
            maker.makeResume();
            Resume resume = builder.build();

            String cvText = "Social NameAndTitle"
                            + "Social Projects"
                            + "Social Certifications"
                            + "Social Education"
                            + "Social Personal";

            Assert.Equal(cvText, resume.toString());
        }

        [Fact]
        public void ensure_social_one_pager()
        {
            IResumeBuilder builder = new SocialResumeBuilder();
            ResumeMaker maker = new ResumeMaker(builder);
            maker.makeOnePagerResume();
            Resume resume = builder.build();

            String cvText = "Social NameAndTitle"
                            + "Social Projects"
                            + "Social Personal";

            Assert.Equal(cvText, resume.toString());

        }
    }
}
