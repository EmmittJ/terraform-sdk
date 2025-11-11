using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTenantTemplateDeploymentDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_tenant_template_deployment.
/// </summary>
public class AzurermTenantTemplateDeploymentDataSource : TerraformDataSource
{
    public AzurermTenantTemplateDeploymentDataSource(string name) : base("azurerm_tenant_template_deployment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermTenantTemplateDeploymentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    [TerraformPropertyName("output_content")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutputContent => new TerraformReference(this, "output_content");

}
