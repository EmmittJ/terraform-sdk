using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53KeySigningKeyTimeoutsBlock : TerraformBlock
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
/// Manages a aws_route53_key_signing_key resource.
/// </summary>
public class AwsRoute53KeySigningKey : TerraformResource
{
    public AwsRoute53KeySigningKey(string name) : base("aws_route53_key_signing_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("digest_algorithm_mnemonic");
        SetOutput("digest_algorithm_type");
        SetOutput("digest_value");
        SetOutput("dnskey_record");
        SetOutput("ds_record");
        SetOutput("flag");
        SetOutput("key_tag");
        SetOutput("public_key");
        SetOutput("signing_algorithm_mnemonic");
        SetOutput("signing_algorithm_type");
        SetOutput("hosted_zone_id");
        SetOutput("id");
        SetOutput("key_management_service_arn");
        SetOutput("name");
        SetOutput("status");
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
    /// The key_management_service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyManagementServiceArn is required")]
    public required TerraformProperty<string> KeyManagementServiceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_management_service_arn");
        set => SetProperty("key_management_service_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53KeySigningKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The digest_algorithm_mnemonic attribute.
    /// </summary>
    public TerraformExpression DigestAlgorithmMnemonic => this["digest_algorithm_mnemonic"];

    /// <summary>
    /// The digest_algorithm_type attribute.
    /// </summary>
    public TerraformExpression DigestAlgorithmType => this["digest_algorithm_type"];

    /// <summary>
    /// The digest_value attribute.
    /// </summary>
    public TerraformExpression DigestValue => this["digest_value"];

    /// <summary>
    /// The dnskey_record attribute.
    /// </summary>
    public TerraformExpression DnskeyRecord => this["dnskey_record"];

    /// <summary>
    /// The ds_record attribute.
    /// </summary>
    public TerraformExpression DsRecord => this["ds_record"];

    /// <summary>
    /// The flag attribute.
    /// </summary>
    public TerraformExpression Flag => this["flag"];

    /// <summary>
    /// The key_tag attribute.
    /// </summary>
    public TerraformExpression KeyTag => this["key_tag"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The signing_algorithm_mnemonic attribute.
    /// </summary>
    public TerraformExpression SigningAlgorithmMnemonic => this["signing_algorithm_mnemonic"];

    /// <summary>
    /// The signing_algorithm_type attribute.
    /// </summary>
    public TerraformExpression SigningAlgorithmType => this["signing_algorithm_type"];

}
