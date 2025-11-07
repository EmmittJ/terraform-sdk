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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    public TerraformProperty<string>? MarketplaceOfferId
    {
        get => GetProperty<TerraformProperty<string>>("marketplace_offer_id");
        set => this.WithProperty("marketplace_offer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The panorama_base64_config attribute.
    /// </summary>
    public TerraformProperty<string>? PanoramaBase64Config
    {
        get => GetProperty<TerraformProperty<string>>("panorama_base64_config");
        set => this.WithProperty("panorama_base64_config", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlanId
    {
        get => GetProperty<TerraformProperty<string>>("plan_id");
        set => this.WithProperty("plan_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The panorama attribute.
    /// </summary>
    public TerraformExpression Panorama => this["panorama"];

}
