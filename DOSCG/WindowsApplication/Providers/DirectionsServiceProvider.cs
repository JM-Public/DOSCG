using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft.Json;

namespace WindowsApplication.Providers
{
    #region " Entities "

    public class GeocodedWaypoint
    {

        [JsonProperty("geocoder_status")]
        public string GeocoderStatus { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("types")]
        public IList<string> Types { get; set; }
    }

    public class Northeast
    {

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Southwest
    {

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Bounds
    {

        [JsonProperty("northeast")]
        public Northeast Northeast { get; set; }

        [JsonProperty("southwest")]
        public Southwest Southwest { get; set; }
    }

    public class Distance
    {

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class Duration
    {

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class EndLocation
    {

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class StartLocation
    {

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Polyline
    {

        [JsonProperty("points")]
        public string Points { get; set; }
    }

    public class Step
    {

        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("end_location")]
        public EndLocation EndLocation { get; set; }

        [JsonProperty("html_instructions")]
        public string HtmlInstructions { get; set; }

        [JsonProperty("polyline")]
        public Polyline Polyline { get; set; }

        [JsonProperty("start_location")]
        public StartLocation StartLocation { get; set; }

        [JsonProperty("travel_mode")]
        public string TravelMode { get; set; }

        [JsonProperty("maneuver")]
        public string Maneuver { get; set; }
    }

    public class Leg
    {

        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("end_address")]
        public string EndAddress { get; set; }

        [JsonProperty("end_location")]
        public EndLocation EndLocation { get; set; }

        [JsonProperty("start_address")]
        public string StartAddress { get; set; }

        [JsonProperty("start_location")]
        public StartLocation StartLocation { get; set; }

        [JsonProperty("steps")]
        public IList<Step> Steps { get; set; }

        [JsonProperty("traffic_speed_entry")]
        public IList<object> TrafficSpeedEntry { get; set; }

        [JsonProperty("via_waypoint")]
        public IList<object> ViaWaypoint { get; set; }
    }

    public class OverviewPolyline
    {

        [JsonProperty("points")]
        public string Points { get; set; }
    }

    public class Route
    {

        [JsonProperty("bounds")]
        public Bounds Bounds { get; set; }

        [JsonProperty("copyrights")]
        public string Copyrights { get; set; }

        [JsonProperty("legs")]
        public IList<Leg> Legs { get; set; }

        [JsonProperty("overview_polyline")]
        public OverviewPolyline OverviewPolyline { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("warnings")]
        public IList<object> Warnings { get; set; }

        [JsonProperty("waypoint_order")]
        public IList<object> WaypointOrder { get; set; }
    }

    public class Direction
    {

        [JsonProperty("geocoded_waypoints")]
        public IList<GeocodedWaypoint> GeocodedWaypoints { get; set; }

        [JsonProperty("routes")]
        public IList<Route> Routes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MessageResponse
    {

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("routes")]
        public IList<object> Routes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    #endregion

    public class DirectionsServiceProvider
    {

        public DirectionsServiceProvider() { }

        public Direction GetDirection(Dictionary<string, string> parameters)
        {
            var uriBuilder = new UriBuilder("https://maps.googleapis.com/maps/api/directions/json")
            {
                Query = string.Join("&", parameters.Select(x => x.Key + "=" + x.Value))
            };

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string response;

                if (parameters.TryGetValue("key", out string key) && string.IsNullOrWhiteSpace(key))
                    response = "{ \"geocoded_waypoints\" : [ { \"geocoder_status\" : \"OK\", \"place_id\" : \"ChIJe5WIpnOc4jARoEQ-IqXo9HA\", \"types\" : [ \"establishment\", \"point_of_interest\" ] }, { \"geocoder_status\" : \"OK\", \"place_id\" : \"ChIJ4VX0ws-e4jARBGaQ2IACrcQ\", \"types\" : [ \"establishment\", \"point_of_interest\", \"shopping_mall\" ] } ], \"routes\" : [ { \"bounds\" : { \"northeast\" : { \"lat\" : 13.8059442, \"lng\" : 100.5507603 }, \"southwest\" : { \"lat\" : 13.7427957, \"lng\" : 100.5325228 } }, \"copyrights\" : \"Map data ©2020 Google\", \"legs\" : [ { \"distance\" : { \"text\" : \"11.4 km\", \"value\" : 11441 }, \"duration\" : { \"text\" : \"21 mins\", \"value\" : 1261 }, \"end_address\" : \"999/9 Rama I Rd, Khwaeng Pathum Wan, Khet Pathum Wan, Krung Thep Maha Nakhon 10330, Thailand\", \"end_location\" : { \"lat\" : 13.7464658, \"lng\" : 100.5405251 }, \"start_address\" : \"1 Siam Cement Alley, Khwaeng Bang Sue, Khet Bang Sue, Krung Thep Maha Nakhon 10800, Thailand\", \"start_location\" : { \"lat\" : 13.8059442, \"lng\" : 100.5373727 }, \"steps\" : [ { \"distance\" : { \"text\" : \"0.2 km\", \"value\" : 218 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 84 }, \"end_location\" : { \"lat\" : 13.8048426, \"lng\" : 100.537431 }, \"html_instructions\" : \"Head \\u003cb\\u003esouthwest\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eRestricted usage road\\u003c/div\\u003e\", \"polyline\" : { \"points\" : \"cngsAqesdRf@PCFENELCHAD?@?@?@vAd@JB@@D?D?HA@ADABADGDGHML]J[Pe@\" }, \"start_location\" : { \"lat\" : 13.8059442, \"lng\" : 100.5373727 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"61 m\", \"value\" : 61 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 43 }, \"end_location\" : { \"lat\" : 13.8044003, \"lng\" : 100.5372173 }, \"html_instructions\" : \"Turn \\u003cb\\u003eright\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eRestricted usage road\\u003c/div\\u003e\", \"maneuver\" : \"turn-right\", \"polyline\" : { \"points\" : \"gggsA}esdRBI`A^JHBD@B\" }, \"start_location\" : { \"lat\" : 13.8048426, \"lng\" : 100.537431 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.1 km\", \"value\" : 142 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 45 }, \"end_location\" : { \"lat\" : 13.8044242, \"lng\" : 100.5361833 }, \"html_instructions\" : \"Turn \\u003cb\\u003eright\\u003c/b\\u003e toward \\u003cb\\u003eซอย ปูนซีเมนต์ไทย ถนนหน้าบ้าน\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003ePartial restricted usage road\\u003c/div\\u003e\", \"maneuver\" : \"turn-right\", \"polyline\" : { \"points\" : \"odgsAsdsdR?BAJQb@e@t@K^AD?H@HDDFBLHd@V\" }, \"start_location\" : { \"lat\" : 13.8044003, \"lng\" : 100.5372173 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"5 m\", \"value\" : 5 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 1 }, \"end_location\" : { \"lat\" : 13.8044102, \"lng\" : 100.536224 }, \"html_instructions\" : \"Turn \\u003cb\\u003eleft\\u003c/b\\u003e onto \\u003cb\\u003eซอย ปูนซีเมนต์ไทย ถนนหน้าบ้าน\\u003c/b\\u003e\", \"maneuver\" : \"turn-left\", \"polyline\" : { \"points\" : \"sdgsAc~rdR@G\" }, \"start_location\" : { \"lat\" : 13.8044242, \"lng\" : 100.5361833 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.7 km\", \"value\" : 661 }, \"duration\" : { \"text\" : \"2 mins\", \"value\" : 104 }, \"end_location\" : { \"lat\" : 13.7994284, \"lng\" : 100.5331728 }, \"html_instructions\" : \"Make a \\u003cb\\u003eU-turn\\u003c/b\\u003e\", \"maneuver\" : \"uturn-right\", \"polyline\" : { \"points\" : \"qdgsAk~rdR@GJH?@JDADAH?H@@?@?@BD@BFFNJf@Tn@Z^P`@PPJDB`@b@t@\\\\t@ZnAh@B@DBNFNF^PhAh@xAn@RJPHB@B@ZNZNd@RRJTJb@RRHJDFDb@RHD\" }, \"start_location\" : { \"lat\" : 13.8044102, \"lng\" : 100.536224 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.6 km\", \"value\" : 585 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 82 }, \"end_location\" : { \"lat\" : 13.7971267, \"lng\" : 100.5380373 }, \"html_instructions\" : \"Turn \\u003cb\\u003eleft\\u003c/b\\u003e at \\u003cb\\u003eแยก วัดสะพานสูง\\u003c/b\\u003e onto \\u003cb\\u003eถนน พระราม6\\u003c/b\\u003e\", \"maneuver\" : \"turn-left\", \"polyline\" : { \"points\" : \"mefsAikrdRZy@b@cAd@kAn@_BtAiDHUPg@Ne@l@eBN_@La@FOL[BKDQ@EDKHW@CXeADMFKJU\" }, \"start_location\" : { \"lat\" : 13.7994284, \"lng\" : 100.5331728 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"62 m\", \"value\" : 62 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 8 }, \"end_location\" : { \"lat\" : 13.7972935, \"lng\" : 100.5385643 }, \"html_instructions\" : \"Slight \\u003cb\\u003eleft\\u003c/b\\u003e onto \\u003cb\\u003eถนน กำแพงเพชร 5\\u003c/b\\u003e\", \"maneuver\" : \"turn-slight-left\", \"polyline\" : { \"points\" : \"awesAwisdR?W@OAKEKGKQ[\" }, \"start_location\" : { \"lat\" : 13.7971267, \"lng\" : 100.5380373 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.3 km\", \"value\" : 311 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 54 }, \"end_location\" : { \"lat\" : 13.7979108, \"lng\" : 100.5411888 }, \"html_instructions\" : \"Continue onto \\u003cb\\u003eถนน กำแพงเพชร\\u003c/b\\u003e\", \"polyline\" : { \"points\" : \"axesA_msdRUSSQKMWYQ]O[Qc@G_@Ey@C[?A@Y?UHiAJoB\" }, \"start_location\" : { \"lat\" : 13.7972935, \"lng\" : 100.5385643 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.5 km\", \"value\" : 457 }, \"duration\" : { \"text\" : \"2 mins\", \"value\" : 95 }, \"end_location\" : { \"lat\" : 13.7944843, \"lng\" : 100.5393316 }, \"html_instructions\" : \"Turn \\u003cb\\u003eright\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"turn-right\", \"polyline\" : { \"points\" : \"}{esAm}sdR?C@S\\\\FAP`@RD@@@D@HBPF@@@?RHb@Pr@Vv@TXHz@^f@X@@n@d@HDZRLHHFDBNHNLFBFDLFhBx@\" }, \"start_location\" : { \"lat\" : 13.7979108, \"lng\" : 100.5411888 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"2.3 km\", \"value\" : 2329 }, \"duration\" : { \"text\" : \"3 mins\", \"value\" : 182 }, \"end_location\" : { \"lat\" : 13.7747565, \"lng\" : 100.5327201 }, \"html_instructions\" : \"Merge onto \\u003cb\\u003eทางพิเศษศรีรัช\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"merge\", \"polyline\" : { \"points\" : \"ofesAyqsdRRFRDpCz@TF^L|Ad@v@Xf@NlA\\\\PDDBJBlBj@VH^Lf@NZH`@LlBj@VHtBn@PFLDNDTFl@P^L^LbAX`@LzH`CNDNDJB?@@?JBTHVHhCv@ZJnC~@~@X|@Zt@Pr@Pj@Lj@NxBp@l@T\\\\JZHfD`AXFhAXRF@?p@R`@Lx@VnA\\\\l@RpAXF@TFFBTDz@Hx@Db@@N?tAAp@Cp@ERAPAd@Ad@A`BCZ@X@\" }, \"start_location\" : { \"lat\" : 13.7944843, \"lng\" : 100.5393316 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"2.5 km\", \"value\" : 2510 }, \"duration\" : { \"text\" : \"2 mins\", \"value\" : 149 }, \"end_location\" : { \"lat\" : 13.7591589, \"lng\" : 100.5477078 }, \"html_instructions\" : \"Keep \\u003cb\\u003eleft\\u003c/b\\u003e at the fork to stay on \\u003cb\\u003eทางพิเศษศรีรัช\\u003c/b\\u003e, follow signs for \\u003cb\\u003eDin Daeng\\u003c/b\\u003e/\\u003cwbr/\\u003e\\u003cb\\u003eดินแดง\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"fork-left\", \"polyline\" : { \"points\" : \"gkasAohrdRBABAR@R?f@BNBPB@?F@TB\\\\D\\\\BPBP@F@N@V?B@L?~@@l@?^E^GPE@AXIh@S@AJE@ALGBAd@[TSDC@CFEHIBCDGd@o@Va@@AV]JYLY|@mBRe@NY@AFKBIZs@@EHSJWJWFMd@gATi@BILU?AHMLSLS@A?A@C^m@Va@FO@A?AHMDIb@s@l@w@NQ`@a@j@k@~@q@h@]bAq@XQJGBAVMHEDCDABAd@WHEDCFEhAu@|@s@^a@TW@Aj@u@t@_Ah@_Al@sA@C@E@E?AFQHYPm@DMFM?CFMHS`@oAPg@FOBEDIDKHQ@AVa@Xe@HMHKDGLOHMDEp@u@VWJMJK^[HG@AJInAaAlAcAp@g@ZYXWXUHGDC?ATQLKFGHId@_@TSRQh@e@RQd@a@TSVUVS\" }, \"start_location\" : { \"lat\" : 13.7747565, \"lng\" : 100.5327201 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.9 km\", \"value\" : 918 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 54 }, \"end_location\" : { \"lat\" : 13.7566775, \"lng\" : 100.5469078 }, \"html_instructions\" : \"Take the exit toward \\u003cb\\u003eDin Daeng\\u003c/b\\u003e/\\u003cwbr/\\u003e\\u003cb\\u003eBang Na Dao Khanong\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"ramp-left\", \"polyline\" : { \"points\" : \"wi~rAefudRHQZ_@Z[Z[Ze@@ADGFIFIDIVa@HQPa@@AL]@AJ]?A@AR_A@C@AJk@HY@CDM@CBGFQJURUROHCHENENC^ARAD?N?F@RBB?HBHBHDFF@?HFFD?@B@HJHN@@DJ@@DJDL@HBN@H?NARCVAHDZCJGf@GXAHCT?@CLc@nC}@xF\" }, \"start_location\" : { \"lat\" : 13.7591589, \"lng\" : 100.5477078 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"1.0 km\", \"value\" : 1009 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 59 }, \"end_location\" : { \"lat\" : 13.7499928, \"lng\" : 100.5496945 }, \"html_instructions\" : \"Keep \\u003cb\\u003eleft\\u003c/b\\u003e at the fork, follow signs for \\u003cb\\u003eSukhumvit\\u003c/b\\u003e/\\u003cwbr/\\u003e\\u003cb\\u003eBang Na\\u003c/b\\u003e/\\u003cwbr/\\u003e\\u003cb\\u003eDao Khanong\\u003c/b\\u003e and merge onto \\u003cb\\u003eทางพิเศษเฉลิมมหานคร\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"fork-left\", \"polyline\" : { \"points\" : \"gz}rAeaudRA`@A`@@n@@H@BBJ@DFLHRPVPNNHLFPFJBRBH?J@F?LAJ?FAVCNCLCVCNAR?l@[dAi@hAy@PINKPQ@CPONUTa@LQd@q@NSBGFIl@cAR[j@w@@CVYHK`@a@XWj@a@\\\\Sb@SHC@?TI?AB?DC|@Y`@OVKTKJAz@Q^E^C\" }, \"start_location\" : { \"lat\" : 13.7566775, \"lng\" : 100.5469078 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.3 km\", \"value\" : 338 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 19 }, \"end_location\" : { \"lat\" : 13.7470115, \"lng\" : 100.5501764 }, \"html_instructions\" : \"Take exit \\u003cb\\u003e1-01\\u003c/b\\u003e toward \\u003cb\\u003eSukhumvit\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"ramp-left\", \"polyline\" : { \"points\" : \"mp|rAqrudRRONEBALCb@E`@Cb@CTCTAVC@?XEh@GB?DAXAZCJ?|AIb@CzAI\" }, \"start_location\" : { \"lat\" : 13.7499928, \"lng\" : 100.5496945 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.5 km\", \"value\" : 473 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 40 }, \"end_location\" : { \"lat\" : 13.7427957, \"lng\" : 100.5506967 }, \"html_instructions\" : \"Keep \\u003cb\\u003eleft\\u003c/b\\u003e to stay on \\u003cb\\u003eExit 1-01\\u003c/b\\u003e, follow signs for \\u003cb\\u003eAsoke Sukhumvit\\u003c/b\\u003e/\\u003cwbr/\\u003e\\u003cb\\u003eNorth Ploenchit\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eToll road\\u003c/div\\u003e\", \"maneuver\" : \"keep-left\", \"polyline\" : { \"points\" : \"y}{rAsuudRPEHA^Ab@E`@ALAp@E~AGfBITAZCF?`@CBA~@If@GH?~AKfAGdAI\" }, \"start_location\" : { \"lat\" : 13.7470115, \"lng\" : 100.5501764 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"1.1 km\", \"value\" : 1138 }, \"duration\" : { \"text\" : \"3 mins\", \"value\" : 200 }, \"end_location\" : { \"lat\" : 13.744609, \"lng\" : 100.5403296 }, \"html_instructions\" : \"Turn \\u003cb\\u003eright\\u003c/b\\u003e onto \\u003cb\\u003eถนน เพลินจิต\\u003c/b\\u003e/\\u003cwbr/\\u003e\\u003cb\\u003eถ. สุขุมวิท\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eContinue to follow ถนน เพลินจิต\\u003c/div\\u003e\", \"maneuver\" : \"turn-right\", \"polyline\" : { \"points\" : \"oc{rA{xudR?FADIl@CP?@AFAF?BCT?FEXAJM`ACTCVGn@Gn@Gp@CRANKx@Eb@Iv@A??@?@CPMfAMxAIv@ALYbDAHAJKbAEb@CTIv@CPIx@CXE^KjAKjACVCVGh@AFEb@Ej@ARIz@?FGd@?HA@Iv@AXAJEXGp@AJKv@\" }, \"start_location\" : { \"lat\" : 13.7427957, \"lng\" : 100.5506967 }, \"travel_mode\" : \"DRIVING\" }, { \"distance\" : { \"text\" : \"0.2 km\", \"value\" : 224 }, \"duration\" : { \"text\" : \"1 min\", \"value\" : 42 }, \"end_location\" : { \"lat\" : 13.7464658, \"lng\" : 100.5405251 }, \"html_instructions\" : \"Turn \\u003cb\\u003eright\\u003c/b\\u003e at \\u003cb\\u003eแยก ราชประสงค์\\u003c/b\\u003e onto \\u003cb\\u003eถนน ราชดำริ\\u003c/b\\u003e\\u003cdiv style=\\\"font-size:0.9em\\\"\\u003eDestination will be on the left\\u003c/div\\u003e\", \"maneuver\" : \"turn-right\", \"polyline\" : { \"points\" : \"yn{rAaxsdRAL?JMGKIe@Ge@EeCMWCYCy@GYC\" }, \"start_location\" : { \"lat\" : 13.744609, \"lng\" : 100.5403296 }, \"travel_mode\" : \"DRIVING\" } ], \"traffic_speed_entry\" : [], \"via_waypoint\" : [] } ], \"overview_polyline\" : { \"points\" : \"cngsAqesdRf@PIVK^?@vAf@XDTGJOVk@\\\\aABI`A^NN@FSn@e@t@K^ANFNTLd@V@G@GJHJFCN@JDLVRvAp@xAr@`@b@t@\\\\dCdAh@TlGtCvDdBl@X~@}BtDkJfCmHx@sCRa@@g@GWYg@i@e@c@g@a@y@Qc@G_@IuA@[TsE@S\\\\FAP`@RFBNDh@RvAh@pA^bBx@p@f@|@j@bAl@|B`AdD`AjEtA~H~B`KzCdSdGlIlC|Bt@hBb@vA\\\\fDfAzF~ApCt@xEvAvBf@pAN|AFdBAbBIpBGzCAV?z@Bj@HpALj@Fx@BlB@~@MvAe@NIPIz@o@XWfA}AX_@Xs@bBoDrAaDlAqCd@w@dAkBNWb@s@l@w@p@s@j@k@~@q@lBoAd@Yj@Yx@a@LIhAu@|@s@t@y@l@w@t@_Ah@_An@wAJ_@h@cBr@uBb@gAh@aAr@gA\\\\c@`BgBbHwFnBaBrE}Dn@i@d@q@v@w@\\\\g@Ze@`@s@Rc@Z}@VgAXkAJYRg@f@e@r@Sx@Cn@Dd@TRNX^Rf@DX@XEj@Bd@UvAk@tD}@xFA`@?pAH^P`@b@f@n@Xt@Hh@ClAOb@ArBeAzAcA`@]RSd@w@fA_BhAiBnAaBz@y@hAu@n@W^OlCaAfAS~@IRONEBAp@IdAGdAIlAO~CO~BMZGbAGn@CnGYhAIfBQhBKlCQALOhA_@fD[hDW`Cu@fHsBrTSlBQbCe@zEOpA?JMGKIe@GkDSq@GsAK\" }, \"summary\" : \"ทางพิเศษศรีรัช\", \"warnings\" : [], \"waypoint_order\" : [] } ], \"status\" : \"OK\" }";
                else
                    response = httpClient.GetStringAsync(uriBuilder.Uri).Result;

                var result = JsonConvert.DeserializeObject<Direction>(response);

                if (result.Routes.Any())
                    return result;

                throw new Exception(JsonConvert.DeserializeObject<MessageResponse>(response).ErrorMessage);
            }
        }
    }
}
