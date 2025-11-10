using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database.
/// </summary>
public class GoogleSqlDatabaseDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseDataSource(string name) : base("google_sql_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("charset");
        this.WithOutput("collation");
        this.WithOutput("deletion_policy");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the Cloud SQL instance. This does not include the project
    /// ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The name of the database in the Cloud SQL instance.
    /// This does not include the project ID or instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The charset value. See MySQL&#39;s
    /// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
    /// and Postgres&#39; [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html)
    /// for more details and supported values. Postgres databases only support
    /// a value of &#39;UTF8&#39; at creation time.
    /// </summary>
    public TerraformExpression Charset => this["charset"];

    /// <summary>
    /// The collation value. See MySQL&#39;s
    /// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
    /// and Postgres&#39; [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html)
    /// for more details and supported values. Postgres databases only support
    /// a value of &#39;en_US.UTF8&#39; at creation time.
    /// </summary>
    public TerraformExpression Collation => this["collation"];

    /// <summary>
    /// The deletion policy for the database. Setting ABANDON allows the resource
    /// to be abandoned rather than deleted. This is useful for Postgres, where databases cannot be
    /// deleted from the API if there are users other than cloudsqlsuperuser with access. Possible
    /// values are: &amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;. Defaults to &amp;quot;DELETE&amp;quot;.
    /// </summary>
    public TerraformExpression DeletionPolicy => this["deletion_policy"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
