using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rolesanywhere_profile Terraform resource.
/// Manages a aws_rolesanywhere_profile resource.
/// </summary>
public partial class AwsRolesanywhereProfile(string name) : TerraformResource("aws_rolesanywhere_profile", name)
{
    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformValue<double> DurationSeconds
    {
        get => new TerraformReference<double>(this, "duration_seconds");
        set => SetArgument("duration_seconds", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The managed_policy_arns attribute.
    /// </summary>
    public TerraformSet<string>? ManagedPolicyArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "managed_policy_arns").ResolveNodes(ctx));
        set => SetArgument("managed_policy_arns", value);
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
    /// The require_instance_properties attribute.
    /// </summary>
    public TerraformValue<bool>? RequireInstanceProperties
    {
        get => new TerraformReference<bool>(this, "require_instance_properties");
        set => SetArgument("require_instance_properties", value);
    }

    /// <summary>
    /// The role_arns attribute.
    /// </summary>
    public TerraformSet<string>? RoleArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "role_arns").ResolveNodes(ctx));
        set => SetArgument("role_arns", value);
    }

    /// <summary>
    /// The session_policy attribute.
    /// </summary>
    public TerraformValue<string>? SessionPolicy
    {
        get => new TerraformReference<string>(this, "session_policy");
        set => SetArgument("session_policy", value);
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

}
