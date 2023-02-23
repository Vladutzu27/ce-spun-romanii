using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raspunsuri : MonoBehaviour
{
    private Raspunsuri() { }
    private static Raspunsuri _instance;
    public static Raspunsuri instance
    {
        get
        {
            if (_instance == null)
            { _instance = new Raspunsuri();  }
            return _instance;
        }
    }


    public List<string> Q1 = new List<string>() { "Am rugat o sută de români să completeze fraza: Sâmbătă mergem în vizită la cuscrii și știi că ei se bucură dacă le aducem și o sticlă de...", "Vin$36", "Șampanie$30", "Lichior$10", "Țuică$9", "Pălincă$6", "Coniac$5", "Ulei$2", "Suc$2" };
    public List<string> Q2 = new List<string>() { "Pe postul RA TV din Regatul Animalelor, ce vietate prezintă, in fiecare duminică „Viața Junglei”?", "Leul$27", "Maimuța$13", "Girafa$13", "Tigrul$8", "Zebra$7", "Elefantul$6", "Vulpe$6", "Ursul$6" };
    public List<string> Q3 = new List<string>() { "La ce eveniment te duci cu telefonul încărcat la maxim pentru că știi că o să faci multe poze?", "Nuntă$39", "Botez$20", "Petrecere$11", "Concert$9", "Aniversare$8", "Balul Bobocilior$5", "Serbare$5", "Revelion$3" };
    public List<string> Q4 = new List<string>() { "Ai o găleată cu mere. Ce faci cu ele?", "Compot$31", "Plăcintă$26", "Gem$14", "Suc$11", "Țuică$5", "Cidru$5", "Prăjitură$4", "Dulceață$4" };
    public List<string> Q5 = new List<string>() { "Pe lângă plopii fără soț, ce mai vezi în parc?", "Bancă$24", "Tei$11", "Stejar$10", "Brad$10", "Castan$10", "Flori$9", "Salcâm$6", "Iarbă$5" };
    public List<string> Q6 = new List<string>() { "Ce se împrăștie foarte ușor dar îți ia o grămadă să aduni la loc?", "Orez$22", "Zahăr$18", "Mărgelele$14", "Făină$13", "Sare$11", "Semințe$9", "Fasole$7", "Piper$6" };

}