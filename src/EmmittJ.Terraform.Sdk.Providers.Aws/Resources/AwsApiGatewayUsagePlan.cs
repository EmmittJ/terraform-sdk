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
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => WithProperty("api_id", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformProperty<string> Stage
    {
        get => GetRequiredProperty<TerraformProperty<string>>("stage");
        set => WithProperty("stage", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("limit");
        set => WithProperty("limit", value);
    }

    /// <summary>
    /// The offset attribute.
    /// </summary>
    public TerraformProperty<double>? Offset
    {
        get => GetProperty<TerraformProperty<double>>("offset");
        set => WithProperty("offset", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    public required TerraformProperty<string> Period
    {
        get => GetRequiredProperty<TerraformProperty<string>>("period");
        set => WithProperty("period", value);
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
        get => GetProperty<TerraformProperty<double>>("burst_limit");
        set => WithProperty("burst_limit", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? RateLimit
    {
        get => GetProperty<TerraformProperty<double>>("rate_limit");
        set => WithProperty("rate_limit", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The product_code attribute.
    /// </summary>
    public TerraformProperty<string>? ProductCode
    {
        get => GetProperty<TerraformProperty<string>>("product_code");
        set => this.WithProperty("product_code", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for api_stages.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApiGatewayUsagePlanApiStagesBlock>? ApiStages
    {
        get => GetProperty<HashSet<AwsApiGatewayUsagePlanApiStagesBlock>>("api_stages");
        set => this.WithProperty("api_stages", value);
    }

    /// <summary>
    /// Block for quota_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaSettings block(s) allowed")]
    public List<AwsApiGatewayUsagePlanQuotaSettingsBlock>? QuotaSettings
    {
        get => GetProperty<List<AwsApiGatewayUsagePlanQuotaSettingsBlock>>("quota_settings");
        set => this.WithProperty("quota_settings", value);
    }

    /// <summary>
    /// Block for throttle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThrottleSettings block(s) allowed")]
    public List<AwsApiGatewayUsagePlanThrottleSettingsBlock>? ThrottleSettings
    {
        get => GetProperty<List<AwsApiGatewayUsagePlanThrottleSettingsBlock>>("throttle_settings");
        set => this.WithProperty("throttle_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
