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
        set => SetProperty("current_signing_key_length", value);
    }

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    public TerraformProperty<string>? DomainSigningPrivateKey
    {
        set => SetProperty("domain_signing_private_key", value);
    }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    public TerraformProperty<string>? DomainSigningSelector
    {
        set => SetProperty("domain_signing_selector", value);
    }

    /// <summary>
    /// The last_key_generation_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? LastKeyGenerationTimestamp
    {
        set => SetProperty("last_key_generation_timestamp", value);
    }

    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    public TerraformProperty<string>? NextSigningKeyLength
    {
        set => SetProperty("next_signing_key_length", value);
    }

    /// <summary>
    /// The signing_attributes_origin attribute.
    /// </summary>
    public TerraformProperty<string>? SigningAttributesOrigin
    {
        set => SetProperty("signing_attributes_origin", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The tokens attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Tokens
    {
        set => SetProperty("tokens", value);
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
        SetOutput("arn");
        SetOutput("identity_type");
        SetOutput("verification_status");
        SetOutput("verified_for_sending_status");
        SetOutput("configuration_set_name");
        SetOutput("email_identity");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public TerraformProperty<string> ConfigurationSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_set_name");
        set => SetProperty("configuration_set_name", value);
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformProperty<string> EmailIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_identity");
        set => SetProperty("email_identity", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for dkim_signing_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DkimSigningAttributes block(s) allowed")]
    public List<AwsSesv2EmailIdentityDkimSigningAttributesBlock>? DkimSigningAttributes
    {
        set => SetProperty("dkim_signing_attributes", value);
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
