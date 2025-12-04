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
        get => GetArgument<TerraformValue<double>>("duration_seconds") ?? AsReference("duration_seconds");
        set => SetArgument("duration_seconds", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    public TerraformSet<string>? ManagedPolicyArns
    {
        get => GetArgument<TerraformSet<string>>("managed_policy_arns");
        set => SetArgument("managed_policy_arns", value);
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
    /// The require_instance_properties attribute.
    /// </summary>
    public TerraformValue<bool>? RequireInstanceProperties
    {
        get => GetArgument<TerraformValue<bool>>("require_instance_properties");
        set => SetArgument("require_instance_properties", value);
    }

    /// <summary>
    /// The role_arns attribute.
    /// </summary>
    public TerraformSet<string>? RoleArns
    {
        get => GetArgument<TerraformSet<string>>("role_arns");
        set => SetArgument("role_arns", value);
    }

    /// <summary>
    /// The session_policy attribute.
    /// </summary>
    public TerraformValue<string>? SessionPolicy
    {
        get => GetArgument<TerraformValue<string>>("session_policy");
        set => SetArgument("session_policy", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
