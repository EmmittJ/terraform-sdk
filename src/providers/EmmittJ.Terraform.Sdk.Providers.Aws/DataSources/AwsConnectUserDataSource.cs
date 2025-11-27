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
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
    {
        get => new TerraformReference<string>(this, "user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    public TerraformValue<string> DirectoryUserId
    {
        get => new TerraformReference<string>(this, "directory_user_id");
    }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformValue<string> HierarchyGroupId
    {
        get => new TerraformReference<string>(this, "hierarchy_group_id");
    }

    /// <summary>
    /// The identity_info attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IdentityInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The phone_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PhoneConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "phone_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformValue<string> RoutingProfileId
    {
        get => new TerraformReference<string>(this, "routing_profile_id");
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityProfileIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_profile_ids").ResolveNodes(ctx));
    }

}
