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
        SetOutput("group_name");
        SetOutput("policy_arns");
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_name");
        set => SetProperty("group_name", value);
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    public HashSet<TerraformProperty<string>> PolicyArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("policy_arns");
        set => SetProperty("policy_arns", value);
    }

}
