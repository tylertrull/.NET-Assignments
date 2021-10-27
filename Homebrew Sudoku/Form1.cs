//Cocded by Ian Sullivan and Tyler Tyler

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Assign5
{
    public partial class Form1 : Form
    {
        System.Timers.Timer t = new System.Timers.Timer(1000);
        Random rng = new Random();
        bool cheated = false;
        bool paused = false;
        bool acceptingInput = false;
        bool loadedPuzzle = false;
        bool puzzleOneComplete = false;
        bool puzzleTwoComplete = false;
        bool puzzleThreeComplete = false;
        int puzzleNumber = 1;
        MaskedTextBox lastClicked = new MaskedTextBox();
        List<MaskedTextBox> Puzzle = new List<MaskedTextBox>();
        List<MaskedTextBox> rowAnswers = new List<MaskedTextBox>();
        List<MaskedTextBox> columnAnswers = new List<MaskedTextBox>();
        List<MaskedTextBox> diagonalAnswers = new List<MaskedTextBox>();
        List<String> tempPuzzle = new List<String>();

        //PuzzleType will hold a string that will tell us the puzzletype
        //This is to change any logic when checking the puzzle for the answer
        string PuzzleType = "";
        int PuzzleSizex;
        int PuzzleSizey;
        List<char> puzzleOne = new List<char>();
        List<char> puzzleOneAnswer = new List<char>();
        List<char> puzzleTwo = new List<char>();
        List<char> puzzleTwoAnswer = new List<char>();
        List<char> puzzleThree = new List<char>();
        List<char> puzzleThreeAnswer = new List<char>();
        List<char> savedPuzzle = new List<char>();
        List<char> savePuzzleAnswer = new List<char>();

        public Form1()
        {
            InitializeComponent();
            ReadFiles();
        }

        //Redraws the screen and clears out all our temparary storage when called
        public void redrawScreen()
        {
            Controls.Clear();
            puzzleOne.Clear();
            puzzleTwo.Clear();
            puzzleThree.Clear();
            puzzleOneAnswer.Clear();
            puzzleTwoAnswer.Clear();
            puzzleThreeAnswer.Clear();
            savedPuzzle.Clear();
            rowAnswers.Clear();
            columnAnswers.Clear();
            diagonalAnswers.Clear();
            loadedPuzzle = false;
            InitializeComponent();
        }

        //This is called every second
        private void MyTimedevent(object source, System.Timers.ElapsedEventArgs args)
        {
            //string words = String.Format("{0:HH:mm:ss.fff}", args.SignalTime);
            //richTextBox1.Text += words;
        }

        //Starts the timer used
        public void startTimer()
        {
            t.Elapsed += MyTimedevent;
            t.AutoReset = true;
            t.Enabled = true; 
        }

        //Reads each file of a given difficulty into 3 seperate arrays of strings including the answers.
        //It then removes the answers from the lists and stores them seperately
        public void ReadFiles()
        {
            //Declares arrays to hold text values
            string[] linesOne = new string[0];
            string[] linesTwo = new string[0];
            string[] linesThree = new string[0];
            if (PuzzleType == "Easy")
            {
                if(System.IO.File.Exists(System.IO.Path.Combine(Environment.CurrentDirectory, "eSave.txt"))){
                    string[] savefile = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "eSave.txt"));
                    puzzleNumber = Convert.ToInt32(savefile[0]);
                    savefile = savefile.Skip(1).ToArray();
                    foreach(string line in savefile)
                    {
                        foreach(char character in line)
                        {
                            savedPuzzle.Add(character);
                            loadedPuzzle = true;
                        }
                    }
                }
                linesOne = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "e1.txt"));
                linesTwo = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "e2.txt"));
                linesThree = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "e3.txt"));
            }
            else if (PuzzleType == "Medium")
            {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.CurrentDirectory, "mSave.txt")))
                {
                    string[] savefile = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "mSave.txt"));
                    puzzleNumber = Convert.ToInt32(savefile[0]);
                    savefile = savefile.Skip(1).ToArray();
                    foreach (string line in savefile)
                    {
                        foreach (char character in line)
                        {
                            savedPuzzle.Add(character);
                            loadedPuzzle = true;
                        }

                    }


                }
                linesOne = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "m1.txt"));
                linesTwo = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "m2.txt"));
                linesThree = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "m3.txt"));

            }
            else if (PuzzleType == "Hard")
            {
                if (System.IO.File.Exists(System.IO.Path.Combine(Environment.CurrentDirectory, "hSave.txt")))
                {
                    string[] savefile = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "hSave.txt"));
                    puzzleNumber = Convert.ToInt32(savefile[0]);
                    savefile = savefile.Skip(1).ToArray();
                    foreach (string line in savefile)
                    {
                        foreach (char character in line)
                        {
                            savedPuzzle.Add(character);
                            loadedPuzzle = true;
                        }
                    }
                }
                linesOne = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "h1.txt"));
                linesTwo = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "h2.txt"));
                linesThree = System.IO.File.ReadAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "h3.txt"));

            }
            //Goes through each line and gets each character and then adds it to the puzzle list
            foreach (string line in linesOne)
            {
                foreach (char character in line)
                {
                    puzzleOne.Add(character);
                }
            }
            foreach (string line in linesTwo)
            {
                foreach (char character in line)
                {
                    puzzleTwo.Add(character);
                }
            }
            foreach (string line in linesThree)
            {
                foreach (char character in line)
                {
                    puzzleThree.Add(character);
                }
            }
            //There will always be an even number of elements in the puzzle list
            //The second half of the puzzle elements are the answer to the puzzle
            //This retrieves them from the puzzle list, puts them in the answer list, and then removes them from the puzzle list
            for (int i = puzzleOne.Count / 2; i < puzzleOne.Count; i++)
            {
                puzzleOneAnswer.Add(puzzleOne[i]);
                puzzleOne.RemoveAt(i);
                i--;
            }
            for (int i = puzzleTwo.Count / 2; i < puzzleTwo.Count; i++)
            {
                puzzleTwoAnswer.Add(puzzleTwo[i]);
                puzzleTwo.RemoveAt(i);
                i--;
            }
            for (int i = puzzleThree.Count / 2; i < puzzleThree.Count; i++)
            {
                puzzleThreeAnswer.Add(puzzleThree[i]);
                puzzleThree.RemoveAt(i);
                i--;
            }

        }

        //It calculates and prints the answer totals for each row column and diagonal.
        public void printAnswers()
        {
            int rowBox = 0;
            int total = 0;
            //The count of rows will always be the delimiter
            int delimiter = rowAnswers.Count;

            List<char> currentPuzzleAnswers = new List<char>();
            switch (puzzleNumber)
            {
                case 1:
                    currentPuzzleAnswers = puzzleOneAnswer;
                    break;
                case 2:
                    currentPuzzleAnswers = puzzleTwoAnswer;
                    break;
                case 3:
                    currentPuzzleAnswers = puzzleThreeAnswer;
                    break;
                default:
                    break;
            }

            //Gets Row Answers
            for(int i = 1; i <= currentPuzzleAnswers.Count; i++)
            {

                if (i % delimiter == 0 && rowBox < delimiter)
                {
                    total += Convert.ToInt32(Char.ToString(currentPuzzleAnswers[i - 1]));
                    rowAnswers[rowBox].Text = total.ToString();
                    rowBox++;
                    total = 0;
                }
                else
                {
                   total += Convert.ToInt32(Char.ToString(currentPuzzleAnswers[i - 1]));
                }
            }
            //Reset Variables
            rowBox = 0;
            total = 0;
            //Gets Column Answers
            for (int i = 0; i < columnAnswers.Count; i++)
            {
                for(int j = 0; j < delimiter; j++)
                {
                    total += Convert.ToInt32(Char.ToString(currentPuzzleAnswers[i + (j * delimiter)]));
                }
                columnAnswers[rowBox].Text = total.ToString();
                rowBox++;
                total = 0;
            }
            //Reset Variables
            total = 0;
            //Get Diagonal Answers
            for(int i = 0; i < currentPuzzleAnswers.Count; i++)
            {
                if(i % (delimiter + 1) == 0)
                {
                    total += Convert.ToInt32(Char.ToString(currentPuzzleAnswers[i]));
                }
            }
            diagonalAnswers[1].Text = total.ToString();
            total = 0;
            for (int i = currentPuzzleAnswers.Count; i > 0; i--)
            {
                if (i % (delimiter - 1) == 0)
                {
                    total += Convert.ToInt32(Char.ToString(currentPuzzleAnswers[i]));
                }
            }
            diagonalAnswers[0].Text = total.ToString();

        }

        //This calculates each row, column, and diagonal and checks to see if the answer is above, below, or equal to the correct answer total.
        //It changes the color of the answer total to green if it's correct and red if it's incorrect.
        public void checkAnswers()
        {
            int CurrentRowTotal;
            int CurrentColumnTotal;
            int CurrentDiagonalTotal;

            //The length of the puzzle will always be the count of either a row or column (How many boxes are in the row/column is the length)
            int puzzleLength = rowAnswers.Count;
            //Check for the diagonals
            for (int i = 0; i < diagonalAnswers.Count; i++)
            {
                CurrentDiagonalTotal = 0;
                if (i == 0)
                {
                    for (int j = Puzzle.Count - 1; j >= 0; j--)
                    {
                        if (j % (puzzleLength - 1) == 0 && Puzzle[j].Text != "")
                        {
                            CurrentDiagonalTotal += Convert.ToInt32(Puzzle[j].Text);
                        }
                    }
                    if (CurrentDiagonalTotal == Convert.ToInt32(diagonalAnswers[i].Text))
                    {
                        diagonalAnswers[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        diagonalAnswers[i].ForeColor = Color.DarkRed;
                    }
                }
                if (i == 1)
                {
                    for (int j = 0; j < Puzzle.Count; j++)
                    {
                        if (j % (puzzleLength + 1) == 0 && Puzzle[j].Text != "")
                        {
                            CurrentDiagonalTotal += Convert.ToInt32(Puzzle[j].Text);
                        }
                    }
                    if (CurrentDiagonalTotal == Convert.ToInt32(diagonalAnswers[i].Text))
                    {
                        diagonalAnswers[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        diagonalAnswers[i].ForeColor = Color.DarkRed;
                    }
                }
            }

            //Check for the columns
            for (int i = 0; i < columnAnswers.Count; i++)
            {
                CurrentColumnTotal = 0;
                for (int j = 0; j < columnAnswers.Count; j++)
                {
                    if (Puzzle[i + (j * columnAnswers.Count)].Text != "")
                    {
                        CurrentColumnTotal += Convert.ToInt32(Puzzle[i + (j * columnAnswers.Count)].Text);
                    }
                }
                if (CurrentColumnTotal == Convert.ToInt32(columnAnswers[i].Text))
                {
                    columnAnswers[i].ForeColor = Color.Green;
                    CurrentColumnTotal = 0;
                }
                else
                {
                    columnAnswers[i].ForeColor = Color.DarkRed;
                    CurrentColumnTotal = 0;
                }
            }

            //Check for the rows

            for (int i = 0; i < rowAnswers.Count; i++)
            {
                CurrentRowTotal = 0;

                for (int j = 0; j < rowAnswers.Count; j++)
                {
                    if (Puzzle[(i * rowAnswers.Count) + j].Text != "")
                    {
                        CurrentRowTotal += Convert.ToInt32(Puzzle[(i * rowAnswers.Count) + j].Text);
                    }
                }

                if (CurrentRowTotal == Convert.ToInt32(rowAnswers[i].Text))
                {
                    rowAnswers[i].ForeColor = Color.Green;
                    CurrentRowTotal = 0;

                }
                else
                {
                    rowAnswers[i].ForeColor = Color.DarkRed;
                    CurrentRowTotal = 0;
                }
            }


        }

        //This generates the actual maskedTextBoxes for the answer totals on the row side of the screen. (including diagonals)
        public void GenerateRowBoxes(int puzzleSizex)
        {

            int originX = 0; //Where the row boxes should start drawing from on X
            int originY = 0; //Where the row boxes should start drawing from on Y

            MaskedTextBox diag1 = new MaskedTextBox();
            MaskedTextBox diag2 = new MaskedTextBox();

            switch (puzzleSizex)
            {
                case 1: //If it's a 3x3

                    originX = 710; //400 + (3 x 100px) + 20px for break
                    originY = 18; //60 + (3 x 20px) + 20px for break

                    for (int i = 1; i < 4; i++) //An extra box for the diagonal
                    {
                        MaskedTextBox tempBox = new MaskedTextBox(); //Might need to make this just a regular textBox
                        tempBox.Font = new Font(tempBox.Font.FontFamily, 23);
                        tempBox.Location = new Point { X = originX, Y = originY + (i * tempBox.Height) };
                        tempBox.TextAlign = HorizontalAlignment.Center;
                        tempBox.Width = 100;
                        rowAnswers.Add(tempBox);
                    }
                    
                    
                    diag1.Font = new Font(diag1.Font.FontFamily, 23);
                    diag1.Location = new Point { X = originX, Y = originY - 10};
                    diag1.Width = 100;
                    diag1.TextAlign = HorizontalAlignment.Center;
                    diagonalAnswers.Add(diag1);

                    
                    diag2.Font = new Font(diag2.Font.FontFamily, 23);
                    diag2.Location = new Point { X = originX, Y = (originY + (4 * diag2.Height) + 10 )};
                    diag2.Width = 100;
                    diag2.TextAlign = HorizontalAlignment.Center;

                    diagonalAnswers.Add(diag2);


                    break;

                case 2: //If it's a 5x5

                    originX = 910;
                    originY = 18;

                    for (int i = 1; i < 6; i++) //An extra box for the diagonal
                    {
                        MaskedTextBox tempBox = new MaskedTextBox(); //Might need to make this just a regular textBox
                        tempBox.Font = new Font(tempBox.Font.FontFamily, 23);
                        tempBox.Location = new Point { X = originX, Y = originY + (i * tempBox.Height) };
                        tempBox.TextAlign = HorizontalAlignment.Center;
                        tempBox.Width = 100;
                        rowAnswers.Add(tempBox);
                    }

                    
                    diag1.Font = new Font(diag1.Font.FontFamily, 23);
                    diag1.Location = new Point { X = originX, Y = originY - 10 };
                    diag1.Width = 100;
                    diag1.TextAlign = HorizontalAlignment.Center;
                    diagonalAnswers.Add(diag1);

                    
                    diag2.Font = new Font(diag2.Font.FontFamily, 23);
                    diag2.Location = new Point { X = originX, Y = (originY + (6 * diag2.Height) + 10) };
                    diag2.Width = 100;
                    diag2.TextAlign = HorizontalAlignment.Center;
                    diagonalAnswers.Add(diag2);

                    break;

                case 3: //If it's a 7x7

                    originX = 1110;
                    originY = 18;

                    for (int i = 1; i < 8; i++) //An extra box for the diagonal
                    {
                        MaskedTextBox tempBox = new MaskedTextBox(); //Might need to make this just a regular textBox
                        tempBox.Font = new Font(tempBox.Font.FontFamily, 23);
                        tempBox.Location = new Point { X = originX, Y = originY + (i * tempBox.Height) };
                        tempBox.TextAlign = HorizontalAlignment.Center;

                        tempBox.Width = 100;

                        rowAnswers.Add(tempBox);
                    }

                    diag1.Font = new Font(diag1.Font.FontFamily, 23);
                    diag1.Location = new Point { X = originX, Y = originY - 10 };
                    diag1.TextAlign = HorizontalAlignment.Center;
                    diag1.Width = 100;
                    diagonalAnswers.Add(diag1);


                    diag2.Font = new Font(diag2.Font.FontFamily, 23);
                    diag2.Location = new Point { X = originX, Y = (originY + (8 * diag2.Height) + 10) };
                    diag2.Width = 100;
                    diag2.TextAlign = HorizontalAlignment.Center;

                    diagonalAnswers.Add(diag2);

                    break;

                default:

                    break;
            }
        }

        //This generates and draws the maskedTextboxes on the column side of the screen.
        public void GenerateColumnBoxes(int puzzleSize)
        {
            int originX = 400;
            int originY = 18;

            switch (puzzleSize) {

                case 1:

                    for (int i = 0; i < 3; i++) //An extra box for the diagonal
                    {
                        MaskedTextBox tempBox = new MaskedTextBox(); //Might need to make this just a regular textBox
                        tempBox.Font = new Font(tempBox.Font.FontFamily, 23);
                        tempBox.Location = new Point { X = originX + (100 * i), Y = originY + (tempBox.Height * 4) + 10 };
                        tempBox.TextAlign = HorizontalAlignment.Center;

                        tempBox.Width = 100;
                        columnAnswers.Add(tempBox);
                    }

                    break;

                case 2:

                    for (int i = 0; i < 5; i++) //An extra box for the diagonal
                    {
                        MaskedTextBox tempBox = new MaskedTextBox(); //Might need to make this just a regular textBox
                        tempBox.Font = new Font(tempBox.Font.FontFamily, 23);
                        tempBox.Location = new Point { X = originX + (100 * i), Y = originY + (tempBox.Height * 6) + 10 };
                        tempBox.TextAlign = HorizontalAlignment.Center;
                        tempBox.Width = 100;
                        columnAnswers.Add(tempBox);
                    }

                    break;

                case 3:

                    for (int i = 0; i < 7; i++) //An extra box for the diagonal
                    {
                        MaskedTextBox tempBox = new MaskedTextBox(); //Might need to make this just a regular textBox
                        tempBox.Font = new Font(tempBox.Font.FontFamily, 23);
                        tempBox.Location = new Point { X = originX + (100 * i), Y = originY + (tempBox.Height * 8) + 10 };
                        tempBox.TextAlign = HorizontalAlignment.Center;
                        tempBox.Width = 100;
                        columnAnswers.Add(tempBox);
                    }

                    break;

                default:

                    break;
            }
        }

        //This function creates the list of maskedTextBoxes and draws them too the screen.
        public List<MaskedTextBox> createBoxes()
        {
            List<MaskedTextBox> CreatedPuzzle = new List<MaskedTextBox>();
;           int FontSize = 23;
            ReadFiles();
            if (PuzzleType == "Easy")
            {
                //Create 9 maskedtextbox objects (3x3)
                for (int i = 0; i < 9; i++)
                {
                    string character = String.Empty;
                    if(loadedPuzzle == true)
                    {
                        character = Char.ToString(savedPuzzle[i]);
                    }
                    else if (puzzleNumber == 1)
                    {
                        character = Char.ToString(puzzleOne[i]);
                    }
                    else if (puzzleNumber == 2)
                    {
                        character = Char.ToString(puzzleTwo[i]);
                    }
                    else
                    {
                        character = Char.ToString(puzzleThree[i]);
                    }
                    MaskedTextBox tempBox = new MaskedTextBox();
                    tempBox.TextAlign = HorizontalAlignment.Center;
                    tempBox.Font = new Font(tempBox.Font.FontFamily, FontSize, FontStyle.Bold);
                    tempBox.Click += new EventHandler(textBox_Click);
                    if (character != "0")
                    {
                        tempBox.BackColor = tempBox.BackColor; //The way that forecolors are coded in .net requires us to set this to update forecolor if readonly is on.
                        tempBox.ForeColor = Color.Black;
                        tempBox.Text = character;
                        tempBox.ReadOnly = true;
                        
                    }

                    CreatedPuzzle.Add(tempBox);
                }
                PuzzleSizex = 300;
                PuzzleSizey = CreatedPuzzle[0].Height;
                

            }
            else if (PuzzleType == "Medium")
            {

                //Create 25 maskedtextbox objects (5x5)
                for (int i = 0; i < 25; i++)
                {
                    string character = String.Empty;
                    if (loadedPuzzle == true)
                    {
                        character = Char.ToString(savedPuzzle[i]);
                    }
                    else if (puzzleNumber == 1)
                    {
                        character = Char.ToString(puzzleOne[i]);
                    }
                    else if(puzzleNumber == 2)
                    {
                        character = Char.ToString(puzzleTwo[i]);
                    }
                    else
                    {
                        character = Char.ToString(puzzleThree[i]);
                    }
                    MaskedTextBox tempBox = new MaskedTextBox();
                    tempBox.TextAlign = HorizontalAlignment.Center;
                    tempBox.Font = new Font(tempBox.Font.FontFamily, FontSize, FontStyle.Bold);
                    tempBox.Click += new EventHandler(textBox_Click);
                    if (character != "0")
                    {
                        tempBox.BackColor = tempBox.BackColor; //The way that forecolors are coded in .net requires us to set this to update forecolor if readonly is on.
                        tempBox.ForeColor = Color.Black;
                        tempBox.Text = character;
                        tempBox.ReadOnly = true;
                        
                    }
                    CreatedPuzzle.Add(tempBox);
                }
                PuzzleSizex = 500;
                PuzzleSizey = CreatedPuzzle[0].Height;
            }
            else if (PuzzleType == "Hard")
            {
                //Create 49 maskedtextbox objects (7x7)
                for(int i = 0; i < 49; i++)
                {
                    string character = String.Empty;
                    if (loadedPuzzle == true)
                    {
                        character = Char.ToString(savedPuzzle[i]);
                    }
                    else  if (puzzleNumber == 1)
                    {
                        character = Char.ToString(puzzleOne[i]);
                    }
                    else if (puzzleNumber == 2)
                    {
                        character = Char.ToString(puzzleTwo[i]);
                    }
                    else
                    {
                        character = Char.ToString(puzzleThree[i]);
                    }
                    MaskedTextBox tempBox = new MaskedTextBox();
                    tempBox.TextAlign = HorizontalAlignment.Center;
                    tempBox.Font = new Font(tempBox.Font.FontFamily, FontSize, FontStyle.Bold);
                    tempBox.Click += new EventHandler(textBox_Click);
                    if (character != "0")
                    {
                        tempBox.BackColor = tempBox.BackColor; //The way that forecolors are coded in .net requires us to set this to update forecolor if readonly is on.
                        tempBox.ForeColor = Color.Black;
                        tempBox.Text = character;
                        tempBox.ReadOnly = true;
                    }
                    CreatedPuzzle.Add(tempBox);
                }
            }
            PuzzleSizex = 700;
            PuzzleSizey = CreatedPuzzle[0].Height;

            return CreatedPuzzle;

        }

        //This function adds all of the answerboxes to the controls allowing them to be drawn
        public void drawAnswerBoxes()
        {
            foreach (MaskedTextBox answerSquares in rowAnswers)
            {
                Controls.Add(answerSquares);
            }

            foreach (MaskedTextBox answerSquares in diagonalAnswers)
            {
                Controls.Add(answerSquares);
            }

            foreach (MaskedTextBox answerSquares in columnAnswers)
            {
                Controls.Add(answerSquares);
            }
        }

        //This function adds all the textboxes in Puzzle to the controls allowing them to be drawn.
        public void drawPuzzle(int delimiter)
        {
            int originX = 400;
            int originY = 60;
            int StartX = originX;
            int StartY = originY;
            int offsetx = 100;
            int offsety = Puzzle[0].Height;
            int counter = 0;
            foreach (MaskedTextBox puzzlesquare in Puzzle)
            {
                Controls.Add(puzzlesquare);
                puzzlesquare.Location = new Point { X = StartX, Y = StartY };
                StartX += offsetx;
                counter++;
                if (counter % delimiter == 0)
                {
                    StartX = originX;
                    StartY += offsety;
                }
            }

        }

        //This function is called when the easy button is clicked.
        //It takes care of calling the other functions to draw, calculate, and make an easy game.
        private void easyButton_Click(object sender, EventArgs e)
        {
            redrawScreen();
            GenerateRowBoxes(1);
            GenerateColumnBoxes(1);
            drawAnswerBoxes();
            PuzzleType = "Easy";
            Puzzle = createBoxes();
            drawPuzzle(3);
            printAnswers();
            checkAnswers();
            disableGivens();
            startTimer();
        }

        //This function is called when the medium button is clicked.
        //It takes care of calling the other functions to draw, calculate, and make an medium game.
        private void mediumButton_Click(object sender, EventArgs e)
        {
            redrawScreen();
            GenerateRowBoxes(2);
            GenerateColumnBoxes(2);
            drawAnswerBoxes();
            PuzzleType = "Medium";
            Puzzle = createBoxes();
            drawPuzzle(5);
            printAnswers();
            checkAnswers();
            disableGivens();
        }

        //This function is called when the easy button is clicked.
        //It takes care of calling the other functions to draw, calculate, and make an medium game.
        private void hardButton_Click(object sender, EventArgs e)
        {
            redrawScreen();
            PuzzleType = "Hard";
            Puzzle = createBoxes();
            drawPuzzle(7);
            GenerateRowBoxes(3);
            GenerateColumnBoxes(3);
            drawAnswerBoxes();
            printAnswers();
            checkAnswers();
            disableGivens();
        }

        //This function saves the game by creating a save file for each difficulty and appending the players current answers to it.
        public void saveGame()
        {
            string filename = String.Empty;
            string tempString = String.Empty;
            int delimiter = 0;
            List<string> savePuzzle = new List<string>();
            List<char> savePuzzlechar = new List<char>();
            savedPuzzle.Clear();
            savePuzzle.Add(puzzleNumber.ToString());
            switch (PuzzleType)
            {
                case "Easy":
                    filename = "eSave.txt";
                    delimiter = 3;
                    break;
                case "Medium":
                    filename = "mSave.txt";
                    delimiter = 5;
                    break;
                case "Hard":
                    filename = "hSave.txt";
                    delimiter = 7;
                    break;
                default:
                    break;
            }
            for(int i = 0; i < Puzzle.Count; i++)
            {
                if(Puzzle[i].Text != "")
                {
                    tempString += Puzzle[i].Text;
                    savedPuzzle.Add(Convert.ToChar(Puzzle[i].Text));
                }
                else
                {
                    tempString += "0";
                    savedPuzzle.Add('0');
                }
                if(((i + 1) % delimiter) == 0)
                {
                    savePuzzle.Add(tempString);
                    Console.WriteLine(tempString);
                    tempString = "";

                }
            }
            string filepath = System.IO.Path.Combine(Environment.CurrentDirectory, filename);
            System.IO.File.WriteAllLines(filepath, savePuzzle);

        }

        //This function resets the game to it's original state removing the players answers and the cheated flag.
        public void ResetGame()
        {
            string filename = String.Empty;
            cheated = false;
            switch (puzzleNumber)
                {
                    case 1:
                        for(int i = 0; i < Puzzle.Count; i++)
                        {
                            Puzzle[i].Text = Char.ToString(puzzleOne[i]);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Puzzle.Count; i++)
                        {
                            Puzzle[i].Text = Char.ToString(puzzleTwo[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < Puzzle.Count; i++)
                        {
                            Puzzle[i].Text = Char.ToString(puzzleThree[i]);
                        }
                        break;
                    default:
                        break;
                }
       
            //Removing the zeroes
            for(int i = 0; i < Puzzle.Count; i++)
            {
                if(Puzzle[i].Text == "0")
                {
                    Puzzle[i].Text = "";
                }
            }
        }

        //This functions make the given numbers uneditable by disabling them.
        public void disableGivens()
        {
            for (int i = 0; i < Puzzle.Count; i++)
            {
                if (Puzzle[i].Text != "")
                {
                    switch (puzzleNumber)
                    {
                        case 1:
                            if (puzzleOne[i] != '0')
                            {
                                Puzzle[i].Enabled = false;
                            }
                            break;
                        case 2:
                            if (puzzleTwo[i] != '0')
                            {
                                Puzzle[i].Enabled = false;
                            }
                            break;
                        case 3:
                            if (puzzleThree[i] != '0')
                            {
                                Puzzle[i].Enabled = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        //This function is called when the pause button is clicked it replaces all of the textboxes with ? to prevent cheating.
        //When resume is clicked it reloads the numbers into textboxes and restarts the timer.
        private void pauseButton_Click(object sender, EventArgs e)
        {
            
            foreach (MaskedTextBox t in Puzzle)
            {
                tempPuzzle.Add(t.Text.ToString());
            }

            if(paused == false)
            {
                
                foreach (MaskedTextBox textbox in Puzzle)
                {
                    //MaskedTextBox temp = new MaskedTextBox();
                    //emp = textbox;
                    //tempPuzzle.Add(temp);
                    textbox.Enabled = false;
                    paused = true;
                    pauseButton.Text = "Resume";
                    textbox.Text = "?";
                }
            }
            else
            {
                for(int i = 0; i < Puzzle.Count; i++)
                {
                    Puzzle[i].Enabled = true;
                    Console.WriteLine(tempPuzzle[i]);
                    Puzzle[i].Text = tempPuzzle[i];
                }
                paused = false;
                pauseButton.Text = "Pause";
            }
            disableGivens();
        }

        //This is called when the reset button is clicked it resets the game.
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        //This checks to see if the game is completed.
        //If it isn't completed it then checks to see if the player has made any mistakes and points them out via row.
        //If the player hasn't made any mistakes it prints a message to the richtexbox and tells them how far they got.
        private void checkButton_Click(object sender, EventArgs e)
        {
            int amountcorrect = 0;
            int amounttotal = Puzzle.Count;
            int[] wrongNumbers = new int[Puzzle.Count];
            bool needsHelp = false;
            List<char> currentPuzzle = new List<char>();
            switch (puzzleNumber)
            {
                case 1:
                    currentPuzzle = puzzleOneAnswer;
                    break;
                case 2:
                    currentPuzzle = puzzleTwoAnswer;
                    break;
                case 3:
                    currentPuzzle = puzzleThreeAnswer;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < Puzzle.Count; i++)
            {
                if (Puzzle[i].Text.ToString() == currentPuzzle[i].ToString())
                {
                    amountcorrect++;
                    wrongNumbers[i] = 0;
                }
                else if (Puzzle[i].Text.ToString() == "")
                {
                    wrongNumbers[i] = 0;
                }
                else
                {
                    needsHelp = true;
                    wrongNumbers[i] = 1;
                }

            }

            if (amountcorrect == amounttotal)
            {
                switch (puzzleNumber)
                {
                    case 1:
                        puzzleOneComplete = true;
                        puzzleNumber = 2;
                        break;
                    case 2:
                        puzzleTwoComplete = true;
                        puzzleNumber = 3;
                        break;
                    default:
                        break;
                }

                switch (PuzzleType)
                {
                    case "Easy":
                        System.IO.File.Delete(System.IO.Path.Combine(Environment.CurrentDirectory, "eSave.txt"));
                        easyButton_Click(sender, e);
                        break;
                    case "Medium":
                        System.IO.File.Delete(System.IO.Path.Combine(Environment.CurrentDirectory, "mSave.txt"));
                        mediumButton_Click(sender, e);
                        break;
                    case "Hard":
                        System.IO.File.Delete(System.IO.Path.Combine(Environment.CurrentDirectory, "HSave.txt"));
                        hardButton_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }

            if (needsHelp == false)
            {
                //The amount correct should always be above 0
                richTextBox1.Text = "You have " + amountcorrect + "/" + amounttotal + " right congrats!";
            }
            else
            {
                richTextBox1.Text = "You might wanna recheck this part.";
                recolorWrongAnswers(wrongNumbers);
            }


        }

        //This is a helper function used to recolor the wrong answer in checkButton_click
        //It just loops through the row and recolors all the textboxes of any wrong answer row.
        private void recolorWrongAnswers(int[] wrongNumbers)
        {
            int i = 0;
            Console.WriteLine("Count:" + Puzzle.Count);

            switch (Puzzle.Count)
            {
                case 9:

                    while (i < 8)
                    {
                        if (wrongNumbers[i] == 1)
                        {

                            Puzzle[i].BackColor = Color.Red;
                            int counter = 0;

                            for (int x = (i % 3); x < 2; x++)
                            {
                                counter++;
                                Puzzle[i + counter].BackColor = Color.Red;
                            }

                            counter = 0;
                            for (int x = (i % 3); x > 0; x--)
                            {
                                counter++;
                                Puzzle[i - counter].BackColor = Color.Red;
                            }


                        }
                        i++;
                    }
                    break;

                case 25:

                    while (i < 24)
                    {
                        if (wrongNumbers[i] == 1)
                        {

                            Puzzle[i].BackColor = Color.Red;
                            int counter = 0;

                            for (int x = (i % 5); x < 4; x++)
                            {
                                counter++;
                                Puzzle[i + counter].BackColor = Color.Red;
                            }

                            counter = 0;
                            for (int x = (i % 5); x > 0; x--)
                            {
                                counter++;
                                Puzzle[i - counter].BackColor = Color.Red;
                            }


                        }
                        i++;
                    }

                    break;

                case 49:

                    while (i < 48)
                    {
                        if (wrongNumbers[i] == 1)
                        {

                            Puzzle[i].BackColor = Color.Red;
                            int counter = 0;

                            for (int x = (i % 7); x < 6; x++)
                            {
                                counter++;
                                Puzzle[i + counter].BackColor = Color.Red;
                            }

                            counter = 0;
                            for (int x = (i % 7); x > 0; x--)
                            {
                                counter++;
                                Puzzle[i - counter].BackColor = Color.Red;
                            }


                        }
                        i++;
                    }
                    
                    break;

                default:

                    Console.WriteLine("Oppsie");
                    break;
            }
        }

        //This function simply resets the board to white.
        private void clearColors()
        {
            for (int i = 0; i < Puzzle.Count; i++)
            {
                Puzzle[i].BackColor = Color.White;
            }
        }

        //This function Is called when a textbox is clicked.
        private void textBox_Click(Object sender, EventArgs e)
        {
            //groupBox1.Focus();
            clearColors();
            MaskedTextBox m1 = sender as MaskedTextBox;
            lastClicked = m1;
            richTextBox1.Focus();
            lastClicked.BackColor = Color.Red;
            acceptingInput = true;
            //lastClicked.Text = "2";
            //m1.fo = false;
            //m1.Text = "2";
            //m1.KeyDown += new KeyEventHandler(getInputEvent);
            //m1.KeyUp += new KeyEventHandler(resetFocus);
            //m1.Text = "2";

        }
        //This button checks for which button was pressed and filters it to make sure that only certain buttons give input.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("I got to the function");
            if (acceptingInput == true)
            {
                Console.WriteLine(e.KeyValue);
                if (e.KeyValue >= 49 && e.KeyValue <= 57)
                {
                    Console.WriteLine("I've been clicked!");
                    //m1.Focus();
                    switch (e.KeyCode)
                    {
                        case Keys.D1:

                            lastClicked.Text = "1";
                            break;
                        case Keys.D2:

                            lastClicked.Text = "2";
                            break;
                        case Keys.D3:

                            lastClicked.Text = "3";
                            break;
                        case Keys.D4:

                            lastClicked.Text = "4";
                            break;
                        case Keys.D5:

                            lastClicked.Text = "5";
                            break;
                        case Keys.D6:

                            lastClicked.Text = "6";
                            break;
                        case Keys.D7:

                            lastClicked.Text = "7";
                            break;
                        case Keys.D8:

                            lastClicked.Text = "8";
                            break;
                        case Keys.D9:

                            lastClicked.Text = "9";
                            break;
                        default:

                            Console.WriteLine("How did we get here!?");
                            break;
                    }
                    lastClicked.BackColor = Color.White;
                    acceptingInput = false;
                    checkAnswers();
                }
                else if (e.KeyCode > Keys.NumPad1 || e.KeyCode < Keys.NumPad9)
                {
                    Console.WriteLine("I've been clicked!");
                    //m1.Focus();
                    switch (e.KeyCode)
                    {
                        case Keys.NumPad1:

                            lastClicked.Text = "1";
                            break;
                        case Keys.NumPad2:

                            lastClicked.Text = "2";
                            break;
                        case Keys.NumPad3:

                            lastClicked.Text = "3";
                            break;
                        case Keys.NumPad4:

                            lastClicked.Text = "4";
                            break;
                        case Keys.NumPad5:

                            lastClicked.Text = "5";
                            break;
                        case Keys.NumPad6:

                            lastClicked.Text = "6";
                            break;
                        case Keys.NumPad7:

                            lastClicked.Text = "7";
                            break;
                        case Keys.NumPad8:

                            lastClicked.Text = "8";
                            break;
                        case Keys.NumPad9:

                            lastClicked.Text = "9";
                            break;
                        default:

                            Console.WriteLine("how did we get here 2 electric boogaloo?!");
                            break;

                    }
                    lastClicked.BackColor = Color.White;
                    acceptingInput = false;
                    checkAnswers();

                }
            }
        }

        //This saves the game.
        private void Save_Click(object sender, EventArgs e)
        {
            saveGame();
        }

        //This button looks for either a random unfilled square and fills it or
        //This button fixes a wrong answer.
        //Either way it sets the cheta flag.
        private void cheatButton_Click(object sender, EventArgs e)
        {
            cheated = true;
            int cheaterCount = 0;
            int randomNumber = 0;
            Dictionary<int, MaskedTextBox> cheaterList = new Dictionary<int, MaskedTextBox>();
            //int[] rngList = new int[49];
            //string p1 = Puzzle[0].ToString();
            //Console.WriteLine(ConvertToUtf32(p1[0]));


            switch (puzzleNumber)
            {
                case 1:


                    for (int i = 0; i < puzzleOne.Count; i++)
                    {
                        //Console.WriteLine(Puzzle[i].ToString() + "x");
                        if (Puzzle[i].Text.ToString() == "")
                        {
                            Console.WriteLine("I'm adding!");
                            cheaterList.Add(i, Puzzle[i]);
                        }
                    }

                    if (cheaterList.Count == 0)
                    {
                        for (int i = 0; i < puzzleOne.Count; i++)
                        {
                            if (Puzzle[i].Text.ToString() != puzzleOneAnswer[i].ToString())
                            {
                                Puzzle[i].Text = puzzleOneAnswer[i].ToString();
                                Console.WriteLine("c1, 1");
                                //Puzzle[i].Text = "21";
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("c1, 2");
                        randomNumber = getRNG(cheaterList.Count);

                        foreach (KeyValuePair<int, MaskedTextBox> m in cheaterList)
                        {
                            cheaterCount++;
                            if (cheaterCount == randomNumber)
                            {
                                Console.WriteLine("c1, 3");
                                //Puzzle[m.Key].Text = "21";
                                Puzzle[m.Key].Text = puzzleOneAnswer[m.Key].ToString();
                                return;
                            }
                        }
                    }


                    break;
                case 2:

                    for (int i = 0; i < puzzleTwo.Count; i++)
                    {
                        if (Puzzle[i].Text.ToString() == "")
                        {
                            cheaterList.Add(i, Puzzle[i]);
                        }
                    }

                    if (cheaterList.Count == 0)
                    {
                        for (int i = 0; i < puzzleTwo.Count; i++)
                        {
                            if (Puzzle[i].Text.ToString() != puzzleTwoAnswer[i].ToString())
                            {
                                Puzzle[i].Text = puzzleTwoAnswer[i].ToString();
                                return;
                            }
                        }
                    }
                    else
                    {
                        randomNumber = getRNG(cheaterList.Count);

                        foreach (KeyValuePair<int, MaskedTextBox> m in cheaterList)
                        {
                            cheaterCount++;
                            if (cheaterCount == randomNumber)
                            {
                                Puzzle[m.Key].Text = puzzleTwoAnswer[m.Key].ToString();
                                return;
                            }
                        }
                    }

                    break;

                case 3:

                    for (int i = 0; i < puzzleThree.Count; i++)
                    {
                        if (Puzzle[i].Text.ToString() == "")
                        {
                            cheaterList.Add(i, Puzzle[i]);
                        }
                    }

                    if (cheaterList.Count == 0)
                    {
                        for (int i = 0; i < puzzleOne.Count; i++)
                        {
                            if (Puzzle[i].Text.ToString() != puzzleThreeAnswer[i].ToString())
                            {
                                Puzzle[i].Text = puzzleThreeAnswer[i].ToString();
                                return;
                            }
                        }
                    }
                    else
                    {
                        randomNumber = getRNG(cheaterList.Count);

                        foreach (KeyValuePair<int, MaskedTextBox> m in cheaterList)
                        {
                            cheaterCount++;
                            if (cheaterCount == randomNumber)
                            {
                                Puzzle[m.Key].Text = puzzleThreeAnswer[m.Key].ToString();
                                return;
                            }
                        }
                    }

                    break;
                default:

                    Console.WriteLine("HOW DID WE GET HERE?!");
                    break;
            }
        }
        
        //This function sets the rng.
        private int getRNG(int r)
        {
            return (rng.Next() % r) + 1;
        }
    }
}
