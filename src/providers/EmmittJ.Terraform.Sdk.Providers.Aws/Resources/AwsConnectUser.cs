using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_info in AwsConnectUser.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserIdentityInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_info";

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => GetArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => GetArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The secondary_email attribute.
    /// </summary>
    public TerraformValue<string>? SecondaryEmail
    {
        get => GetArgument<TerraformValue<string>>("secondary_email");
        set => SetArgument("secondary_email", value);
    }

}


/// <summary>
/// Block type for phone_config in AwsConnectUser.
/// Nesting mode: list
/// </summary>
public class AwsConnectUserPhoneConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phone_config";

    /// <summary>
    /// The after_contact_work_time_limit attribute.
    /// </summary>
    public TerraformValue<double>? AfterContactWorkTimeLimit
    {
        get => GetArgument<TerraformValue<double>>("after_contact_work_time_limit");
        set => SetArgument("after_contact_work_time_limit", value);
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformValue<bool>? AutoAccept
    {
        get => GetArgument<TerraformValue<bool>>("auto_accept");
        set => SetArgument("auto_accept", value);
    }

    /// <summary>
    /// The desk_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? DeskPhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("desk_phone_number");
        set => SetArgument("desk_phone_number", value);
    }

    /// <summary>
    /// The phone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneType is required")]
    public required TerraformValue<string> PhoneType
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_type");
        set => SetArgument("phone_type", value);
    }

}


/// <summary>
/// Represents a aws_connect_user Terraform resource.
/// Manages a aws_connect_user resource.
/// </summary>
public partial class AwsConnectUser(string name) : TerraformResource("aws_connect_user", name)
{
    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    public TerraformValue<string> DirectoryUserId
    {
        get => GetArgument<TerraformValue<string>>("directory_user_id") ?? CreateReference("directory_user_id");
        set => SetArgument("directory_user_id", value);
    }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformValue<string>? HierarchyGroupId
    {
        get => GetArgument<TerraformValue<string>>("hierarchy_group_id");
        set => SetArgument("hierarchy_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingProfileId is required")]
    public required TerraformValue<string> RoutingProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("routing_profile_id");
        set => SetArgument("routing_profile_id", value);
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityProfileIds is required")]
    public required TerraformSet<string> SecurityProfileIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_profile_ids");
        set => SetArgument("security_profile_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
        => CreateReference("user_id");

    /// <summary>
    /// IdentityInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityInfo block(s) allowed")]
    public TerraformList<AwsConnectUserIdentityInfoBlock>? IdentityInfo
    {
        get => GetArgument<TerraformList<AwsConnectUserIdentityInfoBlock>>("identity_info");
        set => SetArgument("identity_info", value);
    }

    /// <summary>
    /// PhoneConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhoneConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneConfig block(s) allowed")]
    public required TerraformList<AwsConnectUserPhoneConfigBlock> PhoneConfig
    {
        get => GetRequiredArgument<TerraformList<AwsConnectUserPhoneConfigBlock>>("phone_config");
        set => SetArgument("phone_config", value);
    }

}
