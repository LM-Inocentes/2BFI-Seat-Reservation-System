using System.Data.SQLite;

namespace _2BFI_Seat_Ticketing
{
    public class Database_functions
    {
        public SQLiteConnection m_dbConnection = null!;
        public void ConnectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=SeatsData.sqlite;Version=3;");
            m_dbConnection.Open();
        }
        public void NewCreation()
        {
            string sql = "CREATE TABLE " + CreatePage.CreationName + " (SeatNo INT, Name TEXT, Date TEXT, TotalSeats INT, Col INT, Row INT)";
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            try
            {
                command = new(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            catch (System.Data.SQLite.SQLiteException)                       //Ensures names are not sql keywords
            {
                CreatePage.CreationName = "_" + CreatePage.CreationName;
                command = new(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }

            // Loop 
            for (int i = 0; i < CreatePage.NumSeats; i++)
            {
                if (i == 0)
                {
                    sql = "INSERT INTO " + CreatePage.CreationName + " (SeatNo, TotalSeats, Col, Row) VALUES (" + (1 + i) + ", " + CreatePage.NumSeats + ", " + CreatePage.numCol + ", " + CreatePage.numRow + ")";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
                else
                { 
                    sql = "INSERT INTO " + CreatePage.CreationName + " (SeatNo) VALUES (" + (1 + i) + ")";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
                
            } 
            m_dbConnection.Dispose();
        }
        public void AddInfo(string NameInfo, string DateAssigned)
        {
            string sql = "UPDATE "+CreatePage.CreationName+" SET Name = '"+NameInfo+ "', Date = '"+DateAssigned+ "' WHERE SeatNo = "+AssignPage.SeatNo;
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Dispose();
        }
        public void GetInfo()
        {
            string sql = "SELECT Name, Date, SeatNo FROM " + CreatePage.CreationName + " WHERE SeatNo = " +AssignPage.SeatNo;
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            using SQLiteDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                InfoPage.NameInfo = rdr.GetString(0);
                InfoPage.DateAssigned = rdr.GetString(1);
                InfoPage.InfoSeatNo = rdr.GetInt32(2);
                break;
            }
        }
        public void DeleteInfo()
        {
            string sql = "UPDATE " + CreatePage.CreationName + " SET Name = NULL, Date = NULL WHERE SeatNo = " + AssignPage.SeatNo;
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Dispose();
        }
        public Boolean SeatStatus(int seatCount)
        {
            string sql = "SELECT Name, SeatNo FROM " + CreatePage.CreationName + " WHERE SeatNo = " + seatCount;
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            using (SQLiteDataReader rdr = command.ExecuteReader())
                while (rdr.Read())
                {
                    if (rdr[0].GetType() != typeof(DBNull)) 
                    { 
                        return false;                                   //false = occupied, true = available
                    }
                }
            return true;
        }
        public void FirstNullSeatNo()
        {
            string sql = "SELECT SeatNo FROM " + CreatePage.CreationName + " WHERE (Name IS NULL) AND (SeatNo BETWEEN 1 AND "+ CreatePage.NumSeats+")";
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            using SQLiteDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                AssignPage.SeatNo = rdr.GetInt32(0);
                break;
            }
        }

        public int FirstNullGroupSeatNo(int Start, int End)
        {
            int count = 0;
            int tempnum = AssignPage.SeatNo;
            string sql = "SELECT SeatNo FROM " + CreatePage.CreationName + " WHERE (Name IS NULL) AND (SeatNo BETWEEN " + Start + " AND " + End + ")";
            ConnectToDatabase();
            SQLiteCommand command = new(sql, m_dbConnection);
            using SQLiteDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                if (tempnum == rdr.GetInt32(0))
                {
                    count++;
                    if (count == AssignPage.groupNum)
                    {
                        return (rdr.GetInt32(0) - AssignPage.groupNum + 1);
                    }  
                }
                else
                {
                    count = 1;
                    tempnum = rdr.GetInt32(0);
                }
                tempnum++;
            }
            if(count < AssignPage.groupNum)
            {
                return 0;
            }
            return tempnum;
        }


        public void DeleteCreation()
        {
            ConnectToDatabase();
            string sql = "DROP TABLE " +CreatePage.CreationName;
            SQLiteCommand command = new(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Dispose();
        }
    }
}
