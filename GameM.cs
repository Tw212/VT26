using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GridA grid;
    [SerializeField] private TMP_Text pengartext;
    [SerializeField] private TMP_Text resulttext;

    private PayoutSystem payoutSystem = new PayoutSystem();

    [SerializeField] private int pengar = 1000;
    [SerializeField] private int betM = 10;

    private void Start()
    {
        UpdateUI();
    }

    public void Spin()
    {
        if (pengar < betM)
        {
            resulttext.text = "Inte tillräckligt med pengar!";
            return;
        }

        pengar -= betM;

        grid.Clear();
        grid.GridG();

        
        int win = payoutSystem.CalculatePayout(grid.GetGrid(), betM);

        if (win > 0)
        {
            pengar += win;
            resulttext.text = "Vinst: " + win;
        }
        else
        {
            resulttext.text = "Ingen vinst";
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        pengartext.text = "Pengar: " + pengar;
    }
}
   
