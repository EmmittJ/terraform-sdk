using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_hsm_client_certificate resource.
/// </summary>
public class AwsRedshiftHsmClientCertificate : TerraformResource
{
    public AwsRedshiftHsmClientCertificate(string name) : base("aws_redshift_hsm_client_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("hsm_client_certificate_public_key");
    }

    /// <summary>
    /// The hsm_client_certificate_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? HsmClientCertificateIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("hsm_client_certificate_identifier");
        set => this.WithProperty("hsm_client_certificate_identifier", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The hsm_client_certificate_public_key attribute.
    /// </summary>
    public TerraformExpression HsmClientCertificatePublicKey => this["hsm_client_certificate_public_key"];

}
