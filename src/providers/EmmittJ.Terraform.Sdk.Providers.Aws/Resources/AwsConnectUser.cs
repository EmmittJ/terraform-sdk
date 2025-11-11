using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_info in .
/// Nesting mode: list
/// </summary>
public class AwsConnectUserIdentityInfoBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The secondary_email attribute.
    /// </summary>
    [TerraformPropertyName("secondary_email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecondaryEmail { get; set; }

}

/// <summary>
/// Block type for phone_config in .
/// Nesting mode: list
/// </summary>
public class AwsConnectUserPhoneConfigBlock
{
    /// <summary>
    /// The after_contact_work_time_limit attribute.
    /// </summary>
    [TerraformPropertyName("after_contact_work_time_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AfterContactWorkTimeLimit { get; set; }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoAccept { get; set; }

    /// <summary>
    /// The desk_phone_number attribute.
    /// </summary>
    [TerraformPropertyName("desk_phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeskPhoneNumber { get; set; }

    /// <summary>
    /// The phone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneType is required")]
    [TerraformPropertyName("phone_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PhoneType { get; set; }

}

/// <summary>
/// Manages a aws_connect_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectUser : TerraformResource
{
    public AwsConnectUser(string name) : base("aws_connect_user", name)
    {
    }

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_user_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DirectoryUserId { get; set; } = default!;

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    [TerraformPropertyName("hierarchy_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HierarchyGroupId { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingProfileId is required")]
    [TerraformPropertyName("routing_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoutingProfileId { get; set; }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityProfileIds is required")]
    [TerraformPropertyName("security_profile_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SecurityProfileIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for identity_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityInfo block(s) allowed")]
    [TerraformPropertyName("identity_info")]
    public TerraformList<TerraformBlock<AwsConnectUserIdentityInfoBlock>>? IdentityInfo { get; set; }

    /// <summary>
    /// Block for phone_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhoneConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneConfig block(s) allowed")]
    [TerraformPropertyName("phone_config")]
    public TerraformList<TerraformBlock<AwsConnectUserPhoneConfigBlock>>? PhoneConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserId => new TerraformReference(this, "user_id");

}
