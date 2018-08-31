public enum AgeRestriction {
	NONE(0, Integer.MAX_VALUE),
	TEENAGER(0, 17),
	ADULT(18, Integer.MAX_VALUE);
	
	private int ageStart;
	private int ageEnd;

	private AgeRestriction(int ageStart, int ageEnd) {
		this.ageStart = ageStart;
		this.ageEnd = ageEnd;
	}
	
	public boolean InAgePeriod(int ageToCompare) {
		if (ageToCompare > this.ageStart && ageToCompare < this.ageEnd) {
			return true;
		} else {
			return false;
		}
	}
}
