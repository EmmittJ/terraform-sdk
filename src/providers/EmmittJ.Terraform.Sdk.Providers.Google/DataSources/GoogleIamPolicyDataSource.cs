using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audit_config in .
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceAuditConfigBlock : TerraformBlock
{
    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
    }

}

/// <summary>
/// Block type for binding in .
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceBindingBlock : TerraformBlock
{
    /// <summary>
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    public HashSet<TerraformProperty<string>>? Members
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("members");
        set => WithProperty("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => WithProperty("role", value);
    }

}

/// <summary>
/// Retrieves information about a google_iam_policy.
/// </summary>
public class GoogleIamPolicyDataSource : TerraformDataSource
{
    public GoogleIamPolicyDataSource(string name) : base("google_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("policy_data");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for audit_config.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleIamPolicyDataSourceAuditConfigBlock>? AuditConfig
    {
        get => GetProperty<HashSet<GoogleIamPolicyDataSourceAuditConfigBlock>>("audit_config");
        set => this.WithProperty("audit_config", value);
    }

    /// <summary>
    /// Block for binding.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleIamPolicyDataSourceBindingBlock>? Binding
    {
        get => GetProperty<HashSet<GoogleIamPolicyDataSourceBindingBlock>>("binding");
        set => this.WithProperty("binding", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
