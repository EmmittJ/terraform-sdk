using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_role_policy_attachments_exclusive resource.
/// </summary>
public class AwsIamRolePolicyAttachmentsExclusive : TerraformResource
{
    public AwsIamRolePolicyAttachmentsExclusive(string name) : base("aws_iam_role_policy_attachments_exclusive", name)
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
    /// The role_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

}
