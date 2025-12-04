using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53HostedZoneDnssec.
/// Nesting mode: single
/// </summary>
public class AwsRoute53HostedZoneDnssecTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_route53_hosted_zone_dnssec Terraform resource.
/// Manages a aws_route53_hosted_zone_dnssec resource.
/// </summary>
public partial class AwsRoute53HostedZoneDnssec(string name) : TerraformResource("aws_route53_hosted_zone_dnssec", name)
{
    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformValue<string> HostedZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("hosted_zone_id");
        set => SetArgument("hosted_zone_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The signing_status attribute.
    /// </summary>
    public TerraformValue<string>? SigningStatus
    {
        get => GetArgument<TerraformValue<string>>("signing_status");
        set => SetArgument("signing_status", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53HostedZoneDnssecTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53HostedZoneDnssecTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
