using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    class SqlQueries
    {
        internal const string sql_Zaposlenik_001 = @"SELECT [ID_ZAPOS] FROM ZAPOSLENIK WHERE [IME]=@ime AND [PREZIME]=@prezime";
        internal const string sql_Zaposlenik_002 = @"SELECT [ID_ZAPOS] FROM ZAPOSLENIK WHERE [USERNAME] = @username";
        internal const string sql_Zaposlenik_003 = @"SELECT ADMIN FROM ZAPOSLENIK WHERE ID_ZAPOS = @idzaposlenika";
        internal const string sql_Smjena_001 = @"SELECT IME, PREZIME, POC_DATUM, POC_VRIJEME, KRAJ_DATUM, KRAJ_VRIJEME, ULOGA FROM (SMJENA S LEFT JOIN ZAPOSLENIK Z ON S.ID_ZAPOS = Z.ID_ZAPOS)";
        internal const string sql_Smjena_002 = @"SELECT COUNT(*) FROM SMJENA";
        internal const string sql_Smjena_003 = @"INSERT INTO [SMJENA] ([ID_ZAPOS], [POC_DATUM], [POC_VRIJEME], [KRAJ_DATUM], [KRAJ_VRIJEME], [ULOGA]) VALUES (@idzap, @pocdat, @pocvr, @krajdat, @krajvr, @uloga)";
        internal const string sql_Smjena_004 = @"SELECT POC_DATUM, POC_VRIJEME, KRAJ_DATUM, KRAJ_VRIJEME, ULOGA FROM (SMJENA S LEFT JOIN ZAPOSLENIK Z ON S.ID_ZAPOS = Z.ID_ZAPOS WHERE Z.IME = @ime AND Z.PREZIME = @prezime)";
        internal const string sql_Film_001 = @"SELECT [NAZIV_FILMA], [DAT_POC_PRIKAZ], [DAT_ZAVR_PRIKAZ], [TRAJANJE] FROM FILM F ORDER BY [NAZIV_FILMA], [DAT_POC_PRIKAZ]";
        internal const string sql_Film_002 = @"SELECT COUNT(*) FROM FILM F";
        internal const string sql_Film_003 = @"SELECT NAZIV_FILMA, TRAJANJE FROM FILM WHERE ID_FILMA=@idfilma";
        internal const string sql_Film_004 = @"INSERT INTO FILM (NAZIV_FILMA, DAT_POC_PRIKAZ, DAT_ZAVR_PRIKAZ, TRAJANJE) VALUES (@nazivfilma, @datpoc, @datzavr, @trajanje)";
        internal const string sql_Film_005 = @"SELECT COUNT(*) FROM FILM WHERE NAZIV_FILMA = @nazivfilma";
        internal const string sql_Termin_001 = @"SELECT ID_TERMINA, NAZIV_FILMA, DATUM, VRIJEME, BROJ_DVORANE, CIJENA, TRAJANJE FROM (TERMIN T INNER JOIN FILM F ON T.ID_FILMA=F.ID_FILMA)";
        internal const string sql_Termin_002 = @"SELECT [BROJ_DVORANE] FROM TERMIN WHERE [ID_TERMINA] = @idtermina";
        internal const string sql_Termin_003 = @"SELECT * FROM TERMIN WHERE [ID_TERMINA]=@idtermina";
        internal const string sql_Dvorana_001 = @"SELECT * FROM DVORANA WHERE [BROJ_DVORANE] = @idtermina";
        internal const string sql_Dvorana_002 = @"INSERT INTO DVORANA (BROJ_DVORANE, TIP_DVORANE, BROJ_SJEDALA, BROJ_REDOVA) VALUES (@brojdvorane, @tip, @brojsjedala, @brojredova)";
        internal const string sql_Dvorana_003 = @"SELECT MAX(BROJ_DVORANE) FROM DVORANA";
        internal const string sql_Dvorana_004 = @"SELECT BROJ_DVORANE, TIP_DVORANE, BROJ_SJEDALA, BROJ_REDOVA FROM DVORANA";
        internal const string sql_Sjedalo_001 = @"SELECT * FROM SJEDALO WHERE [ID_TERMINA] = @idtermina";
        internal const string sql_Sjedalo_002 = @"SELECT MAX(BROJ_KARTE) FROM SJEDALO";
        internal const string sql_Sjedalo_003 = @"INSERT INTO SJEDALO (ID_TERMINA, ID_ZAPOS, BROJ_SJEDALA, RED_SJEDALA, BROJ_KARTE) VALUES (@idtermina, @idzapos, @brsjedala, @brreda, @maxid)";
    }
}
