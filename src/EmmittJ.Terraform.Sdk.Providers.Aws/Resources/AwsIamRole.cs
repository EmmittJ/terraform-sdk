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
    public TerraformProperty<string>? AssumeRolePolicy
    {
        get => GetProperty<TerraformProperty<string>>("assume_role_policy");
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
    public TerraformProperty<HashSet<string>>? ManagedPolicyArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("managed_policy_arns");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
