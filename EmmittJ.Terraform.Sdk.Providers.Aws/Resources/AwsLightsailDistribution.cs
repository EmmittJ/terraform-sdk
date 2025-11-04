using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_distribution resource.
/// </summary>
public class AwsLightsailDistribution : TerraformResource
{
    public AwsLightsailDistribution(string name) : base("aws_lightsail_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alternative_domain_names");
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("location");
        this.DeclareOutput("origin_public_dns");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("status");
        this.DeclareOutput("support_code");
    }

    /// <summary>
    /// The bundle ID to use for the distribution.
    /// </summary>
    public string? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id")?.Value;
        set => this.WithProperty("bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    public string? CertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_name")?.Value;
        set => this.WithProperty("certificate_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The IP address type of the distribution.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    public bool? IsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_enabled")?.Value;
        set => this.WithProperty("is_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The alternate domain names of the distribution.
    /// </summary>
    public TerraformExpression AlternativeDomainNames => this["alternative_domain_names"];

    /// <summary>
    /// The Amazon Resource Name (ARN) of the distribution.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The timestamp when the distribution was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The domain name of the distribution.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// An object that describes the location of the distribution, such as the AWS Region and Availability Zone.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The public DNS of the origin.
    /// </summary>
    public TerraformExpression OriginPublicDns => this["origin_public_dns"];

    /// <summary>
    /// The Lightsail resource type (e.g., Distribution).
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// The status of the distribution.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The support code. Include this code in your email to support when you have questions about your Lightsail distribution. This code enables our support team to look up your Lightsail information more easily.
    /// </summary>
    public TerraformExpression SupportCode => this["support_code"];

}
