using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_policy in AwsIamRole.
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsIamRoleInlinePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_policy";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

}


/// <summary>
/// Represents a aws_iam_role Terraform resource.
/// Manages a aws_iam_role resource.
/// </summary>
public partial class AwsIamRole(string name) : TerraformResource("aws_iam_role", name)
{
    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssumeRolePolicy is required")]
    public required TerraformValue<string> AssumeRolePolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("assume_role_policy");
        set => SetArgument("assume_role_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The force_detach_policies attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDetachPolicies
    {
        get => GetArgument<TerraformValue<bool>>("force_detach_policies");
        set => SetArgument("force_detach_policies", value);
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
    /// The managed_policy_arns attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformSet<string> ManagedPolicyArns
    {
        get => GetArgument<TerraformSet<string>>("managed_policy_arns") ?? CreateReference("managed_policy_arns");
        set => SetArgument("managed_policy_arns", value);
    }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformValue<double>? MaxSessionDuration
    {
        get => GetArgument<TerraformValue<double>>("max_session_duration");
        set => SetArgument("max_session_duration", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformValue<string>? PermissionsBoundary
    {
        get => GetArgument<TerraformValue<string>>("permissions_boundary");
        set => SetArgument("permissions_boundary", value);
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
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => CreateReference("create_date");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
        => CreateReference("unique_id");

    /// <summary>
    /// InlinePolicy block (nesting mode: set).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformSet<AwsIamRoleInlinePolicyBlock>? InlinePolicy
    {
        get => GetArgument<TerraformSet<AwsIamRoleInlinePolicyBlock>>("inline_policy");
        set => SetArgument("inline_policy", value);
    }

}
