using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_repository_association in AwsFsxFileCache.
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheDataRepositoryAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_repository_association";

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => CreateReference("association_id");

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    public required TerraformValue<string> DataRepositoryPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_repository_path");
        set => SetArgument("data_repository_path", value);
    }

    /// <summary>
    /// The data_repository_subdirectories attribute.
    /// </summary>
    public TerraformSet<string>? DataRepositorySubdirectories
    {
        get => GetArgument<TerraformSet<string>>("data_repository_subdirectories");
        set => SetArgument("data_repository_subdirectories", value);
    }

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    public TerraformValue<string> FileCacheId
        => CreateReference("file_cache_id");

    /// <summary>
    /// The file_cache_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCachePath is required")]
    public required TerraformValue<string> FileCachePath
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_cache_path");
        set => SetArgument("file_cache_path", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
        => CreateReference("file_system_id");

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    public TerraformValue<string> FileSystemPath
        => CreateReference("file_system_path");

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformValue<double> ImportedFileChunkSize
        => CreateReference("imported_file_chunk_size");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
        => CreateReference("resource_arn");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Nfs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxFileCacheDataRepositoryAssociationBlockNfsBlock>? Nfs
    {
        get => GetArgument<TerraformSet<AwsFsxFileCacheDataRepositoryAssociationBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

}

/// <summary>
/// Block type for nfs in AwsFsxFileCacheDataRepositoryAssociationBlock.
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheDataRepositoryAssociationBlockNfsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs";

    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    public TerraformSet<string>? DnsIps
    {
        get => GetArgument<TerraformSet<string>>("dns_ips");
        set => SetArgument("dns_ips", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for lustre_configuration in AwsFsxFileCache.
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheLustreConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lustre_configuration";

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    public required TerraformValue<string> DeploymentType
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The log_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogConfiguration
        => CreateReference("log_configuration");

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    public TerraformValue<string> MountName
        => CreateReference("mount_name");

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerUnitStorageThroughput is required")]
    public required TerraformValue<double> PerUnitStorageThroughput
    {
        get => GetRequiredArgument<TerraformValue<double>>("per_unit_storage_throughput");
        set => SetArgument("per_unit_storage_throughput", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string>? WeeklyMaintenanceStartTime
    {
        get => GetArgument<TerraformValue<string>>("weekly_maintenance_start_time");
        set => SetArgument("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// MetadataConfiguration block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetadataConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 MetadataConfiguration block(s) allowed")]
    public required TerraformSet<AwsFsxFileCacheLustreConfigurationBlockMetadataConfigurationBlock> MetadataConfiguration
    {
        get => GetRequiredArgument<TerraformSet<AwsFsxFileCacheLustreConfigurationBlockMetadataConfigurationBlock>>("metadata_configuration");
        set => SetArgument("metadata_configuration", value);
    }

}

/// <summary>
/// Block type for metadata_configuration in AwsFsxFileCacheLustreConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheLustreConfigurationBlockMetadataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_configuration";

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    public required TerraformValue<double> StorageCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("storage_capacity");
        set => SetArgument("storage_capacity", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxFileCache.
/// Nesting mode: single
/// </summary>
public class AwsFsxFileCacheTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fsx_file_cache Terraform resource.
/// Manages a aws_fsx_file_cache resource.
/// </summary>
public partial class AwsFsxFileCache(string name) : TerraformResource("aws_fsx_file_cache", name)
{
    /// <summary>
    /// The copy_tags_to_data_repository_associations attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToDataRepositoryAssociations
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_data_repository_associations");
        set => SetArgument("copy_tags_to_data_repository_associations", value);
    }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheType is required")]
    public required TerraformValue<string> FileCacheType
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_cache_type");
        set => SetArgument("file_cache_type", value);
    }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheTypeVersion is required")]
    public required TerraformValue<string> FileCacheTypeVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_cache_type_version");
        set => SetArgument("file_cache_type_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? CreateReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    public required TerraformValue<double> StorageCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("storage_capacity");
        set => SetArgument("storage_capacity", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => GetArgument<TerraformList<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The data_repository_association_ids attribute.
    /// </summary>
    public TerraformSet<string> DataRepositoryAssociationIds
        => CreateReference("data_repository_association_ids");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    public TerraformValue<string> FileCacheId
        => CreateReference("file_cache_id");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
        => CreateReference("network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// DataRepositoryAssociation block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 DataRepositoryAssociation block(s) allowed")]
    public TerraformSet<AwsFsxFileCacheDataRepositoryAssociationBlock>? DataRepositoryAssociation
    {
        get => GetArgument<TerraformSet<AwsFsxFileCacheDataRepositoryAssociationBlock>>("data_repository_association");
        set => SetArgument("data_repository_association", value);
    }

    /// <summary>
    /// LustreConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxFileCacheLustreConfigurationBlock>? LustreConfiguration
    {
        get => GetArgument<TerraformSet<AwsFsxFileCacheLustreConfigurationBlock>>("lustre_configuration");
        set => SetArgument("lustre_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxFileCacheTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxFileCacheTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
