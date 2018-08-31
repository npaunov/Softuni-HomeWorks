import data.Product;
import enumerations.AgeRestriction;

public class ElectonicsProduct extends Product {
	int guaranteePeriodInMonths;

	public ElectonicsProduct(
			String name,
			float price,
			int quantity,
			AgeRestriction ageRestriction,
			int guaranteePeriodInMonths) {
		super(name, price, quantity, ageRestriction);
		this.setGuaranteePeriodInMonths(guaranteePeriodInMonths);
	}

	public int getGuaranteePeriodInMonths() {
		return guaranteePeriodInMonths;
	}

	public void setGuaranteePeriodInMonths(int guaranteePeriodInMonths) {
		this.guaranteePeriodInMonths = guaranteePeriodInMonths;
	}
	
	@Override	
	public String toString() {
		String electronicsProduct =	
			super.toString().replace(" ]\n", "; ") +
			String.format(
				"Garantee: %s months ]\n",
				this.getGuaranteePeriodInMonths());
				
		return electronicsProduct;
	}
}
