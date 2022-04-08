using System.Text.Json;
using System.Diagnostics;

namespace tpmodul7_1302204034
{
    public class CovidConfig
    {
        public string CONFIG1 { get; set; } = "celcius";
        public int CONFIG2 { get; set; } = 14;
        public string CONFIG3 { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public string CONFIG4 { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }


        public void ReadJSON()
        {
            string jsonText = File.ReadAllText("covid_config.json");
            CovidConfig json = JsonSerializer.Deserialize<CovidConfig>(jsonText);
            Debug.Assert(json != null);

            this.satuan_suhu = json.satuan_suhu;
            this.batas_hari_demam = json.batas_hari_demam;
            this.pesan_ditolak = json.pesan_ditolak;
            this.pesan_diterima = json.pesan_diterima;
        }

        public void UbahSatuan()
        {
            if (CONFIG1 == "celcius") { CONFIG1 = "farenhait"; }
            else { CONFIG1 = "celcius"; };
        }
    }
}
