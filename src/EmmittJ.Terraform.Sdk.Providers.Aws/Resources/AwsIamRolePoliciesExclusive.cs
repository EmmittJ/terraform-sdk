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
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public HashSet<string>? PolicyNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_names")?.Value;
        set => this.WithProperty("policy_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public string? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name")?.Value;
        set => this.WithProperty("role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
