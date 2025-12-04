using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_database Terraform data source.
/// Retrieves information about a google_sql_database.
/// </summary>
public partial class GoogleSqlDatabaseDataSource(string name) : TerraformDataSource("google_sql_database", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Cloud SQL instance. This does not include the project
    /// ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The name of the database in the Cloud SQL instance.
    /// This does not include the project ID or instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The charset value. See MySQL&#39;s
    /// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
    /// and Postgres&#39; [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html)
    /// for more details and supported values. Postgres databases only support
    /// a value of &#39;UTF8&#39; at creation time.
    /// </summary>
    public TerraformValue<string> Charset
        => AsReference("charset");

    /// <summary>
    /// The collation value. See MySQL&#39;s
    /// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
    /// and Postgres&#39; [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html)
    /// for more details and supported values. Postgres databases only support
    /// a value of &#39;en_US.UTF8&#39; at creation time.
    /// </summary>
    public TerraformValue<string> Collation
        => AsReference("collation");

    /// <summary>
    /// The deletion policy for the database. Setting ABANDON allows the resource
    /// to be abandoned rather than deleted. This is useful for Postgres, where databases cannot be
    /// deleted from the API if there are users other than cloudsqlsuperuser with access. Possible
    /// values are: &amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;. Defaults to &amp;quot;DELETE&amp;quot;.
    /// </summary>
    public TerraformValue<string> DeletionPolicy
        => AsReference("deletion_policy");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

}
