using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_repository_association in .
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheDataRepositoryAssociationBlock : TerraformBlock
{
    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformProperty<string>? AssociationId
    {
        get => GetProperty<TerraformProperty<string>>("association_id");
        set => WithProperty("association_id", value);
    }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    public required TerraformProperty<string> DataRepositoryPath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_repository_path");
        set => WithProperty("data_repository_path", value);
    }

    /// <summary>
    /// The data_repository_subdirectories attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataRepositorySubdirectories
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_repository_subdirectories");
        set => WithProperty("data_repository_subdirectories", value);
    }

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileCacheId
    {
        get => GetProperty<TerraformProperty<string>>("file_cache_id");
        set => WithProperty("file_cache_id", value);
    }

    /// <summary>
    /// The file_cache_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCachePath is required")]
    public required TerraformProperty<string> FileCachePath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("file_cache_path");
        set => WithProperty("file_cache_path", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemId
    {
        get => GetProperty<TerraformProperty<string>>("file_system_id");
        set => WithProperty("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemPath
    {
        get => GetProperty<TerraformProperty<string>>("file_system_path");
        set => WithProperty("file_system_path", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformProperty<double>? ImportedFileChunkSize
    {
        get => GetProperty<TerraformProperty<double>>("imported_file_chunk_size");
        set => WithProperty("imported_file_chunk_size", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

}

/// <summary>
/// Block type for lustre_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheLustreConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    public required TerraformProperty<string> DeploymentType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("deployment_type");
        set => WithProperty("deployment_type", value);
    }

    /// <summary>
    /// The log_configuration attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? LogConfiguration
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("log_configuration");
        set => WithProperty("log_configuration", value);
    }

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    public TerraformProperty<string>? MountName
    {
        get => GetProperty<TerraformProperty<string>>("mount_name");
        set => WithProperty("mount_name", value);
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerUnitStorageThroughput is required")]
    public required TerraformProperty<double> PerUnitStorageThroughput
    {
        get => GetRequiredProperty<TerraformProperty<double>>("per_unit_storage_throughput");
        set => WithProperty("per_unit_storage_throughput", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyMaintenanceStartTime
    {
        get => GetProperty<TerraformProperty<string>>("weekly_maintenance_start_time");
        set => WithProperty("weekly_maintenance_start_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxFileCacheTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_fsx_file_cache resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxFileCache : TerraformResource
{
    public AwsFsxFileCache(string name) : base("aws_fsx_file_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("data_repository_association_ids");
        this.WithOutput("dns_name");
        this.WithOutput("file_cache_id");
        this.WithOutput("network_interface_ids");
        this.WithOutput("owner_id");
        this.WithOutput("vpc_id");
    }

    /// <summary>
    /// The copy_tags_to_data_repository_associations attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToDataRepositoryAssociations
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_data_repository_associations");
        set => this.WithProperty("copy_tags_to_data_repository_associations", value);
    }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheType is required")]
    public required TerraformProperty<string> FileCacheType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("file_cache_type");
        set => this.WithProperty("file_cache_type", value);
    }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheTypeVersion is required")]
    public required TerraformProperty<string> FileCacheTypeVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("file_cache_type_version");
        set => this.WithProperty("file_cache_type_version", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    public required TerraformProperty<double> StorageCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("storage_capacity");
        set => this.WithProperty("storage_capacity", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// Block for data_repository_association.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 DataRepositoryAssociation block(s) allowed")]
    public HashSet<AwsFsxFileCacheDataRepositoryAssociationBlock>? DataRepositoryAssociation
    {
        get => GetProperty<HashSet<AwsFsxFileCacheDataRepositoryAssociationBlock>>("data_repository_association");
        set => this.WithProperty("data_repository_association", value);
    }

    /// <summary>
    /// Block for lustre_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsFsxFileCacheLustreConfigurationBlock>? LustreConfiguration
    {
        get => GetProperty<HashSet<AwsFsxFileCacheLustreConfigurationBlock>>("lustre_configuration");
        set => this.WithProperty("lustre_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxFileCacheTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFsxFileCacheTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The data_repository_association_ids attribute.
    /// </summary>
    public TerraformExpression DataRepositoryAssociationIds => this["data_repository_association_ids"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    public TerraformExpression FileCacheId => this["file_cache_id"];

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
