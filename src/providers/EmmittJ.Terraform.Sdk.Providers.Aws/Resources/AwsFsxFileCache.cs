using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_repository_association in .
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheDataRepositoryAssociationBlock : ITerraformBlock
{
    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>("", "association_id");

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    [TerraformPropertyName("data_repository_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataRepositoryPath { get; set; }

    /// <summary>
    /// The data_repository_subdirectories attribute.
    /// </summary>
    [TerraformPropertyName("data_repository_subdirectories")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DataRepositorySubdirectories { get; set; }

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    [TerraformPropertyName("file_cache_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileCacheId => new TerraformReferenceProperty<TerraformProperty<string>>("", "file_cache_id");

    /// <summary>
    /// The file_cache_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCachePath is required")]
    [TerraformPropertyName("file_cache_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FileCachePath { get; set; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemId => new TerraformReferenceProperty<TerraformProperty<string>>("", "file_system_id");

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    [TerraformPropertyName("file_system_path")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemPath => new TerraformReferenceProperty<TerraformProperty<string>>("", "file_system_path");

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    [TerraformPropertyName("imported_file_chunk_size")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ImportedFileChunkSize => new TerraformReferenceProperty<TerraformProperty<double>>("", "imported_file_chunk_size");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "resource_arn");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "tags");

}

/// <summary>
/// Block type for lustre_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsFsxFileCacheLustreConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    [TerraformPropertyName("deployment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeploymentType { get; set; }

    /// <summary>
    /// The log_configuration attribute.
    /// </summary>
    [TerraformPropertyName("log_configuration")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LogConfiguration => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>("", "log_configuration");

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    [TerraformPropertyName("mount_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MountName => new TerraformReferenceProperty<TerraformProperty<string>>("", "mount_name");

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerUnitStorageThroughput is required")]
    [TerraformPropertyName("per_unit_storage_throughput")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WeeklyMaintenanceStartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxFileCacheTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_fsx_file_cache resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxFileCache : TerraformResource
{
    public AwsFsxFileCache(string name) : base("aws_fsx_file_cache", name)
    {
    }

    /// <summary>
    /// The copy_tags_to_data_repository_associations attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_data_repository_associations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CopyTagsToDataRepositoryAssociations { get; set; }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheType is required")]
    [TerraformPropertyName("file_cache_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FileCacheType { get; set; }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheTypeVersion is required")]
    [TerraformPropertyName("file_cache_type_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FileCacheTypeVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    [TerraformPropertyName("storage_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> StorageCapacity { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for data_repository_association.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 DataRepositoryAssociation block(s) allowed")]
    [TerraformPropertyName("data_repository_association")]
    public TerraformSet<TerraformBlock<AwsFsxFileCacheDataRepositoryAssociationBlock>>? DataRepositoryAssociation { get; set; } = new();

    /// <summary>
    /// Block for lustre_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("lustre_configuration")]
    public TerraformSet<TerraformBlock<AwsFsxFileCacheLustreConfigurationBlock>>? LustreConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxFileCacheTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The data_repository_association_ids attribute.
    /// </summary>
    [TerraformPropertyName("data_repository_association_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DataRepositoryAssociationIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "data_repository_association_ids");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    [TerraformPropertyName("file_cache_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileCacheId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_cache_id");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NetworkInterfaceIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
