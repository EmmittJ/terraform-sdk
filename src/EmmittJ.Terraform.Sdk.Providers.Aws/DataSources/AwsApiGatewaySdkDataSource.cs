using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_sdk.
/// </summary>
public class AwsApiGatewaySdkDataSource : TerraformDataSource
{
    public AwsApiGatewaySdkDataSource(string name) : base("aws_api_gateway_sdk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("body");
        this.DeclareOutput("content_disposition");
        this.DeclareOutput("content_type");
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
    /// The parameters attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The sdk_type attribute.
    /// </summary>
    public TerraformProperty<string>? SdkType
    {
        get => GetProperty<TerraformProperty<string>>("sdk_type");
        set => this.WithProperty("sdk_type", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformProperty<string>? StageName
    {
        get => GetProperty<TerraformProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformExpression ContentDisposition => this["content_disposition"];

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

}
