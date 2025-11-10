using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_certificate resource.
/// </summary>
public class AwsRdsCertificate : TerraformResource
{
    public AwsRdsCertificate(string name) : base("aws_rds_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certificate_identifier");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The certificate_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateIdentifier is required")]
    public required TerraformProperty<string> CertificateIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_identifier");
        set => SetProperty("certificate_identifier", value);
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

}
