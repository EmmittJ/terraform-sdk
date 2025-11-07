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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The user attribute.
    /// </summary>
    public TerraformProperty<string>? User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

}
