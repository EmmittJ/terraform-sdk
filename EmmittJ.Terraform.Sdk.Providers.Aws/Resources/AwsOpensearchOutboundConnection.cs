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
    public bool? AcceptConnection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("accept_connection")?.Value;
        set => this.WithProperty("accept_connection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    public string? ConnectionAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_alias")?.Value;
        set => this.WithProperty("connection_alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public string? ConnectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_mode")?.Value;
        set => this.WithProperty("connection_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformExpression ConnectionStatus => this["connection_status"];

}
