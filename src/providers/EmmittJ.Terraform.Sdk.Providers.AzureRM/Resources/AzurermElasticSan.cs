using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanSkuBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_elastic_san resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticSan : TerraformResource
{
    public AzurermElasticSan(string name) : base("azurerm_elastic_san", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("total_iops");
        this.WithOutput("total_mbps");
        this.WithOutput("total_size_in_tib");
        this.WithOutput("total_volume_size_in_gib");
        this.WithOutput("volume_group_count");
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseSizeInTib is required")]
    public required TerraformProperty<double> BaseSizeInTib
    {
        get => GetRequiredProperty<TerraformProperty<double>>("base_size_in_tib");
        set => this.WithProperty("base_size_in_tib", value);
    }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformProperty<double>? ExtendedSizeInTib
    {
        get => GetProperty<TerraformProperty<double>>("extended_size_in_tib");
        set => this.WithProperty("extended_size_in_tib", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermElasticSanSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermElasticSanSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermElasticSanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    public TerraformExpression TotalIops => this["total_iops"];

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    public TerraformExpression TotalMbps => this["total_mbps"];

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    public TerraformExpression TotalSizeInTib => this["total_size_in_tib"];

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    public TerraformExpression TotalVolumeSizeInGib => this["total_volume_size_in_gib"];

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    public TerraformExpression VolumeGroupCount => this["volume_group_count"];

}
