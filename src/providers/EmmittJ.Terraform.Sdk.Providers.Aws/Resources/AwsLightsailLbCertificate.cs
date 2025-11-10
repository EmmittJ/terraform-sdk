using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_lb_certificate resource.
/// </summary>
public class AwsLightsailLbCertificate : TerraformResource
{
    public AwsLightsailLbCertificate(string name) : base("aws_lightsail_lb_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("domain_validation_records");
        SetOutput("support_code");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("lb_name");
        SetOutput("name");
        SetOutput("region");
        SetOutput("subject_alternative_names");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
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
    /// The lb_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbName is required")]
    public required TerraformProperty<string> LbName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lb_name");
        set => SetProperty("lb_name", value);
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
    /// The subject_alternative_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubjectAlternativeNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subject_alternative_names");
        set => SetProperty("subject_alternative_names", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The domain_validation_records attribute.
    /// </summary>
    public TerraformExpression DomainValidationRecords => this["domain_validation_records"];

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    public TerraformExpression SupportCode => this["support_code"];

}
