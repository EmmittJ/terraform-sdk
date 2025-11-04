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
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_type");
        this.DeclareOutput("customer_override");
        this.DeclareOutput("customer_override_valid_till");
        this.DeclareOutput("thumbprint");
        this.DeclareOutput("valid_from");
        this.DeclareOutput("valid_till");
    }

    /// <summary>
    /// The default_for_new_launches attribute.
    /// </summary>
    public bool? DefaultForNewLaunches
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_for_new_launches")?.Value;
        set => this.WithProperty("default_for_new_launches", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The latest_valid_till attribute.
    /// </summary>
    public bool? LatestValidTill
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("latest_valid_till")?.Value;
        set => this.WithProperty("latest_valid_till", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
