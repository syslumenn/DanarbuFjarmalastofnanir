namespace Syslumenn
{
    public static class MockupData
    {
        public static BankaupplysingarDanarbusSkeyti Get(string audkenni)
        {

            return new BankaupplysingarDanarbusSkeyti()
            {
                Audkenni = audkenni,
                StadaVidskiptamanns = new Syslumenn.Stadavidskiptamanns()
                {
                    Kennitala = "1234567890",
                    DagsetningYfirlits = new DateTime(2023, 1, 1),
                    KeyrsluDags = DateTime.Now,
                    InnstaedurIBonkumOgSparisjodum = new Syslumenn.Innstaeduribonkumogsparisjodum[]
                    {
                        new Syslumenn.Innstaeduribonkumogsparisjodum()
                        {
                            AudkenniReiknings = "0101-26-000001",
                            AfallnirVextirISK = 0,
                            StadaISK = 1000000,
                            StadaSamtalsISK = 0,
                            Mynt = "ISK"
                        },
                        new Syslumenn.Innstaeduribonkumogsparisjodum()
                        {
                            AudkenniReiknings = "0101-26-000002",
                            AfallnirVextirISK = 0,
                            StadaISK = 1000000,
                            StadaSamtalsISK = 0,
                            Mynt = "ISK"
                        }
                    },
                    VerdbrefaOgSkuldabref = new Syslumenn.Verdbrefaogskuldabref[]
                    {
                        new Verdbrefaogskuldabref()
                        {
                            Audkenni = "123456780",
                            StadaIsk = 0,
                            Utgefandi = "Nafn útgefanda"
                        }
                    },
                    AbyrgdVegna3jaAdila = new Syslumenn.Abyrgdvegna3jaadila[]
                    {
                        new Syslumenn.Abyrgdvegna3jaadila()
                        {
                            ErISkilum = true,
                            Mynt = "ISK",
                            Numer = "1234567890",
                            StadaISK = 0,
                            Tegund = 1
                        }
                    },
                    Geymsluholf = new Syslumenn.Geymsluholf[]
                    {
                        new Syslumenn.Geymsluholf()
                        {
                            Audkenni = "123456",
                            Stadsetning = "Heiti banka og heimilisfang"
                        }
                    },
                    Hlutabref = new Syslumenn.Hlutabref[]
                    {
                        new Syslumenn.Hlutabref()
                        {
                            Heiti = "Nafn fyrirtækis og kennitala",
                            StadaISK = 0
                        }
                    },
                    Utlan = new Syslumenn.Utlan[]
                    {
                        new Syslumenn.Utlan()
                        {
                            Lansnumer = "1234567890",
                            Mynt = "ÍSK",
                            StadaISK = 0,
                            Tegund = 1
                        }
                    },
                    Tryggingarbref = new Syslumenn.Tryggingar[]
                    {
                        new Syslumenn.Tryggingar()
                        {
                            Numer = "1234567890",
                            Mynt = "ÍSK",
                            StadaIsk = 0
                        }
                    },
                    Skjol = new Syslumenn.Skjol[]
                    {
                        new Syslumenn.Skjol()
                        {
                            Lysing = "Heiti/lýsing skjals",
                            Nafn = "heitiskjals.pdf",
                            FileDataBase64 = Convert.ToBase64String(new byte[] { 0 }),
                            Tegund = "PDF"
                        }
                    },
                }
            };
        }

    }
}
