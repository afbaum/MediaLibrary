using System;
namespace MediaLibrary
{
    class MediaType
    {
        public string Title {get; private set;}
        public bool OnLoan {get; private set;} = false;
        public string Lonee {get; private set;} = "";

        public string OnLoanDisplayText 
        {
            get
            {
                if (OnLoan)
                {
                    if (!string.IsNullOrEmpty(Lonee))
                    {
                        return " Currently on loan to " + Lonee;
                    }
                    else
                    {
                        return " Currently on loan ";
                    }
                }
                else 
                {
                    return "";
                }
            }
        }

        public MediaType(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception();
            }
            Title = title;
        }
        public void Loan(string lonee)
        {
            Lonee = lonee;
            Loan();
        }

        public void Loan()
        {
            OnLoan = true;
        }

        public void Return()
        {
            Lonee = null;
            OnLoan = false;
        }
    }
}