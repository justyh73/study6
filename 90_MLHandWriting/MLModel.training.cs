﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace _90_MLHandWriting
{
    public partial class MLModel
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"col0", @"col0"),new InputOutputColumnPair(@"col1", @"col1"),new InputOutputColumnPair(@"col2", @"col2"),new InputOutputColumnPair(@"col3", @"col3"),new InputOutputColumnPair(@"col4", @"col4"),new InputOutputColumnPair(@"col5", @"col5"),new InputOutputColumnPair(@"col6", @"col6"),new InputOutputColumnPair(@"col7", @"col7"),new InputOutputColumnPair(@"col8", @"col8"),new InputOutputColumnPair(@"col9", @"col9"),new InputOutputColumnPair(@"col10", @"col10"),new InputOutputColumnPair(@"col11", @"col11"),new InputOutputColumnPair(@"col12", @"col12"),new InputOutputColumnPair(@"col13", @"col13"),new InputOutputColumnPair(@"col14", @"col14"),new InputOutputColumnPair(@"col15", @"col15"),new InputOutputColumnPair(@"col16", @"col16"),new InputOutputColumnPair(@"col17", @"col17"),new InputOutputColumnPair(@"col18", @"col18"),new InputOutputColumnPair(@"col19", @"col19"),new InputOutputColumnPair(@"col20", @"col20"),new InputOutputColumnPair(@"col21", @"col21"),new InputOutputColumnPair(@"col22", @"col22"),new InputOutputColumnPair(@"col23", @"col23"),new InputOutputColumnPair(@"col24", @"col24"),new InputOutputColumnPair(@"col25", @"col25"),new InputOutputColumnPair(@"col26", @"col26"),new InputOutputColumnPair(@"col27", @"col27"),new InputOutputColumnPair(@"col28", @"col28"),new InputOutputColumnPair(@"col29", @"col29"),new InputOutputColumnPair(@"col30", @"col30"),new InputOutputColumnPair(@"col31", @"col31"),new InputOutputColumnPair(@"col32", @"col32"),new InputOutputColumnPair(@"col33", @"col33"),new InputOutputColumnPair(@"col34", @"col34"),new InputOutputColumnPair(@"col35", @"col35"),new InputOutputColumnPair(@"col36", @"col36"),new InputOutputColumnPair(@"col37", @"col37"),new InputOutputColumnPair(@"col38", @"col38"),new InputOutputColumnPair(@"col39", @"col39"),new InputOutputColumnPair(@"col40", @"col40"),new InputOutputColumnPair(@"col41", @"col41"),new InputOutputColumnPair(@"col42", @"col42"),new InputOutputColumnPair(@"col43", @"col43"),new InputOutputColumnPair(@"col44", @"col44"),new InputOutputColumnPair(@"col45", @"col45"),new InputOutputColumnPair(@"col46", @"col46"),new InputOutputColumnPair(@"col47", @"col47"),new InputOutputColumnPair(@"col48", @"col48"),new InputOutputColumnPair(@"col49", @"col49"),new InputOutputColumnPair(@"col50", @"col50"),new InputOutputColumnPair(@"col51", @"col51"),new InputOutputColumnPair(@"col52", @"col52"),new InputOutputColumnPair(@"col53", @"col53"),new InputOutputColumnPair(@"col54", @"col54"),new InputOutputColumnPair(@"col55", @"col55"),new InputOutputColumnPair(@"col56", @"col56"),new InputOutputColumnPair(@"col57", @"col57"),new InputOutputColumnPair(@"col58", @"col58"),new InputOutputColumnPair(@"col59", @"col59"),new InputOutputColumnPair(@"col60", @"col60"),new InputOutputColumnPair(@"col61", @"col61"),new InputOutputColumnPair(@"col62", @"col62"),new InputOutputColumnPair(@"col63", @"col63"),new InputOutputColumnPair(@"col64", @"col64"),new InputOutputColumnPair(@"col65", @"col65"),new InputOutputColumnPair(@"col66", @"col66"),new InputOutputColumnPair(@"col67", @"col67"),new InputOutputColumnPair(@"col68", @"col68"),new InputOutputColumnPair(@"col69", @"col69"),new InputOutputColumnPair(@"col70", @"col70"),new InputOutputColumnPair(@"col71", @"col71"),new InputOutputColumnPair(@"col72", @"col72"),new InputOutputColumnPair(@"col73", @"col73"),new InputOutputColumnPair(@"col74", @"col74"),new InputOutputColumnPair(@"col75", @"col75"),new InputOutputColumnPair(@"col76", @"col76"),new InputOutputColumnPair(@"col77", @"col77"),new InputOutputColumnPair(@"col78", @"col78"),new InputOutputColumnPair(@"col79", @"col79"),new InputOutputColumnPair(@"col80", @"col80"),new InputOutputColumnPair(@"col81", @"col81"),new InputOutputColumnPair(@"col82", @"col82"),new InputOutputColumnPair(@"col83", @"col83"),new InputOutputColumnPair(@"col84", @"col84"),new InputOutputColumnPair(@"col85", @"col85"),new InputOutputColumnPair(@"col86", @"col86"),new InputOutputColumnPair(@"col87", @"col87"),new InputOutputColumnPair(@"col88", @"col88"),new InputOutputColumnPair(@"col89", @"col89"),new InputOutputColumnPair(@"col90", @"col90"),new InputOutputColumnPair(@"col91", @"col91"),new InputOutputColumnPair(@"col92", @"col92"),new InputOutputColumnPair(@"col93", @"col93"),new InputOutputColumnPair(@"col94", @"col94"),new InputOutputColumnPair(@"col95", @"col95"),new InputOutputColumnPair(@"col96", @"col96"),new InputOutputColumnPair(@"col97", @"col97"),new InputOutputColumnPair(@"col98", @"col98"),new InputOutputColumnPair(@"col99", @"col99"),new InputOutputColumnPair(@"col100", @"col100"),new InputOutputColumnPair(@"col101", @"col101"),new InputOutputColumnPair(@"col102", @"col102"),new InputOutputColumnPair(@"col103", @"col103"),new InputOutputColumnPair(@"col104", @"col104"),new InputOutputColumnPair(@"col105", @"col105"),new InputOutputColumnPair(@"col106", @"col106"),new InputOutputColumnPair(@"col107", @"col107"),new InputOutputColumnPair(@"col108", @"col108"),new InputOutputColumnPair(@"col109", @"col109"),new InputOutputColumnPair(@"col110", @"col110"),new InputOutputColumnPair(@"col111", @"col111"),new InputOutputColumnPair(@"col112", @"col112"),new InputOutputColumnPair(@"col113", @"col113"),new InputOutputColumnPair(@"col114", @"col114"),new InputOutputColumnPair(@"col115", @"col115"),new InputOutputColumnPair(@"col116", @"col116"),new InputOutputColumnPair(@"col117", @"col117"),new InputOutputColumnPair(@"col118", @"col118"),new InputOutputColumnPair(@"col119", @"col119"),new InputOutputColumnPair(@"col120", @"col120"),new InputOutputColumnPair(@"col121", @"col121"),new InputOutputColumnPair(@"col122", @"col122"),new InputOutputColumnPair(@"col123", @"col123"),new InputOutputColumnPair(@"col124", @"col124"),new InputOutputColumnPair(@"col125", @"col125"),new InputOutputColumnPair(@"col126", @"col126"),new InputOutputColumnPair(@"col127", @"col127"),new InputOutputColumnPair(@"col128", @"col128"),new InputOutputColumnPair(@"col129", @"col129"),new InputOutputColumnPair(@"col130", @"col130"),new InputOutputColumnPair(@"col131", @"col131"),new InputOutputColumnPair(@"col132", @"col132"),new InputOutputColumnPair(@"col133", @"col133"),new InputOutputColumnPair(@"col134", @"col134"),new InputOutputColumnPair(@"col135", @"col135"),new InputOutputColumnPair(@"col136", @"col136"),new InputOutputColumnPair(@"col137", @"col137"),new InputOutputColumnPair(@"col138", @"col138"),new InputOutputColumnPair(@"col139", @"col139"),new InputOutputColumnPair(@"col140", @"col140"),new InputOutputColumnPair(@"col141", @"col141"),new InputOutputColumnPair(@"col142", @"col142"),new InputOutputColumnPair(@"col143", @"col143"),new InputOutputColumnPair(@"col144", @"col144"),new InputOutputColumnPair(@"col145", @"col145"),new InputOutputColumnPair(@"col146", @"col146"),new InputOutputColumnPair(@"col147", @"col147"),new InputOutputColumnPair(@"col148", @"col148"),new InputOutputColumnPair(@"col149", @"col149"),new InputOutputColumnPair(@"col150", @"col150"),new InputOutputColumnPair(@"col151", @"col151"),new InputOutputColumnPair(@"col152", @"col152"),new InputOutputColumnPair(@"col153", @"col153"),new InputOutputColumnPair(@"col154", @"col154"),new InputOutputColumnPair(@"col155", @"col155"),new InputOutputColumnPair(@"col156", @"col156"),new InputOutputColumnPair(@"col157", @"col157"),new InputOutputColumnPair(@"col158", @"col158"),new InputOutputColumnPair(@"col159", @"col159"),new InputOutputColumnPair(@"col160", @"col160"),new InputOutputColumnPair(@"col161", @"col161"),new InputOutputColumnPair(@"col162", @"col162"),new InputOutputColumnPair(@"col163", @"col163"),new InputOutputColumnPair(@"col164", @"col164"),new InputOutputColumnPair(@"col165", @"col165"),new InputOutputColumnPair(@"col166", @"col166"),new InputOutputColumnPair(@"col167", @"col167"),new InputOutputColumnPair(@"col168", @"col168"),new InputOutputColumnPair(@"col169", @"col169"),new InputOutputColumnPair(@"col170", @"col170"),new InputOutputColumnPair(@"col171", @"col171"),new InputOutputColumnPair(@"col172", @"col172"),new InputOutputColumnPair(@"col173", @"col173"),new InputOutputColumnPair(@"col174", @"col174"),new InputOutputColumnPair(@"col175", @"col175"),new InputOutputColumnPair(@"col176", @"col176"),new InputOutputColumnPair(@"col177", @"col177"),new InputOutputColumnPair(@"col178", @"col178"),new InputOutputColumnPair(@"col179", @"col179"),new InputOutputColumnPair(@"col180", @"col180"),new InputOutputColumnPair(@"col181", @"col181"),new InputOutputColumnPair(@"col182", @"col182"),new InputOutputColumnPair(@"col183", @"col183"),new InputOutputColumnPair(@"col184", @"col184"),new InputOutputColumnPair(@"col185", @"col185"),new InputOutputColumnPair(@"col186", @"col186"),new InputOutputColumnPair(@"col187", @"col187"),new InputOutputColumnPair(@"col188", @"col188"),new InputOutputColumnPair(@"col189", @"col189"),new InputOutputColumnPair(@"col190", @"col190"),new InputOutputColumnPair(@"col191", @"col191"),new InputOutputColumnPair(@"col192", @"col192"),new InputOutputColumnPair(@"col193", @"col193"),new InputOutputColumnPair(@"col194", @"col194"),new InputOutputColumnPair(@"col195", @"col195"),new InputOutputColumnPair(@"col196", @"col196"),new InputOutputColumnPair(@"col197", @"col197"),new InputOutputColumnPair(@"col198", @"col198"),new InputOutputColumnPair(@"col199", @"col199"),new InputOutputColumnPair(@"col200", @"col200"),new InputOutputColumnPair(@"col201", @"col201"),new InputOutputColumnPair(@"col202", @"col202"),new InputOutputColumnPair(@"col203", @"col203"),new InputOutputColumnPair(@"col204", @"col204"),new InputOutputColumnPair(@"col205", @"col205"),new InputOutputColumnPair(@"col206", @"col206"),new InputOutputColumnPair(@"col207", @"col207"),new InputOutputColumnPair(@"col208", @"col208"),new InputOutputColumnPair(@"col209", @"col209"),new InputOutputColumnPair(@"col210", @"col210"),new InputOutputColumnPair(@"col211", @"col211"),new InputOutputColumnPair(@"col212", @"col212"),new InputOutputColumnPair(@"col213", @"col213"),new InputOutputColumnPair(@"col214", @"col214"),new InputOutputColumnPair(@"col215", @"col215"),new InputOutputColumnPair(@"col216", @"col216"),new InputOutputColumnPair(@"col217", @"col217"),new InputOutputColumnPair(@"col218", @"col218"),new InputOutputColumnPair(@"col219", @"col219"),new InputOutputColumnPair(@"col220", @"col220"),new InputOutputColumnPair(@"col221", @"col221"),new InputOutputColumnPair(@"col222", @"col222"),new InputOutputColumnPair(@"col223", @"col223"),new InputOutputColumnPair(@"col224", @"col224"),new InputOutputColumnPair(@"col225", @"col225"),new InputOutputColumnPair(@"col226", @"col226"),new InputOutputColumnPair(@"col227", @"col227"),new InputOutputColumnPair(@"col228", @"col228"),new InputOutputColumnPair(@"col229", @"col229"),new InputOutputColumnPair(@"col230", @"col230"),new InputOutputColumnPair(@"col231", @"col231"),new InputOutputColumnPair(@"col232", @"col232"),new InputOutputColumnPair(@"col233", @"col233"),new InputOutputColumnPair(@"col234", @"col234"),new InputOutputColumnPair(@"col235", @"col235"),new InputOutputColumnPair(@"col236", @"col236"),new InputOutputColumnPair(@"col237", @"col237"),new InputOutputColumnPair(@"col238", @"col238"),new InputOutputColumnPair(@"col239", @"col239"),new InputOutputColumnPair(@"col240", @"col240"),new InputOutputColumnPair(@"col241", @"col241"),new InputOutputColumnPair(@"col242", @"col242"),new InputOutputColumnPair(@"col243", @"col243"),new InputOutputColumnPair(@"col244", @"col244"),new InputOutputColumnPair(@"col245", @"col245"),new InputOutputColumnPair(@"col246", @"col246"),new InputOutputColumnPair(@"col247", @"col247"),new InputOutputColumnPair(@"col248", @"col248"),new InputOutputColumnPair(@"col249", @"col249"),new InputOutputColumnPair(@"col250", @"col250"),new InputOutputColumnPair(@"col251", @"col251"),new InputOutputColumnPair(@"col252", @"col252"),new InputOutputColumnPair(@"col253", @"col253"),new InputOutputColumnPair(@"col254", @"col254"),new InputOutputColumnPair(@"col255", @"col255"),new InputOutputColumnPair(@"col256", @"col256"),new InputOutputColumnPair(@"col257", @"col257"),new InputOutputColumnPair(@"col258", @"col258"),new InputOutputColumnPair(@"col259", @"col259"),new InputOutputColumnPair(@"col260", @"col260"),new InputOutputColumnPair(@"col261", @"col261"),new InputOutputColumnPair(@"col262", @"col262"),new InputOutputColumnPair(@"col263", @"col263"),new InputOutputColumnPair(@"col264", @"col264"),new InputOutputColumnPair(@"col265", @"col265"),new InputOutputColumnPair(@"col266", @"col266"),new InputOutputColumnPair(@"col267", @"col267"),new InputOutputColumnPair(@"col268", @"col268"),new InputOutputColumnPair(@"col269", @"col269"),new InputOutputColumnPair(@"col270", @"col270"),new InputOutputColumnPair(@"col271", @"col271"),new InputOutputColumnPair(@"col272", @"col272"),new InputOutputColumnPair(@"col273", @"col273"),new InputOutputColumnPair(@"col274", @"col274"),new InputOutputColumnPair(@"col275", @"col275"),new InputOutputColumnPair(@"col276", @"col276"),new InputOutputColumnPair(@"col277", @"col277"),new InputOutputColumnPair(@"col278", @"col278"),new InputOutputColumnPair(@"col279", @"col279"),new InputOutputColumnPair(@"col280", @"col280"),new InputOutputColumnPair(@"col281", @"col281"),new InputOutputColumnPair(@"col282", @"col282"),new InputOutputColumnPair(@"col283", @"col283"),new InputOutputColumnPair(@"col284", @"col284"),new InputOutputColumnPair(@"col285", @"col285"),new InputOutputColumnPair(@"col286", @"col286"),new InputOutputColumnPair(@"col287", @"col287"),new InputOutputColumnPair(@"col288", @"col288"),new InputOutputColumnPair(@"col289", @"col289"),new InputOutputColumnPair(@"col290", @"col290"),new InputOutputColumnPair(@"col291", @"col291"),new InputOutputColumnPair(@"col292", @"col292"),new InputOutputColumnPair(@"col293", @"col293"),new InputOutputColumnPair(@"col294", @"col294"),new InputOutputColumnPair(@"col295", @"col295"),new InputOutputColumnPair(@"col296", @"col296"),new InputOutputColumnPair(@"col297", @"col297"),new InputOutputColumnPair(@"col298", @"col298"),new InputOutputColumnPair(@"col299", @"col299"),new InputOutputColumnPair(@"col300", @"col300"),new InputOutputColumnPair(@"col301", @"col301"),new InputOutputColumnPair(@"col302", @"col302"),new InputOutputColumnPair(@"col303", @"col303"),new InputOutputColumnPair(@"col304", @"col304"),new InputOutputColumnPair(@"col305", @"col305"),new InputOutputColumnPair(@"col306", @"col306"),new InputOutputColumnPair(@"col307", @"col307"),new InputOutputColumnPair(@"col308", @"col308"),new InputOutputColumnPair(@"col309", @"col309"),new InputOutputColumnPair(@"col310", @"col310"),new InputOutputColumnPair(@"col311", @"col311"),new InputOutputColumnPair(@"col312", @"col312"),new InputOutputColumnPair(@"col313", @"col313"),new InputOutputColumnPair(@"col314", @"col314"),new InputOutputColumnPair(@"col315", @"col315"),new InputOutputColumnPair(@"col316", @"col316"),new InputOutputColumnPair(@"col317", @"col317"),new InputOutputColumnPair(@"col318", @"col318"),new InputOutputColumnPair(@"col319", @"col319"),new InputOutputColumnPair(@"col320", @"col320"),new InputOutputColumnPair(@"col321", @"col321"),new InputOutputColumnPair(@"col322", @"col322"),new InputOutputColumnPair(@"col323", @"col323"),new InputOutputColumnPair(@"col324", @"col324"),new InputOutputColumnPair(@"col325", @"col325"),new InputOutputColumnPair(@"col326", @"col326"),new InputOutputColumnPair(@"col327", @"col327"),new InputOutputColumnPair(@"col328", @"col328"),new InputOutputColumnPair(@"col329", @"col329"),new InputOutputColumnPair(@"col330", @"col330"),new InputOutputColumnPair(@"col331", @"col331"),new InputOutputColumnPair(@"col332", @"col332"),new InputOutputColumnPair(@"col333", @"col333"),new InputOutputColumnPair(@"col334", @"col334"),new InputOutputColumnPair(@"col335", @"col335"),new InputOutputColumnPair(@"col336", @"col336"),new InputOutputColumnPair(@"col337", @"col337"),new InputOutputColumnPair(@"col338", @"col338"),new InputOutputColumnPair(@"col339", @"col339"),new InputOutputColumnPair(@"col340", @"col340"),new InputOutputColumnPair(@"col341", @"col341"),new InputOutputColumnPair(@"col342", @"col342"),new InputOutputColumnPair(@"col343", @"col343"),new InputOutputColumnPair(@"col344", @"col344"),new InputOutputColumnPair(@"col345", @"col345"),new InputOutputColumnPair(@"col346", @"col346"),new InputOutputColumnPair(@"col347", @"col347"),new InputOutputColumnPair(@"col348", @"col348"),new InputOutputColumnPair(@"col349", @"col349"),new InputOutputColumnPair(@"col350", @"col350"),new InputOutputColumnPair(@"col351", @"col351"),new InputOutputColumnPair(@"col352", @"col352"),new InputOutputColumnPair(@"col353", @"col353"),new InputOutputColumnPair(@"col354", @"col354"),new InputOutputColumnPair(@"col355", @"col355"),new InputOutputColumnPair(@"col356", @"col356"),new InputOutputColumnPair(@"col357", @"col357"),new InputOutputColumnPair(@"col358", @"col358"),new InputOutputColumnPair(@"col359", @"col359"),new InputOutputColumnPair(@"col360", @"col360"),new InputOutputColumnPair(@"col361", @"col361"),new InputOutputColumnPair(@"col362", @"col362"),new InputOutputColumnPair(@"col363", @"col363"),new InputOutputColumnPair(@"col364", @"col364"),new InputOutputColumnPair(@"col365", @"col365"),new InputOutputColumnPair(@"col366", @"col366"),new InputOutputColumnPair(@"col367", @"col367"),new InputOutputColumnPair(@"col368", @"col368"),new InputOutputColumnPair(@"col369", @"col369"),new InputOutputColumnPair(@"col370", @"col370"),new InputOutputColumnPair(@"col371", @"col371"),new InputOutputColumnPair(@"col372", @"col372"),new InputOutputColumnPair(@"col373", @"col373"),new InputOutputColumnPair(@"col374", @"col374"),new InputOutputColumnPair(@"col375", @"col375"),new InputOutputColumnPair(@"col376", @"col376"),new InputOutputColumnPair(@"col377", @"col377"),new InputOutputColumnPair(@"col378", @"col378"),new InputOutputColumnPair(@"col379", @"col379"),new InputOutputColumnPair(@"col380", @"col380"),new InputOutputColumnPair(@"col381", @"col381"),new InputOutputColumnPair(@"col382", @"col382"),new InputOutputColumnPair(@"col383", @"col383"),new InputOutputColumnPair(@"col384", @"col384"),new InputOutputColumnPair(@"col385", @"col385"),new InputOutputColumnPair(@"col386", @"col386"),new InputOutputColumnPair(@"col387", @"col387"),new InputOutputColumnPair(@"col388", @"col388"),new InputOutputColumnPair(@"col389", @"col389"),new InputOutputColumnPair(@"col390", @"col390"),new InputOutputColumnPair(@"col391", @"col391"),new InputOutputColumnPair(@"col392", @"col392"),new InputOutputColumnPair(@"col393", @"col393"),new InputOutputColumnPair(@"col394", @"col394"),new InputOutputColumnPair(@"col395", @"col395"),new InputOutputColumnPair(@"col396", @"col396"),new InputOutputColumnPair(@"col397", @"col397"),new InputOutputColumnPair(@"col398", @"col398"),new InputOutputColumnPair(@"col399", @"col399")})      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"col0",@"col1",@"col2",@"col3",@"col4",@"col5",@"col6",@"col7",@"col8",@"col9",@"col10",@"col11",@"col12",@"col13",@"col14",@"col15",@"col16",@"col17",@"col18",@"col19",@"col20",@"col21",@"col22",@"col23",@"col24",@"col25",@"col26",@"col27",@"col28",@"col29",@"col30",@"col31",@"col32",@"col33",@"col34",@"col35",@"col36",@"col37",@"col38",@"col39",@"col40",@"col41",@"col42",@"col43",@"col44",@"col45",@"col46",@"col47",@"col48",@"col49",@"col50",@"col51",@"col52",@"col53",@"col54",@"col55",@"col56",@"col57",@"col58",@"col59",@"col60",@"col61",@"col62",@"col63",@"col64",@"col65",@"col66",@"col67",@"col68",@"col69",@"col70",@"col71",@"col72",@"col73",@"col74",@"col75",@"col76",@"col77",@"col78",@"col79",@"col80",@"col81",@"col82",@"col83",@"col84",@"col85",@"col86",@"col87",@"col88",@"col89",@"col90",@"col91",@"col92",@"col93",@"col94",@"col95",@"col96",@"col97",@"col98",@"col99",@"col100",@"col101",@"col102",@"col103",@"col104",@"col105",@"col106",@"col107",@"col108",@"col109",@"col110",@"col111",@"col112",@"col113",@"col114",@"col115",@"col116",@"col117",@"col118",@"col119",@"col120",@"col121",@"col122",@"col123",@"col124",@"col125",@"col126",@"col127",@"col128",@"col129",@"col130",@"col131",@"col132",@"col133",@"col134",@"col135",@"col136",@"col137",@"col138",@"col139",@"col140",@"col141",@"col142",@"col143",@"col144",@"col145",@"col146",@"col147",@"col148",@"col149",@"col150",@"col151",@"col152",@"col153",@"col154",@"col155",@"col156",@"col157",@"col158",@"col159",@"col160",@"col161",@"col162",@"col163",@"col164",@"col165",@"col166",@"col167",@"col168",@"col169",@"col170",@"col171",@"col172",@"col173",@"col174",@"col175",@"col176",@"col177",@"col178",@"col179",@"col180",@"col181",@"col182",@"col183",@"col184",@"col185",@"col186",@"col187",@"col188",@"col189",@"col190",@"col191",@"col192",@"col193",@"col194",@"col195",@"col196",@"col197",@"col198",@"col199",@"col200",@"col201",@"col202",@"col203",@"col204",@"col205",@"col206",@"col207",@"col208",@"col209",@"col210",@"col211",@"col212",@"col213",@"col214",@"col215",@"col216",@"col217",@"col218",@"col219",@"col220",@"col221",@"col222",@"col223",@"col224",@"col225",@"col226",@"col227",@"col228",@"col229",@"col230",@"col231",@"col232",@"col233",@"col234",@"col235",@"col236",@"col237",@"col238",@"col239",@"col240",@"col241",@"col242",@"col243",@"col244",@"col245",@"col246",@"col247",@"col248",@"col249",@"col250",@"col251",@"col252",@"col253",@"col254",@"col255",@"col256",@"col257",@"col258",@"col259",@"col260",@"col261",@"col262",@"col263",@"col264",@"col265",@"col266",@"col267",@"col268",@"col269",@"col270",@"col271",@"col272",@"col273",@"col274",@"col275",@"col276",@"col277",@"col278",@"col279",@"col280",@"col281",@"col282",@"col283",@"col284",@"col285",@"col286",@"col287",@"col288",@"col289",@"col290",@"col291",@"col292",@"col293",@"col294",@"col295",@"col296",@"col297",@"col298",@"col299",@"col300",@"col301",@"col302",@"col303",@"col304",@"col305",@"col306",@"col307",@"col308",@"col309",@"col310",@"col311",@"col312",@"col313",@"col314",@"col315",@"col316",@"col317",@"col318",@"col319",@"col320",@"col321",@"col322",@"col323",@"col324",@"col325",@"col326",@"col327",@"col328",@"col329",@"col330",@"col331",@"col332",@"col333",@"col334",@"col335",@"col336",@"col337",@"col338",@"col339",@"col340",@"col341",@"col342",@"col343",@"col344",@"col345",@"col346",@"col347",@"col348",@"col349",@"col350",@"col351",@"col352",@"col353",@"col354",@"col355",@"col356",@"col357",@"col358",@"col359",@"col360",@"col361",@"col362",@"col363",@"col364",@"col365",@"col366",@"col367",@"col368",@"col369",@"col370",@"col371",@"col372",@"col373",@"col374",@"col375",@"col376",@"col377",@"col378",@"col379",@"col380",@"col381",@"col382",@"col383",@"col384",@"col385",@"col386",@"col387",@"col388",@"col389",@"col390",@"col391",@"col392",@"col393",@"col394",@"col395",@"col396",@"col397",@"col398",@"col399"}))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName:@"col400",inputColumnName:@"col400"))      
                                    .Append(mlContext.MulticlassClassification.Trainers.OneVersusAll(binaryEstimator:mlContext.BinaryClassification.Trainers.FastTree(new FastTreeBinaryTrainer.Options(){NumberOfLeaves=294,MinimumExampleCountPerLeaf=127,NumberOfTrees=1446,MaximumBinCountPerFeature=162,FeatureFraction=0.99999999,LearningRate=0.0885567434213398,LabelColumnName=@"col400",FeatureColumnName=@"Features"}),labelColumnName: @"col400"))      
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName:@"PredictedLabel",inputColumnName:@"PredictedLabel"));

            return pipeline;
        }
    }
}
