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
public class AzurermManagedDiskSasTokenTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_managed_disk_sas_token resource.
/// </summary>
public class AzurermManagedDiskSasToken : TerraformResource
{
    public AzurermManagedDiskSasToken(string name) : base("azurerm_managed_disk_sas_token", name)
    {
    }

    /// <summary>
    /// The access_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    [TerraformArgument("access_level")]
    public required TerraformValue<string> AccessLevel
    {
        get => new TerraformReference<string>(this, "access_level");
        set => SetArgument("access_level", value);
    }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInSeconds is required")]
    [TerraformArgument("duration_in_seconds")]
    public required TerraformValue<double> DurationInSeconds
    {
        get => new TerraformReference<double>(this, "duration_in_seconds");
        set => SetArgument("duration_in_seconds", value);
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
    /// The managed_disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedDiskId is required")]
    [TerraformArgument("managed_disk_id")]
    public required TerraformValue<string> ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagedDiskSasTokenTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [TerraformArgument("sas_url")]
    public TerraformValue<string> SasUrl
    {
        get => new TerraformReference<string>(this, "sas_url");
    }

}
