using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ipfx_emission in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipfx_emission";

    /// <summary>
    /// The destination_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTypes is required")]
    public TerraformList<string>? DestinationTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_types").ResolveNodes(ctx));
        set => SetArgument("destination_types", value);
    }

}

/// <summary>
/// Block type for ipfx_ingestion in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipfx_ingestion";

    /// <summary>
    /// The source_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceIds is required")]
    public required TerraformSet<string> SourceResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_resource_ids").ResolveNodes(ctx));
        set => SetArgument("source_resource_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkFunctionCollectorPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_network_function_collector_policy Terraform resource.
/// Manages a azurerm_network_function_collector_policy resource.
/// </summary>
public partial class AzurermNetworkFunctionCollectorPolicy(string name) : TerraformResource("azurerm_network_function_collector_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The traffic_collector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficCollectorId is required")]
    public required TerraformValue<string> TrafficCollectorId
    {
        get => new TerraformReference<string>(this, "traffic_collector_id");
        set => SetArgument("traffic_collector_id", value);
    }

    /// <summary>
    /// IpfxEmission block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpfxEmission is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpfxEmission block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpfxEmission block(s) allowed")]
    public required TerraformList<AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock> IpfxEmission
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock>>("ipfx_emission");
        set => SetArgument("ipfx_emission", value);
    }

    /// <summary>
    /// IpfxIngestion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpfxIngestion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpfxIngestion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpfxIngestion block(s) allowed")]
    public required TerraformList<AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock> IpfxIngestion
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock>>("ipfx_ingestion");
        set => SetArgument("ipfx_ingestion", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkFunctionCollectorPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkFunctionCollectorPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
