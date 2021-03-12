using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmMain : Form
    {
        Stack<string> BefInput = new Stack<string>();
        List<string> Infixlist;
        List<string> Postfixlist;

        bool error_flag = false;

        public FrmMain()
        {
            InitializeComponent();

            TxtCmd.KeyPress += TxtCmd_KeyPress;
        }

        #region 계산기 사용자 메서드 영역
        // exp -> 중위 리스트
        public void ExpressionToInfix(string expression)
        {
            char[] symbols = { '+', '-', '*', '/' };
            string tmp_result = null;

            bool num_flag = false;
            bool right_parentheses_flag = false;

            // 공백 제거
            expression = expression.Replace(" ", "");

            string tmp = null;
            for (int idx = 0; idx < expression.Length; idx++)
            {
                // 숫자 입력 (Ex : 15, 5.3)
                if ((expression[idx] >= '0' && expression[idx] <= '9') || (expression[idx] == '.'))
                {
                    for (int idx2 = idx; idx2 < expression.Length; idx2++)
                    {
                        if (expression[idx2] == '+' || expression[idx2] == '-' || expression[idx2] == '*' || expression[idx2] == '/'
                            || expression[idx2] == '(' || expression[idx2] == ')')
                        {
                            Infixlist.Add(tmp);
                            num_flag = true;
                            tmp = null;
                            break;
                        }
                        else
                        {
                            tmp += expression[idx2];
                            idx = idx2;

                            if (idx2 == expression.Length - 1)
                            {
                                Infixlist.Add(tmp);
                                tmp = null;
                                break;
                            }
                        }
                    }
                }

                else if (expression[idx] == '(' || expression[idx] == ')')
                {
                    Infixlist.Add(expression[idx].ToString());
                    num_flag = false;

                    if (expression[idx] == ')')
                        right_parentheses_flag = true;
                }
                else if (expression[idx] == '+' || expression[idx] == '-')
                {
                    // Ex : 3 + 5, ( ~~ ) - 2 => 그대로 연산자 입력
                    if (num_flag || right_parentheses_flag)
                        Infixlist.Add(expression[idx].ToString());
                    // Ex : + 5 , - 2 => (0+1) * 5 , (0-1) * 2 형태로 입력
                    else
                    {
                        Infixlist.Add("(");
                        Infixlist.Add("0");
                        Infixlist.Add(expression[idx].ToString());
                        Infixlist.Add("1");
                        Infixlist.Add(")");
                        Infixlist.Add("*");
                    }
                    num_flag = false;
                    right_parentheses_flag = false;
                }
                else if (expression[idx] == '*' || expression[idx] == '/')
                {
                    Infixlist.Add(expression[idx].ToString());
                    num_flag = false;
                    right_parentheses_flag = false;
                }
                else { }
            }
        }


        // 중위 리스트 -> 후위 리스트
        public void InfixToPostfix(List<string> Infixlist_)
        {

            // 연산자 저장 스택
            Stack<string> SymStack = new Stack<string>();
            while (Infixlist_.Count > 0)
            {
                string element = Infixlist_.ElementAt(0);
                Infixlist_.RemoveAt(0);

                if (element.Contains("+") || element.Contains("-"))
                {
                    if ((SymStack.Count != 0) && (SymStack.Peek().Contains("*") || SymStack.Peek().Contains("/")))
                    {
                        while (SymStack.Count > 0)
                            Postfixlist.Add(SymStack.Pop());

                        SymStack.Push(element);
                    }
                    else
                        SymStack.Push(element);
                }

                else if (element.Contains("*") || element.Contains("/"))
                {
                    SymStack.Push(element);
                }

                // 괄호 재귀 처리
                else if (element.Contains("("))
                {
                    int p_point = 1;

                    List<string> Infixlist2 = new List<string>();
                    while (Infixlist_.Count > 0)
                    {
                        string element2 = Infixlist_.ElementAt(0);
                        Infixlist_.RemoveAt(0);
                        // ( ~~ ( .. ) ~~ )
                        // '(' 만날 때 : + 1
                        if (element2.Contains("("))
                        {
                            p_point++;
                            Infixlist2.Add(element2);
                        }
                        // ')' 만날 때 : - 1 (0일 때 만나면 끝)
                        else if (element2.Contains(")"))
                        {
                            p_point--;
                            if (p_point == 0)
                            {
                                /*string tmp2 = null;
                                foreach (var tmp3 in Infixlist2)
                                    tmp2 += tmp3 + " ";
                                MessageBox.Show(tmp2, "괄호 리스트");*/

                                // 재귀 처리
                                InfixToPostfix(Infixlist2);
                                break;
                            }
                            else
                                Infixlist2.Add(element2);
                        }
                        else
                            Infixlist2.Add(element2);
                    }
                    // 괄호 갯수가 맞질 않음
                    if (p_point != 0)
                    {
                        MessageBox.Show("괄호 매칭이 올바르지 않습니다.", "괄호 에러", MessageBoxButtons.OK);
                        error_flag = true;
                    }

                }
                // 괄호 재귀 처리

                // 위의 괄호 재귀 처리 이후에 남은 것 (즉, 에러)
                else if (element.Contains(")"))
                {
                    MessageBox.Show("괄호 매칭이 올바르지 않습니다.", "괄호 에러", MessageBoxButtons.OK);
                    error_flag = true;
                }
                // 값은 그냥 입력
                else
                    Postfixlist.Add(element);
            }

            // 연산 스택에 남은 연산자들 입력
            while (SymStack.Count > 0)
                Postfixlist.Add(SymStack.Pop());

        }

        public void calculate(List<string> postfixlist_)
        {
            // 값 스택
            Stack<double> stack_value = new Stack<double>();

            for(int i = 0; i < postfixlist_.Count; i++)
            {
                string tmp = postfixlist_[i];

                try
                {
                    if(tmp.Equals("+") || tmp.Equals("-") || tmp.Equals("*") || tmp.Equals("/"))
                    {
                        double val1 = stack_value.Pop();
                        double val2 = stack_value.Pop();

                        switch (tmp)
                        {
                            case "+":
                                stack_value.Push(val2 + val1);
                                break;
                            case "-":
                                stack_value.Push(val2 - val1);
                                break;
                            case "*":
                                stack_value.Push(val2 * val1);
                                break;
                            case "/":
                                if(Math.Abs((val1 - 0.0d)) < double.Epsilon)
                                {
                                    MessageBox.Show("0으로 나누는 것은 할 수 없습니다.", "에러", MessageBoxButtons.OK);
                                    TxtCmd.Text = "";
                                    return;
                                }
                                stack_value.Push(val2 / val1);
                                break;
                            default:
                                MessageBox.Show("기호 인식에 오류가 있습니다.", "에러", MessageBoxButtons.OK);
                                TxtCmd.Text = "";
                                return;
                                break;
                        }

                    }

                    else // 값
                    {
                        try
                        {
                            stack_value.Push(double.Parse(tmp));
                        }
                        catch (FormatException FE)
                        {
                            MessageBox.Show("올바른 숫자를 입력하세요.", "에러", MessageBoxButtons.OK);
                            TxtCmd.Text = "";
                            return;
                        }
                        catch(OverflowException OE)
                        {
                            MessageBox.Show("값이 double 범위를 초과했습니다.", "에러", MessageBoxButtons.OK);
                            TxtCmd.Text = "";
                            return;
                        }
                    }
                }
                // 빈 스택일 경우
                catch (InvalidOperationException IOE)
                {
                    MessageBox.Show(IOE.Message, "에러", MessageBoxButtons.OK);
                    TxtCmd.Text = "";
                    return;
                }

            }

            if (stack_value.Count == 1)
            {
                TxtCmd.Text = stack_value.Pop().ToString();

                BefInput = new Stack<string>();
                BefInput.Push(TxtCmd.Text);
            }
            else
            {
                MessageBox.Show("연산자 수가 부족합니다.", "에러", MessageBoxButtons.OK);
                TxtCmd.Text = "";

                BefInput = new Stack<string>();
                BefInput.Push(TxtCmd.Text);
            }
             
        }

        #endregion 계산기 메서드 영역

        #region 이벤트 핸들링 영역

        // 계산식 결과 출력(=)
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // 문자열(계산식) -> 값(정수,실수) 스택 / 연산자(+,-,*,/) 스택으로 분리한다. (infix to postfix)

            // 중위 스택 초기화
            Infixlist = new List<string>();
            // 후위 스택 초기화
            Postfixlist = new List<string>();

            // 표현식 -> 중위식
            ExpressionToInfix(TxtCmd.Text);
            /*string tmp1 = String.Empty;
            foreach (var element in Infixlist)
                tmp1 += element + " ";
            MessageBox.Show(tmp1, "임시결과1");*/

            // 중위식 -> 후위식
            InfixToPostfix(Infixlist);
            /*string tmp2 = String.Empty;
            foreach (var element in Postfixlist)
                tmp2 += element + " ";
            MessageBox.Show(tmp2, "임시결과2");*/

            // 후위식 -> 계산
            if (!error_flag)
                calculate(Postfixlist);
            else
            {
                TxtCmd.Text = "";
                error_flag = false;
                return;
            }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            BefInput.Push(((Button)sender).Text);
            TxtCmd.Text += BefInput.Peek();
            TxtCmd.SelectionStart = TxtCmd.TextLength;
            TxtCmd.ScrollToCaret();
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            BefInput.Push(".");
            TxtCmd.Text += BefInput.Peek();
            TxtCmd.SelectionStart = TxtCmd.TextLength;
            TxtCmd.ScrollToCaret();
        }

        private void BtnSym_Click(object sender, EventArgs e)
        {
            BefInput.Push(" " + ((Button)sender).Text + " ");
            TxtCmd.Text += BefInput.Peek();
            TxtCmd.SelectionStart = TxtCmd.TextLength;
            TxtCmd.ScrollToCaret();
        }

        // Clear Entry
        private void BtnCE_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtCmd.Text))
            {
                TxtCmd.Text = TxtCmd.Text.Substring(0, TxtCmd.Text.Length - BefInput.Peek().Length);
                TxtCmd.SelectionStart = TxtCmd.TextLength;
                TxtCmd.ScrollToCaret();
                BefInput.Pop();
            }
        }

        private void Parentheses_Click(object sender, EventArgs e)
        {
            BefInput.Push(" " + ((Button)sender).Text + " ");
            TxtCmd.Text += BefInput.Peek();
            TxtCmd.SelectionStart = TxtCmd.TextLength;
            TxtCmd.ScrollToCaret();
        }

        private void TxtCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch((char) e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    // (GroupBoxNumber.Controls[string.Format("Btn{0}", (int)(e.KeyChar - '0'))] as Button).PerformClick();
                    // ((Button) GroupBoxNumber.Controls["Btn" + e.KeyChar]).PerformClick();
                    Button btnNum = new Button();
                    btnNum.Text = e.KeyChar.ToString();
                    btnNum.Click += BtnNum_Click;
                    btnNum.PerformClick();
                    break;

                case '.':
                    ((Button)GroupBoxNumber.Controls["BtnDot"]).PerformClick();
                    break;
                case '=': // ((int) 61) 
                case '\r': // carriage return (엔터, (int) 10)
                    ((Button)GroupBoxNumber.Controls["BtnResult"]).PerformClick();
                    break;
                case '(':
                    // ((Button)GroupBoxNumber.Controls["LeftParentheses"]).PerformClick();
                    // break;
                case ')':
                    // ((Button)GroupBoxNumber.Controls["RightParentheses"]).PerformClick();
                    // break;
                    Button btnPar = new Button();
                    btnPar.Text = e.KeyChar.ToString();
                    btnPar.Click += Parentheses_Click;
                    btnPar.PerformClick();
                    break;

                case (char) 8: // backspace (백스페이스, (int) 8)
                    // 왜 이건 그룹 내에 포함이 안되는 건가 ?ㅅ?..
                    ((Button)Controls["BtnCE"]).PerformClick();
                    break;

                case '+':
                    // ((Button)groupBoxOperation.Controls["BtnAdd"]).PerformClick();
                    // break;
                case '-':
                // ((Button)groupBoxOperation.Controls["BtnSub"]).PerformClick();
                // break;
                case '*':
                // ((Button)groupBoxOperation.Controls["BtnMul"]).PerformClick();
                // break;
                case '/':
                    // ((Button)groupBoxOperation.Controls["BtnDiv"]).PerformClick();
                    // break;
                    Button btnSym = new Button();
                    btnSym.Text = e.KeyChar.ToString();
                    btnSym.Click += BtnSym_Click;
                    btnSym.PerformClick();
                    break;

                default:
                    break;
            }
        }
        #endregion 이벤트 핸들링 영역
    }
}

