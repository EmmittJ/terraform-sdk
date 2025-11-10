using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for staging_distribution_dns_names in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock : TerraformBlock
{
    /// <summary>
    /// The items attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Items
    {
        set => SetProperty("items", value);
    }

    /// <summary>
    /// The quantity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
    public required TerraformProperty<double> Quantity
    {
        set => SetProperty("quantity", value);
    }

}

/// <summary>
/// Block type for traffic_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_continuous_deployment_policy resource.
/// </summary>
public class AwsCloudfrontContinuousDeploymentPolicy : TerraformResource
{
    public AwsCloudfrontContinuousDeploymentPolicy(string name) : base("aws_cloudfront_continuous_deployment_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("etag");
        SetOutput("id");
        SetOutput("last_modified_time");
        SetOutput("enabled");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Block for staging_distribution_dns_names.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudfrontContinuousDeploymentPolicyStagingDistributionDnsNamesBlock>? StagingDistributionDnsNames
    {
        set => SetProperty("staging_distribution_dns_names", value);
    }

    /// <summary>
    /// Block for traffic_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudfrontContinuousDeploymentPolicyTrafficConfigBlock>? TrafficConfig
    {
        set => SetProperty("traffic_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

}
