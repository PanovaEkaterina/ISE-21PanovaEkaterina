
public class Knife {

	public void Cut_Egg(Egg e) {
		if (e.GetHave_shell_egg()) {
			e.SetHave_shell_egg(false);
		}
	}

	public void Cut_Apple(Apple apple) {
		if (apple.GetHave_skin_apple()) {
			apple.SetHave_skin_apple(false);
		}
	}

}
