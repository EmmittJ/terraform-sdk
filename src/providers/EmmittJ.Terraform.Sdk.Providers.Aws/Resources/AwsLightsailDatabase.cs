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
        SetOutput("arn");
        SetOutput("ca_certificate_identifier");
        SetOutput("cpu_count");
        SetOutput("created_at");
        SetOutput("disk_size");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("master_endpoint_address");
        SetOutput("master_endpoint_port");
        SetOutput("ram_size");
        SetOutput("secondary_availability_zone");
        SetOutput("support_code");
        SetOutput("apply_immediately");
        SetOutput("availability_zone");
        SetOutput("backup_retention_enabled");
        SetOutput("blueprint_id");
        SetOutput("bundle_id");
        SetOutput("final_snapshot_name");
        SetOutput("id");
        SetOutput("master_database_name");
        SetOutput("master_password");
        SetOutput("master_username");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("relational_database_name");
        SetOutput("skip_final_snapshot");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BackupRetentionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("backup_retention_enabled");
        set => SetProperty("backup_retention_enabled", value);
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    public required TerraformProperty<string> BlueprintId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blueprint_id");
        set => SetProperty("blueprint_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformProperty<string> BundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bundle_id");
        set => SetProperty("bundle_id", value);
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string> FinalSnapshotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_snapshot_name");
        set => SetProperty("final_snapshot_name", value);
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
    /// The master_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterDatabaseName is required")]
    public required TerraformProperty<string> MasterDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_database_name");
        set => SetProperty("master_database_name", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterPassword is required")]
    public required TerraformProperty<string> MasterPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password");
        set => SetProperty("master_password", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterUsername is required")]
    public required TerraformProperty<string> MasterUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_username");
        set => SetProperty("master_username", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredBackupWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_backup_window");
        set => SetProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The relational_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelationalDatabaseName is required")]
    public required TerraformProperty<string> RelationalDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("relational_database_name");
        set => SetProperty("relational_database_name", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_snapshot");
        set => SetProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
