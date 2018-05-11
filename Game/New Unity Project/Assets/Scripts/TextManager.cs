using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    public TextsMethods txt;
    public GameObject vis;
    static public int An = 1;
    static public int AnScene2 = 1;

    static public bool conversationEnd;

    public object Texts { get; internal set; }

    // Use this for initialization
    void Start () {
	}
		
	
	// Update is called once per frame
	void Update () {
        //Scene 1: PoliceStation
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            txt.setQuestion("“MIN DATTER! Hun… hun.. Hun er væk!”");
            

            if (An == 1)
            {
                conversationEnd = false;
                txt.setText1("“Væk?“");
                txt.setText2("“Rolig nu - er du helt sikker på det?”");
                txt.setText3("“Sæt lige tempoet ned - dit navn?”");
                
            }

            if (An == 2 || An == 11)
            {
                txt.setQuestion("“Ja, jeg er helt sikker! Hun er ikke på sit værelse og vinduet er åbent! Hun kunne aldrig finde på at stikke af midt om natten”");
                txt.setText1("");
                txt.setText2("“Du mener altså, at nogen skulle have brudt ind gennem vinduet og kidnappet hende? Giv mig din adresse, så kommer jeg med det samme.“");
                txt.setText3("");


            }

            if (An == 101)
            {
                txt.setQuestion("“Jamen… Du er nødt til at hjælpe!Mit navn er Christian Møller.Jeg er bange for der er sket hende noget”");
                txt.setText1("“Okay Hr. Møller. Jeg gør hvad jeg kan, for at komme så hurtigt som muligt - din adresse?”");
                txt.setText2("");
                txt.setText3("“Hvis du giver mig din adresse, så kommer jeg med det samme.”");
            }

            if (An >= 102 || An == 21 || An == 12)
            {
                txt.setQuestion("“Svanemøllen 3. Tak - tusinde tak!”");
                txt.setText1("");
                txt.setText2("");
                txt.setText3("");
                conversationEnd = true;
            }


            
        }
        //Scene 2: GrenevsIntrance
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            txt.turnOnObject();

            if (AnScene2 == 1)
            {
                conversationEnd = false;
                txt.turnOnObject();
                txt.setText1("“Godaften - du må være Hr. Møller.”");
                txt.setText2("");
                txt.setText3("“Godt, vil du være så venlig at vise mig rummet, hvor hun sidst befandt sig?”");
                txt.setQuestion("");
            }

            if (AnScene2 == 2)
            {
                txt.setText1("“Det er mit arbejde.”");
                txt.setText2("");
                txt.setText3("“Selvfølgelig. Vil gøre mit bedste for at finde ud af, hvad der sket.”");
                txt.setQuestion("“Det er mig, ja. Jeg er glad for, du kunne komme så hurtigt!”");
            }

            if (AnScene2 > 2)
            {
                txt.setQuestion("“Hendes værelse er ovenpå, men du er velkommen til at kigge dig omkring i huset.”");
                txt.setText1("");
                txt.setText2("");
                txt.setText3("");
                conversationEnd = true;
            }
        }
        //Scene 3: væresle uden lys
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            txt.turnOnObject();
            txt.setText1("");
            txt.setText2("");
            txt.setText3("");

            txt.setQuestion("Lyset virker ikke. Det er alt for mørkt til, at jeg kan se noget. Jeg må få lyset til at virke.s");
            conversationEnd = true;
        }
        //Scene 4: Værelse med lys
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            txt.setText1("Answer1");
            txt.setText2("Answer2");
            txt.setText3("Answer3");

            txt.setQuestion("Question");
        }

        //Scene 5: Kælder
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            txt.turnOnObject();
            txt.setText1("");
            txt.setText2("");
            txt.setText3("");
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

                txt.setQuestion("“Hej, hvad kan jeg hjælpe dig med?”");
                txt.setText1("");
                txt.setText2("“Hej Victoria, jeg har fundet noget bevismateriale, som skal analyseres.”");
                txt.setText3("");
            }

            if (An == 11)
            {
                txt.setQuestion("“Vi kan undersøge DNA fra disse hår. Alle mennesker har unik DNA, så vi kan måske finde frem til gerningsmanden. Vi har travlt, så jeg har brug for din hjælp til at analysere det.”");
                txt.setText1("“Hvordan fungere DNA?”");
                txt.setText2("");
                txt.setText3("“Hvad skal jeg gøre?”");
            }
             
            if (An == 12)
            {
                txt.setQuestion("“DNA består af fire aminosyrer, som vi kalder A, T, C og G. A og T hænger sammen, mens G og C hænger sammen. Ligesom et puslespil.”");
                txt.setText1("");
                txt.setText2("“Okay.”");
                txt.setText3("");
            }

            if (An == 22 || An == 111)
            {
                txt.setQuestion("“Din opgave er, at sammensætte de forskellige aminosyrer, A, T, C og G. Så analyserer jeg det sidste. Tryk på mikroskopet når du er klar.”");
                txt.setText1("");   
                txt.setText2("“Okay.”");
                txt.setText3("");
                conversationEnd = true;

            }

            if (An >= 22 && An !=111)
            {
                txt.turnOffObject();
            }
        }

        //Scene 9: Ulriks hjem
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {

        }

        //Scene 10: Politistation programering
        else if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            txt.setQuestion("Hej, jeg hører, at du er på sporet af en bil.");

            if (An == 1){
                conversationEnd = false;
                txt.setText1("Ja, kan du hjælpe mig, Amalie?");
                txt.setText2("");
                txt.setText3("Jeg er på bar bund, Amalie!");
            }

            if (An == 2 || An == 101){
                txt.setQuestion("Hvis du har den mistænktes navn, kan vi måske finde frem til hans bil."); 
                txt.setText1("Hvordan det?");
                txt.setText2("");
                txt.setText3("Jeg har kun hans navn.");
            }

            if (An == 3 || An == 102 || An == 201 || An == 1000 || An == 1211 || An == 1122){
                An = 1000;
                txt.setQuestion("Du kan finde hans nummerplade i vores database med registrerede personbiler. Imens får jeg adgang til overvågningskameraer i området.");
                txt.setText1("Hvad er en database?");
                txt.setText2("");
                txt.setText3("Hvor starter jeg?");
            }

            if (An == 1001){
                txt.setQuestion("En database er et system til at opbevare information. Den består af tabeller, som kan sorteres efter, hvad du vil finde.");
                txt.setText1("");
                txt.setText2("Hvor starter jeg?");
                txt.setText3("");
            }

            if (An == 1100 || An == 1011){
                txt.setQuestion("Du skal blot skrive en enkelt sætning i SQL, som er et programmeringssprog, som kan sortere tabeller i databaser.");
                txt.setText1("");
                txt.setText2("Men jeg kender ikke SQL!");
                txt.setText3("");
            }

            if (An == 1110 || An == 1021){
                txt.setQuestion("Det er ret simpelt. Først vælger du den tabel du vil sortere, derefter, hvad du leder efter. Vil du have et eksempel på, hvordan det kunne se ud?");
                txt.setText1("Ja tak.");
                txt.setText2("");
                txt.setText3("Nej tak.");
            }

            if (An == 1111 || An == 1022) {
                txt.setQuestion("SELECT * FROM tabel WHERE farve = grøn. Her vælger vi alt fra ‘tabel’, og leder efter information med ‘farve’ som er lig med ‘grøn’. Er du med?");
                txt.setText1("Lad os komme i gang!");
                txt.setText2("");
                txt.setText3("Fortæl mig det en gang til.");
            }

            if (An == 1210 || An == 1121 || An == 1112 || An == 1023){
                conversationEnd = true;
            }
            if (An == 1)
            {
                conversationEnd = false;
                txt.turnOnObject();

                txt.setQuestion("“Hej, hvad kan jeg hjælpe dig med?”");
                txt.setText1("");
                txt.setText2("“Hej Victoria, jeg har fundet noget bevismateriale, som skal analyseres.”");
                txt.setText3("");
            }

            if (An == 11)
            {
                txt.setQuestion("“Vi kan undersøge DNA fra disse hår. Alle mennesker har unik DNA, så vi kan måske finde frem til gerningsmanden. Vi har travlt, så jeg har brug for din hjælp til at analysere det.”");
                txt.setText1("“Hvordan fungere DNA?”");
                txt.setText2("");
                txt.setText3("“Hvad skal jeg gøre?”");
            }
             
            if (An == 12)
            {
                txt.setQuestion("“DNA består af fire aminosyrer, som vi kalder A, T, C og G. A og T hænger sammen, mens G og C hænger sammen. Ligesom et puslespil.”");
                txt.setText1("");
                txt.setText2("“Okay.”");
                txt.setText3("");
            }

            if (An == 22 || An == 111)
            {
                txt.setQuestion("“Din opgave er, at sammensætte de forskellige aminosyrer, A, T, C og G. Så analyserer jeg det sidste. Tryk på mikroskopet når du er klar.”");
                txt.setText1("");   
                txt.setText2("“Okay.”");
                txt.setText3("");
                conversationEnd = true;

            }

            if (An >= 22 && An !=111)
            {
                txt.turnOffObject();
            }
        }

        //Scene 12: tank
        else if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            
        }

        //Scene 14: Lade
        else if (SceneManager.GetActiveScene().buildIndex == 14)
        {

        }

        //Button behavior
        if (txtBehavior.button1)
        {
            if (txt.text1empty())
            {
                Debug.Log("Button1Clicked 1");
                txtBehavior.button1 = false;
                An++;
                if (SceneManager.GetActiveScene().buildIndex == 2)
                    AnScene2++;
            }

            print(An);
        }
        else if (txtBehavior.button2)
        {
            Debug.Log("Button1Clicked 2");
            txtBehavior.button2 = false;
            An = An + 10;
            if (SceneManager.GetActiveScene().buildIndex == 2)
                AnScene2 = AnScene2 + 10;
        }
        else if (txtBehavior.button3)
        {
            if (txt.text3empty())
            {
                Debug.Log("Button1Clicked 3");
                txt.setText3("nej!");
                txtBehavior.button3 = false;
                An = An + 100;
                if (SceneManager.GetActiveScene().buildIndex == 2)
                    AnScene2 = AnScene2 + 100;
            }
            print(An);
        }
    }

}