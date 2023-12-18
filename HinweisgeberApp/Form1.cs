using HinweisgeberApp.Data;
using HinweisgeberApp.Extensions;
using HinweisgeberApp.Models;
using HinweisgeberApp.Services;
using IronBarCode;
using Microsoft.EntityFrameworkCore;

namespace HinweisgeberApp
{
    public partial class partnerhinzufuegenForm : Form
    {
        private readonly DbHinweisContext _context;
        private List<Partner> partnerList = new List<Partner>();
        private List<Filiale> filialeList = new List<Filiale>();
        public partnerhinzufuegenForm(DbHinweisContext context)
        {
            InitializeComponent();
            _context = context;
            textServername.Text = "195.201.138.127";
            textAnmeldename.Text = "sa";
            textKennwort.Text = "123Tobi123!";
            var tmpfilialeList = GetFilialen();
            filialeList = tmpfilialeList.Result.ToList();
            var tmppartnerList = GetPartners();
            partnerList = tmppartnerList.Result.ToList();
            comboPartner.DataSource = partnerList.Select(p => p.Name).ToList();
            comboPartnerQr.DataSource = partnerList.Select(p => p.Name).ToList();
            if (partnerList.Count > 0)
            {
                comboFilialeQr.DataSource = filialeList.Where(p => p.PartnerId == partnerList.First().Id).Select(p => p.AnsichtName).ToList();
            }
        }

        private async void AddPartnerBtn_Click(object sender, EventArgs e)
        {
            string connectionString = KryptoExtensions.EncryptString(DbServices.GetConnectionString(textServername.Text, textAnmeldename.Text, textKennwort.Text, textDatenbankname.Text), "309C23359677");

            bool connectionState = _context.TestConnection();

            if (connectionState == true)
            {
                Partner partner = new Partner()
                {
                    Name = textDatenbankname.Text,
                    ConStr = connectionString.ToPartnerConString(),
                    Active = true
                };
                var res1 = await InsertPartner(partner);

                if (res1 == true)
                {
                    MessageBox.Show("Partner würde hinzugefügt");
					//ResetForm();
					textDatenbankname.Clear();
					var partnerList = GetPartners();
					comboPartner.DataSource = partnerList.Result.Select(p => p.Name).ToList();
                    comboPartnerQr.DataSource = partnerList.Result.Select(p => p.Name).ToList();
                }
            }
        }


        private void ResetForm()
        {
            textDatenbankname.Clear();
            textServername.Clear();
            textAnmeldename.Clear();
            textKennwort.Clear();
        }

        public async Task<bool> InsertPartner(Partner model)
        {
            try
            {
                await _context.Partners.AddAsync(model);
                var res = await _context.SaveChangesAsync();

                if (res > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> InsertFiliale(Filiale model)
        {
            try
            {
                await _context.Filiales.AddAsync(model);
                var res = await _context.SaveChangesAsync();

                if (res > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Filiale>> GetFilialen()
        {
            try
            {
                return _context.Filiales.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdatePartner(Partner model)
        {
            try
            {
                _context.Partners.Update(model);
                _context.Entry(model).State = EntityState.Modified;
                var ss = await _context.SaveChangesAsync();

                if (ss > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<List<Partner>> GetPartners()
        {
            try
            {
                return _context.Partners.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void Ansichtname_Click(object sender, EventArgs e)
        {

        }

        private async void buttonAddFiliale_Click(object sender, EventArgs e)
        {

            bool connectionState = _context.TestConnection();
            if (connectionState == true)
            {
                var tmpPartner = await _context.Partners.FirstOrDefaultAsync(p => p.Name == comboPartner.Text);
                if (tmpPartner != null)
                {
                    Filiale filiale = new Filiale()
                    {
                        FilialNr = (int)numericUpDownFilialnr.Value,
                        AnsichtName = textAnsichtname.Text,
                        Email = textEmail.Text,
                        PartnerId = tmpPartner.Id,
                    };

                    tmpPartner.Filiale.Add(filiale);


                    if (await UpdatePartner(tmpPartner) == true)
                    {
                        MessageBox.Show("Filiale würde hinzugefügt");
                        ResetFilialeForm();
                    }
                }
            }
        }

        private void ResetFilialeForm()
        {
            textAnsichtname.Clear();
            textEmail.Clear();
            numericUpDownFilialnr.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboPartnerQr.SelectedIndex;
            var partner = partnerList.ElementAt(index);

            int index1 = comboFilialeQr.SelectedIndex;
            var filiale = filialeList.ElementAt(index1);
            // Get parameters from TextBoxes
            string parameterPartner = partner.Id.ToString();
            string parameterFiliale = filiale.Id.ToString();

            // Concatenate parameters
            string url = $"https://gfi-hinweisgeber.de/{parameterPartner}/{parameterFiliale}";

            GeneratedBarcode generatedBarcode = IronBarCode.BarcodeWriter.CreateBarcode(url,BarcodeEncoding.QRCode);
            generatedBarcode.AddAnnotationTextAboveBarcode("GFI Hinweisgeber");
            var filename = ("Partner" + partner.Name.Replace(" ","") + "Filiale" + filiale.AnsichtName.Replace(" ", "") + ".pdf").Replace(" ","");
            generatedBarcode.SaveAsPdf(filename);
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void comboPartnerQr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPartnerQr.SelectedIndex != -1)
            {
                //var tmp = partnerList.Where(p => p.Name == comboPartnerQr.SelectedItem.)
                int index = comboPartnerQr.SelectedIndex;
                var partner = partnerList.ElementAt(index);
                comboFilialeQr.DataSource = filialeList.Where(p => p.PartnerId == partner.Id).Select(p => p.AnsichtName).ToList();

            }

        }
    }
}