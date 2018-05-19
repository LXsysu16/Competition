﻿using Competition.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition.ViewModels
{
    class AthleteVM
    {
        private Athlete selectedItem;

        public AthleteVM()
        {
            this.selectedItem = null;
        }

        public Athlete SelectedItem
        {
            get { return selectedItem; }
            set { this.selectedItem = value; }
        }

        private ObservableCollection<Athlete> allAthletes = new ObservableCollection<Athlete>(
            new[]
            {
                new Athlete("序号","姓名","性别","身份证号","手机号","积分","种子序号"),
                new Athlete("1","刘亚辉","男","410804199805280035","15989067460","10","2")
            });
        public ObservableCollection<Athlete> AllAthletes { get { return this.allAthletes; } }

        public void AddAthlete(string index, string name, string sex, string idNum, string phoneNum, string score, string seedNum)
        {
            allAthletes.Add(new Athlete(index, name, sex, idNum, phoneNum, score, seedNum));
        }

        public void RemoveAthlete(Athlete SelectedItem1)
        {
            allAthletes.Remove(SelectedItem);
        }

        public void UpdataAthlete(string index, string name, string sex, string idNum, string phoneNum, string score, string seedNum)
        {
            selectedItem.index = index;
            selectedItem.name = name;
            selectedItem.sex = sex;
            selectedItem.idNum = idNum;
            selectedItem.phoneNum = phoneNum;
            selectedItem.score = score;
            selectedItem.seedNum = seedNum;
        }
    }
}