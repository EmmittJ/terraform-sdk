using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformArgument("tier")]
    public TerraformValue<string>? Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseSizeInTib is required")]
    [TerraformArgument("base_size_in_tib")]
    public required TerraformValue<double> BaseSizeInTib
    {
        get => new TerraformReference<double>(this, "base_size_in_tib");
        set => SetArgument("base_size_in_tib", value);
    }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformArgument("extended_size_in_tib")]
    public TerraformValue<double>? ExtendedSizeInTib
    {
        get => new TerraformReference<double>(this, "extended_size_in_tib");
        set => SetArgument("extended_size_in_tib", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermElasticSanSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermElasticSanTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    [TerraformArgument("total_iops")]
    public TerraformValue<double> TotalIops
    {
        get => new TerraformReference<double>(this, "total_iops");
    }

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    [TerraformArgument("total_mbps")]
    public TerraformValue<double> TotalMbps
    {
        get => new TerraformReference<double>(this, "total_mbps");
    }

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    [TerraformArgument("total_size_in_tib")]
    public TerraformValue<double> TotalSizeInTib
    {
        get => new TerraformReference<double>(this, "total_size_in_tib");
    }

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    [TerraformArgument("total_volume_size_in_gib")]
    public TerraformValue<double> TotalVolumeSizeInGib
    {
        get => new TerraformReference<double>(this, "total_volume_size_in_gib");
    }

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    [TerraformArgument("volume_group_count")]
    public TerraformValue<double> VolumeGroupCount
    {
        get => new TerraformReference<double>(this, "volume_group_count");
    }

}
