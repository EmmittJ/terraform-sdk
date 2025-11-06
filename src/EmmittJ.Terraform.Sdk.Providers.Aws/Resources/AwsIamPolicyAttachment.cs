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
    public HashSet<string>? Groups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("groups")?.Value;
        set => this.WithProperty("groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public string? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn")?.Value;
        set => this.WithProperty("policy_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public HashSet<string>? Roles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("roles")?.Value;
        set => this.WithProperty("roles", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public HashSet<string>? Users
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("users")?.Value;
        set => this.WithProperty("users", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
