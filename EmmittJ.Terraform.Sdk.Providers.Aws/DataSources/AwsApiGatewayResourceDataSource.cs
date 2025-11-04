using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_resource.
/// </summary>
public class AwsApiGatewayResourceDataSource : TerraformDataSource
{
    public AwsApiGatewayResourceDataSource(string name) : base("aws_api_gateway_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("parent_id");
        this.DeclareOutput("path_part");
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
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformExpression ParentId => this["parent_id"];

    /// <summary>
    /// The path_part attribute.
    /// </summary>
    public TerraformExpression PathPart => this["path_part"];

}
