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
        get => new TerraformReference<string>(this, "configuration_set_name");
        set => SetArgument("configuration_set_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The delivery_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeliveryOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "delivery_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The reputation_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReputationOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "reputation_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sending_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SendingOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sending_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The suppression_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SuppressionOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "suppression_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tracking_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrackingOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "tracking_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vdm_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VdmOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vdm_options").ResolveNodes(ctx));
    }

}
