using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for input_mapping_default_values in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainInputMappingDefaultValuesBlock
{
    /// <summary>
    /// The data_version attribute.
    /// </summary>
    [TerraformPropertyName("data_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataVersion { get; set; }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [TerraformPropertyName("event_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventType { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subject { get; set; }

}

/// <summary>
/// Block type for input_mapping_fields in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainInputMappingFieldsBlock
{
    /// <summary>
    /// The data_version attribute.
    /// </summary>
    [TerraformPropertyName("data_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataVersion { get; set; }

    /// <summary>
    /// The event_time attribute.
    /// </summary>
    [TerraformPropertyName("event_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventTime { get; set; }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [TerraformPropertyName("event_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subject { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridDomainTimeoutsBlock
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
/// Manages a azurerm_eventgrid_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridDomain : TerraformResource
{
    public AzurermEventgridDomain(string name) : base("azurerm_eventgrid_domain", name)
    {
    }

    /// <summary>
    /// The auto_create_topic_with_first_subscription attribute.
    /// </summary>
    [TerraformPropertyName("auto_create_topic_with_first_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>
    /// The auto_delete_topic_with_last_subscription attribute.
    /// </summary>
    [TerraformPropertyName("auto_delete_topic_with_last_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    [TerraformPropertyName("inbound_ip_rule")]
    // Optional argument - user may or may not set a value
    public TerraformList<object>? InboundIpRule { get; set; }

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    [TerraformPropertyName("input_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputSchema { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermEventgridDomainIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for input_mapping_default_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingDefaultValues block(s) allowed")]
    [TerraformPropertyName("input_mapping_default_values")]
    public TerraformList<TerraformBlock<AzurermEventgridDomainInputMappingDefaultValuesBlock>>? InputMappingDefaultValues { get; set; }

    /// <summary>
    /// Block for input_mapping_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingFields block(s) allowed")]
    [TerraformPropertyName("input_mapping_fields")]
    public TerraformList<TerraformBlock<AzurermEventgridDomainInputMappingFieldsBlock>>? InputMappingFields { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermEventgridDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

}
