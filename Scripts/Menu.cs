using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] food;
    public Text price;
    public Text calorias;
    public Text grasas;
    public Text sodio;
    public Text proteinas;

    // Platos de Fondo

    public void openPizza(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[0].gameObject.SetActive(true);
        price.text = "Precio: S/.20";
        calorias.text = "Calorias: 2400J";
        grasas.text = "Grasas: 180g";
        sodio.text = "Sodio: 8400mg";
        proteinas.text = "Proteinas: 180g";
    }

    public void openChicken(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[1].gameObject.SetActive(true);
        price.text = "Precio: S/.15";
        calorias.text = "Calorias: 200J-300J";
        grasas.text = "Grasas: 10g-20g";
        sodio.text = "Sodio: 50mg-150mg";
        proteinas.text = "Proteinas: 20g-30g";
    }

    public void openHamburguesa(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[2].gameObject.SetActive(true);
        price.text = "Precio: S/10";
        calorias.text = "Calorias: 71J";
        grasas.text = "Grasas: 893g";
        sodio.text = "Sodio: 893mg";
        proteinas.text = "Proteinas: 893g";
    }

    public void openTofu(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[3].gameObject.SetActive(true);
        price.text = "Precio: S/.16";
        calorias.text = "Calorias: 720J";
        grasas.text = "Grasas: 42.5g";
        sodio.text = "Sodio: 50mg";
        proteinas.text = "Proteinas: 83g";
    }

    public void openStew(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[4].gameObject.SetActive(true);
        price.text = "Precio: S/.15";
        calorias.text = "Calorias: 200J";
        grasas.text = "Grasas: 24g";
        sodio.text = "Sodio: 1000mg";
        proteinas.text = "Proteinas: 14g";
    }

    public void openCombo(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[5].gameObject.SetActive(true);
        price.text = "Precio: S/.8";
        calorias.text = "Calorias: 71J";
        grasas.text = "Grasas: 893g";
        sodio.text = "Sodio: 893g";
        proteinas.text = "Proteinas: 893g";
    }

    // Bebidas

    public void openCappuccino(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[6].gameObject.SetActive(true);
        price.text = "Precio: S/.4.5";
        calorias.text = "Calorias: 120J";
        grasas.text = "Grasas: 7g";
        sodio.text = "Sodio: 100mg";
        proteinas.text = "Proteinas: 8g";
    }

    public void openCoffee(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[7].gameObject.SetActive(true);
        price.text = "Precio: S/.4";
        calorias.text = "Calorias: 2J";
        grasas.text = "Grasas: 0g";
        sodio.text = "Sodio: 5mg";
        proteinas.text = "Proteinas: 0.2g";
    }

    public void openLemonade(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[8].gameObject.SetActive(true);
        price.text = "Precio: S/.2";
        calorias.text = "Calorias: 150J";
        grasas.text = "Grasas: 0g";
        sodio.text = "Sodio: 10mg";
        proteinas.text = "Proteinas: 0g";
    }

    public void openOrangeJuice(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[9].gameObject.SetActive(true);
        price.text = "Precio: S/.6";
        calorias.text = "Calorias: 200J";
        grasas.text = "Grasas: 1g";
        sodio.text = "Sodio: 0mg";
        proteinas.text = "Proteinas: 2g";
    }

    public void openCocaCola(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[10].gameObject.SetActive(true);
        price.text = "Precio: S/.3";
        calorias.text = "Calorias: 140J";
        grasas.text = "Grasas: 0g";
        sodio.text = "Sodio: 45mg";
        proteinas.text = "Proteinas: 0g";
    }

    public void openInkaKola(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[11].gameObject.SetActive(true);
        price.text = "Precio: S/.3";
        calorias.text = "Calorias: 180J";
        grasas.text = "Grasas: 0g";
        sodio.text = "Sodio: 35mg";
        proteinas.text = "Proteinas: 0g";
    }

    // Postres

    public void openPancakes(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[12].gameObject.SetActive(true);
        price.text = "Precio: S/.14";
        calorias.text = "Calorias: 71";
        grasas.text = "Grasas: 893";
        sodio.text = "Sodio: 893";
        proteinas.text = "Proteinas: 893";
    }

    public void openDonut(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[13].gameObject.SetActive(true);
        price.text = "Precio: S/.5";
        calorias.text = "Calorias: 71";
        grasas.text = "Grasas: 893";
        sodio.text = "Sodio: 893";
        proteinas.text = "Proteinas: 893";
    }

    public void openCupcake(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[14].gameObject.SetActive(true);
        price.text = "Precio: S/.4";
        calorias.text = "Calorias: 71";
        grasas.text = "Grasas: 893";
        sodio.text = "Sodio: 893";
        proteinas.text = "Proteinas: 893";
    }

    public void openCake(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[15].gameObject.SetActive(true);
        price.text = "Precio: S/.5.5";
        calorias.text = "Calorias: 71";
        grasas.text = "Grasas: 893";
        sodio.text = "Sodio: 893";
        proteinas.text = "Proteinas: 893";
    }

    public void openCookie(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[16].gameObject.SetActive(true);
        price.text = "Precio: S/.4";
        calorias.text = "Calorias: 71";
        grasas.text = "Grasas: 893";
        sodio.text = "Sodio: 893";
        proteinas.text = "Proteinas: 893";
    }

    public void openPie(){
        for(int i=0; i< food.Length; i++){
            food[i].gameObject.SetActive(false);
        }
        food[17].gameObject.SetActive(true);
        price.text = "Precio: S/.3 - S/.25";
        calorias.text = "Calorias: 71";
        grasas.text = "Grasas: 893";
        sodio.text = "Sodio: 893";
        proteinas.text = "Proteinas: 893";
    }
}
