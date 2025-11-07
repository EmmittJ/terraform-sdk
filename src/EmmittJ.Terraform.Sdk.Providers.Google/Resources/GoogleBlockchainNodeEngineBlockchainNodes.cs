using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_blockchain_node_engine_blockchain_nodes resource.
/// </summary>
public class GoogleBlockchainNodeEngineBlockchainNodes : TerraformResource
{
    public GoogleBlockchainNodeEngineBlockchainNodes(string name) : base("google_blockchain_node_engine_blockchain_nodes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_info");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// ID of the requesting object.
    /// </summary>
    public TerraformProperty<string>? BlockchainNodeId
    {
        get => GetProperty<TerraformProperty<string>>("blockchain_node_id");
        set => this.WithProperty("blockchain_node_id", value);
    }

    /// <summary>
    /// User-provided key-value pairs Possible values: [&amp;quot;ETHEREUM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? BlockchainType
    {
        get => GetProperty<TerraformProperty<string>>("blockchain_type");
        set => this.WithProperty("blockchain_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// User-provided key-value pairs
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Location of Blockchain Node being created.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
