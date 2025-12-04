using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for staging_distribution_dns_names in AwsCloudfrontContinuousDeploymentPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "staging_distribution_dns_names";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => GetArgument<TerraformSet<string>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// The quantity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
    public required TerraformValue<double> Quantity
    {
        get => GetArgument<TerraformValue<double>>("quantity");
        set => SetArgument("quantity", value);
    }

}


/// <summary>
/// Block type for traffic_config in AwsCloudfrontContinuousDeploymentPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_config";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// SingleHeaderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleHeaderConfigBlock>? SingleHeaderConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleHeaderConfigBlock>>("single_header_config");
        set => SetArgument("single_header_config", value);
    }

    /// <summary>
    /// SingleWeightConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlock>? SingleWeightConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlock>>("single_weight_config");
        set => SetArgument("single_weight_config", value);
    }

}

/// <summary>
/// Block type for single_header_config in AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleHeaderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_header_config";

    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    public required TerraformValue<string> Header
    {
        get => GetArgument<TerraformValue<string>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for single_weight_config in AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_weight_config";

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// SessionStickinessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlockSessionStickinessConfigBlock>? SessionStickinessConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlockSessionStickinessConfigBlock>>("session_stickiness_config");
        set => SetArgument("session_stickiness_config", value);
    }

}

/// <summary>
/// Block type for session_stickiness_config in AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlockSingleWeightConfigBlockSessionStickinessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "session_stickiness_config";

    /// <summary>
    /// The idle_ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdleTtl is required")]
    public required TerraformValue<double> IdleTtl
    {
        get => GetArgument<TerraformValue<double>>("idle_ttl");
        set => SetArgument("idle_ttl", value);
    }

    /// <summary>
    /// The maximum_ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTtl is required")]
    public required TerraformValue<double> MaximumTtl
    {
        get => GetArgument<TerraformValue<double>>("maximum_ttl");
        set => SetArgument("maximum_ttl", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_continuous_deployment_policy Terraform resource.
/// Manages a aws_cloudfront_continuous_deployment_policy resource.
/// </summary>
public partial class AwsCloudfrontContinuousDeploymentPolicy(string name) : TerraformResource("aws_cloudfront_continuous_deployment_policy", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
        => AsReference("last_modified_time");

    /// <summary>
    /// StagingDistributionDnsNames block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock>? StagingDistributionDnsNames
    {
        get => GetArgument<TerraformList<AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock>>("staging_distribution_dns_names");
        set => SetArgument("staging_distribution_dns_names", value);
    }

    /// <summary>
    /// TrafficConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock>? TrafficConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock>>("traffic_config");
        set => SetArgument("traffic_config", value);
    }

}
