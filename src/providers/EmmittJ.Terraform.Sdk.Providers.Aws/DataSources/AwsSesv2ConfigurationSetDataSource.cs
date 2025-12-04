using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_configuration_set Terraform data source.
/// Retrieves information about a aws_sesv2_configuration_set.
/// </summary>
public partial class AwsSesv2ConfigurationSetDataSource(string name) : TerraformDataSource("aws_sesv2_configuration_set", name)
{
    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformValue<string> ConfigurationSetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_set_name");
        set => SetArgument("configuration_set_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The delivery_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeliveryOptions
        => AsReference("delivery_options");

    /// <summary>
    /// The reputation_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReputationOptions
        => AsReference("reputation_options");

    /// <summary>
    /// The sending_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SendingOptions
        => AsReference("sending_options");

    /// <summary>
    /// The suppression_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SuppressionOptions
        => AsReference("suppression_options");

    /// <summary>
    /// The tracking_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrackingOptions
        => AsReference("tracking_options");

    /// <summary>
    /// The vdm_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VdmOptions
        => AsReference("vdm_options");

}
