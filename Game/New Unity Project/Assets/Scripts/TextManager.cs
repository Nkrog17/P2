using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    public TextsMethods txt;
    public GameObject vis;

    static public int An = 1;
    static public int AnScene2 = 1;

    static public bool conversationEnd = true;

    public object Texts { get; internal set; }

    [Space(10)]
    [Header("Personer")]
    public GameObject Moller;
    public GameObject Amalie;
    public GameObject Ulrik;
    public GameObject Frederik;
    public GameObject Victoria;
    public GameObject Kone;
    public GameObject Phone;
    public GameObject Emma;

    [Space(10)]
    [Header("buttons")]
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    

    // Use this for initialization
    void Start() {
        Moller.SetActive(false);
        Amalie.SetActive(false);
        Ulrik.SetActive(false);
        Frederik.SetActive(false);
        Victoria.SetActive(false);
        Kone.SetActive(false);
        Phone.SetActive(false);
        Karmen.SetActive(false);
    }


    // Update is called once per frame
    void Update() {
        //Scene 1: PoliceStation
        if (SceneManager.GetActiveScene().buildIndex == 1) {



            if (An == 1)
            {
                Phone.SetActive(true);
                conversationEnd = false;
                txt.setQuestion("“MIN DATTER! Emma, hun… hun er væk!”");
                button1.SetActive(true);
                button2.SetActive(true);
                button3.SetActive(true);
                txt.setText1("“Væk?“");
                txt.setText2("“Rolig nu. Er du helt sikker på det?”");
                txt.setText3("“Sæt lige tempoet ned. Dit navn?”");

            }

            if (An == 2 || An == 11)
            {
                txt.setQuestion("“Ja, jeg er helt sikker! Hun er ikke på sit værelse og vinduet er åbent! Emma kunne aldrig finde på at stikke af midt om natten”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Giv mig din adresse, så kommer jeg.“");
                txt.setText3("");


            }

            if (An == 101)
            {
                txt.setQuestion("“Jamen… Du er nødt til at hjælpe! Mit navn er Christian Møller. Jeg er bange for der er sket hende noget!”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Jeg kommer så hurtigt jeg kan. Hvor bor du?”");
                txt.setText2("");
                txt.setText3("“Giv mig din adresse, så kommer jeg straks.”");
            }

            if (An == 102 || An == 21 || An == 12 || An == 201)
            {
                txt.setQuestion("“Svanemøllen 3. Tak - tusinde tak!”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Okay, jeg er på vej!”");
                txt.setText3("");
            }
            if (An == 112 || An == 21 || An == 22 || An == 211)
            {
                conversationEnd = true;
                Phone.SetActive(false);
                txt.turnOffObject();
            }



        }
        //Scene 2: GrevensEntrance
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {


            if (AnScene2 == 1)
            {
                txt.turnOnObject();
                conversationEnd = false;
                Moller.SetActive(true);
                txt.turnOnObject();
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Godaften, du må være Hr. Møller.”");
                txt.setText2("");
                txt.setText3("“Godt, hvor befandt hun sig sidst?”");
                txt.setQuestion("Hej! Hvor er det godt, du kom!");
            }

            if (AnScene2 == 2)
            {
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Det er mit arbejde.”");
                txt.setText2("");
                txt.setText3("“Selvfølgelig. Jeg finder ud af, hvad der sket.”");
                txt.setQuestion("“Det er mig, ja. Jeg håber, du kan hjælpe mig!”");
            }

			if (AnScene2 == 3 || AnScene2 == 102 || An == 101)
            {
                txt.setQuestion("“På hendes værelse, ovenpå. Men du er velkommen til at kigge dig omkring i huset, hvis det er nødvendigt.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Okay, jeg ser mig omkring!”");
                txt.setText3("");
            }

			if (AnScene2 == 13 || AnScene2 == 112 || An == 111)
            {
                conversationEnd = true;
                Moller.SetActive(false);
                txt.turnOffObject();
            }
        }
        //Scene 3: værelse uden lys
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
                       conversationEnd = true;
        }
        //Scene 4: Værelse med lys
        else if (SceneManager.GetActiveScene().buildIndex == 4 && kam.kamClicked)
        {
            if (An == 1) {
                Moller.SetActive(true);
                conversationEnd = false;
                txt.setQuestion("“Den kam genkender jeg ikke!”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Der er mørke hår på den.”");
                txt.setText3("");
            }
            if (An == 11) {
                txt.setQuestion("“Emma har lyst hår! Det er ikke hendes kam!”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Jeg tager den med og undersøger den.”");
                txt.setText3("");
            }
            if (An == 21)
            {
                Moller.SetActive(false);
                txt.turnOffObject();
                conversationEnd = true;
            }

        }

        //Scene 5: Kælder
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            conversationEnd = true;

            if (opAdTrappenBehaviour.light)
                txt.setQuestion("Jeg har slået strømmen til på værelset igen. Nu burde lyset virke.");
            else
                txt.setQuestion("Det ser ud til, at lyset til værelset ovenpå, er blevet afbrudt herfra.");
        }

        //Scene 6: Laboratorie
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            if (An == 1)
            {
                conversationEnd = false;
                txt.turnOnObject();
                Victoria.SetActive(true);

                txt.setQuestion("“Hej, hvad kan jeg hjælpe dig med?”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText2("“Hej Victoria, jeg har fundet hår, som skal analyseres.”");

                
            }

            if (An == 11)
            {
                txt.setQuestion("“Vi kan undersøge DNA fra disse hår. Alle mennesker har unik DNA, så vi kan måske finde frem til gerningsmanden. Vi har travlt, så jeg har brug for din hjælp til at analysere det.”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Hvordan fungere DNA?”");
                txt.setText3("“Hvad skal jeg gøre?”");
            }

            if (An == 12)
            {
                txt.setQuestion("“DNA består af fire aminosyrer, som vi kalder A, T, C og G. A og T hænger sammen, mens G og C hænger sammen. Ligesom et puslespil.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Forstået!”");
                txt.setText3("");
            }

            if (An == 22 || An == 111)
            {
                txt.setQuestion("“Din opgave er, at sammensætte de forskellige aminosyrer, A, T, C og G. Så analyserer jeg det sidste. Tryk på mikroskopet når du er klar.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Okay.”");
                txt.setText3("");
                conversationEnd = true;

            }

            if (An >= 22 && An != 111)
            {
                Victoria.SetActive(false);
                txt.turnOffObject();
            }
        }

        //scene 8: Efter DNA-spil
        else if (SceneManager.GetActiveScene().buildIndex == 8) {
            if (An == 1) {
                conversationEnd = false;
                txt.turnOnObject();
                Victoria.SetActive(true);
                txt.setQuestion("“Pefekt! Du er færdig med opgaven. Jeg undersøger resultaterne... Det ser ud til, at kammen tilhører en Ulrik Olsen.”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Har vi mere information om ham?”");
                txt.setText2("");
                txt.setText3("“Hvorfor kender vi hans DNA?”");
            }
            if (An == 101) {
                txt.setQuestion("“Han har tidligere siddet i fængsel for at have røvet en kiosk...”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Har vi mere information om ham?”");
                txt.setText3("");
            }
            if (An == 2 || An == 111) {
                txt.setQuestion("“Han bor ikke langt herfra. Jeg skriver adressen ned til dig.”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Har vi mere information om ham?”");
                txt.setText2("");
                txt.setText3("“Jeg tager ud og besøger ham straks!”");
            }
            if (An == 3 || An == 102 || An == 112 || An == 211)
            {
                conversationEnd = true;
                Victoria.SetActive(false);
                txt.turnOffObject();
            }
        }

        //Scene 9: Ulriks hjem
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            if (An == 1)
            {
                Kone.SetActive(true);
                txt.turnOnObject();
                txt.setQuestion("“Jeg vågnede op i nat ved, at Ulrik larmede i gangen. Jeg spurgte ham, hvor han skulle hen, men kan svarede mig ikke”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Hvornår skete det?”");
                txt.setText2("");
                txt.setText3("“Ved du, hvor han skulle hen?”");

            }

            if (An == 2 || An == 111)
            {
                txt.setQuestion("“Det skete cirka en time siden. Omkring klokken to. Han tog sin bil og kørte væk!”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Der er ikke mere her. Jeg må finde hans bil.”");
                txt.setText3("");
            }

            if (An == 101)
            {
                txt.setQuestion("“Nej, han har aldrig gjort det før. Jeg har simpelthen ingen ide om, hvor han skulle tage hen på dette tidspunkt. Åh, jeg håber ikke han har rodet sig ud i noget!”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Hvornår skete det?”");
                txt.setText3("");
            }

            if (An == 121 || An == 12)
            {
                conversationEnd = true;
                Kone.SetActive(false);
                txt.turnOffObject();
            }
        }

        //Scene 10: Politistation programmering
        else if (SceneManager.GetActiveScene().buildIndex == 10)
        {


            if (An == 1) {
                conversationEnd = false;
                txt.turnOnObject();
                Amalie.SetActive(true);

                txt.setQuestion("Hej, jeg hører, at du er på sporet af en bil.");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Ja, kan du hjælpe mig, Amalie?");
                txt.setText2("");
                txt.setText3("Jeg er på bar bund, Amalie!");
            }

            if (An == 2 || An == 101) {
                txt.setQuestion("Hvis du har den mistænktes navn, kan vi måske finde frem til hans bil.");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Hvordan det?");
                txt.setText2("");
                txt.setText3("Jeg har kun hans navn.");
            }

            if (An == 3 || An == 102 || An == 201 || An == 1000 || An == 1211 || An == 1122) {
                An = 1000;
                txt.setQuestion("Du kan finde hans nummerplade i vores database med registrerede personbiler. Imens får jeg adgang til overvågningskameraer i området.");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Hvad er en database?");
                txt.setText2("");
                txt.setText3("Hvor starter jeg?");
            }

            if (An == 1001) {
                txt.setQuestion("En database er et system til at opbevare information. Den består af tabeller, som kan sorteres efter, hvad du vil finde.");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("Hvor starter jeg?");
                txt.setText3("");
            }

            if (An == 1100 || An == 1011) {
                txt.setQuestion("Du skal blot skrive en enkelt sætning i SQL, som er et programmeringssprog, som kan sortere tabeller i databaser.");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("Men jeg kender ikke SQL!");
                txt.setText3("");
            }

            if (An == 1110 || An == 1021) {
                txt.setQuestion("Det er ret simpelt. Først vælger du den tabel du vil sortere, derefter, hvad du leder efter. Vil du have et eksempel på, hvordan det kunne se ud?");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Ja tak.");
                txt.setText2("");
                txt.setText3("Nej tak.");
            }

            if (An == 1111 || An == 1022) {
                txt.setQuestion("SELECT * FROM tabel WHERE farve = grøn. Her vælger vi alt fra ‘tabel’, og leder efter information med ‘farve’ som er lig med ‘grøn’. Er du med?");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Lad os komme i gang!");
                txt.setText2("");
                txt.setText3("Fortæl mig det en gang til.");
            }

            if (An == 1210 || An == 1121 || An == 1112 || An == 1023) {
                conversationEnd = true;
                Amalie.SetActive(false);
                txt.turnOffObject();
            }

        }

        //scene 12: efter sql
        else if (SceneManager.GetActiveScene().buildIndex == 12) {
            if (An == 1) {
                txt.turnOnObject();
                Amalie.SetActive(true);
                conversationEnd = false;
                txt.setQuestion("“Perfekt! Du har fundet ham! Jeg ser, om jeg kan finde bilen.”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Skynd dig!”");
                txt.setText2("");
                txt.setText3("“Hvordan gør du?”");
            }
            if (An == 2) {
                txt.setQuestion("“Rolig nu. Det kræver tålmodighed. Jeg skal nok finde ham.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Okay!”");
                txt.setText3("");
            }
            if (An == 101) {
                txt.setQuestion("“Jeg har adgang til adskillige overvågningskameraer i landet. Jeg ser, om bilen er set på et af dem.”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Sejt!”");
                txt.setText2("");
                txt.setText3("“Okay!”");
            }
            if (An == 102 || An == 201 || An == 12) {
                txt.setQuestion("“Jeg har fundet noget! Hans bil er blevet set på en tankstation ikke langt herfra.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Jeg tager traks afsted!”");
                txt.setText3("");
            }
            if (An == 112 || An == 211 || An == 22)
            {
                conversationEnd = true;
                Amalie.SetActive(false);
                txt.turnOffObject();
            }
        }
        //Scene 13: tank
        else if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            if (An == 1)
            {
                txt.turnOnObject();
                conversationEnd = false;
                Ulrik.SetActive(true);
                txt.setQuestion("“Hvem er du? Hvad vil du?”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Jeg er fra Politiets Efterretningstjeneste.”");
                txt.setText2("");
                txt.setText3("“Jeg vil stille dig spørgsmål om en kidnapning!”");
            }

            if (An == 2 || An == 101)
            {
                txt.setQuestion("“Åh nej! Jeg har ikke gjort noget! Jeg sværger! Jeg sagde nej til at hjælpe ham!”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Hjælpe hvem?”");
                txt.setText2("");
                txt.setText3("“Hvad taler du om?”");
            }

            if (An == 3 || An == 201 || An == 102)
            {
                txt.setQuestion("“Min bror! Han har bortført en pige! Jeg er uskyldig!”");
                button1.SetActive(true);
                button2.SetActive(true);
                button3.SetActive(true);
                txt.setText1("“Rolig nu, jeg tror på dig. Fortæl mig det hele.”");
                txt.setText2("“Slap af! Fortæl mig sandheden!”");
                txt.setText3("“Hvorfor har du ikke kontaktet politiet?”");
            }

            if (An == 103 || An == 301 || An == 201)
            {
                txt.setQuestion("“Han er min bror! Jeg kunne ikke få mig selv til det. Jeg var siddet her ved tankstationen og overvejet, hvad jeg skulle gøre siden han kørte væk.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Fortæl mig hele historien!”");
                txt.setText3("");
            }

            if (An == 4 || An == 202 || An == 103 || An == 13 || An == 211 || An == 112 || An == 113 || An == 313 || An == 211)
            {
                An = 1000;
            }

            if (An == 1000)
            {
                txt.setQuestion("“Min bror, Frederik, ringede til mig her i nat og bad om min hjælp. Han sagde ikke hvorfor, men da jeg mødte ham her, ville han have hjælp til en bortførelse! Jeg nægtede straks! Derefter kørte han bort. Jeg har været her siden!”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Hvor er han kørt hen?”");
                txt.setText3("");
            }

            if (An == 1010)
            {
                txt.setQuestion("“Jeg ved ikke, hvor han tog hen. Han snakkede om en gård, han havde fundet, ikke langt herfra. Jeg ved ikke hvor den er.”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Hvornår kørte han?”");
                txt.setText2("");
                txt.setText3("“Hvor hurtigt kørte han?”");
            }

            if (An == 1011 || An == 1110)
            {
                txt.setQuestion("“Han kørte for 5 minutter siden og havde ikke travlt. Han kørte vel med 60 kilometer i timen, som man må heromkring.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Du kommer med mig! Jeg må finde Frederik.”");
                txt.setText3("");
            }

            if (An == 1021 || An == 1120)
            {
                txt.turnOffObject();
                Ulrik.SetActive(false);
                conversationEnd = true;
            }
        }

        //Scene 14: MathPuzzle
        else if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            if (An == 1)
            {
                txt.turnOnObject();
                conversationEnd = false;
                txt.setQuestion("Okay, jeg ved, at han har kørt omkring 60 km/t for 5 minutter siden. Det kan jeg bruge til at finde en afstand herfra og finde mistænkelige gårde i nærheden.");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Men, jeg er usikker på, hvordan jeg gør det.");
                txt.setText2("");
                txt.setText3("I gang med arbejdet!");
            }

            if (An == 2)
            {
                txt.setQuestion("Ved at bruge hastigheden og tiden han har bevæget sig i, kan jeg bruge en hastighedsformel til at finde en radius. Derefter kan jeg se hvilke huse han kan have nået hen til.");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("Hvor hurtigt og hvor langt var det, han kørte?");
                txt.setText2("");
                txt.setText3("Okay. På med handsken!");
            }

            if (An == 3)
            {
                An = 1;
            }

            if (An == 101 || An == 102)
            {
                txt.turnOffObject();
                conversationEnd = true;
            }
        }

        //Scene 15: Lade
        else if (SceneManager.GetActiveScene().buildIndex == 15)
        {
            if (An == 1)
            {
                txt.turnOnObject();
                Frederik.SetActive(true);
                conversationEnd = false;
                txt.setQuestion("“Hvad sker der?! Hvem er du!?”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Jeg er fra Politiets Efterretningstjeneste!”");
                txt.setText2("");
                txt.setText3("“Frederik! Du er anholdt for kidnapningen af Emma!”");
            }

            if (An == 2 || An == 101)
            {
                txt.setQuestion("“Hvordan fandt du frem til mig!?”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Det tager jeg som en tilståelse.”");
                txt.setText2("");
                txt.setText3("“Det vedkommer ikke dig.”");
            }

            if (An == 3||An == 102|| An == 201)
            {
                txt.setQuestion("“Jeg er uskyldig! Jeg har ikke gjort noget ulovligt!”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Den tager vi på politistationen.”");
                txt.setText2("");
                txt.setText3("“Hvad laver Emma så her?”");
            }

            if (An == 4 || An == 103 || An == 202 || An == 301)
            {
                An = 1000;
            }

            if (An == 1000)
            {
                txt.setQuestion("“Suk… Okay, anhold mig bare. Det her er håbløst!”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Hvorfor bortførte du hende?”");
                txt.setText2("");
                txt.setText3("“Frederik Olsen, klokken er 04:21 og du er anholdt.”");
            }

            if (An == 1001)
            {
                txt.setQuestion("“Jeg har mistet mit job, min bil og snart mister jeg mit hus. Jeg har ikke penge nok til at forsørge min familie. Jeg havde brug for løsepenge. Derfor bortførte jeg en rigmands datter.”");
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(false);
                txt.setText1("");
                txt.setText2("“Frederik Olsen, klokken er 04:23 og du er anholdt!”");
                txt.setText3("");
            }

            if (An == 1100 || An == 1011)
            {
                conversationEnd = true;
                Frederik.SetActive(false);
                txt.turnOffObject();
            }
        }

        // Scene slut 16
        if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            if (An == 1)//Møller
            {
                conversationEnd = false;
                Moller.SetActive(true);
                txt.turnOnObject();
                txt.setQuestion("“Tusind tak skal du have! Jeg var så bekymret!”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Jeg gjorde blot min pligt!”");
                txt.setText2("");
                txt.setText3("“Jeg er glad for, at kunne hjælpe!”");
            }

            if (An == 2 || An == 101)//Emma
            {
            	Moller.SetActive(false);
            	Karmen.SetActive(true);
                txt.setQuestion("“Mange tusind tak! Jeg var så bange for, hvad der ville ske med mig! Hvad skete der med forbryderen?”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Ham tager domstolen sig af!”");
                txt.setText2("");
                txt.setText3("“Han ender bag lås og slå.”");
            }

            if (An == 3 || An == 102 || An == 201)
            {
            	Karmen.SetActive(false);
            	Moller.SetActive(true);
                txt.setQuestion("“Igen, tusind tak! Nu kan vi endelig slappe af. Du gjorde et godt stykke arbejde. Du overgik mine forventninger!”");
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
                txt.setText1("“Jeg må gå nu.“");
                txt.setText2("");
                txt.setText3("“Pas på jer selv”");
            }

            if (An == 4 || An == 103 || An == 202 || An == 301)
            {
                //Spil slut
                Moller.SetActive(false);
                txt.turnOffObject();
                conversationEnd = true;
            }
        }

        //Button behavior
        if (txtBehavior.button1)
        {
            
            
                txtBehavior.button1 = false;
                An++;
                if (SceneManager.GetActiveScene().buildIndex == 2)
                    AnScene2++;
            FindObjectOfType<click>().playClick();
            
				
        }
        else if (txtBehavior.button2)
        {
            txtBehavior.button2 = false;
            An = An + 10;
            if (SceneManager.GetActiveScene().buildIndex == 2)
                AnScene2 = AnScene2 + 10;
            FindObjectOfType<click>().playClick();
           
        }
        else if (txtBehavior.button3)
        {
           
            
                txt.setText3("nej!");
                txtBehavior.button3 = false;
                An = An + 100;
                if (SceneManager.GetActiveScene().buildIndex == 2)
                    AnScene2 = AnScene2 + 100;
            FindObjectOfType<click>().playClick();
            

        }
    }

}