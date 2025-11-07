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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Attributes
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// The fixed_rate attribute.
    /// </summary>
    public TerraformProperty<double>? FixedRate
    {
        get => GetProperty<TerraformProperty<double>>("fixed_rate");
        set => this.WithProperty("fixed_rate", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => this.WithProperty("host", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformProperty<string>? HttpMethod
    {
        get => GetProperty<TerraformProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
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
    /// The reservoir_size attribute.
    /// </summary>
    public TerraformProperty<double>? ReservoirSize
    {
        get => GetProperty<TerraformProperty<double>>("reservoir_size");
        set => this.WithProperty("reservoir_size", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    public TerraformProperty<string>? RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceType
    {
        get => GetProperty<TerraformProperty<string>>("service_type");
        set => this.WithProperty("service_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The url_path attribute.
    /// </summary>
    public TerraformProperty<string>? UrlPath
    {
        get => GetProperty<TerraformProperty<string>>("url_path");
        set => this.WithProperty("url_path", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<double>? Version
    {
        get => GetProperty<TerraformProperty<double>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
