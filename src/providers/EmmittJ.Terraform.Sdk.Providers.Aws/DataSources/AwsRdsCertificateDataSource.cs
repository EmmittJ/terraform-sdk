using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_certificate.
/// </summary>
public class AwsRdsCertificateDataSource : TerraformDataSource
{
    public AwsRdsCertificateDataSource(string name) : base("aws_rds_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate_type");
        SetOutput("customer_override");
        SetOutput("customer_override_valid_till");
        SetOutput("thumbprint");
        SetOutput("valid_from");
        SetOutput("valid_till");
        SetOutput("default_for_new_launches");
        SetOutput("id");
        SetOutput("latest_valid_till");
        SetOutput("region");
    }

    /// <summary>
    /// The default_for_new_launches attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultForNewLaunches
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_for_new_launches");
        set => SetProperty("default_for_new_launches", value);
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
    /// The latest_valid_till attribute.
    /// </summary>
    public TerraformProperty<bool> LatestValidTill
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("latest_valid_till");
        set => SetProperty("latest_valid_till", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    public TerraformExpression CertificateType => this["certificate_type"];

    /// <summary>
    /// The customer_override attribute.
    /// </summary>
    public TerraformExpression CustomerOverride => this["customer_override"];

    /// <summary>
    /// The customer_override_valid_till attribute.
    /// </summary>
    public TerraformExpression CustomerOverrideValidTill => this["customer_override_valid_till"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformExpression ValidFrom => this["valid_from"];

    /// <summary>
    /// The valid_till attribute.
    /// </summary>
    public TerraformExpression ValidTill => this["valid_till"];

}
