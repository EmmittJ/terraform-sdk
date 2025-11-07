using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policy_attachments_exclusive resource.
/// </summary>
public class AwsIamUserPolicyAttachmentsExclusive : TerraformResource
{
    public AwsIamUserPolicyAttachmentsExclusive(string name) : base("aws_iam_user_policy_attachments_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PolicyArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_arns");
        set => this.WithProperty("policy_arns", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}
