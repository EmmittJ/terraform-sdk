using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ethereum_details in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock() : TerraformBlock("ethereum_details")
{

    /// <summary>
    /// Enables JSON-RPC access to functions in the admin namespace. Defaults to false.
    /// </summary>
    [TerraformProperty("api_enable_admin")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApiEnableAdmin { get; set; }

    /// <summary>
    /// Enables JSON-RPC access to functions in the debug namespace. Defaults to false.
    /// </summary>
    [TerraformProperty("api_enable_debug")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApiEnableDebug { get; set; }

    /// <summary>
    /// The consensus client Possible values: [&amp;quot;CONSENSUS_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;LIGHTHOUSE&amp;quot;]
    /// </summary>
    [TerraformProperty("consensus_client")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConsensusClient { get; set; }

    /// <summary>
    /// The execution client Possible values: [&amp;quot;EXECUTION_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;GETH&amp;quot;, &amp;quot;ERIGON&amp;quot;]
    /// </summary>
    [TerraformProperty("execution_client")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionClient { get; set; }

    /// <summary>
    /// The Ethereum environment being accessed. Possible values: [&amp;quot;MAINNET&amp;quot;, &amp;quot;TESTNET_GOERLI_PRATER&amp;quot;, &amp;quot;TESTNET_SEPOLIA&amp;quot;]
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The type of Ethereum node. Possible values: [&amp;quot;LIGHT&amp;quot;, &amp;quot;FULL&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_blockchain_node_engine_blockchain_nodes resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBlockchainNodeEngineBlockchainNodes : TerraformResource
{
    public GoogleBlockchainNodeEngineBlockchainNodes(string name) : base("google_blockchain_node_engine_blockchain_nodes", name)
    {
    }

    /// <summary>
    /// ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockchainNodeId is required")]
    [TerraformProperty("blockchain_node_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BlockchainNodeId { get; set; }

    /// <summary>
    /// User-provided key-value pairs Possible values: [&amp;quot;ETHEREUM&amp;quot;]
    /// </summary>
    [TerraformProperty("blockchain_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BlockchainType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-provided key-value pairs
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location of Blockchain Node being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for ethereum_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EthereumDetails block(s) allowed")]
    [TerraformProperty("ethereum_details")]
    public TerraformList<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock> EthereumDetails { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The connection information through which to interact with a blockchain node.
    /// </summary>
    [TerraformProperty("connection_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConnectionInfo { get; }

    /// <summary>
    /// The timestamp at which the blockchain node was first created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fully qualified name of the blockchain node. e.g. projects/my-project/locations/us-central1/blockchainNodes/my-node.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp at which the blockchain node was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
