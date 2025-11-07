using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_policy_attachment resource.
/// </summary>
public class AwsIamPolicyAttachment : TerraformResource
{
    public AwsIamPolicyAttachment(string name) : base("aws_iam_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Groups
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("groups");
        set => this.WithProperty("groups", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("policy_arn");
        set => this.WithProperty("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Roles
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("roles");
        set => this.WithProperty("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Users
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("users");
        set => this.WithProperty("users", value);
    }

}
