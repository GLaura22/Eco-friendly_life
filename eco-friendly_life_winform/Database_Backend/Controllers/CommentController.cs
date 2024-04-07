using eco_friendly_life_winform.Database_Backend.Connection;
using eco_friendly_life_winform.Database_Backend.Tables;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Database_Backend.Controllers
{
    internal class CommentController
    {

        public byte[] ImageConvertToByteArray(Image mealImage)
        {
            // Convert image to byte array
            byte[] imageByteArray;
            using (MemoryStream ms = new MemoryStream())
            {
                // Assuming mealImage is an instance of System.Drawing.Image
                //mealImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                mealImage.Save(ms, mealImage.RawFormat);
                imageByteArray = ms.ToArray();
                //MessageBox.Show(imageByteArray.ToString());
            }

            // Now assign the byte array to the MealImage property of the comment
            //comment.MealImage = imageByteArray;
            return imageByteArray;
        }

        public Image ByteArrayConvertToImage(byte[] imageByteArray)
        {
            // Convert byte array back to image
            Image image;
            using (MemoryStream ms = new MemoryStream(imageByteArray))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        public int AddComment(Comment comment)
        {
            try
            {
                /* SQL Connection. */
                var context = new AppDbContext();

                /* Insert data into Database. */
                context.Comments.Add(comment);
                context.SaveChanges();

                /* Get last inserted ID. */
                var id = context.Comments.OrderBy(row => row.UserID).Last();

                /* Return the previously saved ID. */
                return id.CommentID;
            }
            catch (Exception)
            {
                /* On error. */
                return 0; // Return 0 to easily check if there is a problem or not.
            }
        }

        public List<Comment> GetCommentList()
        {
            using (var context = new AppDbContext())
            {
                return context.Comments.ToList();
            }
        }
    }
}
