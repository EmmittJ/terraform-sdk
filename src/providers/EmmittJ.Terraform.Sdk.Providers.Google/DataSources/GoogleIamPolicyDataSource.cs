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
        set => SetProperty("service", value);
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
        set => SetProperty("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        set => SetProperty("role", value);
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
        SetOutput("policy_data");
        SetOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for audit_config.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleIamPolicyDataSourceAuditConfigBlock>? AuditConfig
    {
        set => SetProperty("audit_config", value);
    }

    /// <summary>
    /// Block for binding.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleIamPolicyDataSourceBindingBlock>? Binding
    {
        set => SetProperty("binding", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
