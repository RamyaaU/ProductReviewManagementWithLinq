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
        }
    }
}
