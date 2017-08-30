using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class LeadRepositorio : ILeadRepositorio
    {
        private List<Lead> leads = new List<Lead>();
        private int _nextId = 1;
        private string _nextIdStr = "1";

        public LeadRepositorio()
        {
            /*
            Add(new Lead {
                email = "suporte@resultadosdigitais.com.br",
                name = "Bruno Ghisi",
                company = "Resultados Digitais",
                job_title = "IT",
                bio = "This is my bio",
                public_url = "http://rdstation.com.br/leads/public/e8d64a22-17a8-40e3-bb8c-c16af1861708",
                created_at = "2012-06-04T15:31:35-03:00",
                opportunity = "false",
                number_conversions = "3",
                user = "email@example.com",
                first_conversion = new FirstConversion {
                    content = new Content
                    {
                        identificador = "ebook-abc",
                        nome = "Bruno",
                        email_lead = "suporte@resultadosdigitais.com.br",
                        telefone = "99999999",
                        empresa = "Resultados Digitais",
                        cargo = "IT"
                    },
                    created_at = "2012-06-04T15:31:35-03:00",
                    cumulative_sum = "1",
                    source = "source 1",
                    conversion_origin = new ConversionOrigin
                    {
                        source = "source 1",
                        medium = "medium 1",
                        value = "value 1",
                        campaign = "campaign 1",
                        channel = "channel 1"
                    }
                },
                last_conversion = new LastConversion
                {
                    content = new Content2
                    {
                        identificador = "webinar-abc",
                        email_lead = "suporte@resultadosdigitais.com.br"
                    },
                    created_at = "2012-06-04T15:31:35-03:00",
                    cumulative_sum = "2",
                    source = "source 2"
                },
                custom_fields = new CustomFields { },
                website = "http://www.resultadosdigitais.com.br",
                personal_phone = "48 30252598",
                mobile_phone = "48 30252598",
                city = "Florianópolis",
                state = "SC",
                lead_stage = "Lead",
                tags = { "tag 1", "tag 2" }, // CORRIGIR: É UMA LIST<STRING>
                fit_score = "d",
                interest = 0
            });
            */

            Content content = new Content();
            content.identificador = "ebook-abc";
            content.nome = "Bruno";
            content.email_lead = "suporte@resultadosdigitais.com.br";
            content.telefone = "99999999";
            content.empresa = "Resultados Digitais";
            content.cargo = "IT";

            ConversionOrigin conversionOrigin = new ConversionOrigin();
            conversionOrigin.source = "source 1";
            conversionOrigin.medium = "medium 1";
            conversionOrigin.value = "value 1";
            conversionOrigin.campaign = "campaign 1";
            conversionOrigin.channel = "channel 1";

            Content2 content2 = new Content2();
            content2.identificador = "webinar-abc";
            content2.email_lead = "suporte@resultadosdigitais.com.br";

            FirstConversion firstConversion = new FirstConversion();
            firstConversion.content = content;
            firstConversion.conversion_origin = conversionOrigin;
            firstConversion.created_at = "2012-06-04T15:31:35-03:00";
            firstConversion.cumulative_sum = "1";
            firstConversion.source = "source 1";

            LastConversion lastConversion = new LastConversion();
            lastConversion.content = content2;
            lastConversion.created_at = "2012-06-04T15:31:35-03:00";
            lastConversion.cumulative_sum = "2";
            lastConversion.source = "source 2";

            Lead lead = new Lead();
            lead.email = "suporte@resultadosdigitais.com.br";
            lead.name = "Bruno Ghisi";
            lead.company = "Resultados Digitais";
            lead.job_title = "IT";
            lead.bio = "This is my bio";
            lead.public_url = "http://rdstation.com.br/leads/public/e8d64a22-17a8-40e3-bb8c-c16af1861708";
            lead.created_at = "2012-06-04T15:31:35-03:00";
            lead.opportunity = "false";
            lead.number_conversions = "3";
            lead.user = "email@example.com";
            lead.first_conversion = firstConversion;
            lead.last_conversion = lastConversion;
            lead.custom_fields = new CustomFields();
            lead.website = "http://www.resultadosdigitais.com.br";
            lead.personal_phone = "48 30252598";
            lead.mobile_phone = "48 30252598";
            lead.city = "Florianópolis";
            lead.state = "SC";
            lead.lead_stage = "Lead";
            lead.tags = new List<string>();
            lead.tags.Add("tag 1");
            lead.tags.Add("tag 2");
            lead.fit_score = "d";
            lead.interest = 0;

            Add(lead);
        }
        public Lead Add(Lead lead)
        {
            if (lead == null)
            {
                throw new ArgumentNullException("lead");
            }
            _nextIdStr = _nextId.ToString();
            _nextId++;
            lead.id = _nextIdStr;
            leads.Add(lead);
            return lead;
        }

        public Lead Get(string id)
        {
            return leads.Find(l => l.id.Equals(id));
        }

        public IEnumerable<Lead> GetAll()
        {
            return leads;
        }

        public void Remove(string id)
        {
            leads.RemoveAll(l => l.id.Equals(id));
        }

        public bool Update(Lead lead)
        {
            if (lead == null)
            {
                throw new ArgumentNullException("lead");
            }

            int index = leads.FindIndex(l => l.id.Equals(lead.id));

            if (index == -1)
            {
                return false;
            }
            leads.RemoveAt(index);
            leads.Add(lead);
            return true;
        }
    }
}