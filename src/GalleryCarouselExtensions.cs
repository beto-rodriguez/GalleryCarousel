﻿// The MIT License(MIT)
//
// Copyright(c) 2021 Alberto Rodriguez Orozco
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace GalleryCarousel;

public static class GalleryCarouselExtensions
{
    public static Task[] CarouselTransform(
        this VisualElement visual,
        double x,
        double y,
        double rotation,
        double scale,
        uint duration,
        Easing easing)
    {
        var centeredX = x - visual.Width * 0.5;
        var centeredY = y - visual.Height * 0.5;

        return
        [
            visual.TranslateTo(centeredX, centeredY, duration, easing),
            visual.ScaleTo(scale, duration, easing),
            visual.RotateTo(rotation, duration, easing),
        ];
    }
}
