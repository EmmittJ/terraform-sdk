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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The user attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

}
