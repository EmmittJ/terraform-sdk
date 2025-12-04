using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lightsail_database Terraform resource.
/// Manages a aws_lightsail_database resource.
/// </summary>
public partial class AwsLightsailDatabase(string name) : TerraformResource("aws_lightsail_database", name)
{
    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The backup_retention_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BackupRetentionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("backup_retention_enabled");
        set => SetArgument("backup_retention_enabled", value);
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    public required TerraformValue<string> BlueprintId
    {
        get => GetArgument<TerraformValue<string>>("blueprint_id");
        set => SetArgument("blueprint_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformValue<string> BundleId
    {
        get => GetArgument<TerraformValue<string>>("bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotName
    {
        get => GetArgument<TerraformValue<string>>("final_snapshot_name");
        set => SetArgument("final_snapshot_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The master_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterDatabaseName is required")]
    public required TerraformValue<string> MasterDatabaseName
    {
        get => GetArgument<TerraformValue<string>>("master_database_name");
        set => SetArgument("master_database_name", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterPassword is required")]
    public required TerraformValue<string> MasterPassword
    {
        get => GetArgument<TerraformValue<string>>("master_password");
        set => SetArgument("master_password", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterUsername is required")]
    public required TerraformValue<string> MasterUsername
    {
        get => GetArgument<TerraformValue<string>>("master_username");
        set => SetArgument("master_username", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string>? PreferredBackupWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_backup_window");
        set => SetArgument("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The relational_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelationalDatabaseName is required")]
    public required TerraformValue<string> RelationalDatabaseName
    {
        get => GetArgument<TerraformValue<string>>("relational_database_name");
        set => SetArgument("relational_database_name", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertificateIdentifier
        => AsReference("ca_certificate_identifier");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCount
        => AsReference("cpu_count");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformValue<double> DiskSize
        => AsReference("disk_size");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The master_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> MasterEndpointAddress
        => AsReference("master_endpoint_address");

    /// <summary>
    /// The master_endpoint_port attribute.
    /// </summary>
    public TerraformValue<double> MasterEndpointPort
        => AsReference("master_endpoint_port");

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    public TerraformValue<double> RamSize
        => AsReference("ram_size");

    /// <summary>
    /// The secondary_availability_zone attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAvailabilityZone
        => AsReference("secondary_availability_zone");

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    public TerraformValue<string> SupportCode
        => AsReference("support_code");

}
