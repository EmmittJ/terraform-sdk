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
    public TerraformProperty<string>? AccessEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("access_endpoint");
        set => this.WithProperty("access_endpoint", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    public TerraformProperty<string>? WebAppEndpointPolicy
    {
        get => GetProperty<TerraformProperty<string>>("web_app_endpoint_policy");
        set => this.WithProperty("web_app_endpoint_policy", value);
    }

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    public TerraformProperty<List<object>>? WebAppUnits
    {
        get => GetProperty<TerraformProperty<List<object>>>("web_app_units");
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
