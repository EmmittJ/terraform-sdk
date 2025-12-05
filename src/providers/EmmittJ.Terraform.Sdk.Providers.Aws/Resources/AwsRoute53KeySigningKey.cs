using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53KeySigningKey.
/// Nesting mode: single
/// </summary>
public class AwsRoute53KeySigningKeyTimeoutsBlock : TerraformBlock
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
/// Represents a aws_route53_key_signing_key Terraform resource.
/// Manages a aws_route53_key_signing_key resource.
/// </summary>
public partial class AwsRoute53KeySigningKey(string name) : TerraformResource("aws_route53_key_signing_key", name)
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_management_service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyManagementServiceArn is required")]
    public required TerraformValue<string> KeyManagementServiceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_management_service_arn");
        set => SetArgument("key_management_service_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The digest_algorithm_mnemonic attribute.
    /// </summary>
    public TerraformValue<string> DigestAlgorithmMnemonic
        => CreateReference("digest_algorithm_mnemonic");

    /// <summary>
    /// The digest_algorithm_type attribute.
    /// </summary>
    public TerraformValue<double> DigestAlgorithmType
        => CreateReference("digest_algorithm_type");

    /// <summary>
    /// The digest_value attribute.
    /// </summary>
    public TerraformValue<string> DigestValue
        => CreateReference("digest_value");

    /// <summary>
    /// The dnskey_record attribute.
    /// </summary>
    public TerraformValue<string> DnskeyRecord
        => CreateReference("dnskey_record");

    /// <summary>
    /// The ds_record attribute.
    /// </summary>
    public TerraformValue<string> DsRecord
        => CreateReference("ds_record");

    /// <summary>
    /// The flag attribute.
    /// </summary>
    public TerraformValue<double> Flag
        => CreateReference("flag");

    /// <summary>
    /// The key_tag attribute.
    /// </summary>
    public TerraformValue<double> KeyTag
        => CreateReference("key_tag");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
        => CreateReference("public_key");

    /// <summary>
    /// The signing_algorithm_mnemonic attribute.
    /// </summary>
    public TerraformValue<string> SigningAlgorithmMnemonic
        => CreateReference("signing_algorithm_mnemonic");

    /// <summary>
    /// The signing_algorithm_type attribute.
    /// </summary>
    public TerraformValue<double> SigningAlgorithmType
        => CreateReference("signing_algorithm_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53KeySigningKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53KeySigningKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
