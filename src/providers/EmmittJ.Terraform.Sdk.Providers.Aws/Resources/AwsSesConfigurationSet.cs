using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in AwsSesConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesConfigurationSetDeliveryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_options";

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformValue<string>? TlsPolicy
    {
        get => GetArgument<TerraformValue<string>>("tls_policy");
        set => SetArgument("tls_policy", value);
    }

}


/// <summary>
/// Block type for tracking_options in AwsSesConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesConfigurationSetTrackingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tracking_options";

    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    public TerraformValue<string>? CustomRedirectDomain
    {
        get => GetArgument<TerraformValue<string>>("custom_redirect_domain");
        set => SetArgument("custom_redirect_domain", value);
    }

}


/// <summary>
/// Represents a aws_ses_configuration_set Terraform resource.
/// Manages a aws_ses_configuration_set resource.
/// </summary>
public partial class AwsSesConfigurationSet(string name) : TerraformResource("aws_ses_configuration_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ReputationMetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("reputation_metrics_enabled");
        set => SetArgument("reputation_metrics_enabled", value);
    }

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sending_enabled");
        set => SetArgument("sending_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    public TerraformValue<string> LastFreshStart
        => AsReference("last_fresh_start");

    /// <summary>
    /// DeliveryOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    public TerraformList<AwsSesConfigurationSetDeliveryOptionsBlock>? DeliveryOptions
    {
        get => GetArgument<TerraformList<AwsSesConfigurationSetDeliveryOptionsBlock>>("delivery_options");
        set => SetArgument("delivery_options", value);
    }

    /// <summary>
    /// TrackingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    public TerraformList<AwsSesConfigurationSetTrackingOptionsBlock>? TrackingOptions
    {
        get => GetArgument<TerraformList<AwsSesConfigurationSetTrackingOptionsBlock>>("tracking_options");
        set => SetArgument("tracking_options", value);
    }

}
