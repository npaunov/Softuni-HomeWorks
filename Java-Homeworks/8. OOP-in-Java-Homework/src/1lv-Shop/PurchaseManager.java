import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.joda.time.ReadableInstant;

import Customer;
import Product;
import data.product.*;
import data.product.electronicProduct.*;
import AgeRestriction;


public class PurchaseManager {
	public static void main(String[] args) {
		try {
			Product bread = new FoodProduct("Dobrudza", 0.80f, 1000, AgeRestriction.NONE, "2015-03-25");
			Product butter = new FoodProduct("MilkButter", 1.99f, 450, AgeRestriction.NONE, "2015-02-13");
			Product cigars = new FoodProduct("Cigars", 6.90f, 1400, AgeRestriction.ADULT);
			Product alcohol = new FoodProduct("Vodka", 19.99f, 150, AgeRestriction.ADULT);
			
			Product laptop = new Computer("Laptop", 1599f, 1000, AgeRestriction.NONE);
			Product PC = new Computer("PC", 899f, 2000, AgeRestriction.NONE);
			
			Product dishwasher = new Appliance("Dishwasher", 169f, 250, AgeRestriction.NONE);
			Product cooker = new Appliance("Cooker", 199f, 500, AgeRestriction.TEENAGER);
			
			Customer richCustomer = new Customer("Richie Rich", 50, 5000f);
			Customer averageCustomer = new Customer("Middle Man", 35, 1500f);
			Customer poorCustomer = new Customer("Low Lorie", 40, 400f);
			
			List<Product> products = new ArrayList<Product>(Arrays.asList(
					bread,
					butter, 
					cigars, 
					alcohol,
					laptop,
					PC,
					dishwasher,
					cooker));					
			List<Customer> customers = new ArrayList<Customer>(Arrays.asList(
					richCustomer,
					averageCustomer,
					poorCustomer));
			products.forEach(product -> System.out.println(product));
			customers.forEach(customer -> System.out.println(customer));
			
			ProcessPurchase(dishwasher, averageCustomer);			
			ProcessPurchase(laptop, richCustomer);
			
			Product firstToExpire = products.stream()
				.filter(product -> product instanceof FoodProduct)
				.filter(product -> ((FoodProduct) product).getExpirationDate() != null)
				.sorted((productOne, productTwo) ->
					((FoodProduct) productOne).getExpirationDate()
						.compareTo((ReadableInstant) ((FoodProduct) productTwo).getExpirationDate()))
				.findFirst()
				.get();
			System.out.printf(
					"Product with closest expiration date: %s.\n\n",
						firstToExpire.getName());
			System.out.println("All products with adult age restriction and sort them by price in ascending order:");
			products.stream()
				.filter(product -> product.getAgeRestriction() == AgeRestriction.ADULT)
				.sorted((productOne, productTwo) -> productOne.getPrice().compareTo(productTwo.getPrice()))
				.forEach(product -> System.out.println(product));
			
			
		} catch (Exception e) {
			System.err.println(e);
		} 
	}
	
	public static void ProcessPurchase(Product product, Customer customer) throws Exception {
		if (product.getQuantity() == 0) {
			throw new Exception("Product out of stock!", null);
		}
		
		if (product instanceof FoodProduct) {
			if (((FoodProduct) product).isExpired()) {
				throw new Exception("Product has passed expiration date!", null);
			}
		}
		
		if (customer.getBalance().compareTo(product.getPrice()) == -1) {
			throw new Exception("Customer does not have enough balance!", null);
		}
		
		if (!product.getAgeRestriction().InAgePeriod(customer.getAge())) {
			throw new Exception("Customer out of age range!", null);
		}
		
		customer.setBalance(customer.getBalance().subtract(product.getPrice()));
		product.setQuantity(product.getQuantity() - 1);
		
		System.out.printf(
				"Successful purchase: %sbought %s\n",
					customer.toString().replace("\n", ", "),
					product.toString());
	}
}
