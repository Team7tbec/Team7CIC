# Team7tbec

This is Team7's repository for Think Beyond Exams Challenge

Members include Kritika Verma, Yash Tomar and Siddhartha Mahajan.

We've learned how to retrieve data from YouTube.

We have also made a custom categorized dataset using the YouTube Data API and web scraping. We have a ML model trained on the same

# Vision (How will we solve the problem.)
We will start by looking and analysing already existing projects, papers etc. on the theme. We'll try to access or retrieve data of YouTube videos from YouTube itself using the video link. We'll try to make a model or better yet find an already existing model and mould or train it according to our requirements. We'll then try to do classification of our data into educational and non-eduational. If our classification, we'll proceed to catagorizing the data into sub-categories. Then to integrate the whole project, we'll try to create an extension or website to bring everything together. The website or extension can make user access our model and use it to classify and categorize the YouTube videos they want to.

# Our Final Demo
We'll provide a demo video in which we'll show the classification and result our model gives after entering the URL of a YouTube video or the video id by classifying the video into educational or non-educational and then further categorising the educational video into sub-categories like music, coding, business etc. We will also show the model we found or made and the dataset we used to train it. YouTube link: https://youtu.be/12t6aiNIQb4

# Tech Stack and Methodology
- We first used the Youtube Data V3 API in Python to get the YouTube video data from a url or video-id.
- We then used a pre-existing dataset found on Kaggle and modified it to our uses, classifying the data in Educational and Non-Educational class.
- We then used the ML.NET model builder in Visual Studio, provided in .NET packages by Microsoft. It uses C#. We converted the output into a console application and added an icon for easier identification
- For the sub-categorized model we were not able to find any dataset and made our own categorized dataset using web scraping and the YouTube Data V3 API in Python, and then after readying the dataset for model training, trained a model on ML.NET model builder and converted it into console application too.
- We then made a basic website using HTML, CSS and bootstrap to display a download link for our project. We hosted the website with the help of netlify and added the custom domain name of team7cic.co which we obtained for free due to swags from Hack2Educate.
