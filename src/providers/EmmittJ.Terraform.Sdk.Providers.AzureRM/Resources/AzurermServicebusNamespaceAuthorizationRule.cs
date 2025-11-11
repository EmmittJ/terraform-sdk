using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_servicebus_namespace_authorization_rule resource.
/// </summary>
public partial class AzurermServicebusNamespaceAuthorizationRule : TerraformResource
{
    public AzurermServicebusNamespaceAuthorizationRule(string name) : base("azurerm_servicebus_namespace_authorization_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    [TerraformProperty("listen")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Listen { get; set; }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    [TerraformProperty("manage")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Manage { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformProperty("namespace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NamespaceId { get; set; }

    /// <summary>
    /// The send attribute.
    /// </summary>
    [TerraformProperty("send")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Send { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionStringAlias { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionStringAlias { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryKey { get; }

}
