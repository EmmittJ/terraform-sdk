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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    public HashSet<TerraformProperty<string>>? PolicyArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("policy_arns");
        set => this.WithProperty("policy_arns", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}
