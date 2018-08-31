import java.math.BigDecimal;

import enumerations.AgeRestriction;
import interfaces.Buyable;

public class Product implements Buyable {
	private String name;
	private BigDecimal price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	
	
	protected Product(
			String name,
			float price,
			int quantity,
			AgeRestriction ageRestriction) {
		this.setName(name);
		this.setPrice(new BigDecimal(price));
		this.setQuantity(quantity);
		this.setAgeRestriction(ageRestriction);
	}

	public String getName() {
		return this.name;
	}
	
	protected void setName(String name) {
		this.name = name;
	}
	
	public BigDecimal getPrice() {
		return this.price;
	}
	
	protected void setPrice(BigDecimal price) {
		this.price = price;
	}
	
	public int getQuantity() {
		return this.quantity;
	}
	
	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}
	
	public AgeRestriction getAgeRestriction() {
		return this.ageRestriction;
	}
	
	protected void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}
	
	protected void setPromotionPrice(float priceDifferenceInProcentage, boolean whenToApply){
		if (whenToApply == true) {
			BigDecimal procentageDiff = new BigDecimal(priceDifferenceInProcentage);
			this.price = price.multiply(procentageDiff);
		}
	}
	
	@Override	
	public String toString() {
		String product = String.format(
				"%S [ Name: %s; Price: $%.2f; Quantity: %d; Age restriction: %s ]\n",
				this.getClass().getSimpleName(),
				this.getName(),
				this.getPrice(),
				this.getQuantity(),
				this.getAgeRestriction());
				
		return product;
	}	
}
