using System;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog;
using Encog.Persist;
using Encog.ML.Data.Versatile.Sources;
using Encog.Util.CSV;
using Encog.ML.Data.Versatile;
using Encog.ML.Data.Versatile.Columns;
using Encog.ML.Model;
using Encog.ML.Factory;
using Encog.ML;
using System.IO;

namespace FakeAccountPrediction
{
    class Prediction
    {
        NormalizationHelper helper;
        IMLRegression bestMethod;
        
        public void traning(string traningexamplespath)
        {
            IVersatileDataSource source = new CSVDataSource(traningexamplespath, false, CSVFormat.DecimalPoint);
            var data = new VersatileMLDataSet(source);
            data.DefineSourceColumn("num1", 0, ColumnType.Continuous);
            data.DefineSourceColumn("num2", 1, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 2, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 3, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 4, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 5, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 6, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 7, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 8, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 9, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 10, ColumnType.Continuous);
            data.DefineSourceColumn("num1", 11, ColumnType.Continuous);
            ColumnDefinition outputColumn = data.DefineSourceColumn("kind", 12, ColumnType.Nominal);
            data.Analyze();
            data.DefineSingleOutputOthersInput(outputColumn);


            var model = new EncogModel(data);
            model.SelectMethod(data, MLMethodFactory.TypeFeedforward);

            // Send any output to the console.
            model.Report = new ConsoleStatusReportable();

            // Now normalize the data.  Encog will automatically determine the correct normalization
            // type based on the model you chose in the last step.
            data.Normalize();

            model.HoldBackValidation(0.3, true, 1001);

            // Choose whatever is the default training type for this model.
            model.SelectTrainingType(data);

            // Use a 5-fold cross-validated train.  Return the best method found.
            bestMethod = (IMLRegression)model.Crossvalidate(5, true);

            //Console.WriteLine(@"Training error: " + model.CalculateError(bestMethod, model.TrainingDataset));
            //Console.WriteLine(@"Validation error: " + model.CalculateError(bestMethod, model.ValidationDataset));

            // Display our normalization parameters.
            helper = data.NormHelper;
           // Console.WriteLine(helper.ToString());

            // Display the final model.
            //Console.WriteLine(@"Final model: " + bestMethod);
            source.Close();

            saveNetwork("save.eg");
            savehelper("helper.hp");
            //EncogFramework.Instance.Shutdown();
        }
        public int loadNetwork(string name)
        {
            try
            {

                System.IO.FileInfo info = new System.IO.FileInfo(name);
                bestMethod = (IMLRegression)EncogDirectoryPersistence.LoadObject(info);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int saveNetwork(string name)
        {
            try
            {
                System.IO.FileInfo info = new System.IO.FileInfo(name);

                EncogDirectoryPersistence.SaveObject(info, bestMethod);
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }
        public int loadHelper(string name)
        {
            try
            {

                
                helper = ReadFromBinaryFile<NormalizationHelper>(name);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int savehelper(string name)
        {
            try
            {
                WriteToBinaryFile(name, helper);

                
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public Prediction()
        {

        }
        public string test(double[] testInput)
        {
            loadNetwork("save.eg");
            loadHelper("helper.hp");
            
            //var csv = new ReadCSV("t.csv", false, CSVFormat.DecimalPoint);
            var line = new String[12];
            IMLData input = helper.AllocateInputVector();

            
            line[0] = testInput[0].ToString();
            line[1] = testInput[1].ToString();
            line[2] = testInput[2].ToString();
            line[3] = testInput[3].ToString();
            line[4] = testInput[4].ToString();
            line[5] = testInput[5].ToString();
            line[6] = testInput[6].ToString();
            line[7] = testInput[7].ToString();
            line[8] = testInput[8].ToString();
            line[9] = testInput[9].ToString();
            line[10] = testInput[10].ToString();
            line[11] = testInput[11].ToString();
            //String correct = csv.Get(12);
            helper.NormalizeInputVector(line, ((BasicMLData)input).Data, false);
            IMLData output = bestMethod.Compute(input);
            return helper.DenormalizeOutputVectorToString(output)[0];

            
        }
        /// <summary>
        /// Writes the given object instance to a binary file.
        /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
        /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the XML file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the XML file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the XML.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }

}
