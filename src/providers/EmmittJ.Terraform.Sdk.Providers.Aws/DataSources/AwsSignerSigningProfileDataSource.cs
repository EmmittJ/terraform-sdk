using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_signer_signing_profile.
/// </summary>
public class AwsSignerSigningProfileDataSource : TerraformDataSource
{
    public AwsSignerSigningProfileDataSource(string name) : base("aws_signer_signing_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("platform_display_name");
        SetOutput("platform_id");
        SetOutput("revocation_record");
        SetOutput("signature_validity_period");
        SetOutput("signing_material");
        SetOutput("signing_parameters");
        SetOutput("status");
        SetOutput("version");
        SetOutput("version_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformExpression PlatformDisplayName => this["platform_display_name"];

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    public TerraformExpression PlatformId => this["platform_id"];

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformExpression RevocationRecord => this["revocation_record"];

    /// <summary>
    /// The signature_validity_period attribute.
    /// </summary>
    public TerraformExpression SignatureValidityPeriod => this["signature_validity_period"];

    /// <summary>
    /// The signing_material attribute.
    /// </summary>
    public TerraformExpression SigningMaterial => this["signing_material"];

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    public TerraformExpression SigningParameters => this["signing_parameters"];

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
