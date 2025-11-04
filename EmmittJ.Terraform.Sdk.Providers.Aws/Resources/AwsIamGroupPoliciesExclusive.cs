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
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public HashSet<string>? PolicyNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_names")?.Value;
        set => this.WithProperty("policy_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
