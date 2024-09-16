﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace AccountingApp
{
    /// <summary>
    /// DashboardPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DashboardPage : Page
    {
        public ObservableCollection<Transaction> Transactions { get; set; }

        public DashboardPage()
        {
            InitializeComponent();
            Transactions = new ObservableCollection<Transaction>();
            LoadTransactions();
            DataContext = this;
        }

        private void LoadTransactions()
        {
            Transactions.Add(new Transaction 
            { 
                Date = DateTime.Now, 
                Description = "점심", 
                Amount = -10000, 
                Category = "식비", 
                PaymentMethod = "신용카드" 
            }); // 임시 예시: 오늘의 점심 식사 지출

            Transactions.Add(new Transaction 
            { 
                Date = DateTime.Now.AddDays(-1), 
                Description = "월급", 
                Amount = 3000000, 
                Category = "급여", 
                PaymentMethod = "계좌이체" 
            }); // 임시 예시: 어제 받은 월급

            Transactions.Add(new Transaction 
            { 
                Date = DateTime.Now.AddDays(-2), 
                Description = "적금", 
                Amount = -500000, 
                Category = "저축", 
                PaymentMethod = "자동이체" 
            }); // 임시 예시: 이틀 전 적금 납입
        }
    }
}
