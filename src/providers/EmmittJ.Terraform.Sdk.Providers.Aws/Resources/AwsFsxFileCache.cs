using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_repository_association in .
/// Nesting mode: set
/// </summary>
public partial class AwsFsxFileCacheDataRepositoryAssociationBlock() : TerraformBlock("data_repository_association")
{

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    [TerraformProperty("data_repository_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataRepositoryPath { get; set; }

    /// <summary>
    /// The data_repository_subdirectories attribute.
    /// </summary>
    [TerraformProperty("data_repository_subdirectories")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DataRepositorySubdirectories { get; set; }


    /// <summary>
    /// The file_cache_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCachePath is required")]
    [TerraformProperty("file_cache_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileCachePath { get; set; }





    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

}

/// <summary>
/// Block type for lustre_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsFsxFileCacheLustreConfigurationBlock() : TerraformBlock("lustre_configuration")
{
    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    [TerraformProperty("deployment_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentType { get; set; }



    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerUnitStorageThroughput is required")]
    [TerraformProperty("per_unit_storage_throughput")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WeeklyMaintenanceStartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxFileCacheTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_fsx_file_cache resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxFileCache : TerraformResource
{
    public AwsFsxFileCache(string name) : base("aws_fsx_file_cache", name)
    {
    }

    /// <summary>
    /// The copy_tags_to_data_repository_associations attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_data_repository_associations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToDataRepositoryAssociations { get; set; }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheType is required")]
    [TerraformProperty("file_cache_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileCacheType { get; set; }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileCacheTypeVersion is required")]
    [TerraformProperty("file_cache_type_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileCacheTypeVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    [TerraformProperty("storage_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageCapacity { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for data_repository_association.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 DataRepositoryAssociation block(s) allowed")]
    [TerraformProperty("data_repository_association")]
    public TerraformSet<AwsFsxFileCacheDataRepositoryAssociationBlock> DataRepositoryAssociation { get; set; } = new();

    /// <summary>
    /// Block for lustre_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("lustre_configuration")]
    public TerraformSet<AwsFsxFileCacheLustreConfigurationBlock> LustreConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsFsxFileCacheTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The data_repository_association_ids attribute.
    /// </summary>
    [TerraformProperty("data_repository_association_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> DataRepositoryAssociationIds { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    [TerraformProperty("file_cache_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FileCacheId { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
