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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AssociatePublicIpAddress => new TerraformReference(this, "associate_public_ip_address");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> EbsBlockDevice => new TerraformReference(this, "ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EbsOptimized => new TerraformReference(this, "ebs_optimized");

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("enable_monitoring")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableMonitoring => new TerraformReference(this, "enable_monitoring");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> EphemeralBlockDevice => new TerraformReference(this, "ephemeral_block_device");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IamInstanceProfile => new TerraformReference(this, "iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageId => new TerraformReference(this, "image_id");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceType => new TerraformReference(this, "instance_type");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyName => new TerraformReference(this, "key_name");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MetadataOptions => new TerraformReference(this, "metadata_options");

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("placement_tenancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlacementTenancy => new TerraformReference(this, "placement_tenancy");

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    [TerraformPropertyName("root_block_device")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RootBlockDevice => new TerraformReference(this, "root_block_device");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroups => new TerraformReference(this, "security_groups");

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SpotPrice => new TerraformReference(this, "spot_price");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserData => new TerraformReference(this, "user_data");

}
