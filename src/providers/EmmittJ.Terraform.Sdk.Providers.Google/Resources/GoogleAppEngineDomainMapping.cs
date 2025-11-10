using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ssl_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineDomainMappingSslSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
    /// remove SSL support.
    /// By default, a managed certificate is automatically created for every domain mapping. To omit SSL support
    /// or to configure SSL manually, specify &#39;SslManagementType.MANUAL&#39; on a &#39;CREATE&#39; or &#39;UPDATE&#39; request. You must be
    /// authorized to administer the &#39;AuthorizedCertificate&#39; resource to manually map it to a DomainMapping resource.
    /// Example: 12345.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_id");

    /// <summary>
    /// ID of the managed &#39;AuthorizedCertificate&#39; resource currently being provisioned, if applicable. Until the new
    /// managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the
    /// provisioning process completes, the &#39;certificateId&#39; field will reflect the new managed certificate and this
    /// field will be left empty. To remove SSL support while there is still a pending managed certificate, clear the
    /// &#39;certificateId&#39; field with an update request.
    /// </summary>
    [TerraformPropertyName("pending_managed_certificate_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PendingManagedCertificateId => new TerraformReferenceProperty<TerraformProperty<string>>("", "pending_managed_certificate_id");

    /// <summary>
    /// SSL management type for this domain. If &#39;AUTOMATIC&#39;, a managed certificate is automatically provisioned.
    /// If &#39;MANUAL&#39;, &#39;certificateId&#39; must be manually specified in order to configure SSL for this domain. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslManagementType is required")]
    [TerraformPropertyName("ssl_management_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SslManagementType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineDomainMappingTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_domain_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineDomainMapping : TerraformResource
{
    public GoogleAppEngineDomainMapping(string name) : base("google_app_engine_domain_mapping", name)
    {
    }

    /// <summary>
    /// Relative name of the domain serving the application. Example: example.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &amp;quot;STRICT&amp;quot; Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;OVERRIDE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("override_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OverrideStrategy { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for ssl_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslSettings block(s) allowed")]
    [TerraformPropertyName("ssl_settings")]
    public TerraformList<TerraformBlock<GoogleAppEngineDomainMappingSslSettingsBlock>>? SslSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAppEngineDomainMappingTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The resource records required to configure this domain mapping. These records must be added to the domain&#39;s DNS
    /// configuration in order to serve the application via this domain mapping.
    /// </summary>
    [TerraformPropertyName("resource_records")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ResourceRecords => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resource_records");

}
