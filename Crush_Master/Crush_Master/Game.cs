
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Crush_Master

{
    class Game
    {
        public int counter = 0;

        public int Next(bool arg)
        {

            if (arg)
            {
                counter += 1;
                return counter;
            }
            else return counter;
        }

        public event Action Win;
        public event Action Loss;

        Image _backgroundSprite;
        GameObject _paddle;
        GameObject _paddle2;
        Ball _ball;

        Image SpriteBackground(string imgBG) { return SpriteData.Load(imgBG); }
        GameObject SpritePaddle(string imgPaddle) { return new Ball(SpriteData.Load(imgPaddle)); }
        Ball SpriteBall(string imgBall, int speed) { return new Ball(SpriteData.Load(imgBall)) { Velocity = speed }; }

        private Level _level; // лучше создать коллекцию, елси хотим больше одного уровня

        private DateTime _dateTime;
        private bool _gameStart;

        public Size Size { get; set; }
        public int Width { get { return Size.Width; } }
        public int Height { get { return Size.Height; } }
        //public int Width => Size.Width ;
        //public int Height => Size.Height;

        
        // Это нужно заполнять вручную с помошью своего редактора. В данном случае просто заглушка
        private Level GenerateLevelFirst()
        {
            _backgroundSprite = SpriteBackground("Zadnik1.png");
            _paddle = SpritePaddle("Platforma1.png");
            _ball = SpriteBall("Shar1.png", 25);

            var blockCount = 17;
            var blockSprite = SpriteData.Load("Kirpich1.png");
            var blockStepX = blockSprite.Width / 2;

            var startPosition = new Point((Width - (blockSprite.Width * blockCount) - (blockStepX * (blockCount - 1))) / 2, blockSprite.Height);

            var level = new Level { Blocks = new List<Block>(blockCount) };

            for (int i = 0; i < blockCount; i++)
            {
                if (i <= 4)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i+6) * (blockSprite.Width + blockStepX)), startPosition.Y + 25) });
                }
                else if (i > 4 && i <= 11)
                {   
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i) * (blockSprite.Width + blockStepX)), startPosition.Y + 100) });
                }
                else if (i > 11 && i <= 16)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i - 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 175) });
                }
            }

            return level;
        }

        private Level GenerateLevelSecond()
        {
            _backgroundSprite = SpriteBackground("Zadnik2.png");
            _paddle = SpritePaddle("Platforma2.png");
            _ball = SpriteBall("Shar2.png", 20);

            var blockCount = 17;
            var blockSprite = SpriteData.Load("Kirpich2.png");
            var blockStepX = blockSprite.Width / 2;

            var startPosition = new Point((Width - (blockSprite.Width * blockCount) - (blockStepX * (blockCount - 1))) / 2, blockSprite.Height);

            var level = new Level { Blocks = new List<Block>(blockCount) };

            for (int i = 0; i < blockCount; i++)
            {
                if (i <= 4)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i + 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 25) });
                }
                else if (i > 4 && i <= 11)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i) * (blockSprite.Width + blockStepX)), startPosition.Y + 100) });
                }
                else if (i > 11 && i <= 16)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i - 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 175) });
                }
            }

            return level;
        }

        private Level GenerateLevelThree()
        {
            _backgroundSprite = SpriteBackground("Zadnik3.png");
            _paddle = SpritePaddle("Platforma3.png");
            _ball = SpriteBall("Shar3.png", 25);

            var blockCount = 17;
            var blockSprite = SpriteData.Load("Kirpich3.png");
            var blockStepX = blockSprite.Width / 2;

            var startPosition = new Point((Width - (blockSprite.Width * blockCount) - (blockStepX * (blockCount - 1))) / 2, blockSprite.Height);

            var level = new Level { Blocks = new List<Block>(blockCount) };

            for (int i = 0; i < blockCount; i++)
            {
                if (i <= 4)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i + 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 25) });
                }
                else if (i > 4 && i <= 11)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i) * (blockSprite.Width + blockStepX)), startPosition.Y + 100) });
                }
                else if (i > 11 && i <= 16)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i - 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 175) });
                }
            }

            return level;
        }

        private Level GenerateLevelFour()
        {
            _backgroundSprite = SpriteBackground("Zadnik3.png");
            _paddle = SpritePaddle("Platforma3.png");
            _paddle2 = SpritePaddle("Platforma3(2).png");
            _ball = SpriteBall("Shar3.png", 0);
            

            var blockCount = 17;
            var blockSprite = SpriteData.Load("Kirpich3.png");
            var blockStepX = blockSprite.Width / 2;

            var startPosition = new Point((Width - (blockSprite.Width * blockCount) - (blockStepX * (blockCount - 1))) / 2, blockSprite.Height +300);

            var level = new Level { Blocks = new List<Block>(blockCount) };

            for (int i = 0; i < blockCount; i++)
            {
                if (i <= 4)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i + 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 25) });
                }
                else if (i > 4 && i <= 11)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i) * (blockSprite.Width + blockStepX)), startPosition.Y + 100) });
                }
                else if (i > 11 && i <= 16)
                {
                    level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + ((i - 6) * (blockSprite.Width + blockStepX)), startPosition.Y + 175) });
                }
            }

            return level;
        }

        public void Start(int i)
        {
            if (i == 0)
            {
                _level = GenerateLevelFirst();
            }
            else if (i == 1)
            {
                _level = GenerateLevelSecond();
            }
            else if (i == 2)
            {
                _level = GenerateLevelThree();
            }
            else if (i == 3)
            {
                _level = GenerateLevelFour();
               
            }
            _gameStart = true;
            _paddle.Position = new Point((Width - _paddle.Width) / 2, Height - _paddle.Height - 50);
           _paddle2.Position = new Point((Width - _paddle.Width) / 2, _paddle.Height);
            _ball.Position = new Point((Width - _ball.Width) / 2, _paddle.Position.Y - _ball.Height);

            _ball.Direction = BallDirection.RightUp;

            _dateTime = DateTime.Now;

        }

        public void Stop()
        {
            _gameStart = false;
        }

        public void SetPaddlePosition(int x)
        {
            _paddle.Position = new Point(x - (_paddle.Width / 2), _paddle.Position.Y);
            //_paddle2.Position = new Point(x- (_paddle2.Width / 2), _paddle2.Position.Y);
        }

        public void SetPaddle2Position(int x)
        {
            _paddle2.Position = new Point(Width - x - (_paddle2.Width / 2), _paddle2.Position.Y);
        }

        public void Collide(Ball gameObject, Rectangle rect2)
        {

            // Обьект столкнулся сверху или снизу, отражаем направление полета по горизонтали
            if (rect2.Left <= gameObject.Position.X + (gameObject.Width / 2) && gameObject.Position.X + (gameObject.Width / 2) <= rect2.Right)
                gameObject.ReflectHorizontal();

            // Обьект столкнулся слева или справа, отражаем направление полета по вертикали
            else if (rect2.Top <= gameObject.Position.Y + (gameObject.Height / 2) && gameObject.Position.Y + (gameObject.Height / 2) <= rect2.Bottom)
                gameObject.ReflectVertical();
        }



        public void Update(Graphics graphics) // грубо говоря вызывается при каждом кадре
        {
            int newX = 0, newY = 0;

            switch (_ball.Direction)
            {
                case BallDirection.LeftUp:
                    newX = _ball.Position.X - _ball.Velocity;
                    newY = _ball.Position.Y - _ball.Velocity;
                    break;
                case BallDirection.RightUp:
                    newX = _ball.Position.X + _ball.Velocity;
                    newY = _ball.Position.Y - _ball.Velocity;
                    break;
                case BallDirection.LeftBottom:
                    newX = _ball.Position.X - _ball.Velocity;
                    newY = _ball.Position.Y + _ball.Velocity;
                    break;
                case BallDirection.RightBottom:
                    newX = _ball.Position.X + _ball.Velocity;
                    newY = _ball.Position.Y + _ball.Velocity;
                    break;
            }

            _ball.Position = new Point(newX, newY);

            // Столкновение с верхним краем игрового поля
             //if (_ball.Position.Y <= 0)
               //  _ball.ReflectHorizontal();
            

            // При сталкивании мяча с нижним краем игрового поля
            if (_ball.Position.Y >= Height - _ball.Height)
            {
                Stop();
                // Loss?.Invoke(); // Проигрыш 
                Loss.Invoke(); // Проигрыш 
                Next(_level.IsComplited());
            }

            // При сталкивании мяча с верхним краем игрового поля
            if (_ball.Position.Y >= Height - _ball.Height || _ball.Position.Y <= 0)
            {
                Stop();
                // Loss?.Invoke(); // Проигрыш 
                Loss.Invoke(); // Проигрыш 
                Next(_level.IsComplited());
            }

            // Столкновение мячика с левым или правым краем игрового поля
            if ((_ball.Position.X >= Width - _ball.Width) || _ball.Position.X <= 0)
            {
                _ball.ReflectVertical();
            }

            // Столкновение мячика с ракеткой
            if (_ball.Bounds.IntersectsWith(_paddle.Bounds))
            {
                _ball.Collide(_paddle);
            }

            if (_ball.Bounds.IntersectsWith(_paddle2.Bounds))
            {
                _ball.Collide(_paddle2);
            }


            // Столкновение мячика с кирпичами
            foreach (var block in _level.Blocks)
            {
                if (_ball.Bounds.IntersectsWith(block.Bounds) && block.IsAlive)
                {
                    block.IsAlive = false;
                    _ball.Collide(block);
                }
            }


            if (_level.IsComplited())
            {
                Next(_level.IsComplited());
                Stop();
               // Win?.Invoke(); // Победа
                Win.Invoke(); // Победа
            }

            Draw(graphics);

            _dateTime = DateTime.Now;
        }

        private void Draw(Graphics graphics)
        {
            using (var brush = new TextureBrush(_backgroundSprite))
            {
                // Фон
                graphics.FillRectangle(brush, new Rectangle(new Point(), Size));

                if (!_gameStart)
                    return;

                // Уровень(карпичи)
                //_level?.Draw(graphics);
                _level.Draw(graphics);
                // Платформа
                _paddle.Draw(graphics);

                                                                          _paddle2.Draw(graphics);

                // Мяч
                _ball.Draw(graphics);
            }
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////



// Это нужно заполнять вручную с помошью своего редактора. В данном случае просто заглушка
/*private Level GenerateLevel()
{
var blockCount = 5;
var blockSprite = SpriteData.Load("element_green_rectangle.png");
var blockStepX = blockSprite.Width / 2;

var startPosition = new Point((Width - (blockSprite.Width * blockCount) - (blockStepX * (blockCount - 1))) / 2, blockSprite.Height);

var level = new Level { Blocks = new List<Block>(blockCount) };

for (int i = 0; i < blockCount; i++)
level.Blocks.Add(new Block(blockSprite) { Position = new Point(startPosition.X + (i * (blockSprite.Width + blockStepX)), startPosition.Y) });

return level;
}
*/
