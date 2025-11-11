using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_user.
/// </summary>
public partial class AwsConnectUserDataSource : TerraformDataSource
{
    public AwsConnectUserDataSource(string name) : base("aws_connect_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    [TerraformProperty("directory_user_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DirectoryUserId { get; }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    [TerraformProperty("hierarchy_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HierarchyGroupId { get; }

    /// <summary>
    /// The identity_info attribute.
    /// </summary>
    [TerraformProperty("identity_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IdentityInfo { get; }

    /// <summary>
    /// The phone_config attribute.
    /// </summary>
    [TerraformProperty("phone_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PhoneConfig { get; }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [TerraformProperty("routing_profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoutingProfileId { get; }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [TerraformProperty("security_profile_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityProfileIds { get; }

}
