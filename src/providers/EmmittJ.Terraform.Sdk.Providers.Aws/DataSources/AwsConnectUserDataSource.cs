using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_user Terraform data source.
/// Retrieves information about a aws_connect_user.
/// </summary>
public partial class AwsConnectUserDataSource(string name) : TerraformDataSource("aws_connect_user", name)
{
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
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
    {
        get => GetArgument<TerraformValue<string>>("user_id") ?? CreateReference("user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    public TerraformValue<string> DirectoryUserId
        => CreateReference("directory_user_id");

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformValue<string> HierarchyGroupId
        => CreateReference("hierarchy_group_id");

    /// <summary>
    /// The identity_info attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IdentityInfo
        => CreateReference("identity_info");

    /// <summary>
    /// The phone_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PhoneConfig
        => CreateReference("phone_config");

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformValue<string> RoutingProfileId
        => CreateReference("routing_profile_id");

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityProfileIds
        => CreateReference("security_profile_ids");

}
