using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opensearch_outbound_connection resource.
/// </summary>
public class AwsOpensearchOutboundConnection : TerraformResource
{
    public AwsOpensearchOutboundConnection(string name) : base("aws_opensearch_outbound_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_status");
    }

    /// <summary>
    /// The accept_connection attribute.
    /// </summary>
    public TerraformProperty<bool>? AcceptConnection
    {
        get => GetProperty<TerraformProperty<bool>>("accept_connection");
        set => this.WithProperty("accept_connection", value);
    }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionAlias
    {
        get => GetProperty<TerraformProperty<string>>("connection_alias");
        set => this.WithProperty("connection_alias", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("connection_mode");
        set => this.WithProperty("connection_mode", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformExpression ConnectionStatus => this["connection_status"];

}
