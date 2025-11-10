using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleAssignmentsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_role_assignments.
/// </summary>
public class AzurermRoleAssignmentsDataSource : TerraformDataSource
{
    public AzurermRoleAssignmentsDataSource(string name) : base("azurerm_role_assignments", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The limit_at_scope attribute.
    /// </summary>
    [TerraformPropertyName("limit_at_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LimitAtScope { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrincipalId { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TenantId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRoleAssignmentsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The role_assignments attribute.
    /// </summary>
    [TerraformPropertyName("role_assignments")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RoleAssignments => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "role_assignments");

}
