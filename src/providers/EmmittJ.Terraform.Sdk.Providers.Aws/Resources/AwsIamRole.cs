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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        set => SetProperty("policy", value);
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
        SetOutput("arn");
        SetOutput("create_date");
        SetOutput("unique_id");
        SetOutput("assume_role_policy");
        SetOutput("description");
        SetOutput("force_detach_policies");
        SetOutput("id");
        SetOutput("managed_policy_arns");
        SetOutput("max_session_duration");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("path");
        SetOutput("permissions_boundary");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssumeRolePolicy is required")]
    public required TerraformProperty<string> AssumeRolePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("assume_role_policy");
        set => SetProperty("assume_role_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The force_detach_policies attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDetachPolicies
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_detach_policies");
        set => SetProperty("force_detach_policies", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public HashSet<TerraformProperty<string>> ManagedPolicyArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("managed_policy_arns");
        set => SetProperty("managed_policy_arns", value);
    }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformProperty<double> MaxSessionDuration
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_session_duration");
        set => SetProperty("max_session_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformProperty<string> PermissionsBoundary
    {
        get => GetRequiredOutput<TerraformProperty<string>>("permissions_boundary");
        set => SetProperty("permissions_boundary", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for inline_policy.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AwsIamRoleInlinePolicyBlock>? InlinePolicy
    {
        set => SetProperty("inline_policy", value);
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
