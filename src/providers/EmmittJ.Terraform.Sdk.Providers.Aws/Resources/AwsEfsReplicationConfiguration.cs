using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsEfsReplicationConfigurationDestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformProperty("availability_zone_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvailabilityZoneName { get; set; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformProperty("file_system_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FileSystemId { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEfsReplicationConfigurationTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a aws_efs_replication_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEfsReplicationConfiguration : TerraformResource
{
    public AwsEfsReplicationConfiguration(string name) : base("aws_efs_replication_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileSystemId is required")]
    [TerraformProperty("source_file_system_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceFileSystemId { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformProperty("destination")]
    public partial TerraformList<TerraformBlock<AwsEfsReplicationConfigurationDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEfsReplicationConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The original_source_file_system_arn attribute.
    /// </summary>
    [TerraformProperty("original_source_file_system_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OriginalSourceFileSystemArn { get; }

    /// <summary>
    /// The source_file_system_arn attribute.
    /// </summary>
    [TerraformProperty("source_file_system_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceFileSystemArn { get; }

    /// <summary>
    /// The source_file_system_region attribute.
    /// </summary>
    [TerraformProperty("source_file_system_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceFileSystemRegion { get; }

}
