﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormControls;
using DarkUI;
using DarkUI.Controls;
using Models;

namespace IBS
{
    public partial class IntersectBalanceSystem : DarkUI.Forms.DarkForm
    {
        public IntersectBalanceSystem()
        {
            InitializeComponent();
        }

        //Creating Labels
        static DarkLabel titleLbl = new DarkLabel();
        static DarkLabel AttackLbl = new DarkLabel();
        static DarkLabel defenseLbl = new DarkLabel();
        static DarkLabel magicAttackLbl = new DarkLabel();
        static DarkLabel magicDefenseLbl = new DarkLabel();
        static DarkLabel speedLbl = new DarkLabel();
        static DarkLabel hitPointsLbl = new DarkLabel();
        static DarkLabel baseDamageLbl = new DarkLabel();
        static DarkLabel criticalFactorLbl = new DarkLabel();
        static DarkLabel scallingStatLbl = new DarkLabel();
        static DarkLabel scallingFactorLbl = new DarkLabel();
        static DarkLabel pointsLbl = new DarkLabel();
        static DarkLabel maxPointsLbl = new DarkLabel();
        static DarkLabel maxLevelLbl = new DarkLabel();
        static DarkLabel expBaseLbl = new DarkLabel();
        static DarkLabel expFactorLbl = new DarkLabel();

        //Creating NumericsUpDown
        static DarkNumericUpDown attackNum = new DarkNumericUpDown();
        static DarkNumericUpDown defenseNum = new DarkNumericUpDown();
        static DarkNumericUpDown magicAttackNum = new DarkNumericUpDown();
        static DarkNumericUpDown magicDefenseNum = new DarkNumericUpDown();
        static DarkNumericUpDown speedNum = new DarkNumericUpDown();
        static DarkNumericUpDown hitPointsNum = new DarkNumericUpDown();
        static DarkNumericUpDown baseDamageNum = new DarkNumericUpDown();
        static DarkNumericUpDown criticalFactorNum = new DarkNumericUpDown();
        static DarkComboBox scallingStatCbo = new DarkComboBox();
        static DarkNumericUpDown scallingFactorNum = new DarkNumericUpDown();
        static DarkNumericUpDown pointsNum = new DarkNumericUpDown();
        static DarkNumericUpDown maxPointsNum = new DarkNumericUpDown();
        static DarkNumericUpDown maxLevelNum = new DarkNumericUpDown();
        static DarkNumericUpDown expBaseNum = new DarkNumericUpDown();
        static DarkNumericUpDown expFactorNum = new DarkNumericUpDown();

        DataGridView player = new DataGridView();

        private void Form1_Load(object sender, EventArgs e)
        {
            var updating = new Updating();
            CreatingLabels();
            CreatingNums();
            CreatingDataGrid();
            updating.MaxRow(GetStatus(6), player);
        }

        private void CreatingLabels()
        {
            Labels.NewLabel(titleLbl, 10, 10, "Basic Character Status");
            Controls.Add(titleLbl);

            Labels.NewLabel(AttackLbl, 10, 40, "Attack:");
            Controls.Add(AttackLbl);

            Labels.NewLabel(defenseLbl, 10, 70, "Defense:");
            Controls.Add(defenseLbl);
            
            Labels.NewLabel(magicAttackLbl, 10, 100, "Magic Attack:");
            Controls.Add(magicAttackLbl);
            
            Labels.NewLabel(magicDefenseLbl, 10, 130, "Magic Defense:");
            Controls.Add(magicDefenseLbl);
            
            Labels.NewLabel(speedLbl, 10, 160, "Speed:");
            Controls.Add(speedLbl);

            Labels.NewLabel(hitPointsLbl, 10, 190, "Hit Points:");
            Controls.Add(hitPointsLbl);

            Labels.NewLabel(baseDamageLbl, 10, 220, "Base Damage:");
            Controls.Add(baseDamageLbl);
            
            Labels.NewLabel(criticalFactorLbl, 10, 250, "Critical Factor:");
            Controls.Add(criticalFactorLbl);
            
            Labels.NewLabel(scallingStatLbl, 10, 280, "Scalling Status:");
            Controls.Add(scallingStatLbl);
            
            Labels.NewLabel(scallingFactorLbl, 10, 310, "Scalling Factor:");
            Controls.Add(scallingFactorLbl);
            
            Labels.NewLabel(pointsLbl, 10, 340, "Points by Level:");
            Controls.Add(pointsLbl);
            
            Labels.NewLabel(maxPointsLbl, 10, 370, "Max Points:");
            Controls.Add(maxPointsLbl);
            
            Labels.NewLabel(maxLevelLbl, 10, 400, "Max Level:");
            Controls.Add(maxLevelLbl);
            
            Labels.NewLabel(expBaseLbl, 10, 430, "Exp Base:");
            Controls.Add(expBaseLbl);
            
            Labels.NewLabel(expFactorLbl, 10, 460, "Exp Factor:");
            Controls.Add(expFactorLbl);
        }

