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
    /// The policy_names attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? PolicyNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("policy_names");
        set => this.WithProperty("policy_names", value);
    }

}
