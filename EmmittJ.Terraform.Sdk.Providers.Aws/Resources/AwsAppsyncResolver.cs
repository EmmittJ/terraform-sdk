using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_resolver resource.
/// </summary>
public class AwsAppsyncResolver : TerraformResource
{
    public AwsAppsyncResolver(string name) : base("aws_appsync_resolver", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The field attribute.
    /// </summary>
    public string? Field
    {
        get => GetProperty<TerraformLiteralProperty<string>>("field")?.Value;
        set => this.WithProperty("field", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The request_template attribute.
    /// </summary>
    public string? RequestTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_template")?.Value;
        set => this.WithProperty("request_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The response_template attribute.
    /// </summary>
    public string? ResponseTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_template")?.Value;
        set => this.WithProperty("response_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
