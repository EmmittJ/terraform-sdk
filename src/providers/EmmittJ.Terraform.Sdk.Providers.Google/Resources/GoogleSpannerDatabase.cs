using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerDatabaseEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Fully qualified name of the KMS key to use to encrypt this database. This key must exist
    /// in the same location as the Spanner Database.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    public List<TerraformProperty<string>>? KmsKeyNames
    {
        set => SetProperty("kms_key_names", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerDatabaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_spanner_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSpannerDatabase : TerraformResource
{
    public GoogleSpannerDatabase(string name) : base("google_spanner_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("state");
        SetOutput("database_dialect");
        SetOutput("ddl");
        SetOutput("default_time_zone");
        SetOutput("deletion_protection");
        SetOutput("enable_drop_protection");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("name");
        SetOutput("project");
        SetOutput("version_retention_period");
    }

    /// <summary>
    /// The dialect of the Cloud Spanner Database.
    /// If it is not provided, &amp;quot;GOOGLE_STANDARD_SQL&amp;quot; will be used. Possible values: [&amp;quot;GOOGLE_STANDARD_SQL&amp;quot;, &amp;quot;POSTGRESQL&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DatabaseDialect
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_dialect");
        set => SetProperty("database_dialect", value);
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
    public List<TerraformProperty<string>> Ddl
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ddl");
        set => SetProperty("ddl", value);
    }

    /// <summary>
    /// The default time zone for the database. The default time zone must be a valid name
    /// from the tz database. Default value is &amp;quot;America/Los_angeles&amp;quot;.
    /// </summary>
    public TerraformProperty<string> DefaultTimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_time_zone");
        set => SetProperty("default_time_zone", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the database. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the database,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the database will fail.
    /// When the field is set to false, deleting the database is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
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
    public TerraformProperty<bool> EnableDropProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_drop_protection");
        set => SetProperty("enable_drop_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// A unique identifier for the database, which cannot be changed after the
    /// instance is created. Values are of the form &#39;[a-z][-_a-z0-9]*[a-z0-9]&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The retention period for the database. The retention period must be between 1 hour
    /// and 7 days, and can be specified in days, hours, minutes, or seconds. For example,
    /// the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h.
    /// If this property is used, you must avoid adding new DDL statements to &#39;ddl&#39; that
    /// update the database&#39;s version_retention_period.
    /// </summary>
    public TerraformProperty<string> VersionRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_retention_period");
        set => SetProperty("version_retention_period", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleSpannerDatabaseEncryptionConfigBlock>? EncryptionConfig
    {
        set => SetProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSpannerDatabaseTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// An explanation of the status of the database.
    /// </summary>
    public TerraformExpression State => this["state"];

}
