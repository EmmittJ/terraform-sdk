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
        SetOutput("policy_names");
        SetOutput("user_name");
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public HashSet<TerraformProperty<string>> PolicyNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("policy_names");
        set => SetProperty("policy_names", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

}
