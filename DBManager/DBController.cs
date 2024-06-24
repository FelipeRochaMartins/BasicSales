using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Data;
using System.Dynamic;
using System.Collections;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace DBManager
{
    public class DBController
    {
        private static string Directory_ = AppDomain.CurrentDomain.BaseDirectory;
        private static DirectoryInfo dirInfo = new DirectoryInfo(Directory_);
        private static string DataBasePath
        {
            get
            {
                string assemblyPath = Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(assemblyPath);
                return Path.Combine(directory, @"BasicSData.sdf");
            }
        }
        private static string SQLServerCEConnection = $@"Data Source = {DataBasePath};
                                                        Max Database Size=4091;
                                                        Password = 17nxdNFhsyhHbDE3t9Uow7j65LlCZCNz;";

        private void Configure()
        {
            SqlCeEngine Db = new SqlCeEngine(SQLServerCEConnection);

            if (!File.Exists(DataBasePath))
            {
                Db.CreateDatabase();
            }
            Db.Dispose();

            string CreateTableProducts =    @"CREATE TABLE Products (
                                              id INT PRIMARY KEY IDENTITY(1, 1),
                                              product_name NVARCHAR(50) NOT NULL,
                                              bar_code NVARCHAR(20) NOT NULL UNIQUE,
                                              description NVARCHAR(255),
                                              validity DATETIME NOT NULL,
                                              purchase_price DECIMAL(10, 2) NOT NULL,
                                              sale_price DECIMAL(10, 2) NOT NULL,
                                              stock INT NOT NULL,
                                              created_at DATETIME NOT NULL,
                                              updated_at DATETIME NOT NULL)";

            string CreateTableSales =       @"CREATE TABLE Sales (
                                              id INT PRIMARY KEY IDENTITY(1, 1),
                                              products NVARCHAR(255) NOT NULL,
                                              sale_date DATETIME NOT NULL, 
                                              payment NVARCHAR(7) NOT NULL,
                                              modifier NVARCHAR(25),
                                              total_price DECIMAL(10, 2) NOT NULL)";

            string CreateTableStockExtract =  @"CREATE TABLE StockExtract (
                                                id INT PRIMARY KEY IDENTITY(1,1),
                                                date DATETIME NOT NULL,  
                                                operation NVARCHAR(20) NOT NULL,   
                                                quantity INT NOT NULL,           
                                                product_id INT,                 
                                                CONSTRAINT FK_StockExtract_Products FOREIGN KEY (product_id) REFERENCES Products(id))";

            List<string> SQLQuerys = new List<string>(2);
            SQLQuerys.Add(CreateTableProducts);
            SQLQuerys.Add(CreateTableSales);
            SQLQuerys.Add(CreateTableStockExtract);


            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                foreach (string SQL in SQLQuerys)
                {
                    try
                    {
                        conn.Open();

                        SqlCeCommand cmd = new SqlCeCommand(SQL, conn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    catch { }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }

        #region Products Querys

        #region CREATE
        public bool CreateProduct(string Name, string BarCode, string Description, DateTime Validity, double PurchasePrice, double SalePrice, int Stock)
        {
            Configure();

            string AddProductString = @"INSERT INTO Products (product_name,
                                                                bar_code, 
                                                                description,
                                                                validity, 
                                                                purchase_price,
                                                                sale_price,
                                                                stock,
                                                                created_at,
                                                                updated_at)

                                                        VALUES (@product_name,
                                                                @bar_code, 
                                                                @description,
                                                                @validity, 
                                                                @purchase_price,
                                                                @sale_price,
                                                                @stock,
                                                                @created_at,
                                                                @updated_at)";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool added = false;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(AddProductString, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_name", Name);
                        cmd.Parameters.AddWithValue("@bar_code", BarCode);

                        cmd.Parameters.AddWithValue("@validity", Validity.Date);
                        cmd.Parameters.AddWithValue("@purchase_price", PurchasePrice);
                        cmd.Parameters.AddWithValue("@sale_price", SalePrice);
                        cmd.Parameters.AddWithValue("@stock", Stock);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

                        if (Description is null)
                        {
                            cmd.Parameters.AddWithValue("@description", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@description", Description);
                        }

                        int RowsAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (RowsAffected > 0)
                        {
                            added = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return added;
            }
        }
        #endregion

        #region GET
        public DataTable GetAllProducts()
        {
            Configure();

            string GetAllProductsString = @"SELECT id, product_name, bar_code, validity, purchase_price, sale_price, stock FROM Products";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetAllProductsString, conn))
                {
                    try
                    {
                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataTable GetProductsById(int[] ids)
        {
            Configure();

            string GetProductsByIdsString = @"SELECT id, product_name ,stock 
                                                        FROM Products 
                                                        WHERE id 
                                                        IN (" + string.Join(",", ids.Select(id => "@" + id)) + ")";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetProductsByIdsString, conn))
                {
                    try
                    {
                        conn.Open();

                        foreach (int id in ids)
                        {
                            adpt.SelectCommand.Parameters.AddWithValue("@" + id, id);
                        }

                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataRow GetProductById(int id)
        {
            Configure();

            string GetProductByIdString = @"SELECT product_name, 
                                                   bar_code, 
                                                   description, 
                                                   validity, 
                                                   purchase_price, 
                                                   sale_price, 
                                                   stock 
                                            FROM Products 
                                            WHERE id = @id";

            DataTable product = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetProductByIdString, conn))
                {
                    try
                    {
                        adpt.SelectCommand.Parameters.AddWithValue("@id", id);
                        conn.Open();

                        adpt.Fill(product);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return product.Rows[0];
        }

        public string GetProductName(int id)
        {
            Configure();

            string GetProductNameString = @"SELECT product_name
                                            FROM Products 
                                            WHERE id = @id";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                string product = null;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(GetProductNameString, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            product = result.ToString();

                            product = product.Length <= 17 ? product : product.Substring(0, 17) + "...";
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return product;
            }
        }

        public DataTable GetProductsForSale()
        {
            Configure();

            string GetProductsForSaleString = @"SELECT id, product_name, bar_code, sale_price, stock FROM Products WHERE stock > 0";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetProductsForSaleString, conn))
                {
                    try
                    {
                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataTable GetExpiringProducts()
        {
            Configure();

            string GetExpiringProductsString = @"SELECT product_name, 
                                                           validity
                                                    FROM Products
                                                    WHERE validity > '1753-01-01' 
                                                    AND validity <= DATEADD(day, 14, GETDATE())";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetExpiringProductsString, conn))
                {
                    try
                    {
                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }
        #endregion

        #region UPDATE
        public bool UpdateStock(int id, int to_add)
        {
            Configure();

            string AddStockString = @"UPDATE Products SET stock = stock + @add, updated_at = GETDATE() WHERE id = @id";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool added = false;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(AddStockString, conn))
                    {
                        cmd.Parameters.AddWithValue("@add", to_add);
                        cmd.Parameters.AddWithValue("@id", id);

                        int RowsAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (RowsAffected > 0)
                        {
                            added = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return added;
            }
        }

        public bool UpdateStock(Dictionary<int, int> product)
        {
            bool result = false;
            int rowsAffected = 0;
            int count = 0;

            foreach (var kvp in product)
            {
                count++;

                int id = kvp.Key;
                int quantity = kvp.Value;

                string sql = @"UPDATE Products
                                SET stock = CASE
                                    WHEN Stock - @quantity < 0 THEN 0
                                    ELSE Stock - @quantity
                                END
                                WHERE id = @id";

                using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        try
                        {
                            conn.Open();
                            rowsAffected += cmd.ExecuteNonQuery();
                        }
                        catch { }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }

            }

            if (rowsAffected == count)
            {
                result = true;
            }

            return result;

        }

        public void UpdateStock(int id, int quantity, bool put)
        {
            Configure();

            string UpdateStockString;

            if (put)
            {
                UpdateStockString = @"UPDATE Products
                                        SET stock = stock + @quantity
                                        WHERE id = @id";
            }
            else
            {
                UpdateStockString = @"UPDATE Products
                                        SET stock = CASE
                                            WHEN Stock - @quantity < 0 THEN 0
                                            ELSE Stock - @quantity
                                        END
                                        WHERE id = @id";
            }

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(UpdateStockString, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }
            }
        }

        public bool UpdateProduct(int id, string Name, string BarCode, string Description, DateTime Validity, double PurchasePrice, double SalePrice, int Stock)
        {
            Configure();

            string UpdateProductString = @"UPDATE Products 

                                            SET product_name = @product_name,
                                                bar_code = @bar_code,
                                                description = @description,
                                                validity = @validity,
                                                purchase_price = @purchase_price,
                                                sale_price = @sale_price,
                                                stock = @stock,
                                                updated_at = GETDATE()

                                            WHERE id = @id";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool updated = false;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(UpdateProductString, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_name", Name);
                        cmd.Parameters.AddWithValue("@bar_code", BarCode);
                        cmd.Parameters.AddWithValue("@validity", Validity.Date);
                        cmd.Parameters.AddWithValue("@purchase_price", PurchasePrice);
                        cmd.Parameters.AddWithValue("@sale_price", SalePrice);
                        cmd.Parameters.AddWithValue("@stock", Stock);
                        cmd.Parameters.AddWithValue("@id", id);

                        if (Description is null)
                        {
                            cmd.Parameters.AddWithValue("@description", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@description", Description);
                        }

                        int RowsAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (RowsAffected > 0)
                        {
                            updated = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return updated;
            }
        }
        #endregion

        #region DELETE
        public bool DeleteProduct(int id)
        {
            Configure();

            string DeleteRelatedRowsString = @"DELETE FROM StockExtract WHERE product_id = @id";

            string DeleteProductString = @"DELETE Products WHERE id = @id";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool deleted = false;

                try
                {
                    conn.Open();

                    using (SqlCeTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCeCommand cmd = new SqlCeCommand(DeleteRelatedRowsString, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCeCommand cmd = new SqlCeCommand(DeleteProductString, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    deleted = true;
                                }
                            }
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch {}
                finally
                {
                    conn.Close();
                }

                return deleted;
            }
        }
        #endregion

        #endregion

        #region Sales Querys

        #region CREATE
        public bool CreateSale(string Products, string Payment, string Modifier, double Total)
        {
            Configure();

            string AddSaleString = @"INSERT INTO Sales (products,
                                                        sale_date, 
                                                        payment,
                                                        modifier,
                                                        total_price)

                                                VALUES (@products,
                                                        GETDATE(),
                                                        @payment,
                                                        @modifier,
                                                        @total_price)";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool added = false;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(AddSaleString, conn))
                    {
                        cmd.Parameters.AddWithValue("@products", Products);
                        cmd.Parameters.AddWithValue("@payment", Payment);
                        cmd.Parameters.AddWithValue("@total_price", Total);

                        if (Modifier is null)
                        {
                            cmd.Parameters.AddWithValue("@modifier", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@modifier", Modifier);
                        }

                        int RowsAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (RowsAffected > 0)
                        {
                            added = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return added;
            }
        }
        #endregion

        #region GET
        public DataTable GetSales()
        {
            Configure();

            string GetSalesPerDayString = @"SELECT 
                                            CONVERT(nvarchar(10), sale_date, 120) 
                                                AS day,
                                            SUM(total_price) 
                                                AS total
                                            FROM Sales
                                            GROUP BY 
                                                CONVERT(nvarchar(10), sale_date, 120)
                                            ORDER BY 
                                                day";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetSalesPerDayString, conn))
                {
                    try
                    {

                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataTable GetSales(DateTime Start, DateTime End)
        {
            Configure();

            string GetSalesPerDayString = @"SELECT 
                                                CONVERT(nvarchar(10), sale_date, 120) AS day,
                                                SUM(total_price) AS total
                                            FROM 
                                                Sales
                                            WHERE 
                                                sale_date BETWEEN @start_date AND @end_date
                                            GROUP BY 
                                                CONVERT(nvarchar(10), sale_date, 120)
                                            ORDER BY 
                                                day";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetSalesPerDayString, conn))
                {
                    try
                    {
                        adpt.SelectCommand.Parameters.AddWithValue("@start_date", Start.Date);
                        adpt.SelectCommand.Parameters.AddWithValue("@end_date", End.Date);

                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataTable GetSales(string Day)
        {
            Configure();

            string GetSalesPerDayString = @"SELECT 
                                                id, 
                                                sale_date,
                                                payment,
                                                total_price
                                            FROM 
                                                Sales
                                            WHERE 
                                                CONVERT(NVARCHAR(10), sale_date, 23) = @day";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetSalesPerDayString, conn))
                {
                    adpt.SelectCommand.Parameters.AddWithValue("@day", Day);

                    try
                    {
                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataRow GetSales(int id)
        {
            Configure();

            string GetSaleByIdString = @"SELECT products, 
                                                sale_date, 
                                                payment, 
                                                modifier, 
                                                total_price
                                         FROM Sales 
                                         WHERE id = @id";

            DataTable product = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetSaleByIdString, conn))
                {
                    try
                    {
                        adpt.SelectCommand.Parameters.AddWithValue("@id", id);
                        conn.Open();

                        adpt.Fill(product);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return product.Rows[0];
        }
        #endregion

        #region UPDATE
        public bool UpdateSale(int id, string NewProducts, double Total)
        {
            Configure();

            string UpdateSaleProductsString = @"UPDATE Sales 

                                                SET products = @products,
                                                    total_price = @total_price

                                                WHERE id = @id";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool updated = false;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(UpdateSaleProductsString, conn))
                    {
                        cmd.Parameters.AddWithValue("@products", NewProducts);
                        cmd.Parameters.AddWithValue("@total_price", Total);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (rowAffected > 0)
                        {
                            updated = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return updated;
            }
        }
        #endregion

        #region DELETE
        public void DeleteSale(int id)
        {
            Configure();

            string DeleteSaleString = @"DELETE Sales WHERE id = @id";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(DeleteSaleString, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        cmd.Dispose();

                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }
            }
        }

        public bool DeleteSale(string DateString)
        {
            Configure();

            string DeleteSaleString = @"DELETE Sales WHERE CONVERT(nvarchar(10), sale_date, 120) = @date";

            bool sucess = false;

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(DeleteSaleString, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateString);

                        int rowAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (rowAffected > 0)
                        {
                            sucess = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }
            }

            return sucess;
        }
        #endregion

        #endregion

        #region Stock Extract Querys

        #region CREATE
        public bool CreateRegister(string Operation, int Quantity, int ProductID)
        {
            Configure();

            string CreateRegisterString =   @"INSERT INTO StockExtract (date,
                                                                        operation,
                                                                        quantity, 
                                                                        product_id) 

                                                                VALUES (GETDATE(),
                                                                        @operation,
                                                                        @quantity,
                                                                        @product_id);";

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                bool added = false;

                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(CreateRegisterString, conn))
                    {
                        cmd.Parameters.AddWithValue("@operation", Operation);
                        cmd.Parameters.AddWithValue("@quantity", Quantity);
                        cmd.Parameters.AddWithValue("@product_id", ProductID);

                        int RowsAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (RowsAffected > 0)
                        {
                            added = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }

                return added;
            }
        }
        #endregion

        #region GET
        public DataTable GetStock(DateTime Start, DateTime End)
        {
            Configure();

            string GetStockPerDayString = @"SELECT 
                                                CONVERT(nvarchar(10), date, 120) AS day
                                            FROM 
                                                StockExtract
                                            WHERE 
                                                date BETWEEN @start_date AND @end_date
                                            GROUP BY 
                                                CONVERT(nvarchar(10), date, 120)
                                            ORDER BY 
                                                day";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetStockPerDayString, conn))
                {
                    try
                    {
                        adpt.SelectCommand.Parameters.AddWithValue("@start_date", Start.Date);
                        adpt.SelectCommand.Parameters.AddWithValue("@end_date", End.Date);

                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }

        public DataTable GetStock(string Day)
        {
            Configure();

            string GetSalesPerDayString = @"SELECT  
                                                date,
                                                operation,
                                                quantity,
                                                product_id
                                            FROM 
                                                StockExtract
                                            WHERE 
                                                CONVERT(NVARCHAR(10), date, 23) = @day";

            DataTable table = new DataTable();

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                using (SqlCeDataAdapter adpt = new SqlCeDataAdapter(GetSalesPerDayString, conn))
                {
                    adpt.SelectCommand.Parameters.AddWithValue("@day", Day);

                    try
                    {
                        conn.Open();
                        adpt.Fill(table);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return table;
        }
        #endregion

        #region DELETE
        public bool DeleteStock(string DateString)
        {
            Configure();

            string DeleteSaleString = @"DELETE StockExtract WHERE CONVERT(nvarchar(10), sale_date, 120) = @date";

            bool sucess = false;

            using (SqlCeConnection conn = new SqlCeConnection(SQLServerCEConnection))
            {
                try
                {
                    conn.Open();

                    using (SqlCeCommand cmd = new SqlCeCommand(DeleteSaleString, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateString);

                        int rowAffected = cmd.ExecuteNonQuery();

                        cmd.Dispose();

                        if (rowAffected > 0)
                        {
                            sucess = true;
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();

                }
            }

            return sucess;
        }
        #endregion

        #endregion
    }
}