        private void CreatingNums()
        {
            NumericUpDowns.NewNumeric(attackNum, 100, 36, 1, 0, 32767);
            Controls.Add(attackNum);

            NumericUpDowns.NewNumeric(defenseNum, 100, 66, 1, 0, 32767);
            Controls.Add(defenseNum);

            NumericUpDowns.NewNumeric(magicAttackNum, 100, 96, 1, 0, 32767);
            Controls.Add(magicAttackNum);

            NumericUpDowns.NewNumeric(magicDefenseNum, 100, 126, 1, 0, 32767);
            Controls.Add(magicDefenseNum);

            NumericUpDowns.NewNumeric(speedNum, 100, 156, 1, 0, 32767);
            Controls.Add(speedNum);

            NumericUpDowns.NewNumeric(hitPointsNum, 100, 186, 1, 0, 32767);
            Controls.Add(hitPointsNum);

            NumericUpDowns.NewNumeric(baseDamageNum, 100, 216, 1, 0, 32767);
            Controls.Add(baseDamageNum);

            NumericUpDowns.NewNumeric(criticalFactorNum, 100, 246, 1, 0, 1, true);
            Controls.Add(criticalFactorNum);

            scallingStatCbo.Location = new Point(100, 276);
            scallingStatCbo.Items.Insert(0, "Attack");
            scallingStatCbo.Items.Insert(1, "Defense");
            scallingStatCbo.Items.Insert(2, "Magic Attack");
            scallingStatCbo.Items.Insert(3, "Magic Defense");
            scallingStatCbo.Items.Insert(4, "Speed");
            scallingStatCbo.SelectedIndex = 0;
            Controls.Add(scallingStatCbo);

            NumericUpDowns.NewNumeric(scallingFactorNum, 100, 306, 1, 0, 1, true);
            Controls.Add(scallingFactorNum);

            NumericUpDowns.NewNumeric(pointsNum, 100, 336, 1, 0, 32767);
            Controls.Add(pointsNum);

            NumericUpDowns.NewNumeric(maxPointsNum, 100, 366, 1, 0, 32767);
            Controls.Add(maxPointsNum);

            NumericUpDowns.NewNumeric(maxLevelNum, 100, 396, 1, 0, 500);
            Controls.Add(maxLevelNum);

            NumericUpDowns.NewNumeric(expBaseNum, 100, 426, 1, 0, 32767);
            Controls.Add(expBaseNum);

            NumericUpDowns.NewNumeric(expFactorNum, 100, 456, 1, 0, 1, true);
            Controls.Add(expFactorNum);
        }

        private void CreatingDataGrid()
        {
            DataGridViews.NewDataGrid(player, 230, 36, 1110, 440, "PlayerGrid");
            Controls.Add(player);
        }

        public static int GetStatus(int code)
        {
            int value = 0;
            switch (code)
            {
                case 0:
                    value = (int)attackNum.Value;
                    break;
                case 1:
                    value = (int)defenseNum.Value;
                    break;
                case 2:
                    value = (int)magicAttackNum.Value;
                    break;
                case 3:
                    value = (int)magicDefenseNum.Value;
                    break;
                case 4:
                    value = (int)speedNum.Value;
                    break;
                case 5:
                    value = (int)hitPointsNum.Value;
                    break;
                case 6:
                    value = (int)maxLevelNum.Value;
                    break;
            }
            return value;
        }
    }
}
