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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_key");
        SetOutput("allowed_account_ids");
        SetOutput("custom_ca_bundle");
        SetOutput("ec2_metadata_service_endpoint");
        SetOutput("ec2_metadata_service_endpoint_mode");
        SetOutput("forbidden_account_ids");
        SetOutput("http_proxy");
        SetOutput("https_proxy");
        SetOutput("insecure");
        SetOutput("max_retries");
        SetOutput("no_proxy");
        SetOutput("profile");
        SetOutput("region");
        SetOutput("retry_mode");
        SetOutput("s3_us_east_1_regional_endpoint");
        SetOutput("s3_use_path_style");
        SetOutput("secret_key");
        SetOutput("shared_config_files");
        SetOutput("shared_credentials_files");
        SetOutput("skip_credentials_validation");
        SetOutput("skip_metadata_api_check");
        SetOutput("skip_region_validation");
        SetOutput("skip_requesting_account_id");
        SetOutput("sts_region");
        SetOutput("token");
        SetOutput("token_bucket_rate_limiter_capacity");
        SetOutput("use_dualstack_endpoint");
        SetOutput("use_fips_endpoint");
    }

    /// <summary>
    /// The access key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The allowed_account_ids configuration.
    /// (Optional)
    /// </summary>
    public TerraformSet<string>? AllowedAccountIds { get; set; }

    /// <summary>
    /// File containing custom root and intermediate certificates. Can also be configured using the `AWS_CA_BUNDLE` environment variable. (Setting `ca_bundle` in the shared config file is not supported.)
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CustomCaBundle { get; set; }

    /// <summary>
    /// Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Ec2MetadataServiceEndpoint { get; set; }

    /// <summary>
    /// Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Ec2MetadataServiceEndpointMode { get; set; }

    /// <summary>
    /// The forbidden_account_ids configuration.
    /// (Optional)
    /// </summary>
    public TerraformSet<string>? ForbiddenAccountIds { get; set; }

    /// <summary>
    /// URL of a proxy to use for HTTP requests when accessing the AWS API. Can also be set using the `HTTP_PROXY` or `http_proxy` environment variables.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? HttpProxy { get; set; }

    /// <summary>
    /// URL of a proxy to use for HTTPS requests when accessing the AWS API. Can also be set using the `HTTPS_PROXY` or `https_proxy` environment variables.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? HttpsProxy { get; set; }

    /// <summary>
    /// Explicitly allow the provider to perform &amp;quot;insecure&amp;quot; SSL requests. If omitted, default value is `false`
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? Insecure { get; set; }

    /// <summary>
    /// The maximum number of times an AWS API request is
    /// being executed. If the API request still fails, an error is
    /// thrown.
    /// (Optional)
    /// </summary>
    public TerraformValue<double>? MaxRetries { get; set; }

    /// <summary>
    /// Comma-separated list of hosts that should not use HTTP or HTTPS proxies. Can also be set using the `NO_PROXY` or `no_proxy` environment variables.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NoProxy { get; set; }

    /// <summary>
    /// The profile for API operations. If not set, the default profile
    /// created with `aws configure` will be used.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Profile { get; set; }

    /// <summary>
    /// The region where AWS operations will take place. Examples
    /// are us-east-1, us-west-2, etc.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Specifies how retries are attempted. Valid values are `standard` and `adaptive`. Can also be configured using the `AWS_RETRY_MODE` environment variable.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? RetryMode { get; set; }

    /// <summary>
    /// Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint. Valid values are `legacy` or `regional`. Can also be configured using the `AWS_S3_US_EAST_1_REGIONAL_ENDPOINT` environment variable or the `s3_us_east_1_regional_endpoint` shared config file parameter
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? S3UsEast1RegionalEndpoint { get; set; }

    /// <summary>
    /// Set this to true to enable the request to use path-style addressing,
    /// i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will
    /// use virtual hosted bucket addressing when possible
    /// (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? S3UsePathStyle { get; set; }

    /// <summary>
    /// The secret key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecretKey { get; set; }

    /// <summary>
    /// List of paths to shared config files. If not set, defaults to [~/.aws/config].
    /// (Optional)
    /// </summary>
    public TerraformList<string>? SharedConfigFiles { get; set; }

    /// <summary>
    /// List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials].
    /// (Optional)
    /// </summary>
    public TerraformList<string>? SharedCredentialsFiles { get; set; }

    /// <summary>
    /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? SkipCredentialsValidation { get; set; }

    /// <summary>
    /// Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SkipMetadataApiCheck { get; set; }

    /// <summary>
    /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? SkipRegionValidation { get; set; }

    /// <summary>
    /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? SkipRequestingAccountId { get; set; }

    /// <summary>
    /// The region where AWS STS operations will take place. Examples
    /// are us-east-1 and us-west-2.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? StsRegion { get; set; }

    /// <summary>
    /// session token. A session token is only required if you are
    /// using temporary security credentials.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Token { get; set; }

    /// <summary>
    /// The capacity of the AWS SDK&#39;s token bucket rate limiter.
    /// (Optional)
    /// </summary>
    public TerraformValue<double>? TokenBucketRateLimiterCapacity { get; set; }

    /// <summary>
    /// Resolve an endpoint with DualStack capability
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UseDualstackEndpoint { get; set; }

    /// <summary>
    /// Resolve an endpoint with FIPS capability
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UseFipsEndpoint { get; set; }
}
