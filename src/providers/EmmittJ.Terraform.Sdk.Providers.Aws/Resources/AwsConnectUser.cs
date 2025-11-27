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
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The secondary_email attribute.
    /// </summary>
    public TerraformValue<string>? SecondaryEmail
    {
        get => new TerraformReference<string>(this, "secondary_email");
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
        get => new TerraformReference<double>(this, "after_contact_work_time_limit");
        set => SetArgument("after_contact_work_time_limit", value);
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformValue<bool>? AutoAccept
    {
        get => new TerraformReference<bool>(this, "auto_accept");
        set => SetArgument("auto_accept", value);
    }

    /// <summary>
    /// The desk_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? DeskPhoneNumber
    {
        get => new TerraformReference<string>(this, "desk_phone_number");
        set => SetArgument("desk_phone_number", value);
    }

    /// <summary>
    /// The phone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneType is required")]
    public required TerraformValue<string> PhoneType
    {
        get => new TerraformReference<string>(this, "phone_type");
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
        get => new TerraformReference<string>(this, "directory_user_id");
        set => SetArgument("directory_user_id", value);
    }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformValue<string>? HierarchyGroupId
    {
        get => new TerraformReference<string>(this, "hierarchy_group_id");
        set => SetArgument("hierarchy_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingProfileId is required")]
    public required TerraformValue<string> RoutingProfileId
    {
        get => new TerraformReference<string>(this, "routing_profile_id");
        set => SetArgument("routing_profile_id", value);
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityProfileIds is required")]
    public required TerraformSet<string> SecurityProfileIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_profile_ids").ResolveNodes(ctx));
        set => SetArgument("security_profile_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
    {
        get => new TerraformReference<string>(this, "user_id");
    }

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
