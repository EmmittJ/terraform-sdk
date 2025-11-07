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
    public TerraformProperty<string>? ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformProperty<string>? Code
    {
        get => GetProperty<TerraformProperty<string>>("code");
        set => this.WithProperty("code", value);
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformProperty<string>? DataSource
    {
        get => GetProperty<TerraformProperty<string>>("data_source");
        set => this.WithProperty("data_source", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformProperty<string>? Field
    {
        get => GetProperty<TerraformProperty<string>>("field");
        set => this.WithProperty("field", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBatchSize
    {
        get => GetProperty<TerraformProperty<double>>("max_batch_size");
        set => this.WithProperty("max_batch_size", value);
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
    /// The request_template attribute.
    /// </summary>
    public TerraformProperty<string>? RequestTemplate
    {
        get => GetProperty<TerraformProperty<string>>("request_template");
        set => this.WithProperty("request_template", value);
    }

    /// <summary>
    /// The response_template attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseTemplate
    {
        get => GetProperty<TerraformProperty<string>>("response_template");
        set => this.WithProperty("response_template", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
