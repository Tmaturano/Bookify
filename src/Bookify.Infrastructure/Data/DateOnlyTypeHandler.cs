using Dapper;
using System.Data;

namespace Bookify.Infrastructure.Data;

/// <summary>
/// Because I'm using Date Only types in the date range value objhects, this is needed to tell dapper how to be able map this type,
/// because it doesn't support it out of the box.
/// </summary>
internal sealed class DateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
{
    public override DateOnly Parse(object value) => DateOnly.FromDateTime((DateTime)value);

    public override void SetValue(IDbDataParameter parameter, DateOnly value)
    {
        parameter.DbType = DbType.Date;
        parameter.Value = value;
    }
}
