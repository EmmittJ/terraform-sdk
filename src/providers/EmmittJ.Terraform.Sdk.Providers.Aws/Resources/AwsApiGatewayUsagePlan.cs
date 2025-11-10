using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for api_stages in .
/// Nesting mode: set
/// </summary>
public class AwsApiGatewayUsagePlanApiStagesBlock : TerraformBlock
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformProperty<string> Stage
    {
        set => SetProperty("stage", value);
    }

}

/// <summary>
/// Block type for quota_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayUsagePlanQuotaSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Limit is required")]
    public required TerraformProperty<double> Limit
    {
        set => SetProperty("limit", value);
    }

    /// <summary>
    /// The offset attribute.
    /// </summary>
    public TerraformProperty<double>? Offset
    {
        set => SetProperty("offset", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    public required TerraformProperty<string> Period
    {
        set => SetProperty("period", value);
    }

}

/// <summary>
/// Block type for throttle_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayUsagePlanThrottleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? BurstLimit
    {
        set => SetProperty("burst_limit", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? RateLimit
    {
        set => SetProperty("rate_limit", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_usage_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayUsagePlan : TerraformResource
{
    public AwsApiGatewayUsagePlan(string name) : base("aws_api_gateway_usage_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("product_code");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product_code attribute.
    /// </summary>
    public TerraformProperty<string> ProductCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_code");
        set => SetProperty("product_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for api_stages.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApiGatewayUsagePlanApiStagesBlock>? ApiStages
    {
        set => SetProperty("api_stages", value);
    }

    /// <summary>
    /// Block for quota_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaSettings block(s) allowed")]
    public List<AwsApiGatewayUsagePlanQuotaSettingsBlock>? QuotaSettings
    {
        set => SetProperty("quota_settings", value);
    }

    /// <summary>
    /// Block for throttle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThrottleSettings block(s) allowed")]
    public List<AwsApiGatewayUsagePlanThrottleSettingsBlock>? ThrottleSettings
    {
        set => SetProperty("throttle_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
