using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusNamespaceAuthorizationRuleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_namespace_authorization_rule.
/// </summary>
public partial class AzurermServicebusNamespaceAuthorizationRuleDataSource : TerraformDataSource
{
    public AzurermServicebusNamespaceAuthorizationRuleDataSource(string name) : base("azurerm_servicebus_namespace_authorization_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespaceId { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("namespace_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespaceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("resource_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermServicebusNamespaceAuthorizationRuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryConnectionStringAlias { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryConnectionStringAlias { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryKey { get; }

}
