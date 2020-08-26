using Company.Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example
{
    public class ProfessionalResumeBuilder : AbstractResumeBuilder
    {       

        public override void createCertificationDetails()
        {
            resume.addSection("Professional Certifications");
        }

        public override  void createEducationDetails()
        {
            resume.addSection("Professional Education");
        }

        public override void createNameAndTitle()
        {
            resume.addSection("Professional NameAndTitle");
        }

        public override void createPersonalDetails()
        {
            resume.addSection("Professional Personal");
        }

        public override void createProjectDetails()
        {
            resume.addSection("Professional Projects");
        }

        public override void createSocialDetails()
        {
            resume.addSection("Professional Social");
        }

        public override void createTestimonialDetails()
        {
            resume.addSection("Professional Testimonials");
        }
    }
}
