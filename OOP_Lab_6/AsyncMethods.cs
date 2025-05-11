using System.Runtime.InteropServices.JavaScript;

namespace OOP_Lab_6;

public class AsyncMethods
{
    public List<int> Vector { get; set; }

    public AsyncMethods()
    {
        Vector = new List<int>();
    }

    public void GenerateRandomVector(int size)
    {
        Vector = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            Vector.Add(rand.Next(0, size));
        }
    }

    public async Task GenerateRandomVectorAsync(int size)
    {
        await Task.Run(() => GenerateRandomVector(size));
    }

    public int CalcVectorSum()
    {
        if (Vector.Count == 0) throw new Exception("Вектор не сгенерирован");
        int sum = 0;
        for (int i = 0; i < Vector.Count; i++)
        {
            sum += Vector[i];
        }
        return sum;
    }

    public async Task<int> CalcVectorSumAsync()
    {
        return await Task.Run(() => CalcVectorSum());
    }

    public string GetSystemDate()
    {
        return DateTime.Now.ToString();
    }

    public async Task<string> GetSystemDateAsync()
    {
        return await Task.Run(() => GetSystemDate());
    }
    
    public string VectorToString()
    {
        string result = "";
        for (int i = 0; i < Vector.Count; i++)
        {
            if (i > 100)
            {
                result += "...";
                break;
            }
            result += $"{Vector[i].ToString()}, ";
        }
        return result;
    }
}