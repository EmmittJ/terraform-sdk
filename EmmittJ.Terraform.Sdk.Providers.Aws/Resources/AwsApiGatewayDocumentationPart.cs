using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_documentation_part resource.
/// </summary>
public class AwsApiGatewayDocumentationPart : TerraformResource
{
    public AwsApiGatewayDocumentationPart(string name) : base("aws_api_gateway_documentation_part", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("documentation_part_id");
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
    /// The properties attribute.
    /// </summary>
    public string? Properties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("properties")?.Value;
        set => this.WithProperty("properties", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The documentation_part_id attribute.
    /// </summary>
    public TerraformExpression DocumentationPartId => this["documentation_part_id"];

}
