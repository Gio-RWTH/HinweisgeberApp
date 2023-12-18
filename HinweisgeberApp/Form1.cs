using HinweisgeberApp.Data;
using HinweisgeberApp.Extensions;
using HinweisgeberApp.Models;
using HinweisgeberApp.Services;
using Microsoft.EntityFrameworkCore;
//using ZXing;

namespace HinweisgeberApp
{
    public partial class partnerhinzufuegenForm : Form
    {
        private readonly DbHinweisContext _context;
        public partnerhinzufuegenForm(DbHinweisContext context)
        {
            InitializeComponent();
            _context = context;
            textServername.Text = "195.201.138.127";
            textAnmeldename.Text = "sa";
            textKennwort.Text = "123Tobi123!";
            var partnerList = GetPartners();
            comboPartner.DataSource = partnerList.Result.Select(p => p.Name).ToList();
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
            //// Get parameters from TextBoxes
            //string parameter1 = txtParameter1.Text;
            //string parameter2 = txtParameter2.Text;

            //// Concatenate parameters
            //string url = $"http://gfi-hinweisgeber.de/{parameter1}/{parameter2}";

            //// Generate QR code
            //BarcodeWriter barcodeWriter = new BarcodeWriter();
            //barcodeWriter.Format = BarcodeFormat.QR_CODE;
            //barcodeWriter.Options = new ZXing.Common.EncodingOptions
            //{
            //    Width = 300,
            //    Height = 300
            //};

            //// Convert to bitmap
            //var qrCodeBitmap = barcodeWriter.Write(url);

            //// Display the QR code in PictureBox
            //pictureBoxQRCode.Image = qrCodeBitmap;
        }
    }
}