﻿namespace BMIValidation
{
    public class BMIForAge
    {
        public static Double[] DATA = new Double[]
                                          {1.0,24.0,-2.01118107,16.57502768,0.080592465,
                                           1.0,24.5,-1.982373595,16.54777487,0.080127429,
                                           1.0,25.5,-1.924100169,16.49442763,0.079233994,
                                           1.0,26.5,-1.86549793,16.44259552,0.078389356,
                                           1.0,27.5,-1.807261899,16.3922434,0.077593501,
                                           1.0,28.5,-1.750118905,16.34333654,0.076846462,
                                           1.0,29.5,-1.69481584,16.29584097,0.076148308,
                                           1.0,30.5,-1.642106779,16.24972371,0.075499126,
                                           1.0,31.5,-1.592744414,16.20495268,0.074898994,
                                           1.0,32.5,-1.547442391,16.16149871,0.074347997,
                                           1.0,33.5,-1.506902601,16.11933258,0.073846139,
                                           1.0,34.5,-1.471770047,16.07842758,0.07339337,
                                           1.0,35.5,-1.442628957,16.03875896,0.072989551,
                                           1.0,36.5,-1.419991255,16.00030401,0.072634432,
                                           1.0,37.5,-1.404277619,15.96304277,0.072327649,
                                           1.0,38.5,-1.39586317,15.92695418,0.07206864,
                                           1.0,39.5,-1.394935252,15.89202582,0.071856805,
                                           1.0,40.5,-1.401671596,15.85824093,0.071691278,
                                           1.0,41.5,-1.416100312,15.82558822,0.071571093,
                                           1.0,42.5,-1.438164899,15.79405728,0.071495113,
                                           1.0,43.5,-1.467669032,15.76364255,0.071462106,
                                           1.0,44.5,-1.504376347,15.73433668,0.071470646,
                                           1.0,45.5,-1.547942838,15.70613566,0.071519218,
                                           1.0,46.5,-1.597896397,15.67904062,0.071606277,
                                           1.0,47.5,-1.653732283,15.65305192,0.071730167,
                                           1.0,48.5,-1.714869347,15.62817269,0.071889214,
                                           1.0,49.5,-1.780673181,15.604408,0.072081737,
                                           1.0,50.5,-1.850468473,15.58176458,0.072306081,
                                           1.0,51.5,-1.923551865,15.56025067,0.072560637,
                                           1.0,52.5,-1.999220429,15.5398746,0.07284384,
                                           1.0,53.5,-2.076707178,15.52064993,0.073154324,
                                           1.0,54.5,-2.155348017,15.50258427,0.073490667,
                                           1.0,55.5,-2.234438552,15.48568973,0.073851672,
                                           1.0,56.5,-2.313321723,15.46997718,0.074236235,
                                           1.0,57.5,-2.391381273,15.45545692,0.074643374,
                                           1.0,58.5,-2.468032491,15.44213961,0.075072264,
                                           1.0,59.5,-2.542781541,15.43003207,0.075522104,
                                           1.0,60.5,-2.61516595,15.41914163,0.07599225,
                                           1.0,61.5,-2.684789516,15.40947356,0.076482128,
                                           1.0,62.5,-2.751316949,15.40103139,0.076991232,
                                           1.0,63.5,-2.81445945,15.39381785,0.077519149,
                                           1.0,64.5,-2.87402476,15.38783094,0.07806539,
                                           1.0,65.5,-2.92984048,15.38306945,0.078629592,
                                           1.0,66.5,-2.981796828,15.37952958,0.079211369,
                                           1.0,67.5,-3.029831343,15.37720582,0.079810334,
                                           1.0,68.5,-3.073924224,15.37609107,0.080426086,
                                           1.0,69.5,-3.114093476,15.37617677,0.081058206,
                                           1.0,70.5,-3.15039004,15.37745304,0.081706249,
                                           1.0,71.5,-3.182893018,15.37990886,0.082369741,
                                           1.0,72.5,-3.21170511,15.38353217,0.083048178,
                                           1.0,73.5,-3.23694834,15.38831005,0.083741021,
                                           1.0,74.5,-3.25876011,15.39422883,0.0844477,
                                           1.0,75.5,-3.277281546,15.40127496,0.085167651,
                                           1.0,76.5,-3.292683774,15.40943252,0.085900184,
                                           1.0,77.5,-3.305124073,15.41868691,0.086644667,
                                           1.0,78.5,-3.314768951,15.42902273,0.087400421,
                                           1.0,79.5,-3.321785992,15.44042439,0.088166744,
                                           1.0,80.5,-3.326345795,15.45287581,0.088942897,
                                           1.0,81.5,-3.328602731,15.46636218,0.089728202,
                                           1.0,82.5,-3.328725277,15.48086704,0.090521875,
                                           1.0,83.5,-3.32687018,15.49637465,0.091323162,
                                           1.0,84.5,-3.323188896,15.51286936,0.092131305,
                                           1.0,85.5,-3.317827016,15.53033563,0.092945544,
                                           1.0,86.5,-3.310923871,15.54875807,0.093765118,
                                           1.0,87.5,-3.302612272,15.56812143,0.09458927,
                                           1.0,88.5,-3.293018361,15.58841065,0.095417247,
                                           1.0,89.5,-3.282260813,15.60961101,0.096248301,
                                           1.0,90.5,-3.270454609,15.63170735,0.097081694,
                                           1.0,91.5,-3.257703616,15.65468563,0.097916698,
                                           1.0,92.5,-3.244108214,15.67853139,0.098752593,
                                           1.0,93.5,-3.229761713,15.70323052,0.099588675,
                                           1.0,94.5,-3.214751287,15.72876911,0.100424251,
                                           1.0,95.5,-3.199158184,15.75513347,0.101258643,
                                           1.0,96.5,-3.18305795,15.78231007,0.102091189,
                                           1.0,97.5,-3.166520664,15.8102856,0.102921245,
                                           1.0,98.5,-3.1496103,15.83904708,0.103748189,
                                           1.0,99.5,-3.132389637,15.86858123,0.104571386,
                                           1.0,100.5,-3.114911153,15.89887562,0.105390269,
                                           1.0,101.5,-3.097226399,15.92991765,0.106204258,
                                           1.0,102.5,-3.079383079,15.96169481,0.107012788,
                                           1.0,103.5,-3.061423765,15.99419489,0.107815327,
                                           1.0,104.5,-3.043386071,16.02740607,0.108611374,
                                           1.0,105.5,-3.025310003,16.0613159,0.109400388,
                                           1.0,106.5,-3.007225737,16.09591292,0.110181915,
                                           1.0,107.5,-2.989164598,16.13118532,0.110955478,
                                           1.0,108.5,-2.971148225,16.16712234,0.111720691,
                                           1.0,109.5,-2.953208047,16.20371168,0.112477059,
                                           1.0,110.5,-2.935363951,16.24094239,0.1132242,
                                           1.0,111.5,-2.917635157,16.27880346,0.113961734,
                                           1.0,112.5,-2.900039803,16.31728385,0.114689291,
                                           1.0,113.5,-2.882593796,16.35637267,0.115406523,
                                           1.0,114.5,-2.865311266,16.39605916,0.116113097,
                                           1.0,115.5,-2.848204697,16.43633265,0.116808702,
                                           1.0,116.5,-2.831285052,16.47718256,0.117493042,
                                           1.0,117.5,-2.81456189,16.51859843,0.11816584,
                                           1.0,118.5,-2.79804347,16.56056987,0.118826835,
                                           1.0,119.5,-2.781736856,16.60308661,0.119475785,
                                           1.0,120.5,-2.765648008,16.64613844,0.120112464,
                                           1.0,121.5,-2.749782197,16.68971518,0.120736656,
                                           1.0,122.5,-2.734142443,16.73380695,0.121348181,
                                           1.0,123.5,-2.718732873,16.77840363,0.121946849,
                                           1.0,124.5,-2.703555506,16.82349538,0.122532501,
                                           1.0,125.5,-2.688611957,16.86907238,0.123104991,
                                           1.0,126.5,-2.673903164,16.91512487,0.123664186,
                                           1.0,127.5,-2.659429443,16.96164317,0.124209969,
                                           1.0,128.5,-2.645190534,17.00861766,0.124742239,
                                           1.0,129.5,-2.631185649,17.05603879,0.125260905,
                                           1.0,130.5,-2.617413511,17.10389705,0.125765895,
                                           1.0,131.5,-2.603872392,17.15218302,0.126257147,
                                           1.0,132.5,-2.590560148,17.20088732,0.126734613,
                                           1.0,133.5,-2.577474253,17.25000062,0.12719826,
                                           1.0,134.5,-2.564611831,17.29951367,0.127648067,
                                           1.0,135.5,-2.551969684,17.34941726,0.128084023,
                                           1.0,136.5,-2.539539972,17.39970308,0.128506192,
                                           1.0,137.5,-2.527325681,17.45036072,0.128914497,
                                           1.0,138.5,-2.515320235,17.50138161,0.129309001,
                                           1.0,139.5,-2.503519447,17.55275674,0.129689741,
                                           1.0,140.5,-2.491918934,17.60447714,0.130056765,
                                           1.0,141.5,-2.480514136,17.6565339,0.130410133,
                                           1.0,142.5,-2.469300331,17.70891811,0.130749913,
                                           1.0,143.5,-2.458272656,17.76162094,0.131076187,
                                           1.0,144.5,-2.447426113,17.81463359,0.131389042,
                                           1.0,145.5,-2.436755595,17.86794729,0.131688579,
                                           1.0,146.5,-2.426255887,17.92155332,0.131974905,
                                           1.0,147.5,-2.415921689,17.97544299,0.132248138,
                                           1.0,148.5,-2.405747619,18.02960765,0.132508403,
                                           1.0,149.5,-2.395728233,18.08403868,0.132755834,
                                           1.0,150.5,-2.385858029,18.1387275,0.132990575,
                                           1.0,151.5,-2.376131459,18.19366555,0.133212776,
                                           1.0,152.5,-2.366542942,18.24884431,0.133422595,
                                           1.0,153.5,-2.357086871,18.3042553,0.133620197,
                                           1.0,154.5,-2.347757625,18.35989003,0.133805756,
                                           1.0,155.5,-2.338549576,18.41574009,0.133979452,
                                           1.0,156.5,-2.3294571,18.47179706,0.13414147,
                                           1.0,157.5,-2.320474586,18.52805255,0.134292005,
                                           1.0,158.5,-2.311596446,18.5844982,0.134431256,
                                           1.0,159.5,-2.302817124,18.64112567,0.134559427,
                                           1.0,160.5,-2.294131107,18.69792663,0.134676731,
                                           1.0,161.5,-2.285532933,18.75489278,0.134783385,
                                           1.0,162.5,-2.277017201,18.81201584,0.134879611,
                                           1.0,163.5,-2.268578584,18.86928753,0.134965637,
                                           1.0,164.5,-2.260211837,18.92669959,0.135041695,
                                           1.0,165.5,-2.251911809,18.98424378,0.135108024,
                                           1.0,166.5,-2.243673453,19.04191185,0.135164867,
                                           1.0,167.5,-2.235491842,19.09969557,0.135212469,
                                           1.0,168.5,-2.227362173,19.15758672,0.135251083,
                                           1.0,169.5,-2.21927979,19.21557707,0.135280963,
                                           1.0,170.5,-2.211240187,19.27365839,0.135302371,
                                           1.0,171.5,-2.203239029,19.33182247,0.135315568,
                                           1.0,172.5,-2.195272161,19.39006106,0.135320824,
                                           1.0,173.5,-2.187335625,19.44836594,0.135318407,
                                           1.0,174.5,-2.179425674,19.50672885,0.135308594,
                                           1.0,175.5,-2.171538789,19.56514153,0.135291662,
                                           1.0,176.5,-2.163671689,19.62359571,0.135267891,
                                           1.0,177.5,-2.155821357,19.6820831,0.135237567,
                                           1.0,178.5,-2.147985046,19.74059538,0.135200976,
                                           1.0,179.5,-2.140160305,19.7991242,0.135158409,
                                           1.0,180.5,-2.132344989,19.85766121,0.135110159,
                                           1.0,181.5,-2.124537282,19.916198,0.135056522,
                                           1.0,182.5,-2.116735712,19.97472615,0.134997797,
                                           1.0,183.5,-2.108939167,20.03323719,0.134934285,
                                           1.0,184.5,-2.10114692,20.09172262,0.134866291,
                                           1.0,185.5,-2.093358637,20.15017387,0.134794121,
                                           1.0,186.5,-2.085574403,20.20858236,0.134718085,
                                           1.0,187.5,-2.077794735,20.26693944,0.134638494,
                                           1.0,188.5,-2.070020599,20.32523642,0.134555663,
                                           1.0,189.5,-2.062253431,20.38346455,0.13446991,
                                           1.0,190.5,-2.054495145,20.44161501,0.134381553,
                                           1.0,191.5,-2.046748156,20.49967894,0.134290916,
                                           1.0,192.5,-2.039015385,20.5576474,0.134198323,
                                           1.0,193.5,-2.031300282,20.6155114,0.134104101,
                                           1.0,194.5,-2.023606828,20.67326189,0.134008581,
                                           1.0,195.5,-2.015942013,20.73088905,0.133912066,
                                           1.0,196.5,-2.008305745,20.7883851,0.133814954,
                                           1.0,197.5,-2.000706389,20.84574003,0.133717552,
                                           1.0,198.5,-1.993150137,20.90294449,0.1336202,
                                           1.0,199.5,-1.985643741,20.95998909,0.133523244,
                                           1.0,200.5,-1.97819451,21.01686433,0.133427032,
                                           1.0,201.5,-1.970810308,21.07356067,0.133331914,
                                           1.0,202.5,-1.96349954,21.1300685,0.133238245,
                                           1.0,203.5,-1.956271141,21.18637813,0.133146383,
                                           1.0,204.5,-1.949134561,21.24247982,0.13305669,
                                           1.0,205.5,-1.942099744,21.29836376,0.132969531,
                                           1.0,206.5,-1.935177101,21.35402009,0.132885274,
                                           1.0,207.5,-1.92837748,21.40943891,0.132804292,
                                           1.0,208.5,-1.921712136,21.46461026,0.132726962,
                                           1.0,209.5,-1.915192685,21.51952414,0.132653664,
                                           1.0,210.5,-1.908831065,21.57417053,0.132584784,
                                           1.0,211.5,-1.902639482,21.62853937,0.132520711,
                                           1.0,212.5,-1.896630358,21.68262062,0.132461838,
                                           1.0,213.5,-1.890816268,21.73640419,0.132408563,
                                           1.0,214.5,-1.885209876,21.78988003,0.132361289,
                                           1.0,215.5,-1.879823505,21.84303819,0.132320427,
                                           1.0,216.5,-1.874670324,21.8958685,0.132286382,
                                           1.0,217.5,-1.869760299,21.94836168,0.1322596,
                                           1.0,218.5,-1.865113245,22.00050569,0.132240418,
                                           1.0,219.5,-1.860734944,22.05229242,0.13222933,
                                           1.0,220.5,-1.85663384,22.10371305,0.132226801,
                                           1.0,221.5,-1.852827186,22.15475603,0.132233201,
                                           1.0,222.5,-1.849323204,22.20541249,0.132248993,
                                           1.0,223.5,-1.846131607,22.255673,0.132274625,
                                           1.0,224.5,-1.843261294,22.30552831,0.132310549,
                                           1.0,225.5,-1.840720248,22.3549693,0.132357221,
                                           1.0,226.5,-1.83851544,22.40398706,0.132415103,
                                           1.0,227.5,-1.83665586,22.45257182,0.132484631,
                                           1.0,228.5,-1.835138046,22.50071778,0.132566359,
                                           1.0,229.5,-1.833972004,22.54841437,0.132660699,
                                           1.0,230.5,-1.833157751,22.59565422,0.132768153,
                                           1.0,231.5,-1.83269562,22.64242956,0.132889211,
                                           1.0,232.5,-1.832584342,22.68873292,0.133024368,
                                           1.0,233.5,-1.832820974,22.73455713,0.133174129,
                                           1.0,234.5,-1.833400825,22.7798953,0.133338999,
                                           1.0,235.5,-1.834317405,22.82474087,0.133519496,
                                           1.0,236.5,-1.83555752,22.86908912,0.133716192,
                                           1.0,237.5,-1.837119466,22.91293151,0.133929525,
                                           1.0,238.5,-1.838987063,22.95626373,0.134160073,
                                           1.0,239.5,-1.841146139,22.99908062,0.134408381,
                                           1.0,240.0,-1.84233016,23.02029424,0.134539365,
                                           1.0,240.5,-1.843580575,23.04137734,0.134675001,
                                           2.0,24.0,-0.98660853,16.42339664,0.085451785,
                                           2.0,24.5,-1.024496827,16.38804056,0.085025838,
                                           2.0,25.5,-1.102698353,16.3189719,0.084214052,
                                           2.0,26.5,-1.18396635,16.25207985,0.083455124,
                                           2.0,27.5,-1.268071036,16.18734669,0.082748284,
                                           2.0,28.5,-1.354751525,16.12475448,0.082092737,
                                           2.0,29.5,-1.443689692,16.06428762,0.081487717,
                                           2.0,30.5,-1.53454192,16.00593001,0.080932448,
                                           2.0,31.5,-1.626928093,15.94966631,0.080426175,
                                           2.0,32.5,-1.720434829,15.89548197,0.079968176,
                                           2.0,33.5,-1.814635262,15.84336179,0.079557735,
                                           2.0,34.5,-1.909076262,15.79329146,0.079194187,
                                           2.0,35.5,-2.003296102,15.7452564,0.078876895,
                                           2.0,36.5,-2.096828937,15.69924188,0.078605255,
                                           2.0,37.5,-2.189211877,15.65523282,0.078378696,
                                           2.0,38.5,-2.279991982,15.61321371,0.078196674,
                                           2.0,39.5,-2.368732949,15.57316843,0.078058667,
                                           2.0,40.5,-2.455021314,15.53508019,0.077964169,
                                           2.0,41.5,-2.538471972,15.49893145,0.077912684,
                                           2.0,42.5,-2.618732901,15.46470384,0.077903716,
                                           2.0,43.5,-2.695488973,15.43237817,0.077936763,
                                           2.0,44.5,-2.768464816,15.40193436,0.078011309,
                                           2.0,45.5,-2.837426693,15.37335154,0.078126817,
                                           2.0,46.5,-2.902178205,15.34660842,0.078282739,
                                           2.0,47.5,-2.962580386,15.32168181,0.078478449,
                                           2.0,48.5,-3.018521987,15.29854897,0.078713325,
                                           2.0,49.5,-3.069936555,15.27718618,0.078986694,
                                           2.0,50.5,-3.116795864,15.2575692,0.079297841,
                                           2.0,51.5,-3.159107331,15.23967338,0.079646006,
                                           2.0,52.5,-3.196911083,15.22347371,0.080030389,
                                           2.0,53.5,-3.230276759,15.20894491,0.080450145,
                                           2.0,54.5,-3.259300182,15.19606152,0.080904391,
                                           2.0,55.5,-3.284099963,15.18479799,0.081392203,
                                           2.0,56.5,-3.30481415,15.17512871,0.081912623,
                                           2.0,57.5,-3.321596954,15.16702811,0.082464661,
                                           2.0,58.5,-3.334615646,15.16047068,0.083047295,
                                           2.0,59.5,-3.344047622,15.15543107,0.083659478,
                                           2.0,60.5,-3.35007771,15.15188405,0.084300139,
                                           2.0,61.5,-3.352893805,15.14980479,0.0849682,
                                           2.0,62.5,-3.352691376,15.14916825,0.085662539,
                                           2.0,63.5,-3.34966438,15.14994984,0.086382035,
                                           2.0,64.5,-3.343998803,15.15212585,0.087125591,
                                           2.0,65.5,-3.335889574,15.15567186,0.087892047,
                                           2.0,66.5,-3.325522491,15.16056419,0.088680264,
                                           2.0,67.5,-3.31307846,15.16677947,0.089489106,
                                           2.0,68.5,-3.298732648,15.17429464,0.090317434,
                                           2.0,69.5,-3.282653831,15.18308694,0.091164117,
                                           2.0,70.5,-3.265003896,15.1931339,0.092028028,
                                           2.0,71.5,-3.245937506,15.20441335,0.092908048,
                                           2.0,72.5,-3.225606516,15.21690296,0.093803033,
                                           2.0,73.5,-3.204146115,15.2305815,0.094711916,
                                           2.0,74.5,-3.181690237,15.24542745,0.095633595,
                                           2.0,75.5,-3.158363475,15.26141966,0.096566992,
                                           2.0,76.5,-3.134282833,15.27853728,0.097511046,
                                           2.0,77.5,-3.109557879,15.29675967,0.09846471,
                                           2.0,78.5,-3.084290931,15.31606644,0.099426955,
                                           2.0,79.5,-3.058577292,15.33643745,0.100396769,
                                           2.0,80.5,-3.032505499,15.35785274,0.101373159,
                                           2.0,81.5,-3.0061576,15.38029261,0.10235515,
                                           2.0,82.5,-2.979609448,15.40373754,0.103341788,
                                           2.0,83.5,-2.952930993,15.42816819,0.104332139,
                                           2.0,84.5,-2.926186592,15.45356545,0.105325289,
                                           2.0,85.5,-2.899435307,15.47991037,0.106320346,
                                           2.0,86.5,-2.872731211,15.50718419,0.10731644,
                                           2.0,87.5,-2.846123683,15.53536829,0.108312721,
                                           2.0,88.5,-2.819657704,15.56444426,0.109308364,
                                           2.0,89.5,-2.793374145,15.5943938,0.110302563,
                                           2.0,90.5,-2.767310047,15.6251988,0.111294537,
                                           2.0,91.5,-2.741498897,15.65684126,0.112283526,
                                           2.0,92.5,-2.715970894,15.68930333,0.113268793,
                                           2.0,93.5,-2.690753197,15.7225673,0.114249622,
                                           2.0,94.5,-2.665870146,15.75661555,0.115225321,
                                           2.0,95.5,-2.641343436,15.79143062,0.116195218,
                                           2.0,96.5,-2.617192204,15.82699517,0.117158667,
                                           2.0,97.5,-2.593430614,15.86329241,0.118115073,
                                           2.0,98.5,-2.570076037,15.90030484,0.119063807,
                                           2.0,99.5,-2.547141473,15.93801545,0.12000429,
                                           2.0,100.5,-2.524635245,15.97640787,0.120935994,
                                           2.0,101.5,-2.502569666,16.01546483,0.121858355,
                                           2.0,102.5,-2.48095189,16.05516984,0.12277087,
                                           2.0,103.5,-2.459785573,16.09550688,0.123673085,
                                           2.0,104.5,-2.439080117,16.13645881,0.124564484,
                                           2.0,105.5,-2.418838304,16.17800955,0.125444639,
                                           2.0,106.5,-2.399063683,16.22014281,0.126313121,
                                           2.0,107.5,-2.379756861,16.26284277,0.127169545,
                                           2.0,108.5,-2.360920527,16.30609316,0.128013515,
                                           2.0,109.5,-2.342557728,16.34987759,0.128844639,
                                           2.0,110.5,-2.324663326,16.39418118,0.129662637,
                                           2.0,111.5,-2.307240716,16.43898741,0.130467138,
                                           2.0,112.5,-2.290287663,16.48428082,0.131257852,
                                           2.0,113.5,-2.273803847,16.53004554,0.132034479,
                                           2.0,114.5,-2.257782149,16.57626713,0.132796819,
                                           2.0,115.5,-2.242227723,16.62292864,0.133544525,
                                           2.0,116.5,-2.227132805,16.67001572,0.134277436,
                                           2.0,117.5,-2.212495585,16.71751288,0.134995324,
                                           2.0,118.5,-2.19831275,16.76540496,0.135697996,
                                           2.0,119.5,-2.184580762,16.81367689,0.136385276,
                                           2.0,120.5,-2.171295888,16.86231366,0.137057004,
                                           2.0,121.5,-2.158454232,16.91130036,0.137713039,
                                           2.0,122.5,-2.146051754,16.96062216,0.138353254,
                                           2.0,123.5,-2.134084303,17.0102643,0.138977537,
                                           2.0,124.5,-2.122547629,17.06021213,0.139585795,
                                           2.0,125.5,-2.111437411,17.11045106,0.140177947,
                                           2.0,126.5,-2.100749266,17.16096656,0.140753927,
                                           2.0,127.5,-2.090478774,17.21174424,0.141313686,
                                           2.0,128.5,-2.080621484,17.26276973,0.141857186,
                                           2.0,129.5,-2.071172932,17.31402878,0.142384404,
                                           2.0,130.5,-2.062128649,17.3655072,0.142895332,
                                           2.0,131.5,-2.053484173,17.4171909,0.143389972,
                                           2.0,132.5,-2.045235058,17.46906585,0.143868341,
                                           2.0,133.5,-2.03737688,17.52111811,0.144330469,
                                           2.0,134.5,-2.029906684,17.57333347,0.144776372,
                                           2.0,135.5,-2.022817914,17.62569869,0.145206138,
                                           2.0,136.5,-2.016107084,17.67819987,0.145619819,
                                           2.0,137.5,-2.009769905,17.7308234,0.146017491,
                                           2.0,138.5,-2.003802134,17.78355575,0.146399239,
                                           2.0,139.5,-1.998199572,17.83638347,0.146765161,
                                           2.0,140.5,-1.992958064,17.88929321,0.147115364,
                                           2.0,141.5,-1.988073505,17.94227168,0.147449967,
                                           2.0,142.5,-1.983541835,17.9953057,0.147769097,
                                           2.0,143.5,-1.979359041,18.04838216,0.148072891,
                                           2.0,144.5,-1.975521156,18.10148804,0.148361495,
                                           2.0,145.5,-1.972024258,18.15461039,0.148635067,
                                           2.0,146.5,-1.968864465,18.20773639,0.148893769,
                                           2.0,147.5,-1.966037938,18.26085325,0.149137776,
                                           2.0,148.5,-1.963540872,18.31394832,0.14936727,
                                           2.0,149.5,-1.961369499,18.36700902,0.149582439,
                                           2.0,150.5,-1.959520079,18.42002284,0.149783482,
                                           2.0,151.5,-1.9579889,18.47297739,0.149970604,
                                           2.0,152.5,-1.956772271,18.52586035,0.15014402,
                                           2.0,153.5,-1.95586652,18.57865951,0.15030395,
                                           2.0,154.5,-1.955267984,18.63136275,0.150450621,
                                           2.0,155.5,-1.954973011,18.68395801,0.15058427,
                                           2.0,156.5,-1.954977947,18.73643338,0.150705138,
                                           2.0,157.5,-1.955279136,18.788777,0.150813475,
                                           2.0,158.5,-1.955872909,18.84097713,0.150909535,
                                           2.0,159.5,-1.956755579,18.89302212,0.150993582,
                                           2.0,160.5,-1.957923436,18.94490041,0.151065883,
                                           2.0,161.5,-1.959372737,18.99660055,0.151126714,
                                           2.0,162.5,-1.9610997,19.04811118,0.151176355,
                                           2.0,163.5,-1.963100496,19.09942105,0.151215094,
                                           2.0,164.5,-1.96537124,19.15051899,0.151243223,
                                           2.0,165.5,-1.967907983,19.20139397,0.151261042,
                                           2.0,166.5,-1.970706706,19.25203503,0.151268855,
                                           2.0,167.5,-1.973763307,19.30243131,0.151266974,
                                           2.0,168.5,-1.977073595,19.35257209,0.151255713,
                                           2.0,169.5,-1.980633277,19.40244671,0.151235395,
                                           2.0,170.5,-1.984437954,19.45204465,0.151206347,
                                           2.0,171.5,-1.988483106,19.50135548,0.151168902,
                                           2.0,172.5,-1.992764085,19.55036888,0.151123398,
                                           2.0,173.5,-1.997276103,19.59907464,0.15107018,
                                           2.0,174.5,-2.002014224,19.64746266,0.151009595,
                                           2.0,175.5,-2.00697335,19.69552294,0.150942,
                                           2.0,176.5,-2.012148213,19.7432456,0.150867753,
                                           2.0,177.5,-2.017533363,19.79062086,0.150787221,
                                           2.0,178.5,-2.023123159,19.83763907,0.150700774,
                                           2.0,179.5,-2.028911755,19.88429066,0.150608788,
                                           2.0,180.5,-2.034893091,19.9305662,0.150511645,
                                           2.0,181.5,-2.041060881,19.97645636,0.150409731,
                                           2.0,182.5,-2.047408604,20.02195192,0.15030344,
                                           2.0,183.5,-2.05392949,20.06704377,0.150193169,
                                           2.0,184.5,-2.060616513,20.11172291,0.150079322,
                                           2.0,185.5,-2.067462375,20.15598047,0.149962308,
                                           2.0,186.5,-2.074459502,20.19980767,0.14984254,
                                           2.0,187.5,-2.081600029,20.24319586,0.149720441,
                                           2.0,188.5,-2.088875793,20.28613648,0.149596434,
                                           2.0,189.5,-2.096278323,20.32862109,0.149470953,
                                           2.0,190.5,-2.103798828,20.37064138,0.149344433,
                                           2.0,191.5,-2.111428194,20.41218911,0.149217319,
                                           2.0,192.5,-2.119156972,20.45325617,0.14909006,
                                           2.0,193.5,-2.126975375,20.49383457,0.14896311,
                                           2.0,194.5,-2.134873266,20.5339164,0.148836931,
                                           2.0,195.5,-2.142840157,20.57349387,0.148711989,
                                           2.0,196.5,-2.150865204,20.61255929,0.148588757,
                                           2.0,197.5,-2.158937201,20.65110506,0.148467715,
                                           2.0,198.5,-2.167044578,20.6891237,0.148349348,
                                           2.0,199.5,-2.175176987,20.72660728,0.14823412,
                                           2.0,200.5,-2.183317362,20.76355011,0.148122614,
                                           2.0,201.5,-2.191457792,20.79994337,0.148015249,
                                           2.0,202.5,-2.199583649,20.83578051,0.147912564,
                                           2.0,203.5,-2.207681525,20.87105449,0.147815078,
                                           2.0,204.5,-2.215737645,20.90575839,0.147723315,
                                           2.0,205.5,-2.223739902,20.93988477,0.147637768,
                                           2.0,206.5,-2.231667995,20.97342858,0.147559083,
                                           2.0,207.5,-2.239511942,21.00638171,0.147487716,
                                           2.0,208.5,-2.247257081,21.0387374,0.14742421,
                                           2.0,209.5,-2.254885145,21.07048996,0.147369174,
                                           2.0,210.5,-2.26238209,21.10163241,0.147323144,
                                           2.0,211.5,-2.269731517,21.13215845,0.147286698,
                                           2.0,212.5,-2.276917229,21.16206171,0.147260415,
                                           2.0,213.5,-2.283925442,21.1913351,0.147244828,
                                           2.0,214.5,-2.290731442,21.21997472,0.147240683,
                                           2.0,215.5,-2.29732427,21.24797262,0.147248467,
                                           2.0,216.5,-2.303687802,21.27532239,0.14726877,
                                           2.0,217.5,-2.309799971,21.30201933,0.147302299,
                                           2.0,218.5,-2.315651874,21.32805489,0.147349514,
                                           2.0,219.5,-2.32121731,21.35342563,0.147411215,
                                           2.0,220.5,-2.326481911,21.37812462,0.147487979,
                                           2.0,221.5,-2.331428139,21.40214589,0.147580453,
                                           2.0,222.5,-2.336038473,21.42548351,0.147689289,
                                           2.0,223.5,-2.34029545,21.44813156,0.14781515,
                                           2.0,224.5,-2.344181703,21.47008412,0.147958706,
                                           2.0,225.5,-2.34768,21.49133529,0.148120633,
                                           2.0,226.5,-2.350773286,21.51187918,0.148301619,
                                           2.0,227.5,-2.353444725,21.53170989,0.148502355,
                                           2.0,228.5,-2.355677743,21.55082155,0.148723546,
                                           2.0,229.5,-2.35745607,21.56920824,0.148965902,
                                           2.0,230.5,-2.358763788,21.58686406,0.149230142,
                                           2.0,231.5,-2.359585369,21.60378309,0.149516994,
                                           2.0,232.5,-2.359905726,21.61995939,0.149827195,
                                           2.0,233.5,-2.359710258,21.635387,0.150161492,
                                           2.0,234.5,-2.358980464,21.65006126,0.150520734,
                                           2.0,235.5,-2.357714508,21.6639727,0.150905439,
                                           2.0,236.5,-2.355892424,21.67711736,0.151316531,
                                           2.0,237.5,-2.353501353,21.68948935,0.151754808,
                                           2.0,238.5,-2.350528726,21.70108288,0.152221086,
                                           2.0,239.5,-2.346962247,21.71189225,0.152716206,
                                           2.0,240.0,-2.34495843,21.71699934,0.152974718,
                                           2.0,240.5,-2.342796948,21.72190973,0.153240872};

    };
}
