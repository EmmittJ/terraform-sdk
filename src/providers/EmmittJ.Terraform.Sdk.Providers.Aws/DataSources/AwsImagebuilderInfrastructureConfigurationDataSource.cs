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
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ResourceTags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "resource_tags");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

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

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("instance_metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceMetadataOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_metadata_options");

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("instance_profile_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceProfileName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_profile_name");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> InstanceTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "instance_types");

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    [TerraformPropertyName("key_pair")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyPair => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_pair");

    /// <summary>
    /// The logging attribute.
    /// </summary>
    [TerraformPropertyName("logging")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Logging => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logging");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    [TerraformPropertyName("placement")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Placement => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "placement");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnsTopicArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sns_topic_arn");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    [TerraformPropertyName("terminate_instance_on_failure")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TerminateInstanceOnFailure => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "terminate_instance_on_failure");

}
