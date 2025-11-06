using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_app_engine_domain_mapping resource.
/// </summary>
public class GoogleAppEngineDomainMapping : TerraformResource
{
    public GoogleAppEngineDomainMapping(string name) : base("google_app_engine_domain_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("resource_records");
    }

    /// <summary>
    /// Relative name of the domain serving the application. Example: example.com.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &amp;quot;STRICT&amp;quot; Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;OVERRIDE&amp;quot;]
    /// </summary>
    public string? OverrideStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("override_strategy")?.Value;
        set => this.WithProperty("override_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
