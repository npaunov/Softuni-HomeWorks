import data.product.ElectonicsProduct;
import enumerations.AgeRestriction;

public class Computer extends ElectonicsProduct {
	private float promotionProcentage = 0.95f;

	public Computer(
			String name,
			float price,
			int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, 24);
		this.setPromotionPrice(promotionProcentage, QuantityIsOver1000());
	}
	
	private boolean QuantityIsOver1000(){		
		if (this.getQuantity() > 1000) {
			return true;
		} else {
			return false;
		}
	}
}
