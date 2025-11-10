using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_role_policies_exclusive resource.
/// </summary>
public class AwsIamRolePoliciesExclusive : TerraformResource
{
    public AwsIamRolePoliciesExclusive(string name) : base("aws_iam_role_policies_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("policy_names");
        SetOutput("role_name");
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
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

}
