using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace WarcraftLogHelper
{
    public class DPSLog
    {
        public int Parse { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public int ilvl { get; set; }
        public int ilvlParse { get; set; }
        public string Active { get; set; }
        public string DPS { get; set; }
        public string end { get; set; }
    }

    public class DPSLogMap: ClassMap<DPSLog>
    {
        public DPSLogMap()
        {
            Map(m => m.Parse).Name("Parse %");
            Map(m => m.Name).Name("Name");
            Map(m => m.Amount).Name("Amount");
            Map(m => m.ilvl).Name("Ilvl");
            Map(m => m.ilvlParse).Name("Ilvl %");
            Map(m => m.Active).Name("Active");
            Map(m => m.DPS).Name("DPS");
            Map(m => m.end).Name("");
        }
    }

    public class HPSLog
    {
        public string Parse { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Overheal { get; set; }
        public string ilvl { get; set; }
        public string ilvlParse { get; set; }
        public string Active { get; set; }
        public string HPS { get; set; }
        public string end { get; set; }
    }
    public class HPSLogMap : ClassMap<HPSLog>
    {
        public HPSLogMap()
        {
            Map(m => m.Parse).Name("Parse %");
            Map(m => m.Name).Name("Name");
            Map(m => m.Amount).Name("Amount");
            Map(m => m.Overheal).Name("Overheal");
            Map(m => m.ilvl).Name("Ilvl");
            Map(m => m.ilvlParse).Name("Ilvl %");
            Map(m => m.Active).Name("Active");
            Map(m => m.HPS).Name("HPS");
            Map(m => m.end).Name("");
        }
    }

    public class DTLog
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Mitigated { get; set; }
        public string ilvl { get; set; }
        public string Active { get; set; }
        public string DTPS { get; set; }
        public string end { get; set; }
    }
    public class DTLogMap : ClassMap<DTLog>
    {
        public DTLogMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.Amount).Name("Amount");
            Map(m => m.Mitigated).Name("Mitigated");
            Map(m => m.ilvl).Name("Ilvl");
            Map(m => m.Active).Name("Active");
            Map(m => m.DTPS).Name("DTPS");
            Map(m => m.end).Name("");
        }
    }

    public class DeathLog
    {
        public int Time { get; set; }
        public string Name { get; set; }
        public string KillingBlow { get; set; }
        public string Over { get; set; }
        public int LastThreeHits { get; set; }
        public int DmgTaken { get; set; }
        public string HealingRcvd { get; set; }
    }
    public class DeathLogMap : ClassMap<DeathLog>
    {
        public DeathLogMap()
        {
            Map(m => m.Time).Name("Time");
            Map(m => m.Name).Name("Name");
            Map(m => m.KillingBlow).Name("Killing Blow");
            Map(m => m.Over).Name("Over");
            Map(m => m.LastThreeHits).Name("Last Three Hits");
            Map(m => m.DmgTaken).Name("Dmg Taken");
            Map(m => m.HealingRcvd).Name("Healing Rcvd");
        }
    }

    public class OutputLog
    {
        public string Name { get; set; } = "";
        public string ShriekDPS { get; set; } = "";
        public string ShriekHPS { get; set; } = "";
        public string ShriekDT { get; set; } = "";
        public string ShriekDPSParse { get; set; } = "";
        public string ShriekDPSIlvlParse { get; set; } = "";
        public string ShriekHPSParse { get; set; } = "";
        public string ShriekHPSIlvlParse { get; set; } = "";
        public string ShriekDeaths { get; set; } = "";
        public string ShriekFlask { get; set; } = "";
        public string ShriekFood { get; set; } = "";
        public string ShriekPot { get; set; } = "";
        public string ShriekSpace { get; set; } = "";
        public string HuntsmanDPS { get; set; } = "";
        public string HuntsmanHPS { get; set; } = "";
        public string HuntsmanDT { get; set; } = "";
        public string HuntsmanDPSParse { get; set; } = "";
        public string HuntsmanDPSIlvlParse { get; set; } = "";
        public string HuntsmanHPSParse { get; set; } = "";
        public string HuntsmanHPSIlvlParse { get; set; } = "";
        public string HuntsmanDeaths { get; set; } = "";
        public string HuntsmanFlask { get; set; } = "";
        public string HuntsmanFood { get; set; } = "";
        public string HuntsmanPot { get; set; } = "";
        public string HuntsmanSpace { get; set; } = "";
        public string HungeringDPS { get; set; } = "";
        public string HungeringHPS { get; set; } = "";
        public string HungeringDT { get; set; } = "";
        public string HungeringDPSParse { get; set; } = "";
        public string HungeringDPSIlvlParse { get; set; } = "";
        public string HungeringHPSParse { get; set; } = "";
        public string HungeringHPSIlvlParse { get; set; } = "";
        public string HungeringDeaths { get; set; } = "";
        public string HungeringFlask { get; set; } = "";
        public string HungeringFood { get; set; } = "";
        public string HungeringPot { get; set; } = "";
        public string HungeringSpace { get; set; } = "";
        public string InervaDPS { get; set; } = "";
        public string InervaHPS { get; set; } = "";
        public string InervaDT { get; set; } = "";
        public string InervaDPSParse { get; set; } = "";
        public string InervaDPSIlvlParse { get; set; } = "";
        public string InervaHPSParse { get; set; } = "";
        public string InervaHPSIlvlParse { get; set; } = "";
        public string InervaDeaths { get; set; } = "";
        public string InervaFlask { get; set; } = "";
        public string InervaFood { get; set; } = "";
        public string InervaPot { get; set; } = "";
        public string InvervaSpace { get; set; } = "";
        public string ArtificerDPS { get; set; } = "";
        public string ArtificerHPS { get; set; } = "";
        public string ArtificerDT { get; set; } = "";
        public string ArtificerDPSParse { get; set; } = "";
        public string ArtificerDPSIlvlParse { get; set; } = "";
        public string ArtificerHPSParse { get; set; } = "";
        public string ArtificerHPSIlvlParse { get; set; } = "";
        public string ArtificerDeaths { get; set; } = "";
        public string ArtificerFlask { get; set; } = "";
        public string ArtificerFood { get; set; } = "";
        public string ArtificerPot { get; set; } = "";
        public string ArtificerSpace { get; set; } = "";
        public string SunKingDPS { get; set; } = "";
        public string SunKingHPS { get; set; } = "";
        public string SunKingDT { get; set; } = "";
        public string SunKingDPSParse { get; set; } = "";
        public string SunKingDPSIlvlParse { get; set; } = "";
        public string SunKingHPSParse { get; set; } = "";
        public string SunKingHPSIlvlParse { get; set; } = "";
        public string SunKingDeaths { get; set; } = "";
        public string SunKingFlask { get; set; } = "";
        public string SunKingFood { get; set; } = "";
        public string SunKingPot { get; set; } = "";
        public string SunKingSpace { get; set; } = "";
        public string CouncilDPS { get; set; } = "";
        public string CouncilHPS { get; set; } = "";
        public string CouncilDT { get; set; } = "";
        public string CouncilDPSParse { get; set; } = "";
        public string CouncilDPSIlvlParse { get; set; } = "";
        public string CouncilHPSParse { get; set; } = "";
        public string CouncilHPSIlvlParse { get; set; } = "";
        public string CouncilDeaths { get; set; } = "";
        public string CouncilFlask { get; set; } = "";
        public string CouncilFood { get; set; } = "";
        public string CouncilPot { get; set; } = "";
        public string CouncilSpace { get; set; } = "";
        public string SludgeDPS { get; set; } = "";
        public string SludgeHPS { get; set; } = "";
        public string SludgeDT { get; set; } = "";
        public string SludgeDPSParse { get; set; } = "";
        public string SludgeDPSIlvlParse { get; set; } = "";
        public string SludgeHPSParse { get; set; } = "";
        public string SludgeHPSIlvlParse { get; set; } = "";
        public string SludgeDeaths { get; set; } = "";
        public string SludgeFlask { get; set; } = "";
        public string SludgeFood { get; set; } = "";
        public string SludgePot { get; set; } = "";
        public string SludgeSpace { get; set; } = "";
        public string StoneLegionDPS { get; set; } = "";
        public string StoneLegionHPS { get; set; } = "";
        public string StoneLegionDT { get; set; } = "";
        public string StoneLegionDPSParse { get; set; } = "";
        public string StoneLegionDPSIlvlParse { get; set; } = "";
        public string StoneLegionHPSParse { get; set; } = "";
        public string StoneLegionHPSIlvlParse { get; set; } = "";
        public string StoneLegionDeaths { get; set; } = "";
        public string StoneLegionFlask { get; set; } = "";
        public string StoneLegionFood { get; set; } = "";
        public string StoneLegionPot { get; set; } = "";
        public string StoneLegionSpace { get; set; } = "";
        public string SireDPS { get; set; } = "";
        public string SireHPS { get; set; } = "";
        public string SireDT { get; set; } = "";
        public string SireDPSParse { get; set; } = "";
        public string SireDPSIlvlParse { get; set; } = "";
        public string SireHPSParse { get; set; } = "";
        public string SireHPSIlvlParse { get; set; } = "";
        public string SireDeaths { get; set; } = "";
        public string SireFlask { get; set; } = "";
        public string SireFood { get; set; } = "";
        public string SirePot { get; set; } = "";
    }
    class LogHandlerMain
    {
        //TODO: make a readme for how all this works and how to use it
        static public void UpdateForBoss(string boss, Dictionary<string,OutputLog> rets)
        {
            //Read in data
            //DPS Data
            using (var reader = new StreamReader(String.Format("E:\\Design_work\\Guild_Stuff\\LogHandlers\\WarcraftLogHelper\\WarcraftLogHelper\\Data\\{0}\\Log_DMG.csv",boss)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<DPSLogMap>();
                var records = csv.GetRecords<DPSLog>().ToList();
                foreach (DPSLog log in records)
                {
                    if (rets.ContainsKey(log.Name))
                    {
                        UpdateDPS(rets[log.Name], log, boss);
                    }
                    else
                    {
                        OutputLog tmp = new OutputLog { Name = log.Name };
                        UpdateDPS(tmp, log, boss);
                        rets[log.Name] = tmp; ;
                    }
                }
            }

            //HPS Data
            using (var reader = new StreamReader(String.Format("E:\\Design_work\\Guild_Stuff\\LogHandlers\\WarcraftLogHelper\\WarcraftLogHelper\\Data\\{0}\\Log_Heal.csv", boss)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<HPSLogMap>();
                var records = csv.GetRecords<HPSLog>().ToList();
                foreach (HPSLog log in records)
                {
                    if (rets.ContainsKey(log.Name))
                    {
                        rets[log.Name] = UpdateHPS(rets[log.Name], log, boss);
                    }
                    else
                    {
                        OutputLog tmp = new OutputLog { Name = log.Name };
                        UpdateHPS(tmp, log, boss);
                        rets[log.Name] = tmp; ;
                    }
                }
            }

            //DT Data
            using (var reader = new StreamReader(String.Format("E:\\Design_work\\Guild_Stuff\\LogHandlers\\WarcraftLogHelper\\WarcraftLogHelper\\Data\\{0}\\Log_DT.csv", boss)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<DTLogMap>();
                var records = csv.GetRecords<DTLog>().ToList();
                foreach (DTLog log in records)
                {
                    if (rets.ContainsKey(log.Name))
                    {
                        rets[log.Name] = UpdateDT(rets[log.Name], log, boss);
                    }
                    else
                    {
                        OutputLog tmp = new OutputLog { Name = log.Name };
                        UpdateDT(tmp, log, boss);
                        rets[log.Name] = tmp; ;
                    }
                }
            }
            //Currently non-functional because I can't download the CSV from logs
            //Deaths Data 
            /*using (var reader = new StreamReader(String.Format("E:\\Design_work\\Guild_Stuff\\LogHandlers\\WarcraftLogHelper\\WarcraftLogHelper\\Data\\{0}\\Log_Deaths.csv", boss)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<DeathLogMap>();
                var records = csv.GetRecords<DeathLog>().ToList();
                foreach (DeathLog log in records)
                {
                    if (rets.ContainsKey(log.Name))
                    {
                        rets[log.Name] = UpdateDeaths(rets[log.Name], log, boss);
                    }
                    else
                    {
                        OutputLog tmp = new OutputLog { Name = log.Name };
                        UpdateDeaths(tmp, log, boss);
                        rets[log.Name] = tmp; ;
                    }
                }
            }*/
        }
        static public OutputLog UpdateDPS(OutputLog ret, DPSLog dps, string boss)
        {
            if(boss == "Shriek")
            {
                ret.ShriekDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.ShriekDPSParse = dps.Parse.ToString();
                ret.ShriekDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Huntsman")
            {
                ret.HuntsmanDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.HuntsmanDPSParse = dps.Parse.ToString();
                ret.HuntsmanDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Hungering")
            {
                ret.HungeringDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.HungeringDPSParse = dps.Parse.ToString();
                ret.HungeringDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Inerva")
            {
                ret.InervaDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.InervaDPSParse = dps.Parse.ToString();
                ret.InervaDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Council")
            {
                ret.CouncilDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.CouncilDPSParse = dps.Parse.ToString();
                ret.CouncilDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Artificer")
            {
                ret.ArtificerDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.ArtificerDPSParse = dps.Parse.ToString();
                ret.ArtificerDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Sire")
            {
                ret.SireDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.SireDPSParse = dps.Parse.ToString();
                ret.SireDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "StoneLegion")
            {
                ret.StoneLegionDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.StoneLegionDPSParse = dps.Parse.ToString();
                ret.StoneLegionDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "Sludge")
            {
                ret.SludgeDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.SludgeDPSParse = dps.Parse.ToString();
                ret.SludgeDPSIlvlParse = dps.ilvlParse.ToString();
            }
            else if (boss == "SunKing")
            {
                ret.SunKingDPS = int.Parse(dps.DPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.SunKingDPSParse = dps.Parse.ToString();
                ret.SunKingDPSIlvlParse = dps.ilvlParse.ToString();
            }

            return ret;
        }

        static public OutputLog UpdateHPS(OutputLog ret, HPSLog hps, string boss)
        {
            if (boss == "Shriek")
            {
                ret.ShriekHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.ShriekHPSParse = hps.Parse.ToString();
                ret.ShriekHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Huntsman")
            {
                ret.HuntsmanHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.HuntsmanHPSParse = hps.Parse.ToString();
                ret.HuntsmanHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Hungering")
            {
                ret.HungeringHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.HungeringHPSParse = hps.Parse.ToString();
                ret.HungeringHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Inerva")
            {
                ret.InervaHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.InervaHPSParse = hps.Parse.ToString();
                ret.InervaHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Council")
            {
                ret.CouncilHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.CouncilHPSParse = hps.Parse.ToString();
                ret.CouncilHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Artificer")
            {
                ret.ArtificerHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.ArtificerHPSParse = hps.Parse.ToString();
                ret.ArtificerHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Sire")
            {
                ret.SireHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.SireHPSParse = hps.Parse.ToString();
                ret.SireHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "StoneLegion")
            {
                ret.StoneLegionHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.StoneLegionHPSParse = hps.Parse.ToString();
                ret.StoneLegionHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "Sludge")
            {
                ret.SludgeHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.SludgeHPSParse = hps.Parse.ToString();
                ret.SludgeHPSIlvlParse = hps.ilvlParse.ToString();
            }
            else if (boss == "SunKing")
            {
                ret.SunKingHPS = int.Parse(hps.HPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
                ret.SunKingHPSParse = hps.Parse.ToString();
                ret.SunKingHPSIlvlParse = hps.ilvlParse.ToString();
            }
            return ret;
        }

        static public OutputLog UpdateDT(OutputLog ret, DTLog dtps, string boss)
        {
            if (boss == "Shriek")
            {
                ret.ShriekDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Huntsman")
            {
                ret.HuntsmanDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Hungering")
            {
                ret.HungeringDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Inerva")
            {
                ret.InervaDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Council")
            {
                ret.CouncilDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Artificer")
            {
                ret.ArtificerDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Sire")
            {
                ret.SireDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "StoneLegion")
            {
                ret.StoneLegionDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "Sludge")
            {
                ret.SludgeDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            else if (boss == "SunKing")
            {
                ret.SunKingDT = int.Parse(dtps.DTPS.Split(".")[0], NumberStyles.AllowThousands, new CultureInfo("en-au")).ToString();
            }
            return ret;
        }

        static public OutputLog UpdateDeaths(OutputLog ret, DeathLog deaths, string boss)
        {
            if (boss == "Shriek")
            {
                ret.ShriekDeaths += 1;
            }
            else if (boss == "Huntsman")
            {
                ret.HuntsmanDT += 1;
            }
            else if (boss == "Hungering")
            {
                ret.HungeringDT += 1;
            }
            else if (boss == "Inverva")
            {
                ret.InervaDT += 1;
            }
            else if (boss == "Council")
            {
                ret.CouncilDT += 1;
            }
            else if (boss == "Artificer")
            {
                ret.ArtificerDT += 1;
            }
            else if (boss == "Sire")
            {
                ret.SireDT += 1;
            }
            else if (boss == "StoneLegion")
            {
                ret.StoneLegionDT += 1;
            }
            else if (boss == "Sludge")
            {
                ret.SludgeDT += 1;
            }
            else if (boss == "SunKing")
            {
                ret.SunKingDT += 1;
            }
            return ret;
        }

        static void Main(string[] args)
        {
            if(args.Length< 10)
            {
                Console.WriteLine("Invalid Arguments, expect 10 arguments and recieved {0}.", args.Length);
                return;
            }
            Dictionary<string, OutputLog> rets = new Dictionary<string, OutputLog>();
            //Shriekwing Data to be handled
            if (args[0] == "1")
            {
                UpdateForBoss("Shriek", rets);
            }
            //Huntsman Data to be handled
            if (args[1] == "2")
            {
                UpdateForBoss("Huntsman", rets);
            }
            //Hungering Data to be handled
            if (args[2] == "3")
            {
                UpdateForBoss("Hungering", rets);
            }
            //Inverva Data to be handled
            if (args[3] == "4")
            {
                UpdateForBoss("Inerva", rets);
            }
            //Artificer Data to be handled
            if (args[4] == "5")
            {
                UpdateForBoss("Artificer", rets);
            }
            //SunKing Data to be handled
            if (args[5] == "6")
            {
                UpdateForBoss("SunKing", rets);
            }
            //Council Data to be handled
            if (args[6] == "7")
            {
                UpdateForBoss("Council", rets);
            }
            //Sludge Data to be handled
            if (args[7] == "8")
            {
                UpdateForBoss("Sludge", rets);
            }
            //StoneLegion Data to be handled
            if (args[8] == "9")
            {
                UpdateForBoss("StoneLegion", rets);
            }
            //Sire Data to be handled
            if (args[9] == "10")
            {
                UpdateForBoss("Sire", rets);
            }

            var recordz = new List<OutputLog>();
            int count = 0;
            foreach (KeyValuePair<string, OutputLog> dis in rets)
            {
                count++;
                recordz.Add(dis.Value);
            }
            using (var writer = new StreamWriter("E:\\Design_work\\Guild_Stuff\\LogHandlers\\WarcraftLogHelper\\WarcraftLogHelper\\Data\\Output\\Output.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(recordz);
            }
            Console.WriteLine("Logs Have been handled!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! :D");
        }
    }

    
}
