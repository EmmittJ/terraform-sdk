using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("fqdn");
        SetOutput("ip_address");
        SetOutput("allocation_method");
        SetOutput("ddos_protection_mode");
        SetOutput("ddos_protection_plan_id");
        SetOutput("domain_name_label");
        SetOutput("domain_name_label_scope");
        SetOutput("edge_zone");
        SetOutput("id");
        SetOutput("idle_timeout_in_minutes");
        SetOutput("ip_tags");
        SetOutput("ip_version");
        SetOutput("location");
        SetOutput("name");
        SetOutput("public_ip_prefix_id");
        SetOutput("resource_group_name");
        SetOutput("reverse_fqdn");
        SetOutput("sku");
        SetOutput("sku_tier");
        SetOutput("tags");
        SetOutput("zones");
    }

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    public required TerraformProperty<string> AllocationMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allocation_method");
        set => SetProperty("allocation_method", value);
    }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public TerraformProperty<string> DdosProtectionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ddos_protection_mode");
        set => SetProperty("ddos_protection_mode", value);
    }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public TerraformProperty<string> DdosProtectionPlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ddos_protection_plan_id");
        set => SetProperty("ddos_protection_plan_id", value);
    }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformProperty<string> DomainNameLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name_label");
        set => SetProperty("domain_name_label", value);
    }

    /// <summary>
    /// The domain_name_label_scope attribute.
    /// </summary>
    public TerraformProperty<string> DomainNameLabelScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name_label_scope");
        set => SetProperty("domain_name_label_scope", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> IdleTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_timeout_in_minutes");
        set => SetProperty("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> IpTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("ip_tags");
        set => SetProperty("ip_tags", value);
    }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public TerraformProperty<string> IpVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_version");
        set => SetProperty("ip_version", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string> PublicIpPrefixId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ip_prefix_id");
        set => SetProperty("public_ip_prefix_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    public TerraformProperty<string> ReverseFqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reverse_fqdn");
        set => SetProperty("reverse_fqdn", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string> SkuTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_tier");
        set => SetProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPublicIpTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
