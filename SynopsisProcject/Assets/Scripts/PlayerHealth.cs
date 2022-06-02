using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float hp;
    public float maxHp;
    public Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        maxHp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(hp / maxHp, 0, 1);

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
