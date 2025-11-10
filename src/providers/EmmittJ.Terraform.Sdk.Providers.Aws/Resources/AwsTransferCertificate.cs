using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_certificate resource.
/// </summary>
public class AwsTransferCertificate : TerraformResource
{
    public AwsTransferCertificate(string name) : base("aws_transfer_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active_date");
        SetOutput("arn");
        SetOutput("certificate_id");
        SetOutput("inactive_date");
        SetOutput("certificate");
        SetOutput("certificate_chain");
        SetOutput("description");
        SetOutput("id");
        SetOutput("private_key");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("usage");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    public required TerraformProperty<string> Certificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate");
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformProperty<string> CertificateChain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_chain");
        set => SetProperty("certificate_chain", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string> PrivateKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_key");
        set => SetProperty("private_key", value);
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
    /// The usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    public required TerraformProperty<string> Usage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage");
        set => SetProperty("usage", value);
    }

    /// <summary>
    /// The active_date attribute.
    /// </summary>
    public TerraformExpression ActiveDate => this["active_date"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

    /// <summary>
    /// The inactive_date attribute.
    /// </summary>
    public TerraformExpression InactiveDate => this["inactive_date"];

}
