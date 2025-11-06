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
    public string? AllocationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allocation_method")?.Value;
        set => this.WithProperty("allocation_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public string? DdosProtectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ddos_protection_mode")?.Value;
        set => this.WithProperty("ddos_protection_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public string? DdosProtectionPlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ddos_protection_plan_id")?.Value;
        set => this.WithProperty("ddos_protection_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public string? DomainNameLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name_label")?.Value;
        set => this.WithProperty("domain_name_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name_label_scope attribute.
    /// </summary>
    public string? DomainNameLabelScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name_label_scope")?.Value;
        set => this.WithProperty("domain_name_label_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public double? IdleTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout_in_minutes")?.Value;
        set => this.WithProperty("idle_timeout_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public Dictionary<string, string>? IpTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("ip_tags")?.Value;
        set => this.WithProperty("ip_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public string? IpVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_version")?.Value;
        set => this.WithProperty("ip_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public string? PublicIpPrefixId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_prefix_id")?.Value;
        set => this.WithProperty("public_ip_prefix_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The reverse_fqdn attribute.
    /// </summary>
    public string? ReverseFqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reverse_fqdn")?.Value;
        set => this.WithProperty("reverse_fqdn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public string? SkuTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_tier")?.Value;
        set => this.WithProperty("sku_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
