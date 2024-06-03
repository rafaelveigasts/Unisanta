import java.util.HashMap;

public class HashMap {
  public static void main(String[] args) {
    HashMap<String, String> mapa = new HashMap<String, String>();
    mapa.put("A", "A");
    mapa.put("C", "C");
    mapa.put("B", "B");
    mapa.remove("C");
    System.out.println(mapa.get("B")); // B
    for (String a : mapa.keySet()) {
      System.out.println(a);
    }
  }

}
