using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for partner_authorization in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// The authorization_expiration_time_in_utc attribute.
    /// </summary>
    [TerraformProperty("authorization_expiration_time_in_utc")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthorizationExpirationTimeInUtc { get; set; }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerName is required")]
    [TerraformProperty("partner_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PartnerName { get; set; }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerRegistrationId is required")]
    [TerraformProperty("partner_registration_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PartnerRegistrationId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventgridPartnerConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_eventgrid_partner_configuration resource.
/// </summary>
public partial class AzurermEventgridPartnerConfiguration : TerraformResource
{
    public AzurermEventgridPartnerConfiguration(string name) : base("azurerm_eventgrid_partner_configuration", name)
    {
    }

    /// <summary>
    /// The default_maximum_expiration_time_in_days attribute.
    /// </summary>
    [TerraformProperty("default_maximum_expiration_time_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DefaultMaximumExpirationTimeInDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for partner_authorization.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("partner_authorization")]
    public TerraformList<TerraformBlock<AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock>>? PartnerAuthorization { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermEventgridPartnerConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
