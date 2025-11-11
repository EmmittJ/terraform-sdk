using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_launch_configuration.
/// </summary>
public partial class AwsLaunchConfigurationDataSource : TerraformDataSource
{
    public AwsLaunchConfigurationDataSource(string name) : base("aws_launch_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AssociatePublicIpAddress { get; }

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> EbsBlockDevice { get; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EbsOptimized { get; }

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    [TerraformProperty("enable_monitoring")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableMonitoring { get; }

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> EphemeralBlockDevice { get; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IamInstanceProfile { get; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageId { get; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyName { get; }

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformProperty("metadata_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MetadataOptions { get; }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformProperty("placement_tenancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlacementTenancy { get; }

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    [TerraformProperty("root_block_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RootBlockDevice { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformProperty("spot_price")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SpotPrice { get; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserData { get; }

}
