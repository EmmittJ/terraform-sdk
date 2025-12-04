using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in AwsSesv2ConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetDeliveryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_options";

    /// <summary>
    /// The max_delivery_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeliverySeconds
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_seconds");
        set => SetArgument("max_delivery_seconds", value);
    }

    /// <summary>
    /// The sending_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? SendingPoolName
    {
        get => GetArgument<TerraformValue<string>>("sending_pool_name");
        set => SetArgument("sending_pool_name", value);
    }

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
/// Block type for reputation_options in AwsSesv2ConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetReputationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reputation_options";

    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    public TerraformValue<string> LastFreshStart
        => AsReference("last_fresh_start");

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ReputationMetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("reputation_metrics_enabled") ?? AsReference("reputation_metrics_enabled");
        set => SetArgument("reputation_metrics_enabled", value);
    }

}


/// <summary>
/// Block type for sending_options in AwsSesv2ConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetSendingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sending_options";

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SendingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sending_enabled") ?? AsReference("sending_enabled");
        set => SetArgument("sending_enabled", value);
    }

}


/// <summary>
/// Block type for suppression_options in AwsSesv2ConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetSuppressionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "suppression_options";

    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    public TerraformList<string>? SuppressedReasons
    {
        get => GetArgument<TerraformList<string>>("suppressed_reasons");
        set => SetArgument("suppressed_reasons", value);
    }

}


/// <summary>
/// Block type for tracking_options in AwsSesv2ConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetTrackingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tracking_options";

    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomRedirectDomain is required")]
    public required TerraformValue<string> CustomRedirectDomain
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_redirect_domain");
        set => SetArgument("custom_redirect_domain", value);
    }

    /// <summary>
    /// The https_policy attribute.
    /// </summary>
    public TerraformValue<string>? HttpsPolicy
    {
        get => GetArgument<TerraformValue<string>>("https_policy");
        set => SetArgument("https_policy", value);
    }

}


/// <summary>
/// Block type for vdm_options in AwsSesv2ConfigurationSet.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetVdmOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vdm_options";

    /// <summary>
    /// DashboardOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetVdmOptionsBlockDashboardOptionsBlock>? DashboardOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetVdmOptionsBlockDashboardOptionsBlock>>("dashboard_options");
        set => SetArgument("dashboard_options", value);
    }

    /// <summary>
    /// GuardianOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuardianOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetVdmOptionsBlockGuardianOptionsBlock>? GuardianOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetVdmOptionsBlockGuardianOptionsBlock>>("guardian_options");
        set => SetArgument("guardian_options", value);
    }

}

/// <summary>
/// Block type for dashboard_options in AwsSesv2ConfigurationSetVdmOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetVdmOptionsBlockDashboardOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dashboard_options";

    /// <summary>
    /// The engagement_metrics attribute.
    /// </summary>
    public TerraformValue<string>? EngagementMetrics
    {
        get => GetArgument<TerraformValue<string>>("engagement_metrics");
        set => SetArgument("engagement_metrics", value);
    }

}

/// <summary>
/// Block type for guardian_options in AwsSesv2ConfigurationSetVdmOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetVdmOptionsBlockGuardianOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guardian_options";

    /// <summary>
    /// The optimized_shared_delivery attribute.
    /// </summary>
    public TerraformValue<string>? OptimizedSharedDelivery
    {
        get => GetArgument<TerraformValue<string>>("optimized_shared_delivery");
        set => SetArgument("optimized_shared_delivery", value);
    }

}


/// <summary>
/// Represents a aws_sesv2_configuration_set Terraform resource.
/// Manages a aws_sesv2_configuration_set resource.
/// </summary>
public partial class AwsSesv2ConfigurationSet(string name) : TerraformResource("aws_sesv2_configuration_set", name)
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
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DeliveryOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetDeliveryOptionsBlock>? DeliveryOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetDeliveryOptionsBlock>>("delivery_options");
        set => SetArgument("delivery_options", value);
    }

    /// <summary>
    /// ReputationOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReputationOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetReputationOptionsBlock>? ReputationOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetReputationOptionsBlock>>("reputation_options");
        set => SetArgument("reputation_options", value);
    }

    /// <summary>
    /// SendingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SendingOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetSendingOptionsBlock>? SendingOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetSendingOptionsBlock>>("sending_options");
        set => SetArgument("sending_options", value);
    }

    /// <summary>
    /// SuppressionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuppressionOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetSuppressionOptionsBlock>? SuppressionOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetSuppressionOptionsBlock>>("suppression_options");
        set => SetArgument("suppression_options", value);
    }

    /// <summary>
    /// TrackingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetTrackingOptionsBlock>? TrackingOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetTrackingOptionsBlock>>("tracking_options");
        set => SetArgument("tracking_options", value);
    }

    /// <summary>
    /// VdmOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VdmOptions block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetVdmOptionsBlock>? VdmOptions
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetVdmOptionsBlock>>("vdm_options");
        set => SetArgument("vdm_options", value);
    }

}
