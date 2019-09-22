using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Catel.MVVM;

namespace ConvolutionWpf.Commands
{
    public class ContrastCommand : Command
    {
        private readonly Func<WriteableBitmap> _imageFactory;

        public ContrastCommand(Func<WriteableBitmap> imageFactory)
            : base(() => { })
        {
            _imageFactory = imageFactory;
        }

        private static int[] CumulativeHistogram(int[] histogram)
        {
            for (int h = 1; h < 256; h++)
            {
                histogram[h] = histogram[h - 1] + histogram[h];
            }
            return histogram;
        }

        private static int[] Histogram(WriteableBitmap image, byte[] pixels)
        {
            int[] histogram = new int[256];
            for (int i = 0; i < image.PixelWidth; i++)
            {
                for (int j = 0; j < image.PixelHeight; j++)
                {
                    int index = j * image.BackBufferStride + 4 * i;
                    for (int col = 0; col <= 2; col++)
                    {
                        histogram[pixels[index + col]] += 1;
                    }
                }
            }
            return histogram;
        }

        public void ExecuteCommand()
        {
            var image = _imageFactory();
            if (image == null)
                return;

            var pixels = new byte[image.PixelHeight * image.BackBufferStride];
            image.CopyPixels(pixels, image.BackBufferStride, 0);
            var resultPixels = new byte[image.PixelHeight * image.BackBufferStride];

            var p = 0.005;
            double min = 0;
            double max = 255;

            var pixelsSize = 3 * image.PixelHeight * image.PixelWidth;
            var histogram = Histogram(image, pixels);

            var cumulativeHistogram = CumulativeHistogram(histogram);

            for (int j = 0; j < 256; j++)
            {
                if (cumulativeHistogram[j] >= pixelsSize * p)
                {
                    min = j;
                    break;
                }
            }

            for (int i = 255; i >= 0; i--)
            {
                if (cumulativeHistogram[i] <= pixelsSize * (1 - p))
                {
                    max = i;
                    break;
                }
            }

            for (int i = 0; i < image.PixelWidth; i++)
            {
                for (int j = 0; j < image.PixelHeight; j++)
                {
                    var index = j * image.BackBufferStride + 4 * i;
                    for (int c = 0; c < 3; c++)
                    {
                        var a = pixels[index + c];
                        double b = 0;
                        if (a <= min)
                        {
                            b = 0;
                        } else if (a >= max) {
                            b = 255;
                          } else {
                              b = (a - min) / (max - min) * 255;
                            }
                        resultPixels[index + c] = Convert.ToByte(b);
                    }
                    resultPixels[index + 3] = Convert.ToByte(255); 
                }
            }
            image.WritePixels(new Int32Rect(0, 0, image.PixelWidth, image.PixelHeight), resultPixels, image.BackBufferStride, 0);
        }
        protected override void Execute(object parameter, bool ignoreCanExecuteCheck)
        {
            ExecuteCommand();
        }
    }
}