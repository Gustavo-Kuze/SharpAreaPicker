using System;
using System.Drawing;

namespace SharpAreaPicker
{
    public static class AreaPicker
    {
        /// <summary>
        /// Invokes the dialog
        /// </summary>
        private static Tuple<Point, Size> show()
        {
            Point pickerLocation = new Point();
            Size pickerSize = new Size();
            Tuple<Point, Size> selectedAreaTuple = new Tuple<Point, Size>(Point.Empty, Size.Empty);

            Forms.AreaPickerDialog frmAreaPicker = new Forms.AreaPickerDialog();
            if (frmAreaPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pickerLocation = frmAreaPicker.Location;
                pickerSize = frmAreaPicker.Size;
                selectedAreaTuple = new Tuple<Point, Size>(pickerLocation, pickerSize);
            }

            return selectedAreaTuple;
        }


        /// <summary>
        /// Used to invoke the area picker dialog and get the screenshot
        /// </summary>
        public static Image screenshot()
        {
            var area = show();
            if (area.Item1 != Point.Empty && area.Item2 != Size.Empty)
            {
                return getScreenshotFromSelectedArea(area);
            }
            return null;
        }


        /// <summary>
        /// Gets the actual "screenshot" of the screen
        /// </summary>
        /// <param name="area">A tuple returned from the show function, which contains the Point and the Size needed to process the screenshot</param>
        private static Image getScreenshotFromSelectedArea(Tuple<Point, Size> area)
        {
            Rectangle rectangle = new Rectangle(area.Item1, area.Item2);
            using (Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(rectangle.Left, rectangle.Top), Point.Empty, rectangle.Size);
                }
                return Image.FromHbitmap(bitmap.GetHbitmap());
            }
        }

    }
}
