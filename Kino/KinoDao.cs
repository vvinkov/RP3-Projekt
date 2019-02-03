using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    // klasa za spajanje na bazu
    // i rad s bazom

    static class KinoDao
    {
        private static OleDbConnection iConn = null;
        private static OleDbDataReader iReader = null;
        private const string iConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=D:\\Sranja\\Desktop\\Kino-20190203T132010Z-001yxyxyx\\Kino\\Kino\\Kino.accdb";

        

        // uspostavi vezu s bazom
        static KinoDao()
        {
            if(iConn == null)
                iConn = new OleDbConnection(iConnString);
        }

        internal static DataTable getAllKupljenaSjedala(int idTermina)
        {
            DataTable kupljenaSjedala = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Sjedalo_001, iConn);
                OleDbParameter paramIdTermina = new OleDbParameter
                {
                    ParameterName = "@idtermina",
                    Value = idTermina
                };
                command.Parameters.Add(paramIdTermina);
                iReader = command.ExecuteReader();
                kupljenaSjedala.Load(iReader);
            }
            catch(Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }

            return kupljenaSjedala;
        }

        internal static DataTable getInfoDvorana(int brojDvorane)
        {
            DataTable infoDvorana = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Dvorana_001, iConn);
                OleDbParameter paramBrojDvorane = new OleDbParameter
                {
                    ParameterName = "@idtermina",
                    Value = brojDvorane
                };

                command.Parameters.Add(paramBrojDvorane);
                iReader = command.ExecuteReader();
                infoDvorana.Load(iReader);
            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }
            return infoDvorana;
        }

        internal static int getBrojDvorane(int idTermina)
        {
            int brojDvorane = -1;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Termin_002, iConn);
                OleDbParameter paramIdTermina = new OleDbParameter
                {
                    ParameterName = "@idtermina",
                    Value = idTermina
                };
                command.Parameters.Add(paramIdTermina);
                brojDvorane = (int) command.ExecuteScalar();
            }
            catch(Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }

            return brojDvorane;
        }
        
        internal static int checkIfZaposlenikExists(string pUsername)
        {
            int idZaposlenika = -1;

            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Zaposlenik_002, iConn);
                OleDbParameter paramUsername = new OleDbParameter
                {
                    ParameterName = "@username",
                    Value = pUsername
                };
                command.Parameters.Add(paramUsername);

                idZaposlenika = (int)command.ExecuteScalar();

            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }

            return idZaposlenika;
        }

        internal static int checkIfNameOfZaposlenikExists(string pName, string pPrezime)
        {
            int idZaposlenika = -1;

            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Zaposlenik_001, iConn);
                OleDbParameter paramIme = new OleDbParameter
                {
                    ParameterName = "@ime",
                    Value = pName
                };
                OleDbParameter paramPrezime = new OleDbParameter
                {
                    ParameterName = "@prezime",
                    Value = pPrezime
                };
                command.Parameters.Add(paramIme);
                command.Parameters.Add(paramPrezime);

                idZaposlenika = (int) command.ExecuteScalar();

            } catch(Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if(iConn != null)
                    iConn.Close();
            }

            return idZaposlenika;
        }

        internal static int getCountOfAllFilmTermini()
        {
            int rowCount = 0;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_002, iConn);
                rowCount = (int) command.ExecuteScalar();

            } catch(Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }
            return rowCount;
        }

        internal static DataTable getAllTermini()
        {
            DataTable dataTable = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Termin_001, iConn);
                iReader = command.ExecuteReader();

                dataTable.Load(iReader);
            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }
            return dataTable;
        }

        internal static DataTable getAllFilmovi()
        {
            DataTable dataTable = new DataTable();

            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_001, iConn);
                iReader = command.ExecuteReader();

                dataTable.Load(iReader);
            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }
            return dataTable;
        }

        internal static int addNovoZaduzenje(int id, string uloga, DateTime pocDatum, TimeSpan pocVrijeme, DateTime krajDatum, TimeSpan krajVrijeme)
        {
            int rowsAdded = 0;

            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Smjena_003, iConn);
                OleDbParameter paramId = new OleDbParameter
                {
                    ParameterName = "@idzap",
                    Value = id
                };
                OleDbParameter paramUloga = new OleDbParameter
                {
                    ParameterName = "@uloga",
                    Value = uloga.ToUpper()
                };
                OleDbParameter paramPocDat = new OleDbParameter
                {
                    ParameterName = "@pocdat",
                    Value = pocDatum
                };
                OleDbParameter paramPocVrijeme = new OleDbParameter
                {
                    ParameterName = "@pocvr",
                    Value = pocVrijeme
                };
                OleDbParameter paramKrajDat = new OleDbParameter
                {
                    ParameterName = "@krajdat",
                    Value = krajDatum
                };
                OleDbParameter paramKrajVrijeme = new OleDbParameter
                {
                    ParameterName = "@krajvr",
                    Value = krajVrijeme
                };

                command.Parameters.Add(paramId);
                command.Parameters.Add(paramPocDat);
                command.Parameters.Add(paramPocVrijeme);
                command.Parameters.Add(paramKrajDat);
                command.Parameters.Add(paramKrajVrijeme);
                command.Parameters.Add(paramUloga);

                rowsAdded = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }

            return rowsAdded;
        }

        internal static int getCountOfAllZaduzenja()
        {
            int rowCount = 0;

            try
            {
               iConn.Open();
               OleDbCommand command = new OleDbCommand(SqlQueries.sql_Smjena_002, iConn);
               rowCount = (int) command.ExecuteScalar();
            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }
            return rowCount;
        }

        internal static DataTable getAllZaduzenja()
        {
            DataTable dataTable = new DataTable();

            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Smjena_001, iConn);
                iReader = command.ExecuteReader();
               
                dataTable.Load(iReader);
            }
            catch (Exception e)
            {
                // obradi iznimku
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }
            return dataTable;
        }
    }
}
