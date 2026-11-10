using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class Budget
    {
        private int id;
        private List<IService> totalServiceList;
        private DateTime startDate;
        private DateTime finishDate;
        private int amountOfAdultGuests;
        private int amountUnderAgeGuests;
        private StateEnum state;
        private Client client;

        public Budget(int id, List<IService> totalServiceList, DateTime startDate, DateTime finishDate,
            int amountOfAdultGuests, int amountUnderAgeGuests, StateEnum state, Client client)
        {
            Id = id;
            this.totalServiceList = totalServiceList;
            StartDate = startDate;
            FinishDate = finishDate;
            AmountOfAdultGuests = amountOfAdultGuests;
            AmountUnderAgeGuests = amountUnderAgeGuests;
            this.state = state;
            this.client = client;
        }

        public Budget(List<IService> totalServiceList, DateTime startDate, DateTime finishDate,
            int amountOfAdultGuests, int amountUnderAgeGuests, StateEnum state, Client client)
        {
            TotalServiceList = totalServiceList;
            StartDate = startDate;
            FinishDate = finishDate;
            AmountOfAdultGuests = amountOfAdultGuests;
            AmountUnderAgeGuests = amountUnderAgeGuests;
            this.state = state;
            this.client = client;
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                id = value;
            }
        }
        public List<IService> TotalServiceList
        {
            get { return totalServiceList; }
            set
            {
                if (value == null) { throw new ArgumentNullException(); }
                totalServiceList = value;
            }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
            }
        }
        public DateTime FinishDate
        {
            get { return finishDate; }
            set
            {
                finishDate = value;
            }
        }
        public int AmountOfAdultGuests
        {
            get { return amountOfAdultGuests; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                amountOfAdultGuests = value;
            }
        }
        public int AmountUnderAgeGuests
        {
            get { return amountUnderAgeGuests; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                amountUnderAgeGuests = value;
            }
        }

    }
}
