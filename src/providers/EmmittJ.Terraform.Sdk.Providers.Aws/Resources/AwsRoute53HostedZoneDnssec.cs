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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("hosted_zone_id");
        SetOutput("id");
        SetOutput("signing_status");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformProperty<string> HostedZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hosted_zone_id");
        set => SetProperty("hosted_zone_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The signing_status attribute.
    /// </summary>
    public TerraformProperty<string> SigningStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signing_status");
        set => SetProperty("signing_status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53HostedZoneDnssecTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
