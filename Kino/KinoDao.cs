﻿using System;
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

    class KinoDao
    {
        private static OleDbConnection iConn = null;
        private static OleDbDataReader iReader = null;
        private readonly string iConnString;

        // uspostavi vezu s bazom
        public KinoDao(string PathToDB)
        {
            if (iConn == null)
            {
                iConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=" + PathToDB;
                iConn = new OleDbConnection(iConnString);
            }
        }

        internal static bool jelAdmin(int idZaposlenika)
        {
            bool adm = false;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Zaposlenik_003, iConn);

                OleDbParameter paramId = new OleDbParameter
                {
                    ParameterName = "@idzaposlenika",
                    Value = idZaposlenika
                };

                command.Parameters.Add(paramId);

                adm = (int)command.ExecuteScalar() == 1;
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

            return adm;
        }

        internal static int getMaxIdKarte()
        {
            int maxId = -1;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Sjedalo_002, iConn);
                maxId = (int) command.ExecuteScalar();
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

            return maxId;
        }

        internal static DataTable getAllDvorane()
        {
            DataTable dvorane = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Dvorana_004, iConn);
                iReader = command.ExecuteReader();
                dvorane.Load(iReader);
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }

            return dvorane;
        }


        internal static int addNovaDvorana(string tip, decimal brojSjedala, decimal brojRedova)
        {
            int rowsAdded = -1;
            try
            {
                int brojDvorane = getMaxBrojDvorane();
                if (brojDvorane > 0)
                {
                    iConn.Open();
                    OleDbCommand command = new OleDbCommand(SqlQueries.sql_Dvorana_002, iConn);
                    OleDbParameter paramBrojDvorane = new OleDbParameter
                    {
                        ParameterName = "@brojdvorane",
                        Value = brojDvorane + 1
                    };
                    OleDbParameter paramTip = new OleDbParameter
                    {
                        ParameterName = "@tip",
                        Value = tip.ToUpper()
                    };
                    OleDbParameter paramBrojSjedala = new OleDbParameter
                    {
                        ParameterName = "@brojsjedala",
                        Value = (int)brojSjedala
                    };
                    OleDbParameter paramBrojRedova = new OleDbParameter
                    {
                        ParameterName = "@brojredova",
                        Value = (int)brojRedova
                    };

                    command.Parameters.Add(paramBrojDvorane);
                    command.Parameters.Add(paramTip);
                    command.Parameters.Add(paramBrojSjedala);
                    command.Parameters.Add(paramBrojRedova);

                    rowsAdded = command.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Broj dvorane nije uredu!");
                }
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }

            return rowsAdded;
        }

        internal static DataTable getZaduzenjaForOne(string ime, string prezime)
        {
            DataTable zaduzenja = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Smjena_004, iConn);
                OleDbParameter paramIme = new OleDbParameter
                {
                    ParameterName = "@ime",
                    Value = ime
                };
                OleDbParameter paramPrezime = new OleDbParameter
                {
                    ParameterName = "@prezime",
                    Value = prezime
                };
                command.Parameters.Add(paramIme);
                command.Parameters.Add(paramPrezime);

                iReader = command.ExecuteReader();
                zaduzenja.Load(iReader);
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }

            return zaduzenja;
        }

        private static int getMaxBrojDvorane()
        {
            int maxBrojDvorane = -1;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Dvorana_003, iConn);
                maxBrojDvorane = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }

            return maxBrojDvorane;
        }

        internal static int dodajNoviFilm(string nazivFilma, DateTime datPocPrikaz, DateTime datZavrPrikaz, Decimal trajanje)
        {
            int rowsAdded = -1;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_004, iConn);
                OleDbParameter paramNaziv = new OleDbParameter
                {
                    ParameterName = "@nazivfilma",
                    Value = nazivFilma
                };
                OleDbParameter paramDatPoc = new OleDbParameter
                {
                    ParameterName = "@datpoc",
                    Value = datPocPrikaz.Date
                };
                OleDbParameter paramDatZavr = new OleDbParameter
                {
                    ParameterName = "@datzavr",
                    Value = datZavrPrikaz.Date
                };
                OleDbParameter paramTrajanje = new OleDbParameter
                {
                    ParameterName = "@trajanje",
                    Value = (int)trajanje
                };

                command.Parameters.Add(paramNaziv);
                command.Parameters.Add(paramDatPoc);
                command.Parameters.Add(paramDatZavr);
                command.Parameters.Add(paramTrajanje);

                rowsAdded = (int)command.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
            }

            return rowsAdded;
        }

        internal static bool checkIfFilmExists(string nazivFilma)
        {
            int exists = 0;
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_005, iConn);
                OleDbParameter paramNaziv = new OleDbParameter
                {
                    ParameterName = "@nazivfilma",
                    Value = nazivFilma
                };
                command.Parameters.Add(paramNaziv);
                exists = (int)command.ExecuteScalar();
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

            if (exists != 0)
                return true;
            return false;
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

        internal static DataTable getInfoTermin(int idTermina)
        {
            DataTable dataTable = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Termin_003, iConn);
                OleDbParameter paramIdTermina = new OleDbParameter
                {
                    ParameterName = "@idtermina",
                    Value = idTermina
                };

                command.Parameters.Add(paramIdTermina);
                iReader = command.ExecuteReader();
                dataTable.Load(iReader);
            }
            catch (Exception e)
            {
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

        internal static DataTable getFilmById(int idFilma)
        {
            DataTable dataTable = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_003, iConn);
                OleDbParameter paramIdFilma = new OleDbParameter
                {
                    ParameterName = "@idfilma",
                    Value = idFilma
                };

                command.Parameters.Add(paramIdFilma);
                iReader = command.ExecuteReader();
                dataTable.Load(iReader);
            }
            catch (Exception e)
            {
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

        internal static int addNovuKartu(int idTermina, int idZaposlenika, int brojSjedala, int brojReda, int maxIdKarte)
        {
            int rowsAdded = 0;

            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Sjedalo_003, iConn);
                OleDbParameter paramIdTermina = new OleDbParameter
                {
                    ParameterName = "@idtermina",
                    Value = idTermina
                };
                OleDbParameter paramIdZapos = new OleDbParameter
                {
                    ParameterName = "@idzapos",
                    Value = idZaposlenika
                };
                // u bazi zapisujemo od 1 broj i red sjedala
                OleDbParameter paramBrSjedala = new OleDbParameter
                {
                    ParameterName = "@brsjedala",
                    Value = brojSjedala + 1
                };
                OleDbParameter paramBrReda = new OleDbParameter
                {
                    ParameterName = "@brreda",
                    Value = brojReda + 1
                };
                OleDbParameter paramMaxIdKarte = new OleDbParameter
                {
                    ParameterName = "@maxid",
                    Value = maxIdKarte
                };
                command.Parameters.Add(paramIdTermina);
                command.Parameters.Add(paramIdZapos);
                command.Parameters.Add(paramBrSjedala);
                command.Parameters.Add(paramBrReda);
                command.Parameters.Add(paramMaxIdKarte);

                rowsAdded = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine(e.ToString());
            }
            finally
            {
                if (iConn != null)
                    iConn.Close();
                if (iReader != null)
                    iReader.Close();
            }

            return rowsAdded;
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

        internal static DataTable getAktualniFilmovi(DateTime datum)
        {
            DataTable dataTable = new DataTable();
            try
            {
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_006, iConn);
                OleDbParameter paramDatum = new OleDbParameter
                {
                    ParameterName = "@datum",
                    Value = datum.Date.ToShortDateString()
                };

                command.Parameters.Add(paramDatum);
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

        internal static int addTerminFilma(int idFilm, int brojDvorane, DateTime datum, TimeSpan vrijeme, double cijena)
        {
            int rowsAdded = 0;
            try
            { 
                iConn.Open();
                OleDbCommand command = new OleDbCommand(SqlQueries.sql_Termin_004, iConn);
                OleDbParameter IdFilm = new OleDbParameter
                {
                    ParameterName = "@film",
                    Value = idFilm
                };
                OleDbParameter Dvorana = new OleDbParameter
                {
                    ParameterName = "@dvorana",
                    Value = brojDvorane
                };
                OleDbParameter Datum = new OleDbParameter
                {
                    ParameterName = "@datum",
                    Value = datum.Date.ToShortDateString()
                };
                OleDbParameter Vrijeme = new OleDbParameter
                {
                    ParameterName = "@vrijeme",
                    Value = vrijeme
                };
                OleDbParameter Cijena = new OleDbParameter
                {
                    ParameterName = "@cijena",
                    Value = cijena
                };

                command.Parameters.Add(IdFilm);
                command.Parameters.Add(Dvorana);
                command.Parameters.Add(Datum);
                command.Parameters.Add(Vrijeme);
                command.Parameters.Add(Cijena);

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

        internal static int deleteFilm(int idFilm)
        {
            int deletedRows = 0;
            iConn.Open();
            OleDbCommand command = new OleDbCommand(SqlQueries.sql_Film_008, iConn);
            OleDbParameter IdFilm = new OleDbParameter
            {
                ParameterName = "@idfilma",
                Value = idFilm
            };

            command.Parameters.Add(IdFilm);
            deletedRows = command.ExecuteNonQuery();

            return deletedRows;
        }


    }
}
