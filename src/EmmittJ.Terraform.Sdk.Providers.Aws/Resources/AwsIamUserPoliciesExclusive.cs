using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policies_exclusive resource.
/// </summary>
public class AwsIamUserPoliciesExclusive : TerraformResource
{
    public AwsIamUserPoliciesExclusive(string name) : base("aws_iam_user_policies_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public HashSet<TerraformProperty<string>>? PolicyNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("policy_names");
        set => this.WithProperty("policy_names", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}
