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
    public HashSet<string>? Aliases
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("aliases")?.Value;
        set => this.WithProperty("aliases", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public string? AnycastIpListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("anycast_ip_list_id")?.Value;
        set => this.WithProperty("anycast_ip_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public string? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment")?.Value;
        set => this.WithProperty("comment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    public string? ContinuousDeploymentPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("continuous_deployment_policy_id")?.Value;
        set => this.WithProperty("continuous_deployment_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    public string? DefaultRootObject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_root_object")?.Value;
        set => this.WithProperty("default_root_object", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    public string? HttpVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_version")?.Value;
        set => this.WithProperty("http_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The is_ipv6_enabled attribute.
    /// </summary>
    public bool? IsIpv6Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_ipv6_enabled")?.Value;
        set => this.WithProperty("is_ipv6_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    public string? PriceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("price_class")?.Value;
        set => this.WithProperty("price_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    public bool? RetainOnDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("retain_on_delete")?.Value;
        set => this.WithProperty("retain_on_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    public bool? Staging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("staging")?.Value;
        set => this.WithProperty("staging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    public bool? WaitForDeployment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_deployment")?.Value;
        set => this.WithProperty("wait_for_deployment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public string? WebAclId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_acl_id")?.Value;
        set => this.WithProperty("web_acl_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
