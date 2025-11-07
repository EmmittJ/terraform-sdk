using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_distribution resource.
/// </summary>
public class AwsCloudfrontDistribution : TerraformResource
{
    public AwsCloudfrontDistribution(string name) : base("aws_cloudfront_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("caller_reference");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("etag");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("in_progress_validation_batches");
        this.DeclareOutput("last_modified_time");
        this.DeclareOutput("status");
        this.DeclareOutput("trusted_key_groups");
        this.DeclareOutput("trusted_signers");
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Aliases
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("aliases");
        set => this.WithProperty("aliases", value);
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformProperty<string>? AnycastIpListId
    {
        get => GetProperty<TerraformProperty<string>>("anycast_ip_list_id");
        set => this.WithProperty("anycast_ip_list_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContinuousDeploymentPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("continuous_deployment_policy_id");
        set => this.WithProperty("continuous_deployment_policy_id", value);
    }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRootObject
    {
        get => GetProperty<TerraformProperty<string>>("default_root_object");
        set => this.WithProperty("default_root_object", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    public TerraformProperty<string>? HttpVersion
    {
        get => GetProperty<TerraformProperty<string>>("http_version");
        set => this.WithProperty("http_version", value);
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
    /// The is_ipv6_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsIpv6Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_ipv6_enabled");
        set => this.WithProperty("is_ipv6_enabled", value);
    }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    public TerraformProperty<string>? PriceClass
    {
        get => GetProperty<TerraformProperty<string>>("price_class");
        set => this.WithProperty("price_class", value);
    }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainOnDelete
    {
        get => GetProperty<TerraformProperty<bool>>("retain_on_delete");
        set => this.WithProperty("retain_on_delete", value);
    }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    public TerraformProperty<bool>? Staging
    {
        get => GetProperty<TerraformProperty<bool>>("staging");
        set => this.WithProperty("staging", value);
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
    /// The wait_for_deployment attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForDeployment
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_deployment");
        set => this.WithProperty("wait_for_deployment", value);
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebAclId
    {
        get => GetProperty<TerraformProperty<string>>("web_acl_id");
        set => this.WithProperty("web_acl_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformExpression CallerReference => this["caller_reference"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

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
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformExpression TrustedKeyGroups => this["trusted_key_groups"];

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformExpression TrustedSigners => this["trusted_signers"];

}
