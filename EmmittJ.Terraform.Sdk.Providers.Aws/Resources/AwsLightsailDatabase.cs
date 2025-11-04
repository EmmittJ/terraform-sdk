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
        this.DeclareOutput("arn");
        this.DeclareOutput("ca_certificate_identifier");
        this.DeclareOutput("cpu_count");
        this.DeclareOutput("created_at");
        this.DeclareOutput("disk_size");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("master_endpoint_address");
        this.DeclareOutput("master_endpoint_port");
        this.DeclareOutput("ram_size");
        this.DeclareOutput("secondary_availability_zone");
        this.DeclareOutput("support_code");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The backup_retention_enabled attribute.
    /// </summary>
    public bool? BackupRetentionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("backup_retention_enabled")?.Value;
        set => this.WithProperty("backup_retention_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    public string? BlueprintId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blueprint_id")?.Value;
        set => this.WithProperty("blueprint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public string? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id")?.Value;
        set => this.WithProperty("bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public string? FinalSnapshotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_name")?.Value;
        set => this.WithProperty("final_snapshot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The master_database_name attribute.
    /// </summary>
    public string? MasterDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_database_name")?.Value;
        set => this.WithProperty("master_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public string? MasterPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password")?.Value;
        set => this.WithProperty("master_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public string? MasterUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_username")?.Value;
        set => this.WithProperty("master_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public string? PreferredBackupWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_backup_window")?.Value;
        set => this.WithProperty("preferred_backup_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public string? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_maintenance_window")?.Value;
        set => this.WithProperty("preferred_maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The relational_database_name attribute.
    /// </summary>
    public string? RelationalDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relational_database_name")?.Value;
        set => this.WithProperty("relational_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public bool? SkipFinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_snapshot")?.Value;
        set => this.WithProperty("skip_final_snapshot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
