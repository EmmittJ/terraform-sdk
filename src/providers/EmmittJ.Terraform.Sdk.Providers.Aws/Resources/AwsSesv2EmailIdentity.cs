using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dkim_signing_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2EmailIdentityDkimSigningAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The current_signing_key_length attribute.
    /// </summary>
    public TerraformProperty<string>? CurrentSigningKeyLength
    {
        get => GetProperty<TerraformProperty<string>>("current_signing_key_length");
        set => WithProperty("current_signing_key_length", value);
    }

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    public TerraformProperty<string>? DomainSigningPrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("domain_signing_private_key");
        set => WithProperty("domain_signing_private_key", value);
    }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    public TerraformProperty<string>? DomainSigningSelector
    {
        get => GetProperty<TerraformProperty<string>>("domain_signing_selector");
        set => WithProperty("domain_signing_selector", value);
    }

    /// <summary>
    /// The last_key_generation_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? LastKeyGenerationTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("last_key_generation_timestamp");
        set => WithProperty("last_key_generation_timestamp", value);
    }

    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    public TerraformProperty<string>? NextSigningKeyLength
    {
        get => GetProperty<TerraformProperty<string>>("next_signing_key_length");
        set => WithProperty("next_signing_key_length", value);
    }

    /// <summary>
    /// The signing_attributes_origin attribute.
    /// </summary>
    public TerraformProperty<string>? SigningAttributesOrigin
    {
        get => GetProperty<TerraformProperty<string>>("signing_attributes_origin");
        set => WithProperty("signing_attributes_origin", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

    /// <summary>
    /// The tokens attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Tokens
    {
        get => GetProperty<List<TerraformProperty<string>>>("tokens");
        set => WithProperty("tokens", value);
    }

}

/// <summary>
/// Manages a aws_sesv2_email_identity resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesv2EmailIdentity : TerraformResource
{
    public AwsSesv2EmailIdentity(string name) : base("aws_sesv2_email_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("identity_type");
        this.DeclareOutput("verification_status");
        this.DeclareOutput("verified_for_sending_status");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationSetName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_set_name");
        set => this.WithProperty("configuration_set_name", value);
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformProperty<string> EmailIdentity
    {
        get => GetRequiredProperty<TerraformProperty<string>>("email_identity");
        set => this.WithProperty("email_identity", value);
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for dkim_signing_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DkimSigningAttributes block(s) allowed")]
    public List<AwsSesv2EmailIdentityDkimSigningAttributesBlock>? DkimSigningAttributes
    {
        get => GetProperty<List<AwsSesv2EmailIdentityDkimSigningAttributesBlock>>("dkim_signing_attributes");
        set => this.WithProperty("dkim_signing_attributes", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformExpression IdentityType => this["identity_type"];

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    public TerraformExpression VerificationStatus => this["verification_status"];

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    public TerraformExpression VerifiedForSendingStatus => this["verified_for_sending_status"];

}
