using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIothubEndpointServicebusQueueTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_iothub_endpoint_servicebus_queue resource.
/// </summary>
public partial class AzurermIothubEndpointServicebusQueue : TerraformResource
{
    public AzurermIothubEndpointServicebusQueue(string name) : base("azurerm_iothub_endpoint_servicebus_queue", name)
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [TerraformProperty("endpoint_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndpointUri { get; set; }

    /// <summary>
    /// The entity_path attribute.
    /// </summary>
    [TerraformProperty("entity_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EntityPath { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformProperty("identity_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdentityId { get; set; }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformProperty("iothub_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IothubId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermIothubEndpointServicebusQueueTimeoutsBlock>? Timeouts { get; set; }

}
