namespace Syslumenn
{
    public class Stadavidskiptamanns
    {
        public string Kennitala { get; set; }
        public DateTime KeyrsluDags { get; set; }
        public DateTime DagsetningYfirlits { get; set; }
        public Innstaeduribonkumogsparisjodum[] InnstaedurIBonkumOgSparisjodum { get; set; }
        public Verdbrefaogskuldabref[] VerdbrefaOgSkuldabref { get; set; }
        public Hlutabref[] Hlutabref { get; set; }
        public Utlan[] Utlan { get; set; }
        public Tryggingar[] Tryggingarbref { get; set; }
        public Abyrgdvegna3jaadila[] AbyrgdVegna3jaAdila { get; set; }
        public Geymsluholf[] Geymsluholf { get; set; }
        public Skjol[] Skjol { get; set; }
    }    
}