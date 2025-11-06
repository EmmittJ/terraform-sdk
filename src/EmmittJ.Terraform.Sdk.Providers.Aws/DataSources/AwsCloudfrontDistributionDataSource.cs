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
        this.DeclareOutput("aliases");
        this.DeclareOutput("anycast_ip_list_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("enabled");
        this.DeclareOutput("etag");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("in_progress_validation_batches");
        this.DeclareOutput("last_modified_time");
        this.DeclareOutput("status");
        this.DeclareOutput("web_acl_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
