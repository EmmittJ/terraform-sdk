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
        this.WithOutput("arn");
        this.WithOutput("delivery_options");
        this.WithOutput("reputation_options");
        this.WithOutput("sending_options");
        this.WithOutput("suppression_options");
        this.WithOutput("tracking_options");
        this.WithOutput("vdm_options");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformProperty<string> ConfigurationSetName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("configuration_set_name");
        set => this.WithProperty("configuration_set_name", value);
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
