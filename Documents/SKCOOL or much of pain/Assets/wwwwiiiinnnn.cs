using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wwwwiiiinnnn : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = " ";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        text.text = "ТЫ ПАБИДИЛ!! ЕЕЕЕ! ЕСЛИ ТЫ ПАБИДИЛ, ТО ТЫ НИ МАСТИР, ТВАЙО КОДАВАЕ СЛОВА: 3920,ВВИДИ ИВО ШТОБЫ ПАЛУЧИТЬ 15 РУБЛЕЙ ОТ САСДАТИЛЯ ИГРЫ. ПАДАЖДИ 3 СИКУНДЫ...";
        yield return new WaitForSeconds(14);
        text.text = "А НЕ, ПАШОЛ В ЖОПУ ИПАНИЙ НУП, Я ТИПЯ ЗАТРАЛИЛ, АЗАЗАЗАЗА.";
        yield return new WaitForSeconds(4);
        text.text = " -Мастир Сасакус, тебе нужно ещё 1000 сасаев сделать. -ЛАДНА, ПАДАЖДИ, Я ЩА, ПАТОМ ПРАДОЛЖЫМ";
        yield return new WaitForSeconds(15);
        person.life = 0;
    }
}
