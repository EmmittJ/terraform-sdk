using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ssl_settings in GoogleAppEngineDomainMapping.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineDomainMappingSslSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_settings";

    /// <summary>
    /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
    /// remove SSL support.
    /// By default, a managed certificate is automatically created for every domain mapping. To omit SSL support
    /// or to configure SSL manually, specify &#39;SslManagementType.MANUAL&#39; on a &#39;CREATE&#39; or &#39;UPDATE&#39; request. You must be
    /// authorized to administer the &#39;AuthorizedCertificate&#39; resource to manually map it to a DomainMapping resource.
    /// Example: 12345.
    /// </summary>
    public TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// ID of the managed &#39;AuthorizedCertificate&#39; resource currently being provisioned, if applicable. Until the new
    /// managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the
    /// provisioning process completes, the &#39;certificateId&#39; field will reflect the new managed certificate and this
    /// field will be left empty. To remove SSL support while there is still a pending managed certificate, clear the
    /// &#39;certificateId&#39; field with an update request.
    /// </summary>
    public TerraformValue<string> PendingManagedCertificateId
    {
        get => new TerraformReference<string>(this, "pending_managed_certificate_id");
    }

    /// <summary>
    /// SSL management type for this domain. If &#39;AUTOMATIC&#39;, a managed certificate is automatically provisioned.
    /// If &#39;MANUAL&#39;, &#39;certificateId&#39; must be manually specified in order to configure SSL for this domain. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslManagementType is required")]
    public required TerraformValue<string> SslManagementType
    {
        get => new TerraformReference<string>(this, "ssl_management_type");
        set => SetArgument("ssl_management_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineDomainMapping.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineDomainMappingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_app_engine_domain_mapping Terraform resource.
/// Manages a google_app_engine_domain_mapping resource.
/// </summary>
public partial class GoogleAppEngineDomainMapping(string name) : TerraformResource("google_app_engine_domain_mapping", name)
{
    /// <summary>
    /// Relative name of the domain serving the application. Example: example.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &amp;quot;STRICT&amp;quot; Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;OVERRIDE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OverrideStrategy
    {
        get => new TerraformReference<string>(this, "override_strategy");
        set => SetArgument("override_strategy", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The resource records required to configure this domain mapping. These records must be added to the domain&#39;s DNS
    /// configuration in order to serve the application via this domain mapping.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceRecords
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resource_records").ResolveNodes(ctx));
    }

    /// <summary>
    /// SslSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslSettings block(s) allowed")]
    public TerraformList<GoogleAppEngineDomainMappingSslSettingsBlock>? SslSettings
    {
        get => GetArgument<TerraformList<GoogleAppEngineDomainMappingSslSettingsBlock>>("ssl_settings");
        set => SetArgument("ssl_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineDomainMappingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineDomainMappingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
