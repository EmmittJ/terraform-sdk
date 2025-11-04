using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_spanner_database resource.
/// </summary>
public class GoogleSpannerDatabase : TerraformResource
{
    public GoogleSpannerDatabase(string name) : base("google_spanner_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The dialect of the Cloud Spanner Database.
    /// If it is not provided, &amp;quot;GOOGLE_STANDARD_SQL&amp;quot; will be used. Possible values: [&amp;quot;GOOGLE_STANDARD_SQL&amp;quot;, &amp;quot;POSTGRESQL&amp;quot;]
    /// </summary>
    public string? DatabaseDialect
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_dialect")?.Value;
        set => this.WithProperty("database_dialect", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional list of DDL statements to run inside the database. Statements can create
    /// tables, indexes, etc.
    /// 
    /// During creation these statements execute atomically with the creation of the database
    /// and if there is an error in any statement, the database is not created.
    /// 
    /// Terraform does not perform drift detection on this field and assumes that the values
    /// recorded in state are accurate. Limited updates to this field are supported, and
    /// newly appended DDL statements can be executed in an update. However, modifications
    /// to prior statements will create a plan that marks the resource for recreation.
    /// </summary>
    public List<string>? Ddl
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ddl")?.Value;
        set => this.WithProperty("ddl", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The default time zone for the database. The default time zone must be a valid name
    /// from the tz database. Default value is &amp;quot;America/Los_angeles&amp;quot;.
    /// </summary>
    public string? DefaultTimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_time_zone")?.Value;
        set => this.WithProperty("default_time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the database. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the database,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the database will fail.
    /// When the field is set to false, deleting the database is allowed.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether drop protection is enabled for this database. Defaults to false.
    /// Drop protection is different from
    /// the &amp;quot;deletion_protection&amp;quot; attribute in the following ways:
    /// (1) &amp;quot;deletion_protection&amp;quot; only protects the database from deletions in Terraform.
    /// whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces.
    /// (2) Setting &amp;quot;enableDropProtection&amp;quot; to true also prevents the deletion of the parent instance containing the database.
    /// &amp;quot;deletion_protection&amp;quot; attribute does not provide protection against the deletion of the parent instance.
    /// </summary>
    public bool? EnableDropProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_drop_protection")?.Value;
        set => this.WithProperty("enable_drop_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A unique identifier for the database, which cannot be changed after the
    /// instance is created. Values are of the form &#39;[a-z][-_a-z0-9]*[a-z0-9]&#39;.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention period for the database. The retention period must be between 1 hour
    /// and 7 days, and can be specified in days, hours, minutes, or seconds. For example,
    /// the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h.
    /// If this property is used, you must avoid adding new DDL statements to &#39;ddl&#39; that
    /// update the database&#39;s version_retention_period.
    /// </summary>
    public string? VersionRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_retention_period")?.Value;
        set => this.WithProperty("version_retention_period", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An explanation of the status of the database.
    /// </summary>
    public TerraformExpression State => this["state"];

}
