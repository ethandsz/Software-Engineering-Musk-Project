using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteInspection
{
    class Constants
    {
        public static string INSERTFORM = "INSERT INTO form(form_type_id, site_name, cmpltd_by, date, work_area, job_desc, " +
                    "supervisor, inspector, type) VALUES (@form_type_id, @site_name, @cmpltd_by, @date, @work_area, @job_desc," +
                    " @supervisor, @inspector, @type)";
        public static string SELECTALLFORM = "SELECT * FROM form";
    }
}
