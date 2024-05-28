import java.util.*;

public class PhoneBook {
    private final Map<String, Set<String>> phoneBook = new HashMap<>();

    public void addPhone(String name, String phone) {
        phoneBook.computeIfAbsent(name, k -> new HashSet<>()).add(phone);
    }

    public void printPhoneBook() {
        TreeMap<String, Set<String>> sortedPhoneBook = new TreeMap<>((a, b) -> Integer.compare(phoneBook.get(b).size(), phoneBook.get(a).size()));
        sortedPhoneBook.putAll(phoneBook);

        for (Map.Entry<String, Set<String>> entry : sortedPhoneBook.entrySet()) {
            System.out.println("Имя: " + entry.getKey() + ", Телефоны: " + entry.getValue());
        }
    }

    public static void main(String[] args) {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.addPhone("Иван", "123");
        phoneBook.addPhone("Иван", "456");
        phoneBook.addPhone("Анна", "789");
        phoneBook.printPhoneBook();
    }
}
