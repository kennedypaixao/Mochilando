using Dapper;
using Mochilando.Tools.DTO.Travel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mochilando.Tools.Repository.Travel
{
    public class TravelRepository : ITravelRepository
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

        public async Task Save(TravelDto travel)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                await conexao.ExecuteAsync(
                     @$"INSERT INTO TB_TRAVEL 
                        UID,
                        NAME,
                        DESCRIPTION,
                        BEGIN,
                        END,
                        PRICE 
                        VALUES (
                        @UID,
                        @NAME,
                        @DESCRIPTION,
                        @BEGIN,
                        @END,
                        @PRICE)",
                    new
                    {
                        UID = travel.UID,
                        NAME = travel.Name,
                        DESCRIPTION = travel.Description,
                        BEGIN = travel.Begin,
                        END = travel.End,
                        PRICE = travel.Price
                    });
            }
        }
    }
}
