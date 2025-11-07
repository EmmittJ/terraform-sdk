using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_policy_attachments_exclusive resource.
/// </summary>
public class AwsIamGroupPolicyAttachmentsExclusive : TerraformResource
{
    public AwsIamGroupPolicyAttachmentsExclusive(string name) : base("aws_iam_group_policy_attachments_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PolicyArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_arns");
        set => this.WithProperty("policy_arns", value);
    }

}
