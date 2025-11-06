using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_hosted_zone_dnssec resource.
/// </summary>
public class AwsRoute53HostedZoneDnssec : TerraformResource
{
    public AwsRoute53HostedZoneDnssec(string name) : base("aws_route53_hosted_zone_dnssec", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public string? HostedZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hosted_zone_id")?.Value;
        set => this.WithProperty("hosted_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The signing_status attribute.
    /// </summary>
    public string? SigningStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signing_status")?.Value;
        set => this.WithProperty("signing_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
