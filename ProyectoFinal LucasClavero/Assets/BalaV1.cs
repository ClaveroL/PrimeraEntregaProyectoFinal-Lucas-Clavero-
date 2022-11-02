using UnityEngine;

public class BalaV1 : MonoBehaviour
{
    public Rigidbody RbBala;
    void OnCollisionEnter(Collision Detect)
    {
        GameObject target = Detect.transform.gameObject;
        if (target.GetComponent<Vidas>())
        {
            target.GetComponent<Vidas>().vidas--;
            if (Detect.transform.gameObject.tag == "Enemigo")
            {

                int totaldevidas = target.GetComponent<Vidas>().vidas;
                Debug.Log(totaldevidas);
                if (totaldevidas > 0)
                {
                    target.GetComponent<Rigidbody>().AddExplosionForce(10000 / totaldevidas, transform.position, 1);
                }
                else
                {
                    target.GetComponent<Rigidbody>().AddExplosionForce(10000, transform.position, 1);
                }
            }
        }
        Destroy(gameObject);
    }
}
