using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents the aws Terraform provider.
/// 
/// Version: ~&gt; 6.0
/// Resources: 1561
/// Data Sources: 630
/// </summary>
public class AwsProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AwsProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "aws".</param>
    public AwsProvider(string name = "aws") : base(name)
    {
    }

    /// <summary>
    /// The access key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? AccessKey
    {
        get => GetProperty<TerraformProperty<string>>("access_key");
        set => this.WithProperty("access_key", value);
    }

    /// <summary>
    /// The allowed_account_ids configuration.
    /// (Optional)
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedAccountIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_account_ids");
        set => this.WithProperty("allowed_account_ids", value);
    }

    /// <summary>
    /// File containing custom root and intermediate certificates. Can also be configured using the `AWS_CA_BUNDLE` environment variable. (Setting `ca_bundle` in the shared config file is not supported.)
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CustomCaBundle
    {
        get => GetProperty<TerraformProperty<string>>("custom_ca_bundle");
        set => this.WithProperty("custom_ca_bundle", value);
    }

    /// <summary>
    /// Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Ec2MetadataServiceEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("ec2_metadata_service_endpoint");
        set => this.WithProperty("ec2_metadata_service_endpoint", value);
    }

    /// <summary>
    /// Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Ec2MetadataServiceEndpointMode
    {
        get => GetProperty<TerraformProperty<string>>("ec2_metadata_service_endpoint_mode");
        set => this.WithProperty("ec2_metadata_service_endpoint_mode", value);
    }

    /// <summary>
    /// The forbidden_account_ids configuration.
    /// (Optional)
    /// </summary>
    public HashSet<TerraformProperty<string>>? ForbiddenAccountIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("forbidden_account_ids");
        set => this.WithProperty("forbidden_account_ids", value);
    }

    /// <summary>
    /// URL of a proxy to use for HTTP requests when accessing the AWS API. Can also be set using the `HTTP_PROXY` or `http_proxy` environment variables.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? HttpProxy
    {
        get => GetProperty<TerraformProperty<string>>("http_proxy");
        set => this.WithProperty("http_proxy", value);
    }

    /// <summary>
    /// URL of a proxy to use for HTTPS requests when accessing the AWS API. Can also be set using the `HTTPS_PROXY` or `https_proxy` environment variables.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? HttpsProxy
    {
        get => GetProperty<TerraformProperty<string>>("https_proxy");
        set => this.WithProperty("https_proxy", value);
    }

    /// <summary>
    /// Explicitly allow the provider to perform &amp;quot;insecure&amp;quot; SSL requests. If omitted, default value is `false`
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? Insecure
    {
        get => GetProperty<TerraformProperty<bool>>("insecure");
        set => this.WithProperty("insecure", value);
    }

    /// <summary>
    /// The maximum number of times an AWS API request is
    /// being executed. If the API request still fails, an error is
    /// thrown.
    /// (Optional)
    /// </summary>
    public TerraformProperty<double>? MaxRetries
    {
        get => GetProperty<TerraformProperty<double>>("max_retries");
        set => this.WithProperty("max_retries", value);
    }

    /// <summary>
    /// Comma-separated list of hosts that should not use HTTP or HTTPS proxies. Can also be set using the `NO_PROXY` or `no_proxy` environment variables.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NoProxy
    {
        get => GetProperty<TerraformProperty<string>>("no_proxy");
        set => this.WithProperty("no_proxy", value);
    }

    /// <summary>
    /// The profile for API operations. If not set, the default profile
    /// created with `aws configure` will be used.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Profile
    {
        get => GetProperty<TerraformProperty<string>>("profile");
        set => this.WithProperty("profile", value);
    }

    /// <summary>
    /// The region where AWS operations will take place. Examples
    /// are us-east-1, us-west-2, etc.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Specifies how retries are attempted. Valid values are `standard` and `adaptive`. Can also be configured using the `AWS_RETRY_MODE` environment variable.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? RetryMode
    {
        get => GetProperty<TerraformProperty<string>>("retry_mode");
        set => this.WithProperty("retry_mode", value);
    }

    /// <summary>
    /// Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint. Valid values are `legacy` or `regional`. Can also be configured using the `AWS_S3_US_EAST_1_REGIONAL_ENDPOINT` environment variable or the `s3_us_east_1_regional_endpoint` shared config file parameter
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? S3UsEast1RegionalEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("s3_us_east_1_regional_endpoint");
        set => this.WithProperty("s3_us_east_1_regional_endpoint", value);
    }

    /// <summary>
    /// Set this to true to enable the request to use path-style addressing,
    /// i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will
    /// use virtual hosted bucket addressing when possible
    /// (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? S3UsePathStyle
    {
        get => GetProperty<TerraformProperty<bool>>("s3_use_path_style");
        set => this.WithProperty("s3_use_path_style", value);
    }

    /// <summary>
    /// The secret key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecretKey
    {
        get => GetProperty<TerraformProperty<string>>("secret_key");
        set => this.WithProperty("secret_key", value);
    }

    /// <summary>
    /// List of paths to shared config files. If not set, defaults to [~/.aws/config].
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>>? SharedConfigFiles
    {
        get => GetProperty<List<TerraformProperty<string>>>("shared_config_files");
        set => this.WithProperty("shared_config_files", value);
    }

    /// <summary>
    /// List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials].
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>>? SharedCredentialsFiles
    {
        get => GetProperty<List<TerraformProperty<string>>>("shared_credentials_files");
        set => this.WithProperty("shared_credentials_files", value);
    }

    /// <summary>
    /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? SkipCredentialsValidation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_credentials_validation");
        set => this.WithProperty("skip_credentials_validation", value);
    }

    /// <summary>
    /// Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SkipMetadataApiCheck
    {
        get => GetProperty<TerraformProperty<string>>("skip_metadata_api_check");
        set => this.WithProperty("skip_metadata_api_check", value);
    }

    /// <summary>
    /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? SkipRegionValidation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_region_validation");
        set => this.WithProperty("skip_region_validation", value);
    }

    /// <summary>
    /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? SkipRequestingAccountId
    {
        get => GetProperty<TerraformProperty<bool>>("skip_requesting_account_id");
        set => this.WithProperty("skip_requesting_account_id", value);
    }

    /// <summary>
    /// The region where AWS STS operations will take place. Examples
    /// are us-east-1 and us-west-2.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? StsRegion
    {
        get => GetProperty<TerraformProperty<string>>("sts_region");
        set => this.WithProperty("sts_region", value);
    }

    /// <summary>
    /// session token. A session token is only required if you are
    /// using temporary security credentials.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Token
    {
        get => GetProperty<TerraformProperty<string>>("token");
        set => this.WithProperty("token", value);
    }

    /// <summary>
    /// The capacity of the AWS SDK&#39;s token bucket rate limiter.
    /// (Optional)
    /// </summary>
    public TerraformProperty<double>? TokenBucketRateLimiterCapacity
    {
        get => GetProperty<TerraformProperty<double>>("token_bucket_rate_limiter_capacity");
        set => this.WithProperty("token_bucket_rate_limiter_capacity", value);
    }

    /// <summary>
    /// Resolve an endpoint with DualStack capability
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? UseDualstackEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("use_dualstack_endpoint");
        set => this.WithProperty("use_dualstack_endpoint", value);
    }

    /// <summary>
    /// Resolve an endpoint with FIPS capability
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? UseFipsEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("use_fips_endpoint");
        set => this.WithProperty("use_fips_endpoint", value);
    }
}
