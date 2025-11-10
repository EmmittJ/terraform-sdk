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
        set => SetProperty("association_id", value);
    }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    public required TerraformProperty<string> DataRepositoryPath
    {
        set => SetProperty("data_repository_path", value);
    }

    /// <summary>
    /// The data_repository_subdirectories attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataRepositorySubdirectories
    {
        set => SetProperty("data_repository_subdirectories", value);
    }

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileCacheId
    {
        set => SetProperty("file_cache_id", value);
    }

    /// <summary>
    /// The file_cache_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCachePath is required")]
    public required TerraformProperty<string> FileCachePath
    {
        set => SetProperty("file_cache_path", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemId
    {
        set => SetProperty("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemPath
    {
        set => SetProperty("file_system_path", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformProperty<double>? ImportedFileChunkSize
    {
        set => SetProperty("imported_file_chunk_size", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceArn
    {
        set => SetProperty("resource_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
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
        set => SetProperty("deployment_type", value);
    }

    /// <summary>
    /// The log_configuration attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? LogConfiguration
    {
        set => SetProperty("log_configuration", value);
    }

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    public TerraformProperty<string>? MountName
    {
        set => SetProperty("mount_name", value);
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerUnitStorageThroughput is required")]
    public required TerraformProperty<double> PerUnitStorageThroughput
    {
        set => SetProperty("per_unit_storage_throughput", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyMaintenanceStartTime
    {
        set => SetProperty("weekly_maintenance_start_time", value);
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
        SetOutput("arn");
        SetOutput("data_repository_association_ids");
        SetOutput("dns_name");
        SetOutput("file_cache_id");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("vpc_id");
        SetOutput("copy_tags_to_data_repository_associations");
        SetOutput("file_cache_type");
        SetOutput("file_cache_type_version");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("storage_capacity");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The copy_tags_to_data_repository_associations attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToDataRepositoryAssociations
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_data_repository_associations");
        set => SetProperty("copy_tags_to_data_repository_associations", value);
    }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheType is required")]
    public required TerraformProperty<string> FileCacheType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_cache_type");
        set => SetProperty("file_cache_type", value);
    }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheTypeVersion is required")]
    public required TerraformProperty<string> FileCacheTypeVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_cache_type_version");
        set => SetProperty("file_cache_type_version", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    public required TerraformProperty<double> StorageCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_capacity");
        set => SetProperty("storage_capacity", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// Block for data_repository_association.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 DataRepositoryAssociation block(s) allowed")]
    public HashSet<AwsFsxFileCacheDataRepositoryAssociationBlock>? DataRepositoryAssociation
    {
        set => SetProperty("data_repository_association", value);
    }

    /// <summary>
    /// Block for lustre_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsFsxFileCacheLustreConfigurationBlock>? LustreConfiguration
    {
        set => SetProperty("lustre_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxFileCacheTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
