using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ssl_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineDomainMappingSslSettingsBlock : TerraformBlock
{
    /// <summary>
    /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
    /// remove SSL support.
    /// By default, a managed certificate is automatically created for every domain mapping. To omit SSL support
    /// or to configure SSL manually, specify &#39;SslManagementType.MANUAL&#39; on a &#39;CREATE&#39; or &#39;UPDATE&#39; request. You must be
    /// authorized to administer the &#39;AuthorizedCertificate&#39; resource to manually map it to a DomainMapping resource.
    /// Example: 12345.
    /// </summary>
    public TerraformProperty<string>? CertificateId
    {
        set => SetProperty("certificate_id", value);
    }

    /// <summary>
    /// ID of the managed &#39;AuthorizedCertificate&#39; resource currently being provisioned, if applicable. Until the new
    /// managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the
    /// provisioning process completes, the &#39;certificateId&#39; field will reflect the new managed certificate and this
    /// field will be left empty. To remove SSL support while there is still a pending managed certificate, clear the
    /// &#39;certificateId&#39; field with an update request.
    /// </summary>
    public TerraformProperty<string>? PendingManagedCertificateId
    {
        set => SetProperty("pending_managed_certificate_id", value);
    }

    /// <summary>
    /// SSL management type for this domain. If &#39;AUTOMATIC&#39;, a managed certificate is automatically provisioned.
    /// If &#39;MANUAL&#39;, &#39;certificateId&#39; must be manually specified in order to configure SSL for this domain. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslManagementType is required")]
    public required TerraformProperty<string> SslManagementType
    {
        set => SetProperty("ssl_management_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineDomainMappingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_app_engine_domain_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineDomainMapping : TerraformResource
{
    public GoogleAppEngineDomainMapping(string name) : base("google_app_engine_domain_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("resource_records");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("override_strategy");
        SetOutput("project");
    }

    /// <summary>
    /// Relative name of the domain serving the application. Example: example.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &amp;quot;STRICT&amp;quot; Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;OVERRIDE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> OverrideStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("override_strategy");
        set => SetProperty("override_strategy", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for ssl_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslSettings block(s) allowed")]
    public List<GoogleAppEngineDomainMappingSslSettingsBlock>? SslSettings
    {
        set => SetProperty("ssl_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineDomainMappingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource records required to configure this domain mapping. These records must be added to the domain&#39;s DNS
    /// configuration in order to serve the application via this domain mapping.
    /// </summary>
    public TerraformExpression ResourceRecords => this["resource_records"];

}
