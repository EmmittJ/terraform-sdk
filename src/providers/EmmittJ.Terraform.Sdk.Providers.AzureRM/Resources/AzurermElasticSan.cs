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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        set => SetProperty("tier", value);
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
        SetOutput("total_iops");
        SetOutput("total_mbps");
        SetOutput("total_size_in_tib");
        SetOutput("total_volume_size_in_gib");
        SetOutput("volume_group_count");
        SetOutput("base_size_in_tib");
        SetOutput("extended_size_in_tib");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("zones");
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseSizeInTib is required")]
    public required TerraformProperty<double> BaseSizeInTib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("base_size_in_tib");
        set => SetProperty("base_size_in_tib", value);
    }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformProperty<double> ExtendedSizeInTib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("extended_size_in_tib");
        set => SetProperty("extended_size_in_tib", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermElasticSanSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
