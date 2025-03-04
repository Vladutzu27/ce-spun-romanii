import random

# Lista de întrebări și răspunsuri (definiții)
termeni_si_definitii = [
    ("Sclerotică", "Protejează globul ocular dinspre exterior"),
    ("Coroida", "Țesut vascularizat care hrănește retina"),
    ("Retina", "Conține celule fotosensibile cu conuri și cu bastonașe"),
    ("Pata galbenă", "Zona din retină cu cea mai mare densitate de celule nervoase, permițând astfel vederea cea mai clară"),
    ("Nervul optic", "Conduce impulsurile electrice de la celulele nervoase spre creier"),
    ("Pata oarbă", "Zona de intrare a nervului vizual, liberă de celule fotoreceptoare"),
    ("Corneea", "Protejează ochiul dinspre exterior"),
    ("Umoarea apoasă", "Protejează cristalinul, Împreună cu corneea, cu cristalinul și cu umoarea sticloasă compune sistemul optic al ochiului"),
    ("Irisul + pupila", "Irisul reglează mărimea pupilei, iar prin aceasta cantitatea de lumină ce pătrunde în ochi\nAdaptarea:\n -În semiîntuneric -> mărirea pupilei\n -În lumină puternică -> micșorarea pupilei"),
    ("Cristalinul", "Principala componentă optică a ochiului"),
    ("Mușchiul ciliar", "Schimbă curbura (convergența) cristalinului.\nAcomodarea: modificarea curburii cristalinului pentru ca imaginea diverselor obiecte (aflate al diverse distanțe) să se formeze pe retină.\nImagini clare pentru obiecte îndepărtate -> cristalin plat\nImagini clare pentru obiecte apropiate -> cristalin bombat"),
    ("Umoarea sticloasă", "Componentă aferentă sistemului optic al ochiului, care menține constantă distanța dintre cristalin și retină"),
    ("Mușchii globului ocular", "Realizează rotirea globului ocular în interiorul orbitei"),
    ("Pleoapele", "Protejează ochiul de intrarea corpurilor străine")
]

# Funcția care rulează testul
def testeaza_cunostinte(termeni_si_definitii):
    random.shuffle(termeni_si_definitii)  # Amestecă termenii
    for termen, definitie in termeni_si_definitii:
        # Pune întrebarea și afișează răspunsul corect
        print("Ce face {termen}?")
        inputt = input("")
        print("Răspunsul corect: {definitie}\n")

# Rulăm testul
testeaza_cunostinte(termeni_si_definitii)
