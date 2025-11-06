using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("create_date");
        this.DeclareOutput("unique_id");
    }

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    public string? AssumeRolePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assume_role_policy")?.Value;
        set => this.WithProperty("assume_role_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_detach_policies attribute.
    /// </summary>
    public bool? ForceDetachPolicies
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_detach_policies")?.Value;
        set => this.WithProperty("force_detach_policies", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public HashSet<string>? ManagedPolicyArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("managed_policy_arns")?.Value;
        set => this.WithProperty("managed_policy_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public double? MaxSessionDuration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_session_duration")?.Value;
        set => this.WithProperty("max_session_duration", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public string? PermissionsBoundary
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permissions_boundary")?.Value;
        set => this.WithProperty("permissions_boundary", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
