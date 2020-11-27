using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

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

        /// <summary>
        /// UC4
        /// Retrieves the count of records.
        /// </summary>
        /// <param name="listReview">The list review.</param>
        public void RetrieveCountOfRecords(List<ProductReview> listReview)
        {
            //using object listReview also by grouping the object i.e ProductId
            //and then selecting ProductId and then count is used 
            var recordedData = listReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            Console.WriteLine("ProductId and their review count:");

            foreach (var v in recordedData)
            {
                Console.WriteLine($"ProductID:{v.ProductID},ReviewCount:{v.Count}");
            }
        }

        /// <summary>
        /// UC5
        /// Retrieves the product identifier and review.
        /// </summary>
        /// <param name="listReview">The list review.</param>
        public void RetrieveProductIdAndReview(List<ProductReview> listReview)
        {
            //from productreviews of object table listreview retrieve 
            //only product id and review product reviews from the list
            var recordedData = from productReviews in listReview
                               select new
                               {
                                   productReviews.ProductID,
                                   productReviews.Review
                               };

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id:- " + list.ProductID + " " + "Review: " + list.Review);
            }
        }

        /// <summary>
        /// UC6
        /// Retrieves the products by skipping top5.
        /// </summary>
        /// <param name="listReview">The list review.</param>
        public void RetrieveProductsBySkippingTop5(List<ProductReview> listReview)
        {
            //from productreviews of object table listreview retrieve 
            //retrieve list of product reviews from product review
            //by skipping top 5 records from list
            var recordedData = (from productReviews in listReview
                                select productReviews).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "UserId: " + list.UserID + "Rating: " + list.Rating
                    + "Review: " + list.Review + "IsLike: " + list.isLike);
            }
        }

        /// <summary>
        /// UC7
        /// Retrieves the only product identifier and review of all records using select.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveOnlyProductIDAndReviewOfAllRecordsUsingSelect(List<ProductReview> productList)
        {
            var recordedData = productList.Select(x => new { ProductId = x.ProductID, Review = x.Review });
            Console.WriteLine("\nProductId and its review using LINQ select:");
            foreach (var v in recordedData)
            {
                Console.WriteLine($"ProductID:{v.ProductId},ReviewCount:{v.Review}");
            }
        }
    }
}
