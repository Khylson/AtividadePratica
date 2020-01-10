using AP.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AP.Data.Acess.Configuretion
{
    public class EditorConfiguretion : EntityTypeConfiguration<Editor>
    {
        public EditorConfiguretion()
        {
            ToTable("EDITOR");

            HasKey(k => k.EditorId);
        }
    }
}
