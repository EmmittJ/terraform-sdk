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
    public TerraformLiteralProperty<string>? AutoImportPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_import_policy");
        set => this.WithProperty("auto_import_policy", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AutomaticBackupRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("automatic_backup_retention_days");
        set => this.WithProperty("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_id");
        set => this.WithProperty("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CopyTagsToBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_backups");
        set => this.WithProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DailyAutomaticBackupStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("daily_automatic_backup_start_time");
        set => this.WithProperty("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataCompressionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_compression_type");
        set => this.WithProperty("data_compression_type", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_type");
        set => this.WithProperty("deployment_type", value);
    }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DriveCacheType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("drive_cache_type");
        set => this.WithProperty("drive_cache_type", value);
    }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EfaEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("efa_enabled");
        set => this.WithProperty("efa_enabled", value);
    }

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExportPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_path");
        set => this.WithProperty("export_path", value);
    }

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FileSystemTypeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_type_version");
        set => this.WithProperty("file_system_type_version", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? FinalBackupTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("final_backup_tags");
        set => this.WithProperty("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The import_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImportPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("import_path");
        set => this.WithProperty("import_path", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ImportedFileChunkSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("imported_file_chunk_size");
        set => this.WithProperty("imported_file_chunk_size", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PerUnitStorageThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("per_unit_storage_throughput");
        set => this.WithProperty("per_unit_storage_throughput", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipFinalBackup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_backup");
        set => this.WithProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity");
        set => this.WithProperty("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ThroughputCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_capacity");
        set => this.WithProperty("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WeeklyMaintenanceStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_start_time");
        set => this.WithProperty("weekly_maintenance_start_time", value);
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
