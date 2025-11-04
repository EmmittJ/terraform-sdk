using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_rest_api resource.
/// </summary>
public class AwsApiGatewayRestApi : TerraformResource
{
    public AwsApiGatewayRestApi(string name) : base("aws_api_gateway_rest_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_date");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("root_resource_id");
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public string? ApiKeySource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key_source")?.Value;
        set => this.WithProperty("api_key_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public List<string>? BinaryMediaTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("binary_media_types")?.Value;
        set => this.WithProperty("binary_media_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public string? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body")?.Value;
        set => this.WithProperty("body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public bool? DisableExecuteApiEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_execute_api_endpoint")?.Value;
        set => this.WithProperty("disable_execute_api_endpoint", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public bool? FailOnWarnings
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fail_on_warnings")?.Value;
        set => this.WithProperty("fail_on_warnings", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The minimum_compression_size attribute.
    /// </summary>
    public string? MinimumCompressionSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_compression_size")?.Value;
        set => this.WithProperty("minimum_compression_size", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    public string? PutRestApiMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("put_rest_api_mode")?.Value;
        set => this.WithProperty("put_rest_api_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformExpression RootResourceId => this["root_resource_id"];

}
