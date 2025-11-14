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
public class AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Retrieves information about a azurerm_elastic_san_volume_group.
/// </summary>
public class AzurermElasticSanVolumeGroupDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeGroupDataSource(string name) : base("azurerm_elastic_san_volume_group", name)
    {
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    [TerraformArgument("elastic_san_id")]
    public required TerraformValue<string> ElasticSanId
    {
        get => new TerraformReference<string>(this, "elastic_san_id");
        set => SetArgument("elastic_san_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformArgument("encryption")]
    public TerraformList<object> Encryption
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformArgument("encryption_type")]
    public TerraformValue<string> EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_rule attribute.
    /// </summary>
    [TerraformArgument("network_rule")]
    public TerraformList<object> NetworkRule
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformArgument("protocol_type")]
    public TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
    }

}
