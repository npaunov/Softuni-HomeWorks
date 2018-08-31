import java.io.UncheckedIOException;
import java.math.BigDecimal;

public class Customer {
	private String name;
	private int age;
	private BigDecimal balance;
	
	public Customer(String name, int age, float balance) {
		super();
		this.setName(name);
		this.setAge(age);
		this.setBalance(new BigDecimal(balance));
	}

	protected String getName() {
		return name;
	}

	protected void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	protected void setAge(int age) {
		this.age = age;
	}

	public BigDecimal getBalance() {
		return balance;
	}

	public void setBalance(BigDecimal balance) {
		if (balance.compareTo(new BigDecimal(0)) == -1) {
			this.balance = new BigDecimal(0);
			throw new UncheckedIOException("Customer balance = 0!", null);
		} 
		
		this.balance = balance;
	}	

	@Override
	public String toString() {
		String customer = String.format(
				"%S [ Name: %s; Age: %d; Balance %.2f ]\n",
				this.getClass().getSimpleName(),
				this.getName(),
				this.getAge(),
				this.getBalance());
		
		return customer;
	}
}
