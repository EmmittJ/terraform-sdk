using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ssl_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineDomainMappingSslSettingsBlock() : TerraformBlock("ssl_settings")
{
    /// <summary>
    /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
    /// remove SSL support.
    /// By default, a managed certificate is automatically created for every domain mapping. To omit SSL support
    /// or to configure SSL manually, specify &#39;SslManagementType.MANUAL&#39; on a &#39;CREATE&#39; or &#39;UPDATE&#39; request. You must be
    /// authorized to administer the &#39;AuthorizedCertificate&#39; resource to manually map it to a DomainMapping resource.
    /// Example: 12345.
    /// </summary>
    [TerraformProperty("certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CertificateId { get; set; }


    /// <summary>
    /// SSL management type for this domain. If &#39;AUTOMATIC&#39;, a managed certificate is automatically provisioned.
    /// If &#39;MANUAL&#39;, &#39;certificateId&#39; must be manually specified in order to configure SSL for this domain. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslManagementType is required")]
    [TerraformProperty("ssl_management_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SslManagementType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineDomainMappingTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_app_engine_domain_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineDomainMapping : TerraformResource
{
    public GoogleAppEngineDomainMapping(string name) : base("google_app_engine_domain_mapping", name)
    {
    }

    /// <summary>
    /// Relative name of the domain serving the application. Example: example.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &amp;quot;STRICT&amp;quot; Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;OVERRIDE&amp;quot;]
    /// </summary>
    [TerraformProperty("override_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OverrideStrategy { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for ssl_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslSettings block(s) allowed")]
    [TerraformProperty("ssl_settings")]
    public TerraformList<GoogleAppEngineDomainMappingSslSettingsBlock> SslSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleAppEngineDomainMappingTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The resource records required to configure this domain mapping. These records must be added to the domain&#39;s DNS
    /// configuration in order to serve the application via this domain mapping.
    /// </summary>
    [TerraformProperty("resource_records")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ResourceRecords { get; }

}
