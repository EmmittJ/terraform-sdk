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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
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
        get => new TerraformReference<string>(this, "assume_role_policy");
        set => SetArgument("assume_role_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The force_detach_policies attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDetachPolicies
    {
        get => new TerraformReference<bool>(this, "force_detach_policies");
        set => SetArgument("force_detach_policies", value);
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
    [Obsolete("This property is deprecated.")]
    public TerraformSet<string> ManagedPolicyArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "managed_policy_arns").ResolveNodes(ctx));
        set => SetArgument("managed_policy_arns", value);
    }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformValue<double>? MaxSessionDuration
    {
        get => new TerraformReference<double>(this, "max_session_duration");
        set => SetArgument("max_session_duration", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformValue<string>? PermissionsBoundary
    {
        get => new TerraformReference<string>(this, "permissions_boundary");
        set => SetArgument("permissions_boundary", value);
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
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
    {
        get => new TerraformReference<string>(this, "create_date");
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
    {
        get => new TerraformReference<string>(this, "unique_id");
    }

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
