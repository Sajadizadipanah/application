using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Models;


public class Category : object
{
    #region Constructor
    /// <summary>
    /// سازنده پیش‌فرض کلاس
    /// </summary>
    public Category() : base()
    {
    }
    #endregion /Constructor

    #region Properties

    #region public int Id { get; set; }
    /// <summary>
    /// شناسه
    /// </summary>
    public int Id { get; set; }
    #endregion /public int Id { get; set; }

    #region public string? Name { get; set; }
    /// <summary>
    /// نام
    /// </summary>
    public string? Name { get; set; }
    #endregion /public string? Name { get; set; }

    #endregion /Properties

}