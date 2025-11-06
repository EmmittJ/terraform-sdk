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
    /// The static_site_id attribute.
    /// </summary>
    public string? StaticSiteId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("static_site_id")?.Value;
        set => this.WithProperty("static_site_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The validation_type attribute.
    /// </summary>
    public string? ValidationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validation_type")?.Value;
        set => this.WithProperty("validation_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformExpression ValidationToken => this["validation_token"];

}
