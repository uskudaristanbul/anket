
namespace AysPro.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Answers]"), DisplayName("Answers"), InstanceName("Answers"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AnswersRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Guid"), NotNull]
        public Guid? Guid
        {
            get { return Fields.Guid[this]; }
            set { Fields.Guid[this] = value; }
        }

        [DisplayName("Q1"), Size(50), QuickSearch]
        public String Q1
        {
            get { return Fields.Q1[this]; }
            set { Fields.Q1[this] = value; }
        }

        [DisplayName("Q2"), Size(50)]
        public String Q2
        {
            get { return Fields.Q2[this]; }
            set { Fields.Q2[this] = value; }
        }

        [DisplayName("Q3"), Size(50)]
        public String Q3
        {
            get { return Fields.Q3[this]; }
            set { Fields.Q3[this] = value; }
        }

        [DisplayName("Q4"), Size(50)]
        public String Q4
        {
            get { return Fields.Q4[this]; }
            set { Fields.Q4[this] = value; }
        }

        [DisplayName("Q5"), Size(50)]
        public String Q5
        {
            get { return Fields.Q5[this]; }
            set { Fields.Q5[this] = value; }
        }

        [DisplayName("Q6"), Size(50)]
        public String Q6
        {
            get { return Fields.Q6[this]; }
            set { Fields.Q6[this] = value; }
        }

        [DisplayName("Q7"), Size(50)]
        public String Q7
        {
            get { return Fields.Q7[this]; }
            set { Fields.Q7[this] = value; }
        }

        [DisplayName("Q8"), Size(50)]
        public String Q8
        {
            get { return Fields.Q8[this]; }
            set { Fields.Q8[this] = value; }
        }

        [DisplayName("Q9"), Size(50)]
        public String Q9
        {
            get { return Fields.Q9[this]; }
            set { Fields.Q9[this] = value; }
        }

        [DisplayName("Q10"), Size(50)]
        public String Q10
        {
            get { return Fields.Q10[this]; }
            set { Fields.Q10[this] = value; }
        }

        [DisplayName("Q11"), Size(50)]
        public String Q11
        {
            get { return Fields.Q11[this]; }
            set { Fields.Q11[this] = value; }
        }

        [DisplayName("Q12"), Size(50)]
        public String Q12
        {
            get { return Fields.Q12[this]; }
            set { Fields.Q12[this] = value; }
        }

        [DisplayName("Q13"), Size(50)]
        public String Q13
        {
            get { return Fields.Q13[this]; }
            set { Fields.Q13[this] = value; }
        }

        [DisplayName("Q14"), Size(50)]
        public String Q14
        {
            get { return Fields.Q14[this]; }
            set { Fields.Q14[this] = value; }
        }

        [DisplayName("Q15"), Size(50)]
        public String Q15
        {
            get { return Fields.Q15[this]; }
            set { Fields.Q15[this] = value; }
        }

        [DisplayName("Q16"), Size(50)]
        public String Q16
        {
            get { return Fields.Q16[this]; }
            set { Fields.Q16[this] = value; }
        }

        [DisplayName("Q17"), Size(50)]
        public String Q17
        {
            get { return Fields.Q17[this]; }
            set { Fields.Q17[this] = value; }
        }

        [DisplayName("Q18"), Size(50)]
        public String Q18
        {
            get { return Fields.Q18[this]; }
            set { Fields.Q18[this] = value; }
        }

        [DisplayName("Q19"), Size(50)]
        public String Q19
        {
            get { return Fields.Q19[this]; }
            set { Fields.Q19[this] = value; }
        }

        [DisplayName("Q20"), Size(50)]
        public String Q20
        {
            get { return Fields.Q20[this]; }
            set { Fields.Q20[this] = value; }
        }

        [DisplayName("Q21"), Size(50)]
        public String Q21
        {
            get { return Fields.Q21[this]; }
            set { Fields.Q21[this] = value; }
        }

        [DisplayName("Date"), NotNull]
        public DateTime? Date
        {
            get { return Fields.Date[this]; }
            set { Fields.Date[this] = value; }
        }

        [DisplayName("Ip Adress"), Size(16)]
        public String IpAdress
        {
            get { return Fields.IpAdress[this]; }
            set { Fields.IpAdress[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Q1; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AnswersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public GuidField Guid;
            public StringField Q1;
            public StringField Q2;
            public StringField Q3;
            public StringField Q4;
            public StringField Q5;
            public StringField Q6;
            public StringField Q7;
            public StringField Q8;
            public StringField Q9;
            public StringField Q10;
            public StringField Q11;
            public StringField Q12;
            public StringField Q13;
            public StringField Q14;
            public StringField Q15;
            public StringField Q16;
            public StringField Q17;
            public StringField Q18;
            public StringField Q19;
            public StringField Q20;
            public StringField Q21;
            public DateTimeField Date;
            public StringField IpAdress;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Answers";
            }
        }
    }
}
