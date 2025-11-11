using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_infrastructure_configuration.
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationDataSource : TerraformDataSource
{
    public AwsImagebuilderInfrastructureConfigurationDataSource(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> ResourceTags { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateCreated => new TerraformReference(this, "date_created");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformPropertyName("date_updated")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateUpdated => new TerraformReference(this, "date_updated");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("instance_metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceMetadataOptions => new TerraformReference(this, "instance_metadata_options");

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("instance_profile_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceProfileName => new TerraformReference(this, "instance_profile_name");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> InstanceTypes => new TerraformReference(this, "instance_types");

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    [TerraformPropertyName("key_pair")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyPair => new TerraformReference(this, "key_pair");

    /// <summary>
    /// The logging attribute.
    /// </summary>
    [TerraformPropertyName("logging")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Logging => new TerraformReference(this, "logging");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    [TerraformPropertyName("placement")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Placement => new TerraformReference(this, "placement");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SnsTopicArn => new TerraformReference(this, "sns_topic_arn");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instance_on_failure")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TerminateInstanceOnFailure => new TerraformReference(this, "terminate_instance_on_failure");

}
