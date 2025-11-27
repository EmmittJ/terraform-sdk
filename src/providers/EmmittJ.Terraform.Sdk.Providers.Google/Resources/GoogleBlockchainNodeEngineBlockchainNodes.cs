using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ethereum_details in GoogleBlockchainNodeEngineBlockchainNodes.
/// Nesting mode: list
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ethereum_details";

    /// <summary>
    /// User-provided key-value pairs
    /// </summary>
    public TerraformList<TerraformMap<object>> AdditionalEndpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "additional_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// Enables JSON-RPC access to functions in the admin namespace. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ApiEnableAdmin
    {
        get => new TerraformReference<bool>(this, "api_enable_admin");
        set => SetArgument("api_enable_admin", value);
    }

    /// <summary>
    /// Enables JSON-RPC access to functions in the debug namespace. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ApiEnableDebug
    {
        get => new TerraformReference<bool>(this, "api_enable_debug");
        set => SetArgument("api_enable_debug", value);
    }

    /// <summary>
    /// The consensus client Possible values: [&amp;quot;CONSENSUS_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;LIGHTHOUSE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ConsensusClient
    {
        get => new TerraformReference<string>(this, "consensus_client");
        set => SetArgument("consensus_client", value);
    }

    /// <summary>
    /// The execution client Possible values: [&amp;quot;EXECUTION_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;GETH&amp;quot;, &amp;quot;ERIGON&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ExecutionClient
    {
        get => new TerraformReference<string>(this, "execution_client");
        set => SetArgument("execution_client", value);
    }

    /// <summary>
    /// The Ethereum environment being accessed. Possible values: [&amp;quot;MAINNET&amp;quot;, &amp;quot;TESTNET_GOERLI_PRATER&amp;quot;, &amp;quot;TESTNET_SEPOLIA&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The type of Ethereum node. Possible values: [&amp;quot;LIGHT&amp;quot;, &amp;quot;FULL&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// GethDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GethDetails block(s) allowed")]
    public TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlockGethDetailsBlock>? GethDetails
    {
        get => GetArgument<TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlockGethDetailsBlock>>("geth_details");
        set => SetArgument("geth_details", value);
    }

    /// <summary>
    /// ValidatorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidatorConfig block(s) allowed")]
    public TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlockValidatorConfigBlock>? ValidatorConfig
    {
        get => GetArgument<TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlockValidatorConfigBlock>>("validator_config");
        set => SetArgument("validator_config", value);
    }

}

/// <summary>
/// Block type for geth_details in GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlockGethDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geth_details";

    /// <summary>
    /// Blockchain garbage collection modes. Only applicable when NodeType is FULL or ARCHIVE. Possible values: [&amp;quot;FULL&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? GarbageCollectionMode
    {
        get => new TerraformReference<string>(this, "garbage_collection_mode");
        set => SetArgument("garbage_collection_mode", value);
    }

}

/// <summary>
/// Block type for validator_config in GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlockValidatorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validator_config";

    /// <summary>
    /// URLs for MEV-relay services to use for block building. When set, a managed MEV-boost service is configured on the beacon client.
    /// </summary>
    public TerraformList<string>? MevRelayUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mev_relay_urls").ResolveNodes(ctx));
        set => SetArgument("mev_relay_urls", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBlockchainNodeEngineBlockchainNodes.
/// Nesting mode: single
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_blockchain_node_engine_blockchain_nodes Terraform resource.
/// Manages a google_blockchain_node_engine_blockchain_nodes resource.
/// </summary>
public partial class GoogleBlockchainNodeEngineBlockchainNodes(string name) : TerraformResource("google_blockchain_node_engine_blockchain_nodes", name)
{
    /// <summary>
    /// ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockchainNodeId is required")]
    public required TerraformValue<string> BlockchainNodeId
    {
        get => new TerraformReference<string>(this, "blockchain_node_id");
        set => SetArgument("blockchain_node_id", value);
    }

    /// <summary>
    /// User-provided key-value pairs Possible values: [&amp;quot;ETHEREUM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? BlockchainType
    {
        get => new TerraformReference<string>(this, "blockchain_type");
        set => SetArgument("blockchain_type", value);
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
    /// User-provided key-value pairs
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location of Blockchain Node being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The connection information through which to interact with a blockchain node.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connection_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timestamp at which the blockchain node was first created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fully qualified name of the blockchain node. e.g. projects/my-project/locations/us-central1/blockchainNodes/my-node.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timestamp at which the blockchain node was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// EthereumDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EthereumDetails block(s) allowed")]
    public TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock>? EthereumDetails
    {
        get => GetArgument<TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock>>("ethereum_details");
        set => SetArgument("ethereum_details", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
