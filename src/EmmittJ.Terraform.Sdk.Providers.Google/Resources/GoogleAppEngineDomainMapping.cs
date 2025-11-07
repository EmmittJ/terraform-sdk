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
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &amp;quot;STRICT&amp;quot; Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;OVERRIDE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? OverrideStrategy
    {
        get => GetProperty<TerraformProperty<string>>("override_strategy");
        set => this.WithProperty("override_strategy", value);
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
    /// Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource records required to configure this domain mapping. These records must be added to the domain&#39;s DNS
    /// configuration in order to serve the application via this domain mapping.
    /// </summary>
    public TerraformExpression ResourceRecords => this["resource_records"];

}
