using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_policies_exclusive resource.
/// </summary>
public class AwsIamGroupPoliciesExclusive : TerraformResource
{
    public AwsIamGroupPoliciesExclusive(string name) : base("aws_iam_group_policies_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("group_name");
        SetOutput("policy_names");
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
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public HashSet<TerraformProperty<string>> PolicyNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("policy_names");
        set => SetProperty("policy_names", value);
    }

}
