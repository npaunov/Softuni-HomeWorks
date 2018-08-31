import data.product.ElectonicsProduct;
import enumerations.AgeRestriction;

public class Appliance extends ElectonicsProduct {
	private float promotionProcentage = 1.05f;

	public Appliance(
			String name,
			float price,
			int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, 6);
		this.setPromotionPrice(promotionProcentage, QuantityIsLessThan50());
	}

	private boolean QuantityIsLessThan50(){		
		if (this.getQuantity() < 50) {
			return true;
		} else {
			return false;
		}
	}
}
