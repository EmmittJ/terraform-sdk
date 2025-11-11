using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for contact_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlock
{
    /// <summary>
    /// Required. Privacy setting for the contacts associated with the Registration.
    /// Values are PUBLIC_CONTACT_DATA, PRIVATE_CONTACT_DATA, and REDACTED_CONTACT_DATA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Privacy is required")]
    [TerraformPropertyName("privacy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Privacy { get; set; }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationDnsSettingsBlock
{
}

/// <summary>
/// Block type for management_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationManagementSettingsBlock
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
    [TerraformPropertyName("preferred_renewal_method")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredRenewalMethod { get; set; } = default!;


    /// <summary>
    /// Controls whether the domain can be transferred to another registrar. Values are UNLOCKED or LOCKED.
    /// </summary>
    [TerraformPropertyName("transfer_lock_state")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransferLockState { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleClouddomainsRegistrationTimeoutsBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for yearly_price in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationYearlyPriceBlock
{
    /// <summary>
    /// The three-letter currency code defined in ISO 4217.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CurrencyCode { get; set; }

    /// <summary>
    /// The whole units of the amount. For example if currencyCode is &amp;quot;USD&amp;quot;, then 1 unit is one US dollar.
    /// </summary>
    [TerraformPropertyName("units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Units { get; set; }

}

/// <summary>
/// Manages a google_clouddomains_registration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleClouddomainsRegistration : TerraformResource
{
    public GoogleClouddomainsRegistration(string name) : base("google_clouddomains_registration", name)
    {
    }

    /// <summary>
    /// The list of contact notices that the caller acknowledges. Possible value is PUBLIC_CONTACT_DATA_ACKNOWLEDGEMENT
    /// </summary>
    [TerraformPropertyName("contact_notices")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ContactNotices { get; set; }

    /// <summary>
    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The list of domain notices that you acknowledge. Possible value is HSTS_PRELOADED
    /// </summary>
    [TerraformPropertyName("domain_notices")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DomainNotices { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Set of labels associated with the Registration.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for contact_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContactSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContactSettings block(s) allowed")]
    [TerraformPropertyName("contact_settings")]
    public TerraformList<TerraformBlock<GoogleClouddomainsRegistrationContactSettingsBlock>>? ContactSettings { get; set; }

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    [TerraformPropertyName("dns_settings")]
    public TerraformList<TerraformBlock<GoogleClouddomainsRegistrationDnsSettingsBlock>>? DnsSettings { get; set; }

    /// <summary>
    /// Block for management_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementSettings block(s) allowed")]
    [TerraformPropertyName("management_settings")]
    public TerraformList<TerraformBlock<GoogleClouddomainsRegistrationManagementSettingsBlock>>? ManagementSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleClouddomainsRegistrationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for yearly_price.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "YearlyPrice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 YearlyPrice block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 YearlyPrice block(s) allowed")]
    [TerraformPropertyName("yearly_price")]
    public TerraformList<TerraformBlock<GoogleClouddomainsRegistrationYearlyPriceBlock>>? YearlyPrice { get; set; }

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpireTime => new TerraformReference(this, "expire_time");

    /// <summary>
    /// Output only. The set of issues with the Registration that require attention.
    /// </summary>
    [TerraformPropertyName("issues")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Issues => new TerraformReference(this, "issues");

    /// <summary>
    /// Output only. Name of the Registration resource, in the format projects/*/locations/*/registrations/&amp;lt;domain_name&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. The reason the domain registration failed. Only set for domains in REGISTRATION_FAILED state.
    /// </summary>
    [TerraformPropertyName("register_failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegisterFailureReason => new TerraformReference(this, "register_failure_reason");

    /// <summary>
    /// Output only. The current state of the Registration.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Output only. Set of options for the contactSettings.privacy field that this Registration supports.
    /// </summary>
    [TerraformPropertyName("supported_privacy")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedPrivacy => new TerraformReference(this, "supported_privacy");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
