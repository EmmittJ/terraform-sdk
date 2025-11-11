using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audit_config in .
/// Nesting mode: set
/// </summary>
public partial class GoogleIamPolicyDataSourceAuditConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Block type for binding in .
/// Nesting mode: set
/// </summary>
public partial class GoogleIamPolicyDataSourceBindingBlock : TerraformBlockBase
{
    /// <summary>
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    [TerraformProperty("members")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Members { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

}

/// <summary>
/// Retrieves information about a google_iam_policy.
/// </summary>
public partial class GoogleIamPolicyDataSource : TerraformDataSource
{
    public GoogleIamPolicyDataSource(string name) : base("google_iam_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for audit_config.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("audit_config")]
    public partial TerraformSet<TerraformBlock<GoogleIamPolicyDataSourceAuditConfigBlock>>? AuditConfig { get; set; }

    /// <summary>
    /// Block for binding.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("binding")]
    public partial TerraformSet<TerraformBlock<GoogleIamPolicyDataSourceBindingBlock>>? Binding { get; set; }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformProperty("policy_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyData { get; }

}
