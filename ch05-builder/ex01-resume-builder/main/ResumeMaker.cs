using Company.Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example
{
    public class ResumeMaker
    {
        private IResumeBuilder builder;

        public ResumeMaker(IResumeBuilder builder)
        {
            this.builder = builder;
        }
        public void makeCV()
        {
            builder.createNameAndTitle();
            builder.createProjectDetails();
            builder.createTestimonialDetails();
            builder.createCertificationDetails();
            builder.createEducationDetails();
            builder.createSocialDetails();
            builder.createPersonalDetails();
        }

        public void makeResume()
        {
            builder.createNameAndTitle();
            builder.createProjectDetails();
            builder.createCertificationDetails();
            builder.createEducationDetails();
            builder.createPersonalDetails();
        }

        public void makeOnePagerResume()
        {
            builder.createNameAndTitle();
            builder.createProjectDetails();
            builder.createPersonalDetails();
        }
    }
}
