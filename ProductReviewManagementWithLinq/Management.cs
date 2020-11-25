using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ProductReviewManagementWithLinq
{
    /// <summary>
    /// this class is mainly used to perform operations
    /// </summary>
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// UC 2
        /// Tops the records.
        /// </summary>
        /// <param name="listReview">The list review.</param>
        public void TopRecords(List<ProductReview> listReview)
        {
            //from productreviews of object table listreview 
            //performing an orderby operation in descending order over rating column
            //so that top 3 records will be taken from list
            var recordedData = (from productReviews in listReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            Console.WriteLine("\nTop 3 high rated products are:");

            foreach (var v in recordedData)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.isLike}");
            }
        }

        /// <summary>
        /// UC 3
        /// Selecteds the records.
        /// </summary>
        /// <param name="listReview">The list review.</param>
        public void SelectedRecords(List<ProductReview> listReview)
        {
            //from productreviews of object table listreview retrieve review
            //where productreviews of product id 1 4 and 9
            //and rating greater than 3
            var recordedData = (from productReviews in listReview
                                where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) && productReviews.Rating > 3
                                select productReviews);

            Console.WriteLine("\nProducts with rating greater than 3 and id=1 or 4 or 9 are:");

            foreach (var v in recordedData)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.isLike}");
            }
        }
    }
 }
