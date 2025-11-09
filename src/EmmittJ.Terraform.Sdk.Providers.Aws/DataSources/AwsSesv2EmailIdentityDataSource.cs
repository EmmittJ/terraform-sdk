using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_email_identity.
/// </summary>
public class AwsSesv2EmailIdentityDataSource : TerraformDataSource
{
    public AwsSesv2EmailIdentityDataSource(string name) : base("aws_sesv2_email_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("configuration_set_name");
        this.DeclareOutput("dkim_signing_attributes");
        this.DeclareOutput("identity_type");
        this.DeclareOutput("verification_status");
        this.DeclareOutput("verified_for_sending_status");
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    public TerraformProperty<string>? EmailIdentity
    {
        get => GetProperty<TerraformProperty<string>>("email_identity");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public TerraformExpression ConfigurationSetName => this["configuration_set_name"];

    /// <summary>
    /// The dkim_signing_attributes attribute.
    /// </summary>
    public TerraformExpression DkimSigningAttributes => this["dkim_signing_attributes"];

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
