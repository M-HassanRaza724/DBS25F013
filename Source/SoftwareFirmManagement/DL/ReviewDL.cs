using Mysqlx.Crud;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareFirmManagement.DL
{
    class ReviewDL
    {
        public static List<ReviewDAO> allReviews = new List<ReviewDAO>();
        public static void AddReviewToDatabase(ReviewDAO review)
        {
            string query = $"INSERT INTO reviews (order_id, reviewer_name, stars, date, description) VALUES ({review.OrderId}, '{review.ReviewerName}', {review.Stars}, '{review.Date.ToString("yyyy-MM-dd")}', '{review.Description}');";
            DatabaseHelper.Instance.Update(query);
            AddReviewInList(review);
        }

        public static void DeleteReviewFromDatabase(int reviewId)
        {
            string query = $"DELETE FROM finalprojectdb.reviews WHERE(review_id = {reviewId})";
            DatabaseHelper.Instance.Update(query);
            DeleteReviewInList(reviewId);
        }

        public static void UpdateReviewInDatabase(ReviewDAO review)
        {
            string query = $"UPDATE finalprojectdb.reviews SET reviewer_name = '{review.ReviewerName}', stars = { review.Stars}, date = '{review.Date.ToString("yyyy-mm-dd")}', description = '{review.Description}' WHERE(review_id = { review.ReviewId})";
            DatabaseHelper.Instance.Update(query);
            UpdateReviewInList(review);
        }

        public static void LoadAllReviews()
        {
            try
            {
                allReviews.Clear();
                string query = "SELECT * FROM reviews;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int reviewId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    int orderId = data.IsDBNull(1) ? 0 : data.GetInt32(1);
                    string reviewerName = data.GetString(2);
                    int stars = data.IsDBNull(3) ? 1 : data.GetInt32(3);
                    DateTime date = data.IsDBNull(4) ? DateTime.Now : data.GetDateTime(4);
                    string description = data.GetString(5);
                    ReviewDAO review = new ReviewDAO(reviewId, orderId, reviewerName, stars, date, description);
                    allReviews.Add(review);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }
        public static bool UpdateReviewInList(ReviewDAO review)
        {
            for (int i = 0; i < allReviews.Count; i++)
            {
                if (allReviews[i].ReviewId == review.ReviewId)
                {
                    allReviews[i] = review;
                    return true;
                }

            }
            return false;
        }
        public static bool AddReviewInList(ReviewDAO review)
        {
            allReviews.Add(review);
            return true;
        }
        public static bool DeleteReviewInList(int reviewId)
        {
            for (int i = 0; i < allReviews.Count; i++)
            {
                if (allReviews[i].ReviewId == reviewId)
                {
                    allReviews.RemoveAt(i);
                    return true;
                }

            }
            return false;
        }
        public static bool ReviewExist(int orderId)
        {
            foreach (ReviewDAO r in ReviewDL.allReviews)
            {
                if (r.OrderId == orderId)
                    return true;
            }
            return false;
        }
    }
}
