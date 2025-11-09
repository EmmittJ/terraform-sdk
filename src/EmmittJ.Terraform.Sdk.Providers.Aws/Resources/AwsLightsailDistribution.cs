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
    public TerraformProperty<string>? BundleId
    {
        get => GetProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    public TerraformProperty<string>? CertificateName
    {
        get => GetProperty<TerraformProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
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
    /// The IP address type of the distribution.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    public TerraformProperty<bool>? IsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_enabled");
        set => this.WithProperty("is_enabled", value);
    }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
