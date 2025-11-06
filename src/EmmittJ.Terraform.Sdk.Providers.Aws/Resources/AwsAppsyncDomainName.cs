using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_domain_name resource.
/// </summary>
public class AwsAppsyncDomainName : TerraformResource
{
    public AwsAppsyncDomainName(string name) : base("aws_appsync_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("appsync_domain_name");
        this.DeclareOutput("hosted_zone_id");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The appsync_domain_name attribute.
    /// </summary>
    public TerraformExpression AppsyncDomainName => this["appsync_domain_name"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

}
