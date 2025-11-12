using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsConnectUserIdentityInfoBlock() : TerraformBlock("identity_info")
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The secondary_email attribute.
    /// </summary>
    [TerraformProperty("secondary_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecondaryEmail { get; set; }

}

/// <summary>
/// Block type for phone_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsConnectUserPhoneConfigBlock() : TerraformBlock("phone_config")
{
    /// <summary>
    /// The after_contact_work_time_limit attribute.
    /// </summary>
    [TerraformProperty("after_contact_work_time_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AfterContactWorkTimeLimit { get; set; }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    [TerraformProperty("auto_accept")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoAccept { get; set; }

    /// <summary>
    /// The desk_phone_number attribute.
    /// </summary>
    [TerraformProperty("desk_phone_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeskPhoneNumber { get; set; }

    /// <summary>
    /// The phone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneType is required")]
    [TerraformProperty("phone_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PhoneType { get; set; }

}

/// <summary>
/// Manages a aws_connect_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConnectUser : TerraformResource
{
    public AwsConnectUser(string name) : base("aws_connect_user", name)
    {
    }

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    [TerraformProperty("directory_user_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DirectoryUserId { get; set; }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    [TerraformProperty("hierarchy_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HierarchyGroupId { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingProfileId is required")]
    [TerraformProperty("routing_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoutingProfileId { get; set; }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityProfileIds is required")]
    [TerraformProperty("security_profile_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityProfileIds { get; set; }

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
    /// Block for identity_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityInfo block(s) allowed")]
    [TerraformProperty("identity_info")]
    public TerraformList<AwsConnectUserIdentityInfoBlock> IdentityInfo { get; set; } = new();

    /// <summary>
    /// Block for phone_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhoneConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneConfig block(s) allowed")]
    [TerraformProperty("phone_config")]
    public required TerraformList<AwsConnectUserPhoneConfigBlock> PhoneConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserId { get; }

}
