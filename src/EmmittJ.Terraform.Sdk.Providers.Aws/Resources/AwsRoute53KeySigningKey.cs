using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("digest_algorithm_mnemonic");
        this.DeclareOutput("digest_algorithm_type");
        this.DeclareOutput("digest_value");
        this.DeclareOutput("dnskey_record");
        this.DeclareOutput("ds_record");
        this.DeclareOutput("flag");
        this.DeclareOutput("key_tag");
        this.DeclareOutput("public_key");
        this.DeclareOutput("signing_algorithm_mnemonic");
        this.DeclareOutput("signing_algorithm_type");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostedZoneId
    {
        get => GetProperty<TerraformProperty<string>>("hosted_zone_id");
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
    /// The key_management_service_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KeyManagementServiceArn
    {
        get => GetProperty<TerraformProperty<string>>("key_management_service_arn");
        set => this.WithProperty("key_management_service_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
