using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformPropertyName("http_put_response_hop_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpPutResponseHopLimit { get; set; }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformPropertyName("http_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpTokens { get; set; }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationLoggingBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationPlacementBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AvailabilityZone { get; set; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostId { get; set; }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostResourceGroupArn { get; set; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tenancy { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_infrastructure_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderInfrastructureConfiguration : TerraformResource
{
    public AwsImagebuilderInfrastructureConfiguration(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfileName is required")]
    [TerraformPropertyName("instance_profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceProfileName { get; set; }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? InstanceTypes { get; set; }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    [TerraformPropertyName("key_pair")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyPair { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceTags { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnsTopicArn { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

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
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instance_on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TerminateInstanceOnFailure { get; set; }

    /// <summary>
    /// Block for instance_metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataOptions block(s) allowed")]
    [TerraformPropertyName("instance_metadata_options")]
    public TerraformList<TerraformBlock<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock>>? InstanceMetadataOptions { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformPropertyName("logging")]
    public TerraformList<TerraformBlock<AwsImagebuilderInfrastructureConfigurationLoggingBlock>>? Logging { get; set; } = new();

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    [TerraformPropertyName("placement")]
    public TerraformList<TerraformBlock<AwsImagebuilderInfrastructureConfigurationPlacementBlock>>? Placement { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_created");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformPropertyName("date_updated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateUpdated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_updated");

}
