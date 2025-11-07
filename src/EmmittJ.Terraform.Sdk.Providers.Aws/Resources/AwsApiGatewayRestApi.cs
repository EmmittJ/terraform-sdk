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
    public TerraformLiteralProperty<string>? ApiKeySource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key_source");
        set => this.WithProperty("api_key_source", value);
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? BinaryMediaTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("binary_media_types");
        set => this.WithProperty("binary_media_types", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableExecuteApiEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_execute_api_endpoint");
        set => this.WithProperty("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FailOnWarnings
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fail_on_warnings");
        set => this.WithProperty("fail_on_warnings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MinimumCompressionSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_compression_size");
        set => this.WithProperty("minimum_compression_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PutRestApiMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("put_rest_api_mode");
        set => this.WithProperty("put_rest_api_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
