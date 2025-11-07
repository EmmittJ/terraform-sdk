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
    public TerraformLiteralProperty<string>? HostedZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hosted_zone_id");
        set => this.WithProperty("hosted_zone_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The signing_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SigningStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signing_status");
        set => this.WithProperty("signing_status", value);
    }

}
