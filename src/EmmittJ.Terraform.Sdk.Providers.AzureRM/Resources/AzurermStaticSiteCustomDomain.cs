using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_static_site_custom_domain resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermStaticSiteCustomDomain : TerraformResource
{
    public AzurermStaticSiteCustomDomain(string name) : base("azurerm_static_site_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("validation_token");
    }

    /// <summary>
    /// The domain_name attribute.
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
    /// The static_site_id attribute.
    /// </summary>
    public TerraformProperty<string>? StaticSiteId
    {
        get => GetProperty<TerraformProperty<string>>("static_site_id");
        set => this.WithProperty("static_site_id", value);
    }

    /// <summary>
    /// The validation_type attribute.
    /// </summary>
    public TerraformProperty<string>? ValidationType
    {
        get => GetProperty<TerraformProperty<string>>("validation_type");
        set => this.WithProperty("validation_type", value);
    }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformExpression ValidationToken => this["validation_token"];

}
