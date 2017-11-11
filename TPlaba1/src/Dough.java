public class Dough {
	private Egg[] eggs;
	private Sugar sugar;
	private Flour flour;

	public void Init(int countegg) {
		eggs = new Egg[countegg];
	}

	public void AddEgg(Egg e) {
		for (int i = 0; i < eggs.length; i++) {
			if (eggs[i] == null) {
				eggs[i] = e;
				return;
			}
		}
	}

	public void AddSugar(Sugar s) {
		sugar = s;
		sugar.SetCountSugar(true);
	}

	public void AddFlour(Flour f) {
		flour = f;
		flour.SetCountFlour(true);
	}

	public boolean Check() {
		if (eggs == null) {
			return false;
		}
		if (eggs.length == 0) {
			return false;
		}
		for (int i = 0; i < eggs.length; ++i) {
			if (eggs[i].GetHave_shell_egg()) {
				return false;
			}
		}

		if (eggs.length < 1)
			return false;

		for (int i = 0; i < eggs.length; ++i) {
			if (eggs[i] == null)
				return false;
		}

		if (sugar == null)
			return false;

		if (flour == null)
			return false;

		return true;
	}
}
