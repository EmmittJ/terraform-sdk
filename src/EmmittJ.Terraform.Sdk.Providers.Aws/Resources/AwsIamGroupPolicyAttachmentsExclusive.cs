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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    public HashSet<TerraformProperty<string>>? PolicyArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("policy_arns");
        set => this.WithProperty("policy_arns", value);
    }

}
