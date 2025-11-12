using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for contact_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddomainsRegistrationContactSettingsBlock() : TerraformBlock("contact_settings")
{
    /// <summary>
    /// Required. Privacy setting for the contacts associated with the Registration.
    /// Values are PUBLIC_CONTACT_DATA, PRIVATE_CONTACT_DATA, and REDACTED_CONTACT_DATA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Privacy is required")]
    [TerraformProperty("privacy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Privacy { get; set; }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddomainsRegistrationDnsSettingsBlock() : TerraformBlock("dns_settings")
{
}

/// <summary>
/// Block type for management_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddomainsRegistrationManagementSettingsBlock() : TerraformBlock("management_settings")
{
    /// <summary>
    /// The desired renewal method for this Registration. The actual renewalMethod is automatically updated to reflect this choice.
    /// If unset or equal to RENEWAL_METHOD_UNSPECIFIED, the actual renewalMethod is treated as if it were set to AUTOMATIC_RENEWAL.
    /// You cannot use RENEWAL_DISABLED during resource creation, and you can update the renewal status only when the Registration
    /// resource has state ACTIVE or SUSPENDED.
    /// 
    /// When preferredRenewalMethod is set to AUTOMATIC_RENEWAL, the actual renewalMethod can be set to RENEWAL_DISABLED in case of
    /// problems with the billing account or reported domain abuse. In such cases, check the issues field on the Registration. After
    /// the problem is resolved, the renewalMethod is automatically updated to preferredRenewalMethod in a few hours.
    /// </summary>
    [TerraformProperty("preferred_renewal_method")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredRenewalMethod { get; set; }


    /// <summary>
    /// Controls whether the domain can be transferred to another registrar. Values are UNLOCKED or LOCKED.
    /// </summary>
    [TerraformProperty("transfer_lock_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransferLockState { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleClouddomainsRegistrationTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for yearly_price in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddomainsRegistrationYearlyPriceBlock() : TerraformBlock("yearly_price")
{
    /// <summary>
    /// The three-letter currency code defined in ISO 4217.
    /// </summary>
    [TerraformProperty("currency_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CurrencyCode { get; set; }

    /// <summary>
    /// The whole units of the amount. For example if currencyCode is &amp;quot;USD&amp;quot;, then 1 unit is one US dollar.
    /// </summary>
    [TerraformProperty("units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Units { get; set; }

}

/// <summary>
/// Manages a google_clouddomains_registration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleClouddomainsRegistration : TerraformResource
{
    public GoogleClouddomainsRegistration(string name) : base("google_clouddomains_registration", name)
    {
    }

    /// <summary>
    /// The list of contact notices that the caller acknowledges. Possible value is PUBLIC_CONTACT_DATA_ACKNOWLEDGEMENT
    /// </summary>
    [TerraformProperty("contact_notices")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ContactNotices { get; set; }

    /// <summary>
    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The list of domain notices that you acknowledge. Possible value is HSTS_PRELOADED
    /// </summary>
    [TerraformProperty("domain_notices")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DomainNotices { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Set of labels associated with the Registration.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for contact_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContactSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContactSettings block(s) allowed")]
    [TerraformProperty("contact_settings")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlock> ContactSettings { get; set; } = new();

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    [TerraformProperty("dns_settings")]
    public TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlock> DnsSettings { get; set; } = new();

    /// <summary>
    /// Block for management_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementSettings block(s) allowed")]
    [TerraformProperty("management_settings")]
    public TerraformList<GoogleClouddomainsRegistrationManagementSettingsBlock> ManagementSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleClouddomainsRegistrationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for yearly_price.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "YearlyPrice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 YearlyPrice block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 YearlyPrice block(s) allowed")]
    [TerraformProperty("yearly_price")]
    public required TerraformList<GoogleClouddomainsRegistrationYearlyPriceBlock> YearlyPrice { get; set; } = new();

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// Output only. The set of issues with the Registration that require attention.
    /// </summary>
    [TerraformProperty("issues")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Issues { get; }

    /// <summary>
    /// Output only. Name of the Registration resource, in the format projects/*/locations/*/registrations/&amp;lt;domain_name&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The reason the domain registration failed. Only set for domains in REGISTRATION_FAILED state.
    /// </summary>
    [TerraformProperty("register_failure_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegisterFailureReason { get; }

    /// <summary>
    /// Output only. The current state of the Registration.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. Set of options for the contactSettings.privacy field that this Registration supports.
    /// </summary>
    [TerraformProperty("supported_privacy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedPrivacy { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
