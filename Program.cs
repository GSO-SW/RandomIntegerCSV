// See https://aka.ms/new-console-template for more information
string resultPath = @"../../../input.csv";
int quantity = 10000000;
int minValue = -100;
int maxValue = 100;

// Generate numbers
Random numberGenerator = new Random();
int[] result = new int[quantity];
for (int i = 0; i < quantity; i++)
{
    var number = numberGenerator.Next(minValue, maxValue);
    result[i] = number;
}

// Save numbers to file
using (FileStream stream = File.Open(resultPath, FileMode.Create))
{
    using (StreamWriter writer = new StreamWriter(stream))
    {
        for (int i = 0; i < result.Length - 1; i++)
        {
            writer.Write(result[i] + ",");
        }
        writer.Write(result[result.Length - 1]);
    }
}
