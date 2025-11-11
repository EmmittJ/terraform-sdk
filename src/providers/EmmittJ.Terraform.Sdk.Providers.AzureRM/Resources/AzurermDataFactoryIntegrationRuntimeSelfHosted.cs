using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rbac_authorization in .
/// Nesting mode: set
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_self_hosted resource.
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeSelfHosted : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeSelfHosted(string name) : base("azurerm_data_factory_integration_runtime_self_hosted", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The self_contained_interactive_authoring_enabled attribute.
    /// </summary>
    [TerraformProperty("self_contained_interactive_authoring_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SelfContainedInteractiveAuthoringEnabled { get; set; }

    /// <summary>
    /// Block for rbac_authorization.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("rbac_authorization")]
    public TerraformSet<TerraformBlock<AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock>>? RbacAuthorization { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_authorization_key attribute.
    /// </summary>
    [TerraformProperty("primary_authorization_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAuthorizationKey { get; }

    /// <summary>
    /// The secondary_authorization_key attribute.
    /// </summary>
    [TerraformProperty("secondary_authorization_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAuthorizationKey { get; }

}
