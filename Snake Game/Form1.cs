using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        const int MOVE_VALUE = 22;

        int inputX = 0;
        int inputY = -MOVE_VALUE; // starts it moving upwards

        int x = 0;
        int y = -MOVE_VALUE; // starts it moving upwards
        int bodNum = 3;

        int foodX = 0;
        int foodY = 0;

        int score = 0;

        List<PictureBox> snake = new List<PictureBox>();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            snake.Add(snakeHead);
            snake.Add(snakeBody1);
            snake.Add(snakeBody2);

            GenerateFood();

            Time.Start();
        }

        // Game loop that will tick every 1000 milliseconds (1 seconds)
        private void Time_Tick(object sender, EventArgs e)
        {
            if (snakeHead.Location.X >= this.Width || snakeHead.Location.X <= 0 || snakeHead.Location.Y >= this.Height - 22 || snakeHead.Location.Y <= 0)
            {
                Time.Enabled = false;
                MessageBox.Show("You lose. Your Score is: " + score);
            }

            x = inputX;
            y = inputY;
            SnakeMovement();
            Collisions();
            Eat();
        }

        // Movement
        private void Form1_KeyDown(object sender, KeyEventArgs e) // gets keyboard input
        {
            if (e.KeyCode == Keys.Up)
            {
                if (y == MOVE_VALUE) // makes sure you can't go backwards
                    return;

                inputX = 0;
                inputY = -MOVE_VALUE;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (y == -MOVE_VALUE)
                    return;

                inputX = 0;
                inputY = MOVE_VALUE;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (x == -MOVE_VALUE)
                    return;

                inputX = MOVE_VALUE;
                inputY = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (x == MOVE_VALUE)
                    return;

                inputX = -MOVE_VALUE;
                inputY = 0;
            }
        }
        private void SnakeMovement()
        {
            for (int i = snake.Count - 1; i > 0; i--) // ensures that the rest of the body parts all follow the head
            {
                snake[i].Location = new Point(snake[i - 1].Location.X, snake[i - 1].Location.Y);
            }

            snakeHead.Location = new Point(snakeHead.Location.X + x, snakeHead.Location.Y + y);

        }

        // Adding to the Body
        private void Eat()
        {
            if (food.Location == snakeHead.Location)
            {
                score++;
                GrowSnake();
                GenerateFood();
            }
        }
        private void GrowSnake()
        {
            PictureBox snakeBody = new PictureBox()
            {
                Name = "snakeBody" + bodNum,
                Size = new Size(20, 20),
                BackColor = Color.DarkSeaGreen,
                Location = new Point(1000, 1000)
            };

            bodNum++;
            snake.Add(snakeBody);
            Controls.Add(snakeBody);

        }

        // Collisions for snake and boundaries
        private void Collisions()
        {
            bool isTouchingSnake;
            do
            {
                int tempX = snakeHead.Left;
                int tempY = snakeHead.Top;

                isTouchingSnake = false;

                for (int i = 1; i < snake.Count; i++)
                {
                    if (tempX == snake[i].Location.X && tempY == snake[i].Location.Y)
                    {
                        Time.Enabled = false;
                        MessageBox.Show("You lose. Your Score is: " + score);
                        break;
                    }
                }
            } while (isTouchingSnake);
        }

        // Food
        private void GenerateFood()
        {
            bool isOnSnake;
            do
            {
                foodX = rand.Next(0, 20);
                foodY = rand.Next(0, 20);
                food.Left = foodX * MOVE_VALUE;
                food.Top = foodY * MOVE_VALUE;

                isOnSnake = false;

                for (int i = 0; i < snake.Count; i++)
                {
                    if (food.Location.X == snake[i].Location.X && food.Location.Y == snake[i].Location.Y)
                    {
                        isOnSnake = true;
                        break;
                    }
                }
            } while (isOnSnake);
        }

    }
}
