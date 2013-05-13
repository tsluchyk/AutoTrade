use AutoTrade;
go

--create table AutoModels
--(
--Id int identity primary key not null,
--IdBrand int default NULL
--constraint fk_IdBrand foreign key
--references Brands(Id)
--on delete cascade
--on update cascade,
--Name nvarchar(50) not null,
--);
--go

INSERT INTO [AutoTrade].[dbo].[AutoModels]
           ([IdBrand]
           ,[Name])
     VALUES
    (1
    ,'Legend')
    ,(1
	,'Integra')
	,(1
	,'NSX')
	,(1
	,'Vigor')
	,(1
	,'TL')
	,(1
	,'RL')
	,(1
	,'SLX')
	,(1
	,'MDX')
	,(1
	,'RSX')
	,(1
	,'TSX')
	,(1
	,'RDX')
	,(1
	,'ZDX')
	,(2
	,'164')
	,(2
	,'Spider')
	,(3
	,'Typ-1')
	,(3
	,'Type-1h')
	,(4
	,'DB9')
	,(4
	,'Vanquish S')
	,(4
	,'DB9 Volante')
	,(4
	,'V8 Vantage')
	,(4
	,'Vantage')
	,(4
	,'DBS')
	,(4
	,'Rapide')
	,(4
	,'V8 Vantage S')
	,(4
	,'V12 Vantage')
	,(4
	,'Virage')
	,(5
	,'Quattro')
	,(5
	,'Coupe GT')
	,(5
	,'5000CS Quattro')
	,(5
	,'4000s Quattro')
	,(5
	,'4000CS Quattro')
	,(5
	,'5000CS')
	,(5
	,'V8')
	,(5
	,'Coupe Quattro')
	,(5
	,'S4')
	,(5
	,'Cabriolet')
	,(5
	,'riolet')
	,(5
	,'S6')
	,(5
	,'A6')
	,(5
	,'A4')
	,(5
	,'A8')
	,(5
	,'TT')
	,(5
	,'S8')
	,(5
	,'Allroad')
	,(5
	,'RS6')
	,(5
	,'RS 6')
	,(5
	,'A3')
	,(5
	,'Q7')
	,(5
	,'RS4')
	,(5
	,'RS 4')
	,(5
	,'S5')
	,(5
	,'R8')
	,(5
	,'A5')
	,(5
	,'Q5')
	,(5
	,'A7')
	,(6
	,'Mini')
	,(6
	,'Mini Cooper')
	,(6
	,'Mini Cooper S')
	,(7
	,'600')
	,(7
	,'6 Series')
	,(7
	,'3 Series')
	,(7
	,'5 Series')
	,(7
	,'7 Series')
	,(7
	,'8 Series')
	,(7
	,'M5')
	,(7
	,'M3')
	,(7
	,'Z3')
	,(7
	,'X5')
	,(7
	,'M')
	,(7
	,'Z8')
	,(7
	,'525')
	,(7
	,'530')
	,(7
	,'745')
	,(7
	,'760')
	,(7
	,'Z4')
	,(7
	,'325')
	,(7
	,'545')
	,(7
	,'645')
	,(7
	,'X3')
	,(7
	,'330')
	,(7
	,'550')
	,(7
	,'650')
	,(7
	,'750')
	,(7
	,'M6')
	,(7
	,'M Roadster')
	,(7
	,'Z4 M')
	,(7
	,'Alpina B7')
	,(7
	,'1 Series')
	,(7
	,'X6')
	,(7
	,'Z4 M Roadster')
	,(7
	,'X5 M')
	,(7
	,'X6 M')
	,(8
	,'Arnage')
	,(8
	,'Continental')
	,(8
	,'Azure')
	,(8
	,'Continental GT')
	,(8
	,'Continental Flying Spur')
	,(8
	,'Continental GTC')
	,(8
	,'Brooklands')
	,(8
	,'Continental Super')
	,(8
	,'Azure T')
	,(8
	,'Mulsanne')
	,(9
	,'Veyron')
	,(10
	,'Special')
	,(10
	,'Riviera')
	,(10
	,'Electra')
	,(10
	,'Century')
	,(10
	,'Skyhawk')
	,(10
	,'Somerset')
	,(10
	,'LeSabre')
	,(10
	,'Regal')
	,(10
	,'Skylark')
	,(10
	,'Reatta')
	,(10
	,'Estate')
	,(10
	,'Coachbuilder')
	,(10
	,'Park Avenue')
	,(10
	,'Roadmaster')
	,(10
	,'Hearse')
	,(10
	,'Rendezvous')
	,(10
	,'Rainier')
	,(10
	,'LaCrosse')
	,(10
	,'Terraza')
	,(10
	,'Lucerne')
	,(10
	,'Enclave')
	,(10
	,'Verano')
	,(11
	,'Fleetwood')
	,(11
	,'Seville')
	,(11
	,'Allante')
	,(11
	,'Brougham')
	,(11
	,'DeVille')
	,(11
	,'Eldorado')
	,(11
	,'Sixty Special')
	,(11
	,'Catera')
	,(11
	,'Escalade')
	,(11
	,'Escalade EXT')
	,(11
	,'CTS')
	,(11
	,'Escalade ESV')
	,(11
	,'SRX')
	,(11
	,'XLR')
	,(11
	,'STS')
	,(11
	,'DTS')
	,(11
	,'XLR-V')
	,(11
	,'CTS-V')
	,(11
	,'STS-V')
	,(12
	,'Corvette')
	,(12
	,'Corvair')
	,(12
	,'Corvair 500')
	,(12
	,'Camaro')
	,(12
	,'Bel Air')
	,(12
	,'Vega')
	,(12
	,'Monte Carlo')
	,(12
	,'Monza')
	,(12
	,'Caprice')
	,(12
	,'LUV')
	,(12
	,'Citation')
	,(12
	,'1500')
	,(12
	,'2500')
	,(12
	,'3500')
	,(12
	,'APV')
	,(12
	,'Astro')
	,(12
	,'Beretta')
	,(12
	,'Blazer')
	,(12
	,'Cavalier')
	,(12
	,'Corsica')
	,(12
	,'G-Series G10')
	,(12
	,'G-Series G20')
	,(12
	,'G-Series G30')
	,(12
	,'Lumina')
	,(12
	,'Lumina APV')
	,(12
	,'S10 Blazer')
	,(12
	,'S10')
	,(12
	,'Sportvan G10')
	,(12
	,'Sportvan G20')
	,(12
	,'Sportvan G30')
	,(12
	,'Suburban 1500')
	,(12
	,'Suburban 2500')
	,(12
	,'Caprice Classic')
	,(12
	,'Impala SS')
	,(12
	,'Impala')
	,(12
	,'K5 Blazer')
	,(12
	,'Tahoe')
	,(12
	,'Express 1500')
	,(12
	,'Express 2500')
	,(12
	,'Express 3500')
	,(12
	,'G-Series 1500')
	,(12
	,'G-Series 2500')
	,(12
	,'Malibu')
	,(12
	,'G-Series 3500')
	,(12
	,'Venture')
	,(12
	,'Metro')
	,(12
	,'Prizm')
	,(12
	,'Tracker')
	,(12
	,'Silverado')
	,(12
	,'Silverado 1500')
	,(12
	,'Silverado 2500')
	,(12
	,'Silverado 3500')
	,(12
	,'Avalanche')
	,(12
	,'Trailblazer')
	,(12
	,'Avalanche 1500')
	,(12
	,'Avalanche 2500')
	,(12
	,'SSR')
	,(12
	,'TrailBlazer')
	,(12
	,'Aveo')
	,(12
	,'Classic')
	,(12
	,'Colorado')
	,(12
	,'Cobalt')
	,(12
	,'Equinox')
	,(12
	,'Uplander')
	,(12
	,'Suburban')
	,(12
	,'Silverado 3500HD')
	,(12
	,'HHR Panel')
	,(12
	,'Malibu Maxx')
	,(12
	,'HHR')
	,(12
	,'Silverado Hybrid')
	,(12
	,'Express')
	,(12
	,'Cobalt SS')
	,(12
	,'Traverse')
	,(12
	,'Volt')
	,(12
	,'Cruze')
	,(12
	,'Sonic')
	,(13
	,'Imperial')
	,(13
	,'Fifth Ave')
	,(13
	,'LeBaron')
	,(13
	,'New Yorker')
	,(13
	,'Town & Country')
	,(13
	,'Concorde')
	,(13
	,'LHS')
	,(13
	,'Cirrus')
	,(13
	,'Sebring')
	,(13
	,'300')
	,(13
	,'300M')
	,(13
	,'Grand Voyager')
	,(13
	,'Voyager')
	,(13
	,'PT Cruiser')
	,(13
	,'Prowler')
	,(13
	,'Crossfire')
	,(13
	,'Pacifica')
	,(13
	,'300C')
	,(13
	,'Crossfire Roadster')
	,(13
	,'Aspen')
	,(14
	,'2CV')
	,(14
	,'SM')
	,(14
	,'CX')
	,(15
	,'Sparrow')
	,(16
	,'Lanos')
	,(16
	,'Leganza')
	,(16
	,'Nubira')
	,(17
	,'Charade')
	,(17
	,'Rocky')
	,(18
	,'Ice Edition')
	,(19
	,'Charger')
	,(19
	,'Omni')
	,(19
	,'Aries')
	,(19
	,'Daytona')
	,(19
	,'Caravan')
	,(19
	,'Colt')
	,(19
	,'Viper')
	,(19
	,'D150 Club')
	,(19
	,'D150')
	,(19
	,'D250 Club')
	,(19
	,'D250')
	,(19
	,'D350 Club')
	,(19
	,'D350')
	,(19
	,'Dakota Club')
	,(19
	,'Dakota')
	,(19
	,'Dynasty')
	,(19
	,'Grand Caravan')
	,(19
	,'Monaco')
	,(19
	,'Ram 50')
	,(19
	,'Ram Van B150')
	,(19
	,'Ram Van B250')
	,(19
	,'Ram Van B350')
	,(19
	,'Ram Wagon B150')
	,(19
	,'Ram Wagon B250')
	,(19
	,'Ram Wagon B350')
	,(19
	,'Ramcharger')
	,(19
	,'Shadow')
	,(19
	,'Spirit')
	,(19
	,'Stealth')
	,(19
	,'Viper RT/10')
	,(19
	,'Intrepid')
	,(19
	,'Ram')
	,(19
	,'Ram 1500')
	,(19
	,'Ram 2500')
	,(19
	,'Ram 3500')
	,(19
	,'Avenger')
	,(19
	,'Neon')
	,(19
	,'Ram 1500 Club')
	,(19
	,'Ram 2500 Club')
	,(19
	,'Ram 3500 Club')
	,(19
	,'Ram Van 1500')
	,(19
	,'Ram Van 2500')
	,(19
	,'Ram Van 3500')
	,(19
	,'Stratus')
	,(19
	,'Durango')
	,(19
	,'Magnum')
	,(19
	,'Sprinter')
	,(19
	,'Nitro')
	,(19
	,'Caliber')
	,(19
	,'Challenger')
	,(19
	,'Journey')
	,(20
	,'Talon')
	,(20
	,'Premier')
	,(20
	,'Summit')
	,(20
	,'Vision')
	,(21
	,'500')
	,(22
	,'Rockette')
	,(23
	,'F430')
	,(23
	,'612 Scaglietti')
	,(23
	,'F430 Spider')
	,(23
	,'599 GTB Fiorano')
	,(23
	,'430 Scuderia')
	,(23
	,'California')
	,(23
	,'458 Italia')
	,(23
	,'FF')
	,(24
	,'Nuova 500')
	,(25
	,'Fillmore')
	,(26
	,'Hemisfear')
	,(27
	,'Model T')
	,(27
	,'Thunderbird')
	,(27
	,'E-Series')
	,(27
	,'Mustang')
	,(27
	,'Galaxie')
	,(27
	,'Fairlane')
	,(27
	,'Falcon')
	,(27
	,'Country')
	,(27
	,'Torino')
	,(27
	,'Bronco II')
	,(27
	,'Laser')
	,(27
	,'EXP')
	,(27
	,'Ranger')
	,(27
	,'Escort')
	,(27
	,'Tempo')
	,(27
	,'LTD')
	,(27
	,'F250')
	,(27
	,'F150')
	,(27
	,'E250')
	,(27
	,'LTD Crown Victoria')
	,(27
	,'Bronco')
	,(27
	,'E150')
	,(27
	,'F-Series')
	,(27
	,'Taurus')
	,(27
	,'Aerostar')
	,(27
	,'Courier')
	,(27
	,'Festiva')
	,(27
	,'Probe')
	,(27
	,'Explorer')
	,(27
	,'Crown Victoria')
	,(27
	,'Club Wagon')
	,(27
	,'Econoline E150')
	,(27
	,'Econoline E250')
	,(27
	,'Econoline E350')
	,(27
	,'F350')
	,(27
	,'Lightning')
	,(27
	,'Aspire')
	,(27
	,'Windstar')
	,(27
	,'Contour')
	,(27
	,'Expedition')
	,(27
	,'Th!nk')
	,(27
	,'Explorer Sport Trac')
	,(27
	,'Escape')
	,(27
	,'Excursion')
	,(27
	,'Explorer Sport')
	,(27
	,'Focus')
	,(27
	,'TH!NK')
	,(27
	,'Fiesta')
	,(27
	,'ZX2')
	,(27
	,'Escort ZX2')
	,(27
	,'Freestar')
	,(27
	,'E350')
	,(27
	,'GT')
	,(27
	,'Freestyle')
	,(27
	,'Five Hundred')
	,(27
	,'F-250 Super Duty')
	,(27
	,'F-350 Super Duty')
	,(27
	,'E-350 Super Duty')
	,(27
	,'E-350 Super Duty Van')
	,(27
	,'Fusion')
	,(27
	,'F-Series Super Duty')
	,(27
	,'GT500')
	,(27
	,'Edge')
	,(27
	,'Expedition EL')
	,(27
	,'Taurus X')
	,(27
	,'F450')
	,(27
	,'Flex')
	,(27
	,'Transit Connect')
	,(27
	,'C-MAX Hybrid')
	,(27
	,'Focus ST')
	,(28
	,'1500 Club Coupe')
	,(28
	,'2500 Club Coupe')
	,(28
	,'3500 Club Coupe')
	,(28
	,'Jimmy')
	,(28
	,'Rally Wagon 1500')
	,(28
	,'Rally Wagon 2500')
	,(28
	,'Rally Wagon 3500')
	,(28
	,'Safari')
	,(28
	,'Sonoma Club')
	,(28
	,'Sonoma')
	,(28
	,'Vandura 1500')
	,(28
	,'Vandura 2500')
	,(28
	,'Vandura 3500')
	,(28
	,'Yukon')
	,(28
	,'Sonoma Club Coupe')
	,(28
	,'Rally Wagon G2500')
	,(28
	,'Rally Wagon G3500')
	,(28
	,'Vandura G1500')
	,(28
	,'Vandura G2500')
	,(28
	,'Vandura G3500')
	,(28
	,'Savana 1500')
	,(28
	,'Savana 2500')
	,(28
	,'Savana 3500')
	,(28
	,'Envoy')
	,(28
	,'EV1')
	,(28
	,'Sierra 1500')
	,(28
	,'Sierra 2500')
	,(28
	,'Sierra 3500')
	,(28
	,'Yukon Denali')
	,(28
	,'Yukon XL 1500')
	,(28
	,'Yukon XL 2500')
	,(28
	,'Envoy XL')
	,(28
	,'Canyon')
	,(28
	,'Envoy XUV')
	,(28
	,'Sierra Denali')
	,(28
	,'Sierra 3500HD')
	,(28
	,'Sierra 2500HD')
	,(28
	,'Yukon XL')
	,(28
	,'Savana Cargo Van')
	,(28
	,'Sierra Hybrid')
	,(28
	,'Savana')
	,(28
	,'Acadia')
	,(28
	,'Sierra')
	,(28
	,'Terrain')
	,(29
	,'Storm')
	,(30
	,'H1')
	,(30
	,'H2')
	,(30
	,'H3T')
	,(30
	,'H3')
	,(31
	,'Minx Magnificent')
	,(32
	,'VS Commodore')
	,(32
	,'Monaro')
	,(33
	,'Civic')
	,(33
	,'Accord')
	,(33
	,'CR-X')
	,(33
	,'Prelude')
	,(33
	,'del Sol')
	,(33
	,'Passport')
	,(33
	,'Odyssey')
	,(33
	,'CR-V')
	,(33
	,'Del Sol')
	,(33
	,'Insight')
	,(33
	,'S2000')
	,(33
	,'Pilot')
	,(33
	,'Element')
	,(33
	,'Civic Si')
	,(33
	,'Civic GX')
	,(33
	,'Ridgeline')
	,(33
	,'Fit')
	,(33
	,'Accord Crosstour')
	,(33
	,'CR-Z')
	,(33
	,'FCX Clarity')
	,(33
	,'Crosstour')
	,(34
	,'H2 SUT')
	,(34
	,'H2 SUV')
	,(35
	,'Elantra')
	,(35
	,'Excel')
	,(35
	,'Scoupe')
	,(35
	,'Sonata')
	,(35
	,'Accent')
	,(35
	,'Tiburon')
	,(35
	,'Santa Fe')
	,(35
	,'XG300')
	,(35
	,'XG350')
	,(35
	,'Tucson')
	,(35
	,'Azera')
	,(35
	,'Veracruz')
	,(35
	,'Entourage')
	,(35
	,'Genesis')
	,(35
	,'Genesis Coupe')
	,(35
	,'Equus')
	,(35
	,'HED-5')
	,(35
	,'Veloster')
	,(36
	,'G')
	,(36
	,'Q')
	,(36
	,'J')
	,(36
	,'I')
	,(36
	,'QX')
	,(36
	,'G35')
	,(36
	,'FX')
	,(36
	,'QX56')
	,(36
	,'G37')
	,(36
	,'EX')
	,(36
	,'G25')
	,(36
	,'IPL G')
	,(36
	,'JX')
	,(37
	,'Amigo')
	,(37
	,'Impulse')
	,(37
	,'Rodeo')
	,(37
	,'Space')
	,(37
	,'Stylus')
	,(37
	,'Trooper')
	,(37
	,'Hombre')
	,(37
	,'Oasis')
	,(37
	,'Hombre Space')
	,(37
	,'VehiCROSS')
	,(37
	,'Rodeo Sport')
	,(37
	,'Axiom')
	,(37
	,'Ascender')
	,(37
	,'i-Series')
	,(37
	,'i-280')
	,(37
	,'i-350')
	,(37
	,'i-290')
	,(37
	,'i-370')
	,(38
	,'XJ Series')
	,(38
	,'XK Series')
	,(38
	,'S-Type')
	,(38
	,'X-Type')
	,(38
	,'XK')
	,(38
	,'XJ')
	,(38
	,'XF')
	,(39
	,'Cherokee')
	,(39
	,'Comanche')
	,(39
	,'Wrangler')
	,(39
	,'Grand Cherokee')
	,(39
	,'Liberty')
	,(39
	,'Commander')
	,(39
	,'Compass')
	,(39
	,'Patriot')
	,(40
	,'Interceptor')
	,(41
	,'Sephia')
	,(41
	,'Sportage')
	,(41
	,'Mentor')
	,(41
	,'Spectra')
	,(41
	,'Rio')
	,(41
	,'Optima')
	,(41
	,'Sedona')
	,(41
	,'Sorento')
	,(41
	,'Amanti')
	,(41
	,'Spectra5')
	,(41
	,'Carens')
	,(41
	,'Rondo')
	,(41
	,'Rio5')
	,(41
	,'Mohave/Borrego')
	,(41
	,'Borrego')
	,(41
	,'Soul')
	,(41
	,'Forte')
	,(42
	,'Countach')
	,(42
	,'Diablo')
	,(42
	,'Murciélago')
	,(42
	,'Gallardo')
	,(42
	,'Murcielago')
	,(42
	,'Reventón')
	,(42
	,'Murcielago LP640')
	,(42
	,'Aventador')
	,(43
	,'Range Rover')
	,(43
	,'Sterling')
	,(43
	,'Defender')
	,(43
	,'Range Rover Classic')
	,(43
	,'Defender 110')
	,(43
	,'Discovery')
	,(43
	,'Defender 90')
	,(43
	,'Discovery Series II')
	,(43
	,'Freelander')
	,(43
	,'LR3')
	,(43
	,'Range Rover Sport')
	,(43
	,'LR2')
	,(43
	,'LR4')
	,(43
	,'Range Rover Evoque')
	,(44
	,'LS')
	,(44
	,'ES')
	,(44
	,'SC')
	,(44
	,'GS')
	,(44
	,'LX')
	,(44
	,'RX')
	,(44
	,'IS')
	,(44
	,'GX')
	,(44
	,'RX Hybrid')
	,(44
	,'IS-F')
	,(44
	,'IS F')
	,(44
	,'LS Hybrid')
	,(44
	,'HS')
	,(44
	,'CT')
	,(44
	,'LFA')
	,(45
	,'Town Car')
	,(45
	,'Mark VII')
	,(45
	,'Continental Mark VII')
	,(45
	,'Mark VIII')
	,(45
	,'Navigator')
	,(45
	,'Blackwood')
	,(45
	,'Aviator')
	,(45
	,'Zephyr')
	,(45
	,'Mark LT')
	,(45
	,'MKX')
	,(45
	,'MKZ')
	,(45
	,'Navigator L')
	,(45
	,'MKS')
	,(45
	,'MKT')
	,(46
	,'Esprit Turbo')
	,(46
	,'Elise')
	,(46
	,'Exige')
	,(46
	,'Exige S')
	,(46
	,'Evora')
	,(47
	,'Esprit')
	,(47
	,'Elan')
	,(48
	,'MGB')
	,(49
	,'MINI')
	,(49
	,'Cooper')
	,(49
	,'Clubman')
	,(49
	,'Cooper Clubman')
	,(49
	,'Countryman')
	,(49
	,'Cooper Countryman')
	,(50
	,'Quattroporte')
	,(50
	,'Biturbo')
	,(50
	,'228')
	,(50
	,'430')
	,(50
	,'Spyder')
	,(50
	,'Karif')
	,(50
	,'Gran Sport')
	,(50
	,'Coupe')
	,(50
	,'GranSport')
	,(50
	,'GranTurismo')
	,(51
	,'57')
	,(51
	,'62')
	,(51
	,'57S')
	,(51
	,'Landaulet')
	,(52
	,'626')
	,(52
	,'RX-7')
	,(52
	,'GLC')
	,(52
	,'Familia')
	,(52
	,'B2000')
	,(52
	,'B-Series')
	,(52
	,'929')
	,(52
	,'B2600')
	,(52
	,'MX-6')
	,(52
	,'MPV')
	,(52
	,'MX-5')
	,(52
	,'Navajo')
	,(52
	,'323')
	,(52
	,'Protege')
	,(52
	,'MX-3')
	,(52
	,'B-Series Plus')
	,(52
	,'Miata MX-5')
	,(52
	,'Millenia')
	,(52
	,'B2500')
	,(52
	,'Tribute')
	,(52
	,'Protege5')
	,(52
	,'Mazda6')
	,(52
	,'Mazda3')
	,(52
	,'RX-8')
	,(52
	,'Mazda6 5-Door')
	,(52
	,'Mazda5')
	,(52
	,'Mazda6 Sport')
	,(52
	,'Mazdaspeed6')
	,(52
	,'CX-7')
	,(52
	,'Mazdaspeed 3')
	,(52
	,'CX-9')
	,(52
	,'Mazda2')
	,(52
	,'CX-5')
	,(52
	,'MAZDA6')
	,(53
	,'MP4-12C')
	,(54
	,'W123')
	,(54
	,'W126')
	,(54
	,'S-Class')
	,(54
	,'E-Class')
	,(54
	,'W201')
	,(54
	,'SL-Class')
	,(54
	,'190E')
	,(54
	,'300CE')
	,(54
	,'300D')
	,(54
	,'300E')
	,(54
	,'300SD')
	,(54
	,'300SE')
	,(54
	,'300SL')
	,(54
	,'300TE')
	,(54
	,'400E')
	,(54
	,'400SE')
	,(54
	,'500E')
	,(54
	,'500SEL')
	,(54
	,'500SL')
	,(54
	,'600SEL')
	,(54
	,'C-Class')
	,(54
	,'400SEL')
	,(54
	,'500SEC')
	,(54
	,'600SEC')
	,(54
	,'600SL')
	,(54
	,'SLK-Class')
	,(54
	,'M-Class')
	,(54
	,'CL-Class')
	,(54
	,'CLK-Class')
	,(54
	,'G-Class')
	,(54
	,'SLR McLaren')
	,(54
	,'CLS-Class')
	,(54
	,'G55 AMG')
	,(54
	,'SL65 AMG')
	,(54
	,'R-Class')
	,(54
	,'GL-Class')
	,(54
	,'SLK55 AMG')
	,(54
	,'CL65 AMG')
	,(54
	,'GLK-Class')
	,(54
	,'SLS AMG')
	,(54
	,'SLS-Class')
	,(54
	,'Sprinter 2500')
	,(54
	,'Sprinter 3500')
	,(55
	,'Cougar')
	,(55
	,'Topaz')
	,(55
	,'Grand Marquis')
	,(55
	,'Lynx')
	,(55
	,'Capri')
	,(55
	,'Marquis')
	,(55
	,'Sable')
	,(55
	,'Tracer')
	,(55
	,'Villager')
	,(55
	,'Mystique')
	,(55
	,'Mountaineer')
	,(55
	,'Marauder')
	,(55
	,'Monterey')
	,(55
	,'Montego')
	,(55
	,'Mariner')
	,(55
	,'Milan')
	,(56
	,'XR4Ti')
	,(57
	,'Galant')
	,(57
	,'Mirage')
	,(57
	,'Starion')
	,(57
	,'Pajero')
	,(57
	,'Cordia')
	,(57
	,'Tredia')
	,(57
	,'Truck')
	,(57
	,'Chariot')
	,(57
	,'Mighty Max')
	,(57
	,'Precis')
	,(57
	,'L300')
	,(57
	,'Sigma')
	,(57
	,'Eclipse')
	,(57
	,'GTO')
	,(57
	,'Diamante')
	,(57
	,'RVR')
	,(57
	,'3000GT')
	,(57
	,'Expo')
	,(57
	,'Mighty Max Macro')
	,(57
	,'Montero')
	,(57
	,'Expo LRV')
	,(57
	,'Montero Sport')
	,(57
	,'Lancer')
	,(57
	,'Lancer Evolution')
	,(57
	,'Outlander')
	,(57
	,'Endeavor')
	,(57
	,'Raider')
	,(57
	,'Tundra')
	,(57
	,'Outlander Sport')
	,(57
	,'i-MiEV')
	,(58
	,'Aero 8')
	,(59
	,'280ZX')
	,(59
	,'Maxima')
	,(59
	,'Datsun/Nissan Z-car')
	,(59
	,'300ZX')
	,(59
	,'Sentra')
	,(59
	,'240SX')
	,(59
	,'NX')
	,(59
	,'Pathfinder')
	,(59
	,'Stanza')
	,(59
	,'Altima')
	,(59
	,'Quest')
	,(59
	,'200SX')
	,(59
	,'Frontier')
	,(59
	,'Xterra')
	,(59
	,'350Z')
	,(59
	,'Murano')
	,(59
	,'Titan')
	,(59
	,'Pathfinder Armada')
	,(59
	,'Armada')
	,(59
	,'350Z Roadster')
	,(59
	,'Versa')
	,(59
	,'Rogue')
	,(59
	,'Cube')
	,(59
	,'GT-R')
	,(59
	,'370Z')
	,(59
	,'Leaf')
	,(59
	,'JUKE')
	,(59
	,'cube')
	,(59
	,'NV1500')
	,(59
	,'NV2500')
	,(59
	,'NV3500')
	,(60
	,'Toronado')
	,(60
	,'88')
	,(60
	,'98')
	,(60
	,'Achieva')
	,(60
	,'Bravada')
	,(60
	,'Ciera')
	,(60
	,'Custom Cruiser')
	,(60
	,'Cutlass Supreme')
	,(60
	,'Silhouette')
	,(60
	,'Cutlass Cruiser')
	,(60
	,'Aurora')
	,(60
	,'Cutlass')
	,(60
	,'LSS')
	,(60
	,'Regency')
	,(60
	,'Intrigue')
	,(60
	,'Alero')
	,(61
	,'Esperante')
	,(62
	,'207')
	,(63
	,'Fury')
	,(63
	,'Roadrunner')
	,(63
	,'Volare')
	,(63
	,'Horizon')
	,(63
	,'Reliant')
	,(63
	,'Acclaim')
	,(63
	,'Colt Vista')
	,(63
	,'Sundance')
	,(63
	,'Breeze')
	,(64
	,'Tempest')
	,(64
	,'Grand Prix')
	,(64
	,'LeMans')
	,(64
	,'Bonneville')
	,(64
	,'Firebird')
	,(64
	,'Lemans')
	,(64
	,'6000')
	,(64
	,'Sunbird')
	,(64
	,'1000')
	,(64
	,'Parisienne')
	,(64
	,'Fiero')
	,(64
	,'Firefly')
	,(64
	,'Grand Am')
	,(64
	,'Gemini')
	,(64
	,'Firebird Trans Am')
	,(64
	,'Chevette')
	,(64
	,'Turbo Firefly')
	,(64
	,'Trans Sport')
	,(64
	,'Grand Prix Turbo')
	,(64
	,'Firebird Formula')
	,(64
	,'Sunfire')
	,(64
	,'Montana')
	,(64
	,'Aztek')
	,(64
	,'Vibe')
	,(64
	,'G6')
	,(64
	,'Daewoo Kalos')
	,(64
	,'Montana SV6')
	,(64
	,'Torrent')
	,(64
	,'Solstice')
	,(64
	,'G5')
	,(64
	,'G8')
	,(64
	,'G3')
	,(65
	,'914')
	,(65
	,'944')
	,(65
	,'911')
	,(65
	,'928')
	,(65
	,'924 S')
	,(65
	,'924')
	,(65
	,'968')
	,(65
	,'Boxster')
	,(65
	,'Cayenne')
	,(65
	,'Carrera GT')
	,(65
	,'Cayman')
	,(65
	,'Panamera')
	,(66
	,'C/V')
	,(68
	,'Alliance')
	,(69
	,'Phantom')
	,(69
	,'Ghost')
	,(70
	,'900')
	,(70
	,'9000')
	,(70
	,'9-3')
	,(70
	,'9-5')
	,(70
	,'9-7X')
	,(70
	,'9-2X')
	,(70
	,'9-4X')
	,(71
	,'S-Series')
	,(71
	,'L-Series')
	,(71
	,'VUE')
	,(71
	,'Ion')
	,(71
	,'Relay')
	,(71
	,'Vue')
	,(71
	,'Outlook')
	,(71
	,'Aura')
	,(71
	,'Sky')
	,(71
	,'Astra')
	,(72
	,'xA')
	,(72
	,'xB')
	,(72
	,'tC')
	,(72
	,'xD')
	,(72
	,'iQ')
	,(72
	,'FR-S')
	,(73
	,'GT350')
	,(74
	,'Fortwo')
	,(75
	,'C8 Spyder')
	,(75
	,'C8 Spyder Wide Body')
	,(75
	,'C8 Laviolette')
	,(75
	,'C8 Double 12 S')
	,(76
	,'C8')
	,(77
	,'Avanti')
	,(78
	,'Brat')
	,(78
	,'XT')
	,(78
	,'BRAT')
	,(78
	,'Leone')
	,(78
	,'Justy')
	,(78
	,'Legacy')
	,(78
	,'Loyale')
	,(78
	,'Alcyone SVX')
	,(78
	,'SVX')
	,(78
	,'Impreza')
	,(78
	,'Forester')
	,(78
	,'Outback')
	,(78
	,'Outback Sport')
	,(78
	,'Baja')
	,(78
	,'Tribeca')
	,(78
	,'B9 Tribeca')
	,(78
	,'Impreza WRX')
	,(78
	,'BRZ')
	,(79
	,'SJ 410')
	,(79
	,'Cultus')
	,(79
	,'SJ')
	,(79
	,'Swift')
	,(79
	,'Sidekick')
	,(79
	,'Samurai')
	,(79
	,'Esteem')
	,(79
	,'X-90')
	,(79
	,'Vitara')
	,(79
	,'Grand Vitara')
	,(79
	,'XL-7')
	,(79
	,'Aerio')
	,(79
	,'Daewoo Lacetti')
	,(79
	,'Daewoo Magnus')
	,(79
	,'Forenza')
	,(79
	,'Verona')
	,(79
	,'Reno')
	,(79
	,'XL7')
	,(79
	,'SX4')
	,(79
	,'Equator')
	,(79
	,'Kizashi')
	,(80
	,'Roadster')
	,(80
	,'Model S')
	,(81
	,'Celica')
	,(81
	,'MR2')
	,(81
	,'Truck Xtracab SR5')
	,(81
	,'Previa')
	,(81
	,'Camry')
	,(81
	,'4Runner')
	,(81
	,'Corolla')
	,(81
	,'Cressida')
	,(81
	,'Land Cruiser')
	,(81
	,'Paseo')
	,(81
	,'Supra')
	,(81
	,'Tercel')
	,(81
	,'Xtra')
	,(81
	,'T100')
	,(81
	,'Avalon')
	,(81
	,'T100 Xtra')
	,(81
	,'Tacoma')
	,(81
	,'Tacoma Xtra')
	,(81
	,'RAV4')
	,(81
	,'Sienna')
	,(81
	,'Solara')
	,(81
	,'Ipsum')
	,(81
	,'Echo')
	,(81
	,'Highlander')
	,(81
	,'Prius')
	,(81
	,'Sequoia')
	,(81
	,'Matrix')
	,(81
	,'Yaris')
	,(81
	,'Camry Solara')
	,(81
	,'Highlander Hybrid')
	,(81
	,'Camry Hybrid')
	,(81
	,'FJ Cruiser')
	,(81
	,'TundraMax')
	,(81
	,'Venza')
	,(81
	,'Prius v')
	,(81
	,'Prius Plug-in Hybrid')
	,(81
	,'Prius c')
	,(81
	,'Prius Plug-in')
	,(82
	,'Beetle')
	,(82
	,'Golf')
	,(82
	,'Jetta')
	,(82
	,'Vanagon')
	,(82
	,'Scirocco')
	,(82
	,'Quantum')
	,(82
	,'GTI')
	,(82
	,'Passat')
	,(82
	,'Type 2')
	,(82
	,'Fox')
	,(82
	,'Corrado')
	,(82
	,'Eurovan')
	,(82
	,'Golf III')
	,(82
	,'Jetta III')
	,(82
	,'rio')
	,(82
	,'New Beetle')
	,(82
	,'Touareg')
	,(82
	,'R32')
	,(82
	,'Phaeton')
	,(82
	,'Rabbit')
	,(82
	,'Eos')
	,(82
	,'GLI')
	,(82
	,'Touareg 2')
	,(82
	,'CC')
	,(82
	,'Tiguan')
	,(82
	,'Routan')
	,(83
	,'240')
	,(83
	,'740')
	,(83
	,'940')
	,(83
	,'960')
	,(83
	,'850')
	,(83
	,'S90')
	,(83
	,'V90')
	,(83
	,'C70');
