using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database.
/// </summary>
public partial class GoogleSqlDatabaseDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseDataSource(string name) : base("google_sql_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Cloud SQL instance. This does not include the project
    /// ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The name of the database in the Cloud SQL instance.
    /// This does not include the project ID or instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The charset value. See MySQL&#39;s
    /// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
    /// and Postgres&#39; [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html)
    /// for more details and supported values. Postgres databases only support
    /// a value of &#39;UTF8&#39; at creation time.
    /// </summary>
    [TerraformProperty("charset")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Charset { get; }

    /// <summary>
    /// The collation value. See MySQL&#39;s
    /// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
    /// and Postgres&#39; [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html)
    /// for more details and supported values. Postgres databases only support
    /// a value of &#39;en_US.UTF8&#39; at creation time.
    /// </summary>
    [TerraformProperty("collation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Collation { get; }

    /// <summary>
    /// The deletion policy for the database. Setting ABANDON allows the resource
    /// to be abandoned rather than deleted. This is useful for Postgres, where databases cannot be
    /// deleted from the API if there are users other than cloudsqlsuperuser with access. Possible
    /// values are: &amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;. Defaults to &amp;quot;DELETE&amp;quot;.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeletionPolicy { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
