using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ethereum_details in .
/// Nesting mode: list
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// User-provided key-value pairs
    /// </summary>
    [TerraformPropertyName("additional_endpoints")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdditionalEndpoints => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "additional_endpoints");

    /// <summary>
    /// Enables JSON-RPC access to functions in the admin namespace. Defaults to false.
    /// </summary>
    [TerraformPropertyName("api_enable_admin")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApiEnableAdmin { get; set; }

    /// <summary>
    /// Enables JSON-RPC access to functions in the debug namespace. Defaults to false.
    /// </summary>
    [TerraformPropertyName("api_enable_debug")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApiEnableDebug { get; set; }

    /// <summary>
    /// The consensus client Possible values: [&amp;quot;CONSENSUS_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;LIGHTHOUSE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("consensus_client")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConsensusClient { get; set; }

    /// <summary>
    /// The execution client Possible values: [&amp;quot;EXECUTION_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;GETH&amp;quot;, &amp;quot;ERIGON&amp;quot;]
    /// </summary>
    [TerraformPropertyName("execution_client")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionClient { get; set; }

    /// <summary>
    /// The Ethereum environment being accessed. Possible values: [&amp;quot;MAINNET&amp;quot;, &amp;quot;TESTNET_GOERLI_PRATER&amp;quot;, &amp;quot;TESTNET_SEPOLIA&amp;quot;]
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// The type of Ethereum node. Possible values: [&amp;quot;LIGHT&amp;quot;, &amp;quot;FULL&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_blockchain_node_engine_blockchain_nodes resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBlockchainNodeEngineBlockchainNodes : TerraformResource
{
    public GoogleBlockchainNodeEngineBlockchainNodes(string name) : base("google_blockchain_node_engine_blockchain_nodes", name)
    {
    }

    /// <summary>
    /// ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockchainNodeId is required")]
    [TerraformPropertyName("blockchain_node_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BlockchainNodeId { get; set; }

    /// <summary>
    /// User-provided key-value pairs Possible values: [&amp;quot;ETHEREUM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("blockchain_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BlockchainType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User-provided key-value pairs
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Location of Blockchain Node being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for ethereum_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EthereumDetails block(s) allowed")]
    [TerraformPropertyName("ethereum_details")]
    public TerraformList<TerraformBlock<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock>>? EthereumDetails { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The connection information through which to interact with a blockchain node.
    /// </summary>
    [TerraformPropertyName("connection_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connection_info");

    /// <summary>
    /// The timestamp at which the blockchain node was first created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The fully qualified name of the blockchain node. e.g. projects/my-project/locations/us-central1/blockchainNodes/my-node.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The timestamp at which the blockchain node was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
