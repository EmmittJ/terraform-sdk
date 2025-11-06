using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_function resource.
/// </summary>
public class AwsAppsyncFunction : TerraformResource
{
    public AwsAppsyncFunction(string name) : base("aws_appsync_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("function_id");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public string? Code
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code")?.Value;
        set => this.WithProperty("code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public string? DataSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source")?.Value;
        set => this.WithProperty("data_source", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The function_version attribute.
    /// </summary>
    public string? FunctionVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_version")?.Value;
        set => this.WithProperty("function_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_batch_size attribute.
    /// </summary>
    public double? MaxBatchSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_batch_size")?.Value;
        set => this.WithProperty("max_batch_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The request_mapping_template attribute.
    /// </summary>
    public string? RequestMappingTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_mapping_template")?.Value;
        set => this.WithProperty("request_mapping_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    public string? ResponseMappingTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_mapping_template")?.Value;
        set => this.WithProperty("response_mapping_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    public TerraformExpression FunctionId => this["function_id"];

}
