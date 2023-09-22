using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{   // ------------------------------------------ The following code will be to display my birth MONTH. --------------------------------------------------------
    int totalMonths = 12;                               // total number of months per year (12 months).
    int bdayMonth = 8;                                  // my birthday month (August).

    int sum = 1;                                        // adds 1 to the count, thus progressing one month per loop.
    int count = 1;                                      // starts at January 1st 

    // Start is called before the first frame update
    void Start()
    {
       while (sum <= totalMonths)                       // while loop will stop at the 12th month.
        {
            Debug.Log(sum);                             // presents the current number within the Console (starts at 1).
            sum += count;                               // the command that adds +1 every loop.
            {
                if (sum == bdayMonth)                   // if the number equals my birth month (August / 8th month), then it will trigger
                {                                       // the following:
                    sum += 1;                           // adds an extra +1 to skip displaying the number of my birth month.
                    Debug.Log("It's my birthday!");     // the text will display "It's my birthday!" once reaching the 8th month.
                }
            }
        }
    }
    // ------------------------------------------ The following code will be to display my birth DATE. --------------------------------------------------------
    int totalDays = 31;                                 // total number of days within my birth month (August).
    int bdayDate = 27;                                  // my birth date (August 27th).

    int sumOfDays = 1;                                  // adds 1 to the countOfDays, thus progressing one day per loop.
    int countOfDays = 1;                                // starts August 1st.

    // Start is called before the first frame update
    void Update()
    {
        while (sumOfDays <= totalDays)                  // while loop will stop at the 31st of August.
        {
            Debug.Log(sumOfDays);                       // presents the current number within the Console (starts at 1).
            sumOfDays += countOfDays;                   // the command that adds +1 every loop.
            {
                if (sumOfDays == bdayDate)              // if the number equals my birth date (27th), then it will trigger the
                {                                       // following:
                    sumOfDays += 1;                     // adds an extra +1 to skip displaying the number of my birth date.
                    Debug.Log("It's my birthday!");     // the text will display "It's my birthday!" once reaching the 27th day of August.
                }
            }
        }
    }
}