using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Praktosik4Csharp
{
    public class TestManager
    {
        private readonly string testDataFilePath;

        public TestManager(string testDataFilePath)
        {
            this.testDataFilePath = testDataFilePath;
        }

        public async Task SaveTestDataAsync(List<TestData> testData)
        {
            try
            {
                using (FileStream fs = new FileStream(testDataFilePath, FileMode.Create))
                {
                    await JsonSerializer.SerializeAsync(fs, testData);
                }
            }
            catch (Exception ex)
            {
                // Log or propagate the exception
                throw new DataSerializationException("Error saving test data.", ex);
            }
        }

        public async Task<List<TestData>> LoadTestDataAsync()
        {
            try
            {
                using (FileStream fs = new FileStream(testDataFilePath, FileMode.Open))
                {
                    return await JsonSerializer.DeserializeAsync<List<TestData>>(fs);
                }
            }
            catch (FileNotFoundException ex)
            {
                // Log or propagate the exception
                throw new DataFileNotFoundException("Test data file not found.", ex);
            }
            catch (Exception ex)
            {
                // Log or propagate the exception
                throw new DataDeserializationException("Error loading test data.", ex);
            }
        }
    }

    [DataContract]
    public class TestData
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Option1 { get; set; }

        [DataMember]
        public string Option2 { get; set; }

        [DataMember]
        public string Option3 { get; set; }

        [DataMember]
        public CorrectOption CorrectAnswer { get; set; }
    }

    public enum CorrectOption
    {
        Option1,
        Option2,
        Option3
    }

    [Serializable]
    public class DataSerializationException : Exception
    {
        public DataSerializationException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class DataDeserializationException : Exception
    {
        public DataDeserializationException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class DataFileNotFoundException : Exception
    {
        public DataFileNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}