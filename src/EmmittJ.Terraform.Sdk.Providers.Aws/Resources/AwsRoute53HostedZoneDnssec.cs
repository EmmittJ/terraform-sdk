using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53HostedZoneDnssecTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformProperty<string> HostedZoneId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hosted_zone_id");
        set => this.WithProperty("hosted_zone_id", value);
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
    /// The signing_status attribute.
    /// </summary>
    public TerraformProperty<string>? SigningStatus
    {
        get => GetProperty<TerraformProperty<string>>("signing_status");
        set => this.WithProperty("signing_status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53HostedZoneDnssecTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53HostedZoneDnssecTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
