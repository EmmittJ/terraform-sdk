using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventhubNamespaceIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventhubNamespaceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_eventhub_namespace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermEventhubNamespace : TerraformResource
{
    public AzurermEventhubNamespace(string name) : base("azurerm_eventhub_namespace", name)
    {
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_inflate_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoInflateEnabled { get; set; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Capacity { get; set; }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    [TerraformProperty("dedicated_cluster_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DedicatedClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    [TerraformProperty("maximum_throughput_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumThroughputUnits { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_rulesets attribute.
    /// </summary>
    [TerraformProperty("network_rulesets")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> NetworkRulesets { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermEventhubNamespaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermEventhubNamespaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("default_primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryConnectionString { get; }

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("default_primary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryConnectionStringAlias { get; }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformProperty("default_primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryKey { get; }

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("default_secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryConnectionString { get; }

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("default_secondary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryConnectionStringAlias { get; }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformProperty("default_secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryKey { get; }

}
