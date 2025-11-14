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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappPoolTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_netapp_pool resource.
/// </summary>
public class AzurermNetappPool : TerraformResource
{
    public AzurermNetappPool(string name) : base("azurerm_netapp_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    [TerraformArgument("cool_access_enabled")]
    public TerraformValue<bool>? CoolAccessEnabled
    {
        get => new TerraformReference<bool>(this, "cool_access_enabled");
        set => SetArgument("cool_access_enabled", value);
    }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    [TerraformArgument("custom_throughput_mibps")]
    public TerraformValue<double>? CustomThroughputMibps
    {
        get => new TerraformReference<double>(this, "custom_throughput_mibps");
        set => SetArgument("custom_throughput_mibps", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformArgument("encryption_type")]
    public TerraformValue<string>? EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
        set => SetArgument("encryption_type", value);
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
    /// The qos_type attribute.
    /// </summary>
    [TerraformArgument("qos_type")]
    public TerraformValue<string>? QosType
    {
        get => new TerraformReference<string>(this, "qos_type");
        set => SetArgument("qos_type", value);
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
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    [TerraformArgument("service_level")]
    public required TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
        set => SetArgument("service_level", value);
    }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInTb is required")]
    [TerraformArgument("size_in_tb")]
    public required TerraformValue<double> SizeInTb
    {
        get => new TerraformReference<double>(this, "size_in_tb");
        set => SetArgument("size_in_tb", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetappPoolTimeoutsBlock Timeouts { get; set; } = new();

}
