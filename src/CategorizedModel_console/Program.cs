
// This file was auto-generated by ML.NET Model Builder. 

using CategorizedModel_console;


// This file was auto-generated by ML.NET Model Builder. 


using System;

using Google.Apis;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
Console.WriteLine("Enter link here:");
string url = Console.ReadLine();
string toFind1 = "?v=";
string toFind2 = "&ab";
int start = url.IndexOf(toFind1) + toFind1.Length;
int end = url.IndexOf(toFind2, start); //Start after the index of 'my' since 'is' appears twice
if (end == -1)
{
    end = url.Length;
}
string string2 = url.Substring(start, end - start);
using (var youtubeService = new YouTubeService(new BaseClientService.Initializer()
{
    ApiKey = "AIzaSyAtOeh2lPTmqQ6Ncw1Jn1zRi0deYAaTqEo",
}))
{
    var searchRequest = youtubeService.Videos.List("snippet");
    searchRequest.Id = string2;
    var searchResponse = await searchRequest.ExecuteAsync();

    var youTubeVideo = searchResponse.Items.FirstOrDefault();
    if (youTubeVideo != null)
    {
        string Title1 = youTubeVideo.Snippet.Title;
        string Description1 = youTubeVideo.Snippet.Description;

        MLModel.ModelInput sampleData = new MLModel.ModelInput()
        {
            Title = @Title1,
            Description = @Description1,
        };




        // Make a single prediction on the sample data and print results
        var predictionResult = MLModel.Predict(sampleData);

        Console.WriteLine("Using model to make single prediction -- \n\n");
        Console.WriteLine($"Title: {@Title1}");
        Console.WriteLine($"Description: {Description1}");

        Console.WriteLine($"\n\nPredicted Category: {predictionResult.PredictedLabel}\n\n");
        Console.WriteLine("=============== End of process, hit any key to finish ===============");
        Console.ReadKey();




    }
}







