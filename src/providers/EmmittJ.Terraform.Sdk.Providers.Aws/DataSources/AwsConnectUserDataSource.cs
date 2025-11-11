using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_user.
/// </summary>
public class AwsConnectUserDataSource : TerraformDataSource
{
    public AwsConnectUserDataSource(string name) : base("aws_connect_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserId { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DirectoryUserId => new TerraformReference(this, "directory_user_id");

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    [TerraformPropertyName("hierarchy_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HierarchyGroupId => new TerraformReference(this, "hierarchy_group_id");

    /// <summary>
    /// The identity_info attribute.
    /// </summary>
    [TerraformPropertyName("identity_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IdentityInfo => new TerraformReference(this, "identity_info");

    /// <summary>
    /// The phone_config attribute.
    /// </summary>
    [TerraformPropertyName("phone_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PhoneConfig => new TerraformReference(this, "phone_config");

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("routing_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoutingProfileId => new TerraformReference(this, "routing_profile_id");

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_profile_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityProfileIds => new TerraformReference(this, "security_profile_ids");

}
