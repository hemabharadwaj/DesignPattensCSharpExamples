using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example
{
    public class SocialResumeBuilder : AbstractResumeBuilder
    {
        public override void createCertificationDetails()
        {
            resume.addSection("Social Certifications");
        }

        public override void createEducationDetails()
        {
            resume.addSection("Social Education");
        }

        public override void createNameAndTitle()
        {
            resume.addSection("Social NameAndTitle");
        }

        public override void createPersonalDetails()
        {
            resume.addSection("Social Personal");
        }

        public override void createProjectDetails()
        {
            resume.addSection("Social Projects");
        }

        public override void createSocialDetails()
        {
            resume.addSection("Social Social");
        }

        public override void createTestimonialDetails()
        {
            resume.addSection("Social Testimonials");
        }
    }
}
