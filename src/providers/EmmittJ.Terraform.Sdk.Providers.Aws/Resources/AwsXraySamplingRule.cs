using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_xray_sampling_rule resource.
/// </summary>
public class AwsXraySamplingRule : TerraformResource
{
    public AwsXraySamplingRule(string name) : base("aws_xray_sampling_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("attributes");
        SetOutput("fixed_rate");
        SetOutput("host");
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("priority");
        SetOutput("region");
        SetOutput("reservoir_size");
        SetOutput("resource_arn");
        SetOutput("rule_name");
        SetOutput("service_name");
        SetOutput("service_type");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("url_path");
        SetOutput("version");
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Attributes
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("attributes");
        set => SetProperty("attributes", value);
    }

    /// <summary>
    /// The fixed_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FixedRate is required")]
    public required TerraformProperty<double> FixedRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("fixed_rate");
        set => SetProperty("fixed_rate", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host");
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformProperty<string> HttpMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_method");
        set => SetProperty("http_method", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
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
    /// The reservoir_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservoirSize is required")]
    public required TerraformProperty<double> ReservoirSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("reservoir_size");
        set => SetProperty("reservoir_size", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_arn");
        set => SetProperty("resource_arn", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    public TerraformProperty<string> RuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_name");
        set => SetProperty("rule_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceType is required")]
    public required TerraformProperty<string> ServiceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_type");
        set => SetProperty("service_type", value);
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
    /// The url_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlPath is required")]
    public required TerraformProperty<string> UrlPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url_path");
        set => SetProperty("url_path", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<double> Version
    {
        get => GetRequiredOutput<TerraformProperty<double>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
