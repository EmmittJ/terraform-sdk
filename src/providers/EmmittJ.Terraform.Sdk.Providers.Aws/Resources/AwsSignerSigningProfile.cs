using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for signature_validity_period in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningProfileSignatureValidityPeriodBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<double> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for signing_material in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningProfileSigningMaterialBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformProperty<string> CertificateArn
    {
        set => SetProperty("certificate_arn", value);
    }

}

/// <summary>
/// Manages a aws_signer_signing_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSignerSigningProfile : TerraformResource
{
    public AwsSignerSigningProfile(string name) : base("aws_signer_signing_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("platform_display_name");
        SetOutput("revocation_record");
        SetOutput("status");
        SetOutput("version");
        SetOutput("version_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("platform_id");
        SetOutput("region");
        SetOutput("signing_parameters");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformId is required")]
    public required TerraformProperty<string> PlatformId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_id");
        set => SetProperty("platform_id", value);
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
    /// The signing_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> SigningParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("signing_parameters");
        set => SetProperty("signing_parameters", value);
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
    /// Block for signature_validity_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignatureValidityPeriod block(s) allowed")]
    public List<AwsSignerSigningProfileSignatureValidityPeriodBlock>? SignatureValidityPeriod
    {
        set => SetProperty("signature_validity_period", value);
    }

    /// <summary>
    /// Block for signing_material.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SigningMaterial block(s) allowed")]
    public List<AwsSignerSigningProfileSigningMaterialBlock>? SigningMaterial
    {
        set => SetProperty("signing_material", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformExpression PlatformDisplayName => this["platform_display_name"];

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformExpression RevocationRecord => this["revocation_record"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    public TerraformExpression VersionArn => this["version_arn"];

}
