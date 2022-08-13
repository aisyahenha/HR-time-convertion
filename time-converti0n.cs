/*
Given a 12 time in

-hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock. 

*/
/*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string tmpFormat = s.Substring(8,2);
        int H =int.Parse(s. Substring(0,2)) ;
        string mAndS = s.Substring(2,6);
        if(tmpFormat =="PM"){
            H = (H == 12)? 12: H+12;         
            
        }
        else if(tmpFormat =="AM"){
            H = (H == 12)? - 12: H;         
            
        }
        string convsetion = H.ToString()+mAndS;
        return convsetion;

    }
