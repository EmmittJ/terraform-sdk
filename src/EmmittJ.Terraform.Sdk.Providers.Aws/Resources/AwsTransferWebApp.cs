using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_web_app resource.
/// </summary>
public class AwsTransferWebApp : TerraformResource
{
    public AwsTransferWebApp(string name) : base("aws_transfer_web_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("web_app_id");
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    public string? AccessEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_endpoint")?.Value;
        set => this.WithProperty("access_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    public string? WebAppEndpointPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_app_endpoint_policy")?.Value;
        set => this.WithProperty("web_app_endpoint_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    public List<object>? WebAppUnits
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("web_app_units")?.Value;
        set => this.WithProperty("web_app_units", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    public TerraformExpression WebAppId => this["web_app_id"];

}
