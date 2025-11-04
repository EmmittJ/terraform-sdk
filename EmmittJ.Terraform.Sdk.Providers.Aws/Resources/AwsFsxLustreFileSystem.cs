using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_lustre_file_system resource.
/// </summary>
public class AwsFsxLustreFileSystem : TerraformResource
{
    public AwsFsxLustreFileSystem(string name) : base("aws_fsx_lustre_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("mount_name");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The auto_import_policy attribute.
    /// </summary>
    public string? AutoImportPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_import_policy")?.Value;
        set => this.WithProperty("auto_import_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public double? AutomaticBackupRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("automatic_backup_retention_days")?.Value;
        set => this.WithProperty("automatic_backup_retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public string? BackupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_id")?.Value;
        set => this.WithProperty("backup_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public bool? CopyTagsToBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_backups")?.Value;
        set => this.WithProperty("copy_tags_to_backups", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public string? DailyAutomaticBackupStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("daily_automatic_backup_start_time")?.Value;
        set => this.WithProperty("daily_automatic_backup_start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public string? DataCompressionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_compression_type")?.Value;
        set => this.WithProperty("data_compression_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public string? DeploymentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_type")?.Value;
        set => this.WithProperty("deployment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    public string? DriveCacheType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("drive_cache_type")?.Value;
        set => this.WithProperty("drive_cache_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    public bool? EfaEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("efa_enabled")?.Value;
        set => this.WithProperty("efa_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    public string? ExportPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_path")?.Value;
        set => this.WithProperty("export_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    public string? FileSystemTypeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_type_version")?.Value;
        set => this.WithProperty("file_system_type_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, string>? FinalBackupTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("final_backup_tags")?.Value;
        set => this.WithProperty("final_backup_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The import_path attribute.
    /// </summary>
    public string? ImportPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("import_path")?.Value;
        set => this.WithProperty("import_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public double? ImportedFileChunkSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("imported_file_chunk_size")?.Value;
        set => this.WithProperty("imported_file_chunk_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    public double? PerUnitStorageThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("per_unit_storage_throughput")?.Value;
        set => this.WithProperty("per_unit_storage_throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public bool? SkipFinalBackup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_backup")?.Value;
        set => this.WithProperty("skip_final_backup", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public double? StorageCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity")?.Value;
        set => this.WithProperty("storage_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public List<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The throughput_capacity attribute.
    /// </summary>
    public double? ThroughputCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_capacity")?.Value;
        set => this.WithProperty("throughput_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public string? WeeklyMaintenanceStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_start_time")?.Value;
        set => this.WithProperty("weekly_maintenance_start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    public TerraformExpression MountName => this["mount_name"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
