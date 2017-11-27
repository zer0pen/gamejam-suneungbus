using System;

public static class ValueTable
{
	public class ExplorationTable
	{
		public static string[] incomeTitle = new string[] {
			"산속",
			"강가",
			"동굴",
			"평야",
			"바다"
		};
		public static int [,] incomeCount = new int[,] {
			{2, 1}, {2, 1}, {2, 1}, {2, 0}, {2, 0}
		};
		public static string[] incomeContentBefore = new string[] {
			"산속으로 출발합니다.",
				"강가로 출발합니다",
				"평야로 출발합니다.",
				"동굴로 출발합니다.",
				"바다로 출발합니다"
		};
		public static string[,] incomeContent = new string[,] {
			{
				"산속의 그득한 나무를 채취하던 중, 나무 안에 가득 들어있던 풍뎅이 애벌레를 발견했습니다",
				"산속의 나무를 채취하던 중 큰 상처를 입은 사슴을 발견했습니다",
				"쿵...쿵...쿵...쿵...쿵...퍽!...으드득...퍽!............쿵...쿵...쿵...쿵..."
			},
			{
				"물살이 다른곳보다 느린 강가를 찾아, 평소보다 많은 양의 물을 확보할수 있었습니다",
				"폭포를 거슬러 오르다가 힘이 다해버린 연어를 대량으로 발견했습니다",
				"강을 거슬러 오르다 연어를 먹기위한 곰을 마주쳤습니다... 곰이 왜 이곳ㅇ.."
			},
			{
				"동굴 주변에 불타오른 나무에서 숯과 고기를 채취했습니다.",
				"동굴 안쪽에서 생각지도 못한 화덕을 발견했습니다. 많은 양의 숯을 채취하였습니다.",
				"... ... ... ... ... ... ... 까악 까악 까악 까악 까악 까악.....",
			},
			{
				"감자~감자~ 머홍단 감자~",
				"감자밭 옆에 쓰러져있던 귀여운 짐승을 함께 가져왔습니다. 상한것같진 않네요",
				""
			},
			{
				"바다다~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
				"기왕이면 생선 말고 바닷가재가 좋은데...",
				""
			}
		};
		public static string[,,] incomeItems = new string[,,] {
			{{"item_tree", "item_beef", ""}, {"item_tree", "item_beef", ""}, {"", "", ""}},
			{{"item_badwater", "item_sand", "item_fish"}, {"item_badwater", "item_sand", "item_fish"}, {"", "", ""}},
			{{"item_coal", "item_beef", ""}, {"item_coal", "item_beef", ""}, {"", "", ""}},
			{{"item_beef", "item_potato", ""}, {"item_beef", "item_potato", ""}, {"", "", ""}},
			{{"item_beef", "item_fish", ""}, {"item_sand", "item_fish", ""}, {"", "", ""}}
		};
		public static int[,,] incomeDatas = new int[,,] {
			{{53, 8, 0}, {44, 11, 0}, {0, 0, 0}},
			{{37, 19, 3}, {19, 21, 8}, {0, 0, 0}},
			{{31, 170, 0}, {46, 190, 0}, {0, 0, 0}},
			{{27, 16, 0}, {19, 12, 0}, {0, 0, 0}},
			{{27, 21, 0}, {50, 14, 0}, {0, 0, 0}}
		};
		public static float[] badStatistic = new float[] {
			1f,
			0.5f,
			0.25f,
			0.125f,
			0.0625f
		};
		public static string[] badTitle = new string[] {
			"AsnapynButton 망망ㅇ",
			"MbButton 망망ㅇ",
			"GolrpButton 망망ㅇ",
			"MtpowerButton 망망ㅇ",
			"FrmskButton 망망ㅇ"
		};
		public static string[] badContent = new string[] {
			"AsnapynButton 망망ㅇ",
			"MbButton 망망ㅇ",
			"GolrpButton 망망ㅇ",
			"MtpowerButton 망망ㅇ",
			"FrmskButton 망망ㅇ"
		};
	}

	public class FireMakeScene {
		public static float timeLimit = 10000;
		public static int countPerFire = 3;
		public static int clickPerTree = 1;
	}

	public class WaterFilteringScene {
		public static float timeLimit = 10000;
		public static int countPerWater = 3;
		public static int clickPerBadwater = 1;
		public static int clickPerCoal = 2;
		public static int clickPerSand = 3;
	}

	public class FoodBakingScene {
		public static float timeLimit = 10000;
		public static int countPerFood = 3;
		public static int clickPerBeef = 1;
		public static int clickPerFish = 2;
		public static int clickPerPotato = 3;
	}

	public class GlobalTable {
		public static int fireMax = 100;
		public static int waterMax = 100;
		public static int foodMax = 100;
		public static int heartMax = 5;
	}
}
