using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolidProject
{

    public class BeforeUserService
    {
        private readonly IDataSrtorage _database;
        public BeforeUserService(IDataSrtorage database)
        {
            _database = database;
        }



    }
}
