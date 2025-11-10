using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_distribution.
/// </summary>
public class AwsCloudfrontDistributionDataSource : TerraformDataSource
{
    public AwsCloudfrontDistributionDataSource(string name) : base("aws_cloudfront_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("aliases");
        SetOutput("anycast_ip_list_id");
        SetOutput("arn");
        SetOutput("domain_name");
        SetOutput("enabled");
        SetOutput("etag");
        SetOutput("hosted_zone_id");
        SetOutput("in_progress_validation_batches");
        SetOutput("last_modified_time");
        SetOutput("status");
        SetOutput("web_acl_id");
        SetOutput("id");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The aliases attribute.
    /// </summary>
    public TerraformExpression Aliases => this["aliases"];

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformExpression AnycastIpListId => this["anycast_ip_list_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    public TerraformExpression InProgressValidationBatches => this["in_progress_validation_batches"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformExpression WebAclId => this["web_acl_id"];

}
