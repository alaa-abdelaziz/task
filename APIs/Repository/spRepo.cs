using APIs.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace APIs.Repository
{
    public class spRepo : IspRepo
    {
        private UserContext _context;
        public spRepo(UserContext _context)
        {

            this._context = _context;

        }


        public virtual async Task<int> spAsync(int? Id, string FristName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    Value = Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "FristName",
                    Size = 20,
                    Value = FristName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp] @Id, @FristName", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }








    }




    public class OutputParameter<TValue>
    {
        private bool _valueSet = false;

        public TValue _value;

        public TValue Value
        {
            get
            {
                if (!_valueSet)
                    throw new InvalidOperationException("Value not set.");

                return _value;
            }
        }

        internal void SetValue(object value)
        {
            _valueSet = true;

            _value = null == value || Convert.IsDBNull(value) ? default(TValue) : (TValue)value;
        }
    }
}

    

