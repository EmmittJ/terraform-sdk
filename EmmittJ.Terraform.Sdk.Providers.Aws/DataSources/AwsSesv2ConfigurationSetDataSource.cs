using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_configuration_set.
/// </summary>
public class AwsSesv2ConfigurationSetDataSource : TerraformDataSource
{
    public AwsSesv2ConfigurationSetDataSource(string name) : base("aws_sesv2_configuration_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("delivery_options");
        this.DeclareOutput("reputation_options");
        this.DeclareOutput("sending_options");
        this.DeclareOutput("suppression_options");
        this.DeclareOutput("tracking_options");
        this.DeclareOutput("vdm_options");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public string? ConfigurationSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_set_name")?.Value;
        set => this.WithProperty("configuration_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The delivery_options attribute.
    /// </summary>
    public TerraformExpression DeliveryOptions => this["delivery_options"];

    /// <summary>
    /// The reputation_options attribute.
    /// </summary>
    public TerraformExpression ReputationOptions => this["reputation_options"];

    /// <summary>
    /// The sending_options attribute.
    /// </summary>
    public TerraformExpression SendingOptions => this["sending_options"];

    /// <summary>
    /// The suppression_options attribute.
    /// </summary>
    public TerraformExpression SuppressionOptions => this["suppression_options"];

    /// <summary>
    /// The tracking_options attribute.
    /// </summary>
    public TerraformExpression TrackingOptions => this["tracking_options"];

    /// <summary>
    /// The vdm_options attribute.
    /// </summary>
    public TerraformExpression VdmOptions => this["vdm_options"];

}
