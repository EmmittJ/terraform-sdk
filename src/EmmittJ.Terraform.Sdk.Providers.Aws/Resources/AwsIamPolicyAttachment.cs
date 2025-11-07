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
    public TerraformLiteralProperty<HashSet<string>>? Groups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("groups");
        set => this.WithProperty("groups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn");
        set => this.WithProperty("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Roles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("roles");
        set => this.WithProperty("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Users
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("users");
        set => this.WithProperty("users", value);
    }

}
