using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ethereum_details in .
/// Nesting mode: list
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock : TerraformBlock
{
    /// <summary>
    /// User-provided key-value pairs
    /// </summary>
    public List<TerraformProperty<object>>? AdditionalEndpoints
    {
        set => SetProperty("additional_endpoints", value);
    }

    /// <summary>
    /// Enables JSON-RPC access to functions in the admin namespace. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ApiEnableAdmin
    {
        set => SetProperty("api_enable_admin", value);
    }

    /// <summary>
    /// Enables JSON-RPC access to functions in the debug namespace. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ApiEnableDebug
    {
        set => SetProperty("api_enable_debug", value);
    }

    /// <summary>
    /// The consensus client Possible values: [&amp;quot;CONSENSUS_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;LIGHTHOUSE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ConsensusClient
    {
        set => SetProperty("consensus_client", value);
    }

    /// <summary>
    /// The execution client Possible values: [&amp;quot;EXECUTION_CLIENT_UNSPECIFIED&amp;quot;, &amp;quot;GETH&amp;quot;, &amp;quot;ERIGON&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ExecutionClient
    {
        set => SetProperty("execution_client", value);
    }

    /// <summary>
    /// The Ethereum environment being accessed. Possible values: [&amp;quot;MAINNET&amp;quot;, &amp;quot;TESTNET_GOERLI_PRATER&amp;quot;, &amp;quot;TESTNET_SEPOLIA&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The type of Ethereum node. Possible values: [&amp;quot;LIGHT&amp;quot;, &amp;quot;FULL&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        set => SetProperty("node_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_blockchain_node_engine_blockchain_nodes resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBlockchainNodeEngineBlockchainNodes : TerraformResource
{
    public GoogleBlockchainNodeEngineBlockchainNodes(string name) : base("google_blockchain_node_engine_blockchain_nodes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("connection_info");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("blockchain_node_id");
        SetOutput("blockchain_type");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockchainNodeId is required")]
    public required TerraformProperty<string> BlockchainNodeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blockchain_node_id");
        set => SetProperty("blockchain_node_id", value);
    }

    /// <summary>
    /// User-provided key-value pairs Possible values: [&amp;quot;ETHEREUM&amp;quot;]
    /// </summary>
    public TerraformProperty<string> BlockchainType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blockchain_type");
        set => SetProperty("blockchain_type", value);
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
    /// User-provided key-value pairs
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location of Blockchain Node being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for ethereum_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EthereumDetails block(s) allowed")]
    public List<GoogleBlockchainNodeEngineBlockchainNodesEthereumDetailsBlock>? EthereumDetails
    {
        set => SetProperty("ethereum_details", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBlockchainNodeEngineBlockchainNodesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The connection information through which to interact with a blockchain node.
    /// </summary>
    public TerraformExpression ConnectionInfo => this["connection_info"];

    /// <summary>
    /// The timestamp at which the blockchain node was first created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fully qualified name of the blockchain node. e.g. projects/my-project/locations/us-central1/blockchainNodes/my-node.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp at which the blockchain node was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
