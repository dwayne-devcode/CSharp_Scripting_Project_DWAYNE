// Extrait de code simplifié à des fins de démonstration
// Fait partie d’un projet collaboratif plus large
// Exemple : initialisation d’un personnage et création d’un menu interactif

public void Awake()
{
    // Récupération des composants principaux du personnage
    var Head = transform.root.gameObject.GetComponent<PersonBehaviour>().Limbs[0].gameObject;
    var MiddleBody = transform.root.gameObject.GetComponent<PersonBehaviour>().Limbs[2].gameObject;

    // Liaison avec le système d’aura
    MiddleBody.GetComponent<Aura>().User = transform.root.gameObject;

    // Création d’un bouton contextuel pour ouvrir le menu de transformations
    gameObject.GetComponent<PhysicalBehaviour>().ContextMenuOptions.Buttons.Add(
        new ContextMenuButton("Z2", "Transformations Menu", "Transformations Menu", () =>
        {
            // Création du menu principal
            GameObject Menu = new GameObject("Image");
            Menu.transform.SetParent(GameObject.Find("Canvas").transform);
            Menu.GetOrAddComponent<Image>().sprite = Mod.Menu;

            // Exemple : création d’un bouton pour fermer le menu
            GameObject XButton = new GameObject("X");
            XButton.transform.SetParent(Menu.transform);
            XButton.GetOrAddComponent<Button>().onClick.AddListener(() => Menu.SetActive(false));
        })
    );
}
// Les captures d’écran montrent le résultat visuel final dans le jeu.
// Ces extraits ont été volontairement réduits pour faciliter la lecture.