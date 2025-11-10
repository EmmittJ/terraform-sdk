using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_launch_configuration.
/// </summary>
public class AwsLaunchConfigurationDataSource : TerraformDataSource
{
    public AwsLaunchConfigurationDataSource(string name) : base("aws_launch_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AssociatePublicIpAddress => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "associate_public_ip_address");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> EbsBlockDevice => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EbsOptimized => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ebs_optimized");

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("enable_monitoring")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableMonitoring => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_monitoring");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> EphemeralBlockDevice => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "ephemeral_block_device");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IamInstanceProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_id");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_name");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MetadataOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "metadata_options");

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("placement_tenancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlacementTenancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_tenancy");

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    [TerraformPropertyName("root_block_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RootBlockDevice => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "root_block_device");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SpotPrice => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "spot_price");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_data");

}
