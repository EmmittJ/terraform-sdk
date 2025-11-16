using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_elastic_san_volume_group Terraform data source.
/// Retrieves information about a azurerm_elastic_san_volume_group.
/// </summary>
public partial class AzurermElasticSanVolumeGroupDataSource(string name) : TerraformDataSource("azurerm_elastic_san_volume_group", name)
{
    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    public required TerraformValue<string> ElasticSanId
    {
        get => new TerraformReference<string>(this, "elastic_san_id");
        set => SetArgument("elastic_san_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string> EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
