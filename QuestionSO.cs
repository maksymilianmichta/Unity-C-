using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "NewQuestion", menuName = "Flight Quiz Question")]
public class QuestionSO : ScriptableObject 
{
    [TextArea (2,8)]
    [SerializeField] string question = "Enter new question here please sir ";
    [SerializeField] string [] answers = { "Answer 1 " , "Answer 2" , "Answer 3" , "Answer 4"} ;
    [SerializeField] int  correctAnswerID ;



 public string GetQuestion ()
 {
    
    
    return question;

 }

public int GetCorrectAnswerID()
{
    return correctAnswerID;

}

public string GetAnswer(int index)
{
    return answers[index]; 
}

}

