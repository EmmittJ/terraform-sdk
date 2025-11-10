using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for contact_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Required. Privacy setting for the contacts associated with the Registration.
    /// Values are PUBLIC_CONTACT_DATA, PRIVATE_CONTACT_DATA, and REDACTED_CONTACT_DATA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Privacy is required")]
    public required TerraformProperty<string> Privacy
    {
        get => GetRequiredProperty<TerraformProperty<string>>("privacy");
        set => WithProperty("privacy", value);
    }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationDnsSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for management_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationManagementSettingsBlock : TerraformBlock
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
    public TerraformProperty<string>? PreferredRenewalMethod
    {
        get => GetProperty<TerraformProperty<string>>("preferred_renewal_method");
        set => WithProperty("preferred_renewal_method", value);
    }

    /// <summary>
    /// Output only. The actual renewal method for this Registration. When preferredRenewalMethod is set to AUTOMATIC_RENEWAL,
    /// the actual renewalMethod can be equal to RENEWAL_DISABLED—for example, when there are problems with the billing account
    /// or reported domain abuse. In such cases, check the issues field on the Registration. After the problem is resolved, the
    /// renewalMethod is automatically updated to preferredRenewalMethod in a few hours.
    /// </summary>
    public TerraformProperty<string>? RenewalMethod
    {
        get => GetProperty<TerraformProperty<string>>("renewal_method");
        set => WithProperty("renewal_method", value);
    }

    /// <summary>
    /// Controls whether the domain can be transferred to another registrar. Values are UNLOCKED or LOCKED.
    /// </summary>
    public TerraformProperty<string>? TransferLockState
    {
        get => GetProperty<TerraformProperty<string>>("transfer_lock_state");
        set => WithProperty("transfer_lock_state", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleClouddomainsRegistrationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for yearly_price in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationYearlyPriceBlock : TerraformBlock
{
    /// <summary>
    /// The three-letter currency code defined in ISO 4217.
    /// </summary>
    public TerraformProperty<string>? CurrencyCode
    {
        get => GetProperty<TerraformProperty<string>>("currency_code");
        set => WithProperty("currency_code", value);
    }

    /// <summary>
    /// The whole units of the amount. For example if currencyCode is &amp;quot;USD&amp;quot;, then 1 unit is one US dollar.
    /// </summary>
    public TerraformProperty<string>? Units
    {
        get => GetProperty<TerraformProperty<string>>("units");
        set => WithProperty("units", value);
    }

}

/// <summary>
/// Manages a google_clouddomains_registration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleClouddomainsRegistration : TerraformResource
{
    public GoogleClouddomainsRegistration(string name) : base("google_clouddomains_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("expire_time");
        this.WithOutput("issues");
        this.WithOutput("name");
        this.WithOutput("register_failure_reason");
        this.WithOutput("state");
        this.WithOutput("supported_privacy");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// The list of contact notices that the caller acknowledges. Possible value is PUBLIC_CONTACT_DATA_ACKNOWLEDGEMENT
    /// </summary>
    public List<TerraformProperty<string>>? ContactNotices
    {
        get => GetProperty<List<TerraformProperty<string>>>("contact_notices");
        set => this.WithProperty("contact_notices", value);
    }

    /// <summary>
    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The list of domain notices that you acknowledge. Possible value is HSTS_PRELOADED
    /// </summary>
    public List<TerraformProperty<string>>? DomainNotices
    {
        get => GetProperty<List<TerraformProperty<string>>>("domain_notices");
        set => this.WithProperty("domain_notices", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Set of labels associated with the Registration.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for contact_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContactSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContactSettings block(s) allowed")]
    public List<GoogleClouddomainsRegistrationContactSettingsBlock>? ContactSettings
    {
        get => GetProperty<List<GoogleClouddomainsRegistrationContactSettingsBlock>>("contact_settings");
        set => this.WithProperty("contact_settings", value);
    }

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public List<GoogleClouddomainsRegistrationDnsSettingsBlock>? DnsSettings
    {
        get => GetProperty<List<GoogleClouddomainsRegistrationDnsSettingsBlock>>("dns_settings");
        set => this.WithProperty("dns_settings", value);
    }

    /// <summary>
    /// Block for management_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementSettings block(s) allowed")]
    public List<GoogleClouddomainsRegistrationManagementSettingsBlock>? ManagementSettings
    {
        get => GetProperty<List<GoogleClouddomainsRegistrationManagementSettingsBlock>>("management_settings");
        set => this.WithProperty("management_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleClouddomainsRegistrationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleClouddomainsRegistrationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for yearly_price.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 YearlyPrice block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 YearlyPrice block(s) allowed")]
    public List<GoogleClouddomainsRegistrationYearlyPriceBlock>? YearlyPrice
    {
        get => GetProperty<List<GoogleClouddomainsRegistrationYearlyPriceBlock>>("yearly_price");
        set => this.WithProperty("yearly_price", value);
    }

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// Output only. The set of issues with the Registration that require attention.
    /// </summary>
    public TerraformExpression Issues => this["issues"];

    /// <summary>
    /// Output only. Name of the Registration resource, in the format projects/*/locations/*/registrations/&amp;lt;domain_name&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The reason the domain registration failed. Only set for domains in REGISTRATION_FAILED state.
    /// </summary>
    public TerraformExpression RegisterFailureReason => this["register_failure_reason"];

    /// <summary>
    /// Output only. The current state of the Registration.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. Set of options for the contactSettings.privacy field that this Registration supports.
    /// </summary>
    public TerraformExpression SupportedPrivacy => this["supported_privacy"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
