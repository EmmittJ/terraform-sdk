using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_database resource.
/// </summary>
public class AwsLightsailDatabase : TerraformResource
{
    public AwsLightsailDatabase(string name) : base("aws_lightsail_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("ca_certificate_identifier");
        this.WithOutput("cpu_count");
        this.WithOutput("created_at");
        this.WithOutput("disk_size");
        this.WithOutput("engine");
        this.WithOutput("engine_version");
        this.WithOutput("master_endpoint_address");
        this.WithOutput("master_endpoint_port");
        this.WithOutput("ram_size");
        this.WithOutput("secondary_availability_zone");
        this.WithOutput("support_code");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackupRetentionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("backup_retention_enabled");
        set => this.WithProperty("backup_retention_enabled", value);
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    public required TerraformProperty<string> BlueprintId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("blueprint_id");
        set => this.WithProperty("blueprint_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformProperty<string> BundleId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string>? FinalSnapshotName
    {
        get => GetProperty<TerraformProperty<string>>("final_snapshot_name");
        set => this.WithProperty("final_snapshot_name", value);
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
    /// The master_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterDatabaseName is required")]
    public required TerraformProperty<string> MasterDatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("master_database_name");
        set => this.WithProperty("master_database_name", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterPassword is required")]
    public required TerraformProperty<string> MasterPassword
    {
        get => GetRequiredProperty<TerraformProperty<string>>("master_password");
        set => this.WithProperty("master_password", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterUsername is required")]
    public required TerraformProperty<string> MasterUsername
    {
        get => GetRequiredProperty<TerraformProperty<string>>("master_username");
        set => this.WithProperty("master_username", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredBackupWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_backup_window");
        set => this.WithProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The relational_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelationalDatabaseName is required")]
    public required TerraformProperty<string> RelationalDatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("relational_database_name");
        set => this.WithProperty("relational_database_name", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public TerraformExpression CaCertificateIdentifier => this["ca_certificate_identifier"];

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformExpression CpuCount => this["cpu_count"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformExpression DiskSize => this["disk_size"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The master_endpoint_address attribute.
    /// </summary>
    public TerraformExpression MasterEndpointAddress => this["master_endpoint_address"];

    /// <summary>
    /// The master_endpoint_port attribute.
    /// </summary>
    public TerraformExpression MasterEndpointPort => this["master_endpoint_port"];

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    public TerraformExpression RamSize => this["ram_size"];

    /// <summary>
    /// The secondary_availability_zone attribute.
    /// </summary>
    public TerraformExpression SecondaryAvailabilityZone => this["secondary_availability_zone"];

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    public TerraformExpression SupportCode => this["support_code"];

}
