using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class QuestionDataList
{
    public List<QuestionData> data;

    public QuestionDataList(List<QuestionData> data){
        this.data = data;
    }
}

[System.Serializable]
public class QuestionData
{
    public string content;
    public string type;
    public int rank;
    public List<AnswerData> questionAnswers;


    public QuestionData(string content, string type, int rank, List<AnswerData> questionAnswers){
        this.content = content;
        this.type = type;
        this.rank = rank;
        this.questionAnswers = questionAnswers;
    }
}

[System.Serializable]
public class AnswerData
{
    public string content;
    public string type;
    public bool correct;

    public AnswerData(string content, string type, bool correct){
        this.content = content;
        this.type = type;
        this.correct = correct;
    }
}
public static class IListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
public class APIQuestion : MonoBehaviour
{
    private const string API_URL = "http://localhost:5054/quiz/GetQuizQuestion/1";
    public QuestionDataList questionDataList;

    public void Start()
    {
        //StartCoroutine(GetDataFromAPI());

        List<QuestionData> data = new List<QuestionData>();
        

        AnswerData answer1 = new AnswerData("Yes", "1", false);
        AnswerData answer2 = new AnswerData("No", "1", true);
        List<AnswerData> questionAnsw = new List<AnswerData>{answer1,answer2};
        QuestionData question1 = new QuestionData("Can a variable name start with number in C?", "1", 1,questionAnsw);
        data.Add(question1);


        AnswerData answer3 = new AnswerData("Yes", "1", true);
        AnswerData answer4 = new AnswerData("No", "1", false);
        List<AnswerData> questionAnsw2 = new List<AnswerData>{answer3,answer4};
        QuestionData question2 = new QuestionData("Int data type’s format specifiers are the %d and %I? ", "1", 1,questionAnsw2);
        data.Add(question2);


        AnswerData answer5 = new AnswerData("Int", "1", true);
        AnswerData answer6   = new AnswerData("Float", "1", false);
        List<AnswerData> questionAnsw3 = new List<AnswerData>{answer5,answer6};
        QuestionData question3 = new QuestionData("Which data type is used to store whole numbers in C?", "1", 1,questionAnsw3);
        data.Add(question3);


        AnswerData answer7 = new AnswerData("4 bytes ", "1", true);
        AnswerData answer8   = new AnswerData("8 bytes ", "1", false);
        List<AnswerData> questionAnsw4 = new List<AnswerData>{answer7,answer8};
        QuestionData question4 = new QuestionData("What is the size of the float data type in C?", "1", 1,questionAnsw4);
        data.Add(question4);


        AnswerData answer9 = new AnswerData("Float", "1", false);
        AnswerData answer10   = new AnswerData("Char ", "1", true);
        List<AnswerData> questionAnsw5 = new List<AnswerData>{answer9,answer10};
        QuestionData question5 = new QuestionData("Which data type is used to store characters in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer9 = new AnswerData("4 bytes", "1", false);
        answer10   = new AnswerData("8 bytes", "1", true);
        questionAnsw5 = new List<AnswerData>{answer9,answer10};
        question5 = new QuestionData("What is the size of the double data type in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer9 = new AnswerData("int", "1", false);
        answer10   = new AnswerData("long ", "1", true);
        questionAnsw5 = new List<AnswerData>{answer9,answer10};
        question5 = new QuestionData("Which data type is used to store large whole numbers in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer9 = new AnswerData("%d ", "1", false);
        answer10   = new AnswerData("%f", "1", true);
        questionAnsw5 = new List<AnswerData>{answer9,answer10};
        question5 = new QuestionData("Which format specifier is used to print a floating-point number in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer9 = new AnswerData("%d ", "1", false);
        answer10   = new AnswerData("%u ", "1", true);
        questionAnsw5 = new List<AnswerData>{answer9,answer10};
        question5 = new QuestionData("What is the format specifier used to print an unsigned integer in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer9 = new AnswerData("The fprintf() function is used to write formatted data to a file", "1", false);
        answer10   = new AnswerData("The fopen() function is used to read formatted data", "1", true);
        questionAnsw5 = new List<AnswerData>{answer9,answer10};
        question5 = new QuestionData("Which of the following statements is incorrect regarding file handling in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer8 = new AnswerData("%c ", "1", true);
        answer9 = new AnswerData("%d ", "1", false);
        answer10   = new AnswerData("%f", "1", false);
        questionAnsw5 = new List<AnswerData>{answer8,answer9,answer10};
        question5 = new QuestionData("What is the format specifier used to print a character in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer8 = new AnswerData("float", "1", false);
        answer9 = new AnswerData("Char", "1", false);
        answer10   = new AnswerData("bool", "1", true);
        questionAnsw5 = new List<AnswerData>{answer8,answer9,answer10};
        question5 = new QuestionData("Which data type is used to store true/false values in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer8 = new AnswerData("Double is used to hold real numbers", "1", true);
        answer9 = new AnswerData("Double is used to hold characters", "1", false);
        answer10   = new AnswerData("Double is used to hold integers ", "1", true);
        questionAnsw5 = new List<AnswerData>{answer8,answer9,answer10};
        question5 = new QuestionData("What is the role of the double data type?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer8 = new AnswerData("1 byte", "1", true);
        answer9 = new AnswerData("2 bytes ", "1", false);
        answer10   = new AnswerData("4 bytes ", "1", false);
        questionAnsw5 = new List<AnswerData>{answer8,answer9,answer10};
        question5 = new QuestionData("What is the size of a char variable?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer8 = new AnswerData("fopen()", "1", true);
        answer9 = new AnswerData("fread()", "1", false);
        answer10   = new AnswerData("fwrite()", "1", false);
        questionAnsw5 = new List<AnswerData>{answer8,answer9,answer10};
        question5 = new QuestionData("Which function is used to open a file in C?", "1", 1,questionAnsw5);
        data.Add(question5);


        answer8 = new AnswerData("The printf() sends formatted output to the screen ", "1", false);
        answer9 = new AnswerData("The scanf() is an output function ", "1", true);
        answer10   = new AnswerData("To use printf() we need to include the stdio.h library ", "1", false);
        questionAnsw5 = new List<AnswerData>{answer8,answer9,answer10};
        question5 = new QuestionData("The wrong statement indicates what direction you must go.", "1", 1,questionAnsw5);
        data.Add(question5);

        
        questionDataList = new QuestionDataList(data);

            foreach (QuestionData questionData in questionDataList.data)
            {
                Debug.Log("Question: " + questionData.content);
                foreach (AnswerData answerData in questionData.questionAnswers)
                {
                    Debug.Log("Answer: " + answerData.content);
                }
            }
        
    }

    public IEnumerator GetDataFromAPI()
    {
        UnityWebRequest request = UnityWebRequest.Get(API_URL);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            string response = request.downloadHandler.text;
            // Process the response data
            Debug.Log(response);

            // Deserialize JSON response
            questionDataList = JsonUtility.FromJson<QuestionDataList>(response);

            // Display the questions and answers
            foreach (QuestionData questionData in questionDataList.data)
            {
                Debug.Log("Question: " + questionData.content);
                foreach (AnswerData answerData in questionData.questionAnswers)
                {
                    Debug.Log("Answer: " + answerData.content);
                }
            }
        }
        else
        {
            Debug.LogError("Error: " + request.error);
        }
    }

    public QuestionData Get2AnswersQuestion(){
        IListExtensions.Shuffle<QuestionData>(questionDataList.data);
        foreach(QuestionData questionData in  questionDataList.data){
            
            if(questionData.questionAnswers.Count == 2){
  
                List<AnswerData>newOrder = new List<AnswerData>();
                if(questionData.questionAnswers[0].correct == true){
                    newOrder.Add(questionData.questionAnswers[0]);
                    newOrder.Add(questionData.questionAnswers[1]);
                }else{
                    newOrder.Add(questionData.questionAnswers[1]);
                    newOrder.Add(questionData.questionAnswers[0]);
                }
                questionData.questionAnswers = newOrder;
                //questionDataList.data.Remove(questionData);
                return questionData;
            }
        }
        return null;
    }

    public QuestionData Get3AnswersQuestion(){
        IListExtensions.Shuffle<QuestionData>(questionDataList.data);
        foreach(QuestionData questionData in questionDataList.data){
            
            if(questionData.questionAnswers.Count == 3){
                Debug.Log("PIROS");
                List<AnswerData>newOrder = new List<AnswerData>();

                if(questionData.questionAnswers[0].correct == true){
                    newOrder.Add(questionData.questionAnswers[0]);
                    newOrder.Add(questionData.questionAnswers[1]);
                    newOrder.Add(questionData.questionAnswers[2]);
                }else if(questionData.questionAnswers[1].correct == true){
                    newOrder.Add(questionData.questionAnswers[1]);
                    newOrder.Add(questionData.questionAnswers[0]);
                    newOrder.Add(questionData.questionAnswers[2]);
                }else{
                    newOrder.Add(questionData.questionAnswers[2]);
                    newOrder.Add(questionData.questionAnswers[0]);
                    newOrder.Add(questionData.questionAnswers[1]);
                }
                questionData.questionAnswers = newOrder;
                //questionDataList.data.Remove(questionData);
                return questionData;
            }
        }
        return null;
    }    

}