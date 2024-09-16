using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace AccountingApp
{
    public partial class ReportPage : Page
    {
        public ReportPage()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            LoadStatisticsChart();
            LoadMonthlyIncomeExpenseChart();
            LoadQuarterlyYearlyAnalysisChart();
            LoadCategorySpendingChart();
            LoadIncomeExpenseTrendChart();
            LoadAnomalousSpendingData();
            LoadBudgetPerformanceChart();
            LoadPaymentMethodChart();
            LoadBalanceTrendChart();
        }

        private void LoadStatisticsChart()
        {
            StatisticsPieChart.Series = new SeriesCollection
            {
                new PieSeries { Title = "수입", Values = new ChartValues<double> { 75 } },
                new PieSeries { Title = "지출", Values = new ChartValues<double> { 25 } }
            };
        }

        private void LoadMonthlyIncomeExpenseChart()
        {
            MonthlyIncomeExpenseChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "수입",
                    Values = new ChartValues<double> { 100, 120, 110, 130, 150, 140 }
                },
                new LineSeries
                {
                    Title = "지출",
                    Values = new ChartValues<double> { 80, 90, 85, 95, 100, 110 }
                }
            };

            MonthlyIncomeExpenseChart.AxisX.Add(new Axis
            {
                Title = "월",
                Labels = new[] { "1월", "2월", "3월", "4월", "5월", "6월" }
            });

            MonthlyIncomeExpenseChart.AxisY.Add(new Axis
            {
                Title = "금액",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void LoadQuarterlyYearlyAnalysisChart()
        {
            QuarterlyYearlyAnalysisChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "수입",
                    Values = new ChartValues<double> { 300, 450, 380, 520 }
                },
                new ColumnSeries
                {
                    Title = "지출",
                    Values = new ChartValues<double> { 250, 350, 300, 400 }
                }
            };

            QuarterlyYearlyAnalysisChart.AxisX.Add(new Axis
            {
                Title = "분기",
                Labels = new[] { "1분기", "2분기", "3분기", "4분기" }
            });

            QuarterlyYearlyAnalysisChart.AxisY.Add(new Axis
            {
                Title = "금액 (만원)",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void LoadCategorySpendingChart()
        {
            CategorySpendingChart.Series = new SeriesCollection
            {
                new PieSeries { Title = "식비", Values = new ChartValues<double> { 30 } },
                new PieSeries { Title = "주거비", Values = new ChartValues<double> { 25 } },
                new PieSeries { Title = "교통비", Values = new ChartValues<double> { 15 } },
                new PieSeries { Title = "여가", Values = new ChartValues<double> { 20 } },
                new PieSeries { Title = "기타", Values = new ChartValues<double> { 10 } }
            };
        }

        private void LoadIncomeExpenseTrendChart()
        {
            IncomeExpenseTrendChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "수입",
                    Values = new ChartValues<double> { 100, 120, 110, 130, 150, 140, 160 }
                },
                new LineSeries
                {
                    Title = "지출",
                    Values = new ChartValues<double> { 80, 90, 85, 95, 100, 110, 105 }
                }
            };

            IncomeExpenseTrendChart.AxisX.Add(new Axis
            {
                Title = "월",
                Labels = new[] { "1월", "2월", "3월", "4월", "5월", "6월", "7월" }
            });

            IncomeExpenseTrendChart.AxisY.Add(new Axis
            {
                Title = "금액 (만원)",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void LoadAnomalousSpendingData()
        {
            var anomalousSpending = new List<AnomalousSpending>
            {
                new AnomalousSpending { Date = DateTime.Now, Category = "식비", Amount = 100000, Difference = "+50%" },
                new AnomalousSpending { Date = DateTime.Now.AddDays(-1), Category = "교통비", Amount = 50000, Difference = "+100%" },
                new AnomalousSpending { Date = DateTime.Now.AddDays(-2), Category = "여가", Amount = 200000, Difference = "+150%" }
            };

            AnomalousSpendingGrid.ItemsSource = anomalousSpending;
        }

        private void LoadBudgetPerformanceChart()
        {
            BudgetPerformanceChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "예산",
                    Values = new ChartValues<double> { 100, 80, 60, 40, 20 }
                },
                new ColumnSeries
                {
                    Title = "실제 지출",
                    Values = new ChartValues<double> { 90, 85, 55, 45, 15 }
                }
            };

            BudgetPerformanceChart.AxisX.Add(new Axis
            {
                Title = "카테고리",
                Labels = new[] { "식비", "주거비", "교통비", "여가", "기타" }
            });

            BudgetPerformanceChart.AxisY.Add(new Axis
            {
                Title = "금액 (만원)",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void LoadPaymentMethodChart()
        {
            PaymentMethodChart.Series = new SeriesCollection
            {
                new PieSeries { Title = "현금", Values = new ChartValues<double> { 20 } },
                new PieSeries { Title = "신용카드", Values = new ChartValues<double> { 50 } },
                new PieSeries { Title = "체크카드", Values = new ChartValues<double> { 25 } },
                new PieSeries { Title = "기타", Values = new ChartValues<double> { 5 } }
            };
        }

        private void LoadBalanceTrendChart()
        {
            BalanceTrendChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "잔액",
                    Values = new ChartValues<double> { 100, 120, 115, 130, 140, 135, 150 }
                }
            };

            BalanceTrendChart.AxisX.Add(new Axis
            {
                Title = "월",
                Labels = new[] { "1월", "2월", "3월", "4월", "5월", "6월", "7월" }
            });

            BalanceTrendChart.AxisY.Add(new Axis
            {
                Title = "금액 (만원)",
                LabelFormatter = value => value.ToString("N0")
            });
        }
    }

    public class AnomalousSpending
    {
        public DateTime Date { get; set; }
        public string? Category { get; set; }
        public decimal Amount { get; set; }
        public string? Difference { get; set; }
    }
}