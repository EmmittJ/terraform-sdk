using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridTopicIdentityBlock() : TerraformBlock("identity")
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
/// Block type for input_mapping_default_values in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridTopicInputMappingDefaultValuesBlock() : TerraformBlock("input_mapping_default_values")
{
    /// <summary>
    /// The data_version attribute.
    /// </summary>
    [TerraformProperty("data_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataVersion { get; set; }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [TerraformProperty("event_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventType { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformProperty("subject")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subject { get; set; }

}

/// <summary>
/// Block type for input_mapping_fields in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridTopicInputMappingFieldsBlock() : TerraformBlock("input_mapping_fields")
{
    /// <summary>
    /// The data_version attribute.
    /// </summary>
    [TerraformProperty("data_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataVersion { get; set; }

    /// <summary>
    /// The event_time attribute.
    /// </summary>
    [TerraformProperty("event_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventTime { get; set; }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [TerraformProperty("event_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformProperty("subject")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subject { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [TerraformProperty("topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventgridTopicTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_eventgrid_topic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermEventgridTopic : TerraformResource
{
    public AzurermEventgridTopic(string name) : base("azurerm_eventgrid_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    [TerraformProperty("inbound_ip_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<object>? InboundIpRule { get; set; }

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    [TerraformProperty("input_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputSchema { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    public TerraformList<AzurermEventgridTopicIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for input_mapping_default_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingDefaultValues block(s) allowed")]
    [TerraformProperty("input_mapping_default_values")]
    public TerraformList<AzurermEventgridTopicInputMappingDefaultValuesBlock> InputMappingDefaultValues { get; set; } = new();

    /// <summary>
    /// Block for input_mapping_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingFields block(s) allowed")]
    [TerraformProperty("input_mapping_fields")]
    public TerraformList<AzurermEventgridTopicInputMappingFieldsBlock> InputMappingFields { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermEventgridTopicTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAccessKey { get; }

}
