using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpPrefixTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_public_ip_prefix resource.
/// </summary>
public class AzurermPublicIpPrefix : TerraformResource
{
    public AzurermPublicIpPrefix(string name) : base("azurerm_public_ip_prefix", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ip_prefix");
        SetOutput("custom_ip_prefix_id");
        SetOutput("id");
        SetOutput("ip_version");
        SetOutput("location");
        SetOutput("name");
        SetOutput("prefix_length");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("sku_tier");
        SetOutput("tags");
        SetOutput("zones");
    }

    /// <summary>
    /// The custom_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomIpPrefixId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_ip_prefix_id");
        set => SetProperty("custom_ip_prefix_id", value);
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
    /// The prefix_length attribute.
    /// </summary>
    public TerraformProperty<double> PrefixLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("prefix_length");
        set => SetProperty("prefix_length", value);
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
    public AzurermPublicIpPrefixTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The ip_prefix attribute.
    /// </summary>
    public TerraformExpression IpPrefix => this["ip_prefix"];

}
