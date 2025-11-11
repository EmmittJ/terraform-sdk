using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rbac_authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_self_hosted resource.
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHosted : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeSelfHosted(string name) : base("azurerm_data_factory_integration_runtime_self_hosted", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

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
    /// The self_contained_interactive_authoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("self_contained_interactive_authoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SelfContainedInteractiveAuthoringEnabled { get; set; }

    /// <summary>
    /// Block for rbac_authorization.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("rbac_authorization")]
    public TerraformSet<TerraformBlock<AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock>>? RbacAuthorization { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_authorization_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAuthorizationKey => new TerraformReference(this, "primary_authorization_key");

    /// <summary>
    /// The secondary_authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_authorization_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAuthorizationKey => new TerraformReference(this, "secondary_authorization_key");

}
