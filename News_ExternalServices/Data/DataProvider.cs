using News_Model.NewsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace News_ExternalServices.Data
{
    public class DataProvider
    {
        SqlConnection conn;
        public void connect()
        {
            conn = new SqlConnection(@"Server=den1.mssql7.gear.host; Database=milliyet; User Id=milliyet; Password=Om7j~3tGs99_;");
            conn.Open();
        }

        public void disconnect()
        {
            conn.Close();
        }

        public List<Categori> getCategory()
        {
            List<Categori> categoryList = new List<Categori>();
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Category", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Categori category = new Categori();
                category.ID = Convert.ToInt32(item["ID"]);
                category.CategoryID = Convert.ToInt32(item["CategoryID"]);
                category.MainCategoryID = Convert.ToInt32(item["MainCategoryID"]);
                category.Name = item["Name"].ToString();
                category.ImgPath = item["ImgPath"].ToString();
                category.MainCategoryID = Convert.ToInt32(item["CategoryOrder"]);

                categoryList.Add(category);
            }
            disconnect();

            return categoryList;
        }

        public List<SubCategori> getSubCategori(int CategoryID)
        {
            List<SubCategori> subCategoryList = new List<SubCategori>();
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select *, c.ContentID from SubCategory sc join Content c on sc.ID = c.CategoryID where sc.CategoryID =" + CategoryID + " order by sc.CategoryID desc", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                SubCategori subCategory = new SubCategori();
                subCategory.ID= Convert.ToInt32(item["ID"]);
                subCategory.CategoryID = Convert.ToInt32(item["CategoryID"]);
                subCategory.CategoryName = item["CategoryName"].ToString();
                subCategory.CategoryTitle = item["CategoryTitle"].ToString();
                subCategory.ImgPath = item["ImgPath"].ToString();
                subCategory.ContentID = Convert.ToInt32(item["ContentID"]);

                subCategoryList.Add(subCategory);
            }
            disconnect();

            return subCategoryList;
        }

        public List<Comment> getComment(int ContentID)
        {
            List<Comment> commentList = new List<Comment>();
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Comment where ContentID = " + ContentID + " order by ContentID desc", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Comment comment = new Comment();
                comment.ID = Convert.ToInt32(item["ID"]);
                comment.ContentID = Convert.ToInt32(item["ContentID"]);
                comment.CommentID = Convert.ToInt32(item["CommentID"]);
                comment.Text = item["Text"].ToString();
                comment.CreatedDate = item["CreatedDate"].ToString();

                commentList.Add(comment);
            }

            disconnect();

            return commentList;
        }

        public Content getContent(int ContentID)
        {
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Content where ContentID= " + ContentID, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Content content = new Content();
            content.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            content.ContentID = Convert.ToInt32(dt.Rows[0]["ContentID"]);
            content.CategoryID = Convert.ToInt32(dt.Rows[0]["CategoryID"]);
            content.Text = dt.Rows[0]["Text"].ToString();
            content.CreatedDate = Convert.ToDateTime(dt.Rows[0]["CreatedDate"]).ToString();

            disconnect();

            return content;
        }

        public List<LastMuniteSubCategori> getLastMuniteSubCategori()
        {
            List<LastMuniteSubCategori> lastMuniteSubCategoriList = new List<LastMuniteSubCategori>();
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from LastMuniteSubCategori", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                LastMuniteSubCategori lastMuniteSubCategori = new LastMuniteSubCategori();
                lastMuniteSubCategori.CategoryID = Convert.ToInt32(item["CategoryID"]);
                lastMuniteSubCategori.NewsDate = Convert.ToDateTime(item["NewsDate"]).ToString();
                lastMuniteSubCategori.NewsTitle = item["NewsTitle"].ToString();
                lastMuniteSubCategori.NewsOrder = Convert.ToInt32(item["NewsOrder"]).ToString();

                lastMuniteSubCategoriList.Add(lastMuniteSubCategori);
            }

            disconnect();

            return lastMuniteSubCategoriList;
        }

        public List<MainPageSliderNew> getMainPageSliderNew()
        {
            List<MainPageSliderNew> mainPageSliderNewiList = new List<MainPageSliderNew>();
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from MainPageSliderNews", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                MainPageSliderNew mainPageSliderNew = new MainPageSliderNew();
                mainPageSliderNew.ID = Convert.ToInt32(item["ID"]);
                mainPageSliderNew.ContentID = Convert.ToInt32(item["ContentID"]);
                mainPageSliderNew.CategoryID = Convert.ToInt32(item["CategoryID"]);
                mainPageSliderNew.CategoryName = item["CategoryName"].ToString();
                mainPageSliderNew.ImgPath = item["ImgPath"].ToString();
                mainPageSliderNew.SliderOrder = Convert.ToInt32(item["SliderOrder"].ToString());

                mainPageSliderNewiList.Add(mainPageSliderNew);
            }

            disconnect();

            return mainPageSliderNewiList;
        }

        public List<WriterSubCategori> getWriterSubCategori()
        {
            List<WriterSubCategori> writerSubCategoriList = new List<WriterSubCategori>();
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from SubCategory", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                WriterSubCategori writerSubCategori = new WriterSubCategori();
                writerSubCategori.ID = Convert.ToInt32(item["ID"]);
                writerSubCategori.CategoryID = Convert.ToInt32(item["CategoryID"]);
                writerSubCategori.CategoryName = item["CategoryName"].ToString();
                writerSubCategori.WriteTitle = item["CategoryTitle"].ToString();
                writerSubCategori.ImgPath = item["ImgPath"].ToString();
                writerSubCategori.WriteOrder = Convert.ToInt32(item["NewsOrder"]);

                writerSubCategoriList.Add(writerSubCategori);
            }

            disconnect();

            return writerSubCategoriList;
        }

        public Write getWrite(int WriteID)
        {
            connect();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Write where WriteID= " + WriteID, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Write writer = new Write();
            writer.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            writer.WriteID = Convert.ToInt32(dt.Rows[0]["WriteID"]);
            writer.Name = dt.Rows[0]["Name"].ToString();
            writer.PhotoPath = dt.Rows[0]["PhotoPath"].ToString();
            writer.WriteTitle = dt.Rows[0]["WriteTitle"].ToString();
            writer.WriteDate = dt.Rows[0]["WriteDate"].ToString();
            writer.WriteContent = dt.Rows[0]["WriteContent"].ToString();

            disconnect();

            return writer;
        }
    }
}