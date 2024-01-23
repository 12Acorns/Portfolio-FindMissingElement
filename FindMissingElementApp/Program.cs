namespace FindMissingElementApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] _values = new int[]
			{
				3, 0, 1
			};
			Console.WriteLine(FindMissingElement(_values));
		}
		/// <summary>
		/// Expects an array to start at 0 and increment by one.
		/// </summary>
		static int FindMissingElement(int[] _array)
		{
			if(_array.Min() != 0)
			{
				throw new ArgumentException("Invalid input", nameof(_array));
			}
			Dictionary<int, int> _weightArray = new Dictionary<int, int>();
			for(int i = 0; i < _array.Max(); i++)
			{
				_weightArray.Add(i, 0);
			}
			for(int i = 0; i < _array.Length; i++)
			{
				_weightArray[_array[i]] = 1;
			}
			return _weightArray.FirstOrDefault(x => x.Value == 0).Key;
		}
	}
}