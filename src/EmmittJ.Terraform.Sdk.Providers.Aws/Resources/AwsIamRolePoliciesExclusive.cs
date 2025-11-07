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
    public TerraformProperty<HashSet<string>>? PolicyNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("policy_names");
        set => this.WithProperty("policy_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

}
