using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_rest_api.
/// </summary>
public class AwsApiGatewayRestApiDataSource : TerraformDataSource
{
    public AwsApiGatewayRestApiDataSource(string name) : base("aws_api_gateway_rest_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key_source");
        this.DeclareOutput("arn");
        this.DeclareOutput("binary_media_types");
        this.DeclareOutput("description");
        this.DeclareOutput("endpoint_configuration");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("minimum_compression_size");
        this.DeclareOutput("policy");
        this.DeclareOutput("root_resource_id");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public TerraformExpression ApiKeySource => this["api_key_source"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public TerraformExpression BinaryMediaTypes => this["binary_media_types"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    public TerraformExpression EndpointConfiguration => this["endpoint_configuration"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformExpression MinimumCompressionSize => this["minimum_compression_size"];

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformExpression RootResourceId => this["root_resource_id"];

}
