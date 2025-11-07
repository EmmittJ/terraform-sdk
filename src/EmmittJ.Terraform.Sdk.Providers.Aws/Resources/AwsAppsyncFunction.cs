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
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Code
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code");
        set => this.WithProperty("code", value);
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source");
        set => this.WithProperty("data_source", value);
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
    /// The function_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_version");
        set => this.WithProperty("function_version", value);
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
    /// The max_batch_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxBatchSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_batch_size");
        set => this.WithProperty("max_batch_size", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_mapping_template attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestMappingTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_mapping_template");
        set => this.WithProperty("request_mapping_template", value);
    }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResponseMappingTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_mapping_template");
        set => this.WithProperty("response_mapping_template", value);
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
