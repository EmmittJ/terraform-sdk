using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policy_attachment resource.
/// </summary>
public class AwsIamUserPolicyAttachment : TerraformResource
{
    public AwsIamUserPolicyAttachment(string name) : base("aws_iam_user_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The policy_arn attribute.
    /// </summary>
    public string? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn")?.Value;
        set => this.WithProperty("policy_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public string? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user")?.Value;
        set => this.WithProperty("user", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
