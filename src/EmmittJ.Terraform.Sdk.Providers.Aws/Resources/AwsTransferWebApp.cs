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
    public TerraformLiteralProperty<string>? AccessEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_endpoint");
        set => this.WithProperty("access_endpoint", value);
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
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebAppEndpointPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_app_endpoint_policy");
        set => this.WithProperty("web_app_endpoint_policy", value);
    }

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? WebAppUnits
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("web_app_units");
        set => this.WithProperty("web_app_units", value);
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
