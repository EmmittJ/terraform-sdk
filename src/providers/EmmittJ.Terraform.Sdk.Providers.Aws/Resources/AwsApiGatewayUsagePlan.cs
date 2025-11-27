using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for api_stages in AwsApiGatewayUsagePlan.
/// Nesting mode: set
/// </summary>
public class AwsApiGatewayUsagePlanApiStagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_stages";

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformValue<string> Stage
    {
        get => new TerraformReference<string>(this, "stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// Throttle block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsApiGatewayUsagePlanApiStagesBlockThrottleBlock>? Throttle
    {
        get => GetArgument<TerraformSet<AwsApiGatewayUsagePlanApiStagesBlockThrottleBlock>>("throttle");
        set => SetArgument("throttle", value);
    }

}

/// <summary>
/// Block type for throttle in AwsApiGatewayUsagePlanApiStagesBlock.
/// Nesting mode: set
/// </summary>
public class AwsApiGatewayUsagePlanApiStagesBlockThrottleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "throttle";

    /// <summary>
    /// The burst_limit attribute.
    /// </summary>
    public TerraformValue<double>? BurstLimit
    {
        get => new TerraformReference<double>(this, "burst_limit");
        set => SetArgument("burst_limit", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? RateLimit
    {
        get => new TerraformReference<double>(this, "rate_limit");
        set => SetArgument("rate_limit", value);
    }

}


/// <summary>
/// Block type for quota_settings in AwsApiGatewayUsagePlan.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayUsagePlanQuotaSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota_settings";

    /// <summary>
    /// The limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Limit is required")]
    public required TerraformValue<double> Limit
    {
        get => new TerraformReference<double>(this, "limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// The offset attribute.
    /// </summary>
    public TerraformValue<double>? Offset
    {
        get => new TerraformReference<double>(this, "offset");
        set => SetArgument("offset", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    public required TerraformValue<string> Period
    {
        get => new TerraformReference<string>(this, "period");
        set => SetArgument("period", value);
    }

}


/// <summary>
/// Block type for throttle_settings in AwsApiGatewayUsagePlan.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayUsagePlanThrottleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "throttle_settings";

    /// <summary>
    /// The burst_limit attribute.
    /// </summary>
    public TerraformValue<double>? BurstLimit
    {
        get => new TerraformReference<double>(this, "burst_limit");
        set => SetArgument("burst_limit", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? RateLimit
    {
        get => new TerraformReference<double>(this, "rate_limit");
        set => SetArgument("rate_limit", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_usage_plan Terraform resource.
/// Manages a aws_api_gateway_usage_plan resource.
/// </summary>
public partial class AwsApiGatewayUsagePlan(string name) : TerraformResource("aws_api_gateway_usage_plan", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product_code attribute.
    /// </summary>
    public TerraformValue<string>? ProductCode
    {
        get => new TerraformReference<string>(this, "product_code");
        set => SetArgument("product_code", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// ApiStages block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsApiGatewayUsagePlanApiStagesBlock>? ApiStages
    {
        get => GetArgument<TerraformSet<AwsApiGatewayUsagePlanApiStagesBlock>>("api_stages");
        set => SetArgument("api_stages", value);
    }

    /// <summary>
    /// QuotaSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaSettings block(s) allowed")]
    public TerraformList<AwsApiGatewayUsagePlanQuotaSettingsBlock>? QuotaSettings
    {
        get => GetArgument<TerraformList<AwsApiGatewayUsagePlanQuotaSettingsBlock>>("quota_settings");
        set => SetArgument("quota_settings", value);
    }

    /// <summary>
    /// ThrottleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThrottleSettings block(s) allowed")]
    public TerraformList<AwsApiGatewayUsagePlanThrottleSettingsBlock>? ThrottleSettings
    {
        get => GetArgument<TerraformList<AwsApiGatewayUsagePlanThrottleSettingsBlock>>("throttle_settings");
        set => SetArgument("throttle_settings", value);
    }

}
