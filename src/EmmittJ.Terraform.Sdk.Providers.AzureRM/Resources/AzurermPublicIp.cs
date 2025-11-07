using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_public_ip resource.
/// </summary>
public class AzurermPublicIp : TerraformResource
{
    public AzurermPublicIp(string name) : base("azurerm_public_ip", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("ip_address");
    }

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationMethod
    {
        get => GetProperty<TerraformProperty<string>>("allocation_method");
        set => this.WithProperty("allocation_method", value);
    }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DdosProtectionMode
    {
        get => GetProperty<TerraformProperty<string>>("ddos_protection_mode");
        set => this.WithProperty("ddos_protection_mode", value);
    }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? DdosProtectionPlanId
    {
        get => GetProperty<TerraformProperty<string>>("ddos_protection_plan_id");
        set => this.WithProperty("ddos_protection_plan_id", value);
    }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformProperty<string>? DomainNameLabel
    {
        get => GetProperty<TerraformProperty<string>>("domain_name_label");
        set => this.WithProperty("domain_name_label", value);
    }

    /// <summary>
    /// The domain_name_label_scope attribute.
    /// </summary>
    public TerraformProperty<string>? DomainNameLabelScope
    {
        get => GetProperty<TerraformProperty<string>>("domain_name_label_scope");
        set => this.WithProperty("domain_name_label_scope", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("idle_timeout_in_minutes");
        set => this.WithProperty("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? IpTags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("ip_tags");
        set => this.WithProperty("ip_tags", value);
    }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public TerraformProperty<string>? IpVersion
    {
        get => GetProperty<TerraformProperty<string>>("ip_version");
        set => this.WithProperty("ip_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpPrefixId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_prefix_id");
        set => this.WithProperty("public_ip_prefix_id", value);
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
    /// The reverse_fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? ReverseFqdn
    {
        get => GetProperty<TerraformProperty<string>>("reverse_fqdn");
        set => this.WithProperty("reverse_fqdn", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string>? SkuTier
    {
        get => GetProperty<TerraformProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
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
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

}
