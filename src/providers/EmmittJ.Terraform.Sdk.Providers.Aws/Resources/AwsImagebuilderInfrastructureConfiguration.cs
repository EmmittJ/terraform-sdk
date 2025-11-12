using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock() : TerraformBlock("instance_metadata_options")
{
    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformProperty("http_put_response_hop_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpPutResponseHopLimit { get; set; }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformProperty("http_tokens")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpTokens { get; set; }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderInfrastructureConfigurationLoggingBlock() : TerraformBlock("logging")
{
}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderInfrastructureConfigurationPlacementBlock() : TerraformBlock("placement")
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvailabilityZone { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostId { get; set; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformProperty("host_resource_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostResourceGroupArn { get; set; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tenancy { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_infrastructure_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsImagebuilderInfrastructureConfiguration : TerraformResource
{
    public AwsImagebuilderInfrastructureConfiguration(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfileName is required")]
    [TerraformProperty("instance_profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceProfileName { get; set; }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformProperty("instance_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? InstanceTypes { get; set; }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    [TerraformProperty("key_pair")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyPair { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnsTopicArn { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

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
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    [TerraformProperty("terminate_instance_on_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TerminateInstanceOnFailure { get; set; }

    /// <summary>
    /// Block for instance_metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataOptions block(s) allowed")]
    [TerraformProperty("instance_metadata_options")]
    public TerraformList<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock> InstanceMetadataOptions { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformProperty("logging")]
    public TerraformList<AwsImagebuilderInfrastructureConfigurationLoggingBlock> Logging { get; set; } = new();

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    [TerraformProperty("placement")]
    public TerraformList<AwsImagebuilderInfrastructureConfigurationPlacementBlock> Placement { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformProperty("date_updated")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateUpdated { get; }

}
