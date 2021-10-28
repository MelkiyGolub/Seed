using System;

namespace Семечко
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" Однажды в мире появилось семечко \n\t 1 - Посадить \n\t 2 - Скормить ");
			int.TryParse(Console.ReadLine(), out int a);

			switch (a)
			{
				case 1:

					Console.WriteLine(" Вскоре его посадили в милый горшочек \n\t 1 - Полить \n\t 2 - Забыть");
					int.TryParse(Console.ReadLine(), out int b);

					switch (b)
					{
						case 1:
							Console.WriteLine(" Его поливали и совсем скоро Семечко прорасло. Уже зелёный росточек стал тянуться к солнышку \n\t 1 - Полить \n\t 2 - Забыть");
							int.TryParse(Console.ReadLine(), out int c);

							switch (c)
							{
								case 1:
									Console.WriteLine(" Время шло, росточек становился больше \n\t 1 - Полить \n\t 2 - Забыть");
									int.TryParse(Console.ReadLine(), out int d);

									switch (d)
									{
										case 1:
											Console.WriteLine(" Но одной воды ему было мало. Росточек требовал любви \n\t 1 - Спеть \n\t 2 - Забить");
											 int.TryParse(Console.ReadLine(), out int e);
											
											switch (e)
											{
												case 1:
													Console.ForegroundColor = ConsoleColor.Magenta;
													Console.WriteLine(" Вы спели росточку и вскоре появился бутон. Каждый день вы заботились об этом Росточке и он стал ярким цветком \nКонцовка 1/6");
													break;

												case 2:
													Console.ForegroundColor = ConsoleColor.DarkRed;
													Console.WriteLine(" К сожаленю тебе всё равно на чувства цветочка. Ему тоже стало плевать и вместо красивого цветка вырос уродливый шипастый сорняк \nКонцовка 2/6");
													break;
											}
											break;
										case 2:
											Console.ForegroundColor = ConsoleColor.DarkGreen;
											Console.WriteLine(" Ты давно не поливал своё растение и к сожалению бутон так и не распустился \nКонцовка 3/6");
											break;
									}
									break;
								case 2:
									Console.ForegroundColor = ConsoleColor.DarkYellow;
									Console.WriteLine(" Но он так и не вырос.Ты забыл про растение и оно погибло \nКонцовка 4/6");
									break;
							}
							break;
						case 2:
							Console.ForegroundColor = ConsoleColor.Gray;
							Console.WriteLine(" Как-то раз вы нечаянно задели горшочек и разбили его \nКонцовка 5/6");
							break;
					}
					break;
				case 2:
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine(" Вы решили скормить семечко Птичке. Вы добрый человек и теперь у вас есть друг \nКонцовка 6/6");
					break;
			}
		}
	}		
}
