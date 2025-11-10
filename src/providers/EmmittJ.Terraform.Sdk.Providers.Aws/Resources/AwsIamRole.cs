using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_policy in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsIamRoleInlinePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => WithProperty("policy", value);
    }

}

/// <summary>
/// Manages a aws_iam_role resource.
/// </summary>
public class AwsIamRole : TerraformResource
{
    public AwsIamRole(string name) : base("aws_iam_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("create_date");
        this.WithOutput("unique_id");
    }

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssumeRolePolicy is required")]
    public required TerraformProperty<string> AssumeRolePolicy
    {
        get => GetRequiredProperty<TerraformProperty<string>>("assume_role_policy");
        set => this.WithProperty("assume_role_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The force_detach_policies attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDetachPolicies
    {
        get => GetProperty<TerraformProperty<bool>>("force_detach_policies");
        set => this.WithProperty("force_detach_policies", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public HashSet<TerraformProperty<string>>? ManagedPolicyArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("managed_policy_arns");
        set => this.WithProperty("managed_policy_arns", value);
    }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSessionDuration
    {
        get => GetProperty<TerraformProperty<double>>("max_session_duration");
        set => this.WithProperty("max_session_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformProperty<string>? PermissionsBoundary
    {
        get => GetProperty<TerraformProperty<string>>("permissions_boundary");
        set => this.WithProperty("permissions_boundary", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for inline_policy.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AwsIamRoleInlinePolicyBlock>? InlinePolicy
    {
        get => GetProperty<HashSet<AwsIamRoleInlinePolicyBlock>>("inline_policy");
        set => this.WithProperty("inline_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
