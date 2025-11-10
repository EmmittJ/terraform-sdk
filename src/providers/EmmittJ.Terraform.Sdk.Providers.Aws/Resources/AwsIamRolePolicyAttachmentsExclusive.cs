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
        SetOutput("policy_arns");
        SetOutput("role_name");
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

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

}
