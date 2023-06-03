using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int melons = 0;
    private int totalMelons;
    public static bool areAllMelonsCollected = false;

    public Text melonsText;

    public AudioSource collectionSoundEffect;

    private void Start()
    {
        totalMelons = GameObject.FindGameObjectsWithTag("Melon").Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;
            melonsText.text = "Watermelons : " + melons + "/" + totalMelons;
        }

        AllMelonsCollected();
    }

    public void AllMelonsCollected()
    {
        if (melons == totalMelons)
        {
            areAllMelonsCollected = true;
        }
    }
}
