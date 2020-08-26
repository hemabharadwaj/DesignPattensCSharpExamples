using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example.Interface
{
    public interface IResumeBuilder
    {
        void createEducationDetails();
        void createProjectDetails();
        void createSocialDetails();
        void createTestimonialDetails();
        void createPersonalDetails();
        void createCertificationDetails();
        void createNameAndTitle();
        Resume build();
    }
}
