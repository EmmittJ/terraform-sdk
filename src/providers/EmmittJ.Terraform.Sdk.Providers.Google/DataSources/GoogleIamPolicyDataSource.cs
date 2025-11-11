using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audit_config in .
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceAuditConfigBlock
{
    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Block type for binding in .
/// Nesting mode: set
/// </summary>
public class GoogleIamPolicyDataSourceBindingBlock
{
    /// <summary>
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    [TerraformPropertyName("members")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Members { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Role { get; set; }

}

/// <summary>
/// Retrieves information about a google_iam_policy.
/// </summary>
public class GoogleIamPolicyDataSource : TerraformDataSource
{
    public GoogleIamPolicyDataSource(string name) : base("google_iam_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for audit_config.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("audit_config")]
    public TerraformSet<TerraformBlock<GoogleIamPolicyDataSourceAuditConfigBlock>>? AuditConfig { get; set; }

    /// <summary>
    /// Block for binding.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("binding")]
    public TerraformSet<TerraformBlock<GoogleIamPolicyDataSourceBindingBlock>>? Binding { get; set; }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformPropertyName("policy_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyData => new TerraformReference(this, "policy_data");

}
