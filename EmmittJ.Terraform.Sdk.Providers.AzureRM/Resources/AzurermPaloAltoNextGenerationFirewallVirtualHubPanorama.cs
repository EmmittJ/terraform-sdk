using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_hub_panorama resource.
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_hub_panorama", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("panorama");
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    public string? MarketplaceOfferId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("marketplace_offer_id")?.Value;
        set => this.WithProperty("marketplace_offer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The panorama_base64_config attribute.
    /// </summary>
    public string? PanoramaBase64Config
    {
        get => GetProperty<TerraformLiteralProperty<string>>("panorama_base64_config")?.Value;
        set => this.WithProperty("panorama_base64_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public string? PlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan_id")?.Value;
        set => this.WithProperty("plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The panorama attribute.
    /// </summary>
    public TerraformExpression Panorama => this["panorama"];

}
