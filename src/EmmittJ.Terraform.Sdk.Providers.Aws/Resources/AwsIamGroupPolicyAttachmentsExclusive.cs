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
    public TerraformProperty<string>? GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? PolicyArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("policy_arns");
        set => this.WithProperty("policy_arns", value);
    }

}
